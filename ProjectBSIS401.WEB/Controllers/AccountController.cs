using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using BCrypt;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Grecaptcha;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using ProjectBSIS401.WEB.ViewModels;
using ProjectBSIS401.WEB.ViewModels.account;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace ProjectBSIS401.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;

        private string emailUserName;
        private string emailPassword;

        private static string publicSiteKey;
        private static string privateSiteKey;

        public AccountController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;

            var emailConfig = this._config.GetSection("Email");
            emailUserName = (emailConfig["Username"]).ToString();
            emailPassword = (emailConfig["Password"]).ToString();

            var recaptchaConfig = this._config.GetSection("GRecaptcha");
            publicSiteKey = (recaptchaConfig["PublicSiteKey"]).ToString();
            privateSiteKey = (recaptchaConfig["PrivateSiteKey"]).ToString();
        }
    
        public IActionResult Index()
        {

            return View();
        }

        #region First Method Recaptcha = ERROR METHOD 
        //public static CaptchaResponse ValidateCaptcha(string response)
        //{
        //    var secret = privateSiteKey;
        //    var client = new WebClient();
        //    var jsonResult = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secret, response));
        //    var captchaResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<CaptchaResponse>(jsonResult);

        //    return captchaResponse;

        //}
        #endregion

        [HttpGet, Route("/account/login")]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost, Route("/account/login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            string EncodedResponse = Request.Form["g-recaptcha-response"];
            var isCaptchaValid = CaptchaResponse.Validate(EncodedResponse);
            
            if (!ModelState.IsValid)
            {

                return View(model);
            }

            var user = this._context.Users.FirstOrDefault(u => u.EmailAddress.ToLower() == model.EmailAddress.ToLower());

             if(isCaptchaValid)
            {
                if (user != null)
                {
                    var userRole = this._context.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id);
                    var shop = this._context.Shops.FirstOrDefault(s => s.UserId == user.Id);
                    if (BCrypt.BCryptHelper.CheckPassword(model.Password, user.Password))
                    {
                        if (user.LoginStatus == Infrastructures.Domain.Enums.LoginStatus.Locked)
                        {
                            ModelState.AddModelError("", "Your account has been locked ");
                            return View();
                        }
                        else if (user.LoginStatus.Equals(Infrastructures.Domain.Enums.LoginStatus.Unverified))
                        {
                            ModelState.AddModelError("", "Please verify your account first.");
                            return View();
                        }

                        else if (user.LoginStatus.Equals(Infrastructures.Domain.Enums.LoginStatus.NeedToChangePassword))
                        {
                            user.LoginRetries = 0;
                            user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active;
                            this._context.Users.Update(user);
                            this._context.SaveChanges();


                            var roles = this._context.UserRoles.Where(ur => ur.UserId == user.Id).Select(ur => ur.Role).ToList();
                            var groupIds = this._context.UserGroups.Where(ug => ug.Id == user.Id).Select(ur => ur.GroupId).ToList();
                            var groups = this._context.Groups.Where(g => groupIds.Contains(g.Id.Value)).ToList();
                            //var shops = this._context.Shops.Where(s => s.Id == user.Id).Where(s => ).ToList();

                            WebUser.SetUser(user, roles, groups);
                            await this.SignIn();
                            return RedirectToAction("~/account/change-password");
                        }
                        else if (userRole.Role == Infrastructures.Domain.Enums.Role.Admin && user.LoginStatus == Infrastructures.Domain.Enums.LoginStatus.Active)
                        {
                            user.LoginRetries = 0;
                            user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active;
                            this._context.Users.Update(user);
                            this._context.SaveChanges();

                            var roles = this._context.UserRoles.Where(ur => ur.UserId == user.Id).Select(ur => ur.Role).ToList();

                            var groupIds = this._context.UserGroups.Where(ug => ug.Id == user.Id).Select(ur => ur.GroupId).ToList();
                            var groups = this._context.Groups.Where(g => groupIds.Contains(g.Id.Value)).ToList();

                            WebUser.SetUser(user, roles, groups);
                            WebIDS.SetUserId(user.Id, user.UserName, user.EmailAddress, roles, groups);
                            WebIDS.SetAdminId(user.Id, roles, groups);

                            //Send email login alert!
                            this.EmailSendNow(
                                        EmailLoginAlert(user.UserName),
                                        model.EmailAddress,
                                        user.UserName,
                                        "Welcome To Fixit.PH"
                            );
                            await this.SignIn();


                            return RedirectPermanent("~/manage/users");
                        }
                        else if (userRole.Role == Infrastructures.Domain.Enums.Role.ShopAdmin && user.LoginStatus == LoginStatus.Active && shop.Id != null)
                        {
                            user.LoginStatus = LoginStatus.Active;
                            user.LoginRetries = 0;
                            this._context.Users.Update(user);
                            this._context.SaveChanges();

                            var roles = this._context.UserRoles.Where(ur => ur.UserId == user.Id).Select(ur => ur.Role).ToList();
                            var groupIds = this._context.UserGroups.Where(ug => ug.Id == user.Id).Select(ur => ur.GroupId).ToList();
                            var groups = this._context.Groups.Where(g => groupIds.Contains(g.Id.Value)).ToList();

                            WebIDS.SetShopId(shop.Id);
                            WebIDS.SetUserId(user.Id, user.UserName, user.EmailAddress, roles, groups);
                            WebIDS.SetShopAdminId(user.Id, roles, groups);
                            await this.SignIn();

                            this.EmailSendNow(
                                          EmailLoginAlert(user.UserName),
                                          model.EmailAddress,
                                          user.UserName,
                                          "Welcome To Fixit.PH"
                              );
                            return RedirectPermanent("~/shop/my-dashboard");
                        }

                        else if (userRole.Role == Infrastructures.Domain.Enums.Role.User && user.LoginStatus == Infrastructures.Domain.Enums.LoginStatus.Active)
                        {
                            user.LoginRetries = 0;
                            user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active;

                            this._context.Users.Update(user);
                            this._context.SaveChanges();


                            var roles = this._context.UserRoles.Where(ur => ur.UserId == user.Id).Select(ur => ur.Role).ToList();
                            var groupIds = this._context.UserGroups.Where(ug => ug.Id == user.Id).Select(ur => ur.GroupId).ToList();
                            var groups = this._context.Groups.Where(g => groupIds.Contains(g.Id.Value)).ToList();
                            //var shops = this._context.Shops.Where(s => ).Select(s => s.Id).ToList;

                            WebUser.SetUser(user, roles, groups);
                            WebIDS.SetUserId(user.Id, user.UserName, user.EmailAddress, roles, groups);
                            WebIDS.SetPublicUserId(user.Id, roles, groups);

                            //Send email login alert!
                            this.EmailSendNow(
                                        EmailLoginAlert(user.UserName),
                                        model.EmailAddress,
                                        user.UserName,
                                        "Welcome To Fixit.PH"
                            );
                            await this.SignIn();

                            return RedirectPermanent("~/shop/index");
                        }
                        else
                        {
                            user.LoginRetries = user.LoginRetries + 1;

                            if (user.LoginRetries >= 3)
                            {
                                ModelState.AddModelError("", "Your account has been locked please contact an Administrator.");
                                user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Locked;
                            }

                            this._context.Users.Update(user);
                            this._context.SaveChanges();

                            ModelState.AddModelError("", "Invalid Login.");
                            return View();
                        }
                    }



                }
                else
                {
                    ModelState.AddModelError("", "Invalid login. Please create your account first.");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("","Error From Google ReCaptcha :" + isCaptchaValid);
                return View();
            }
          


            return View();
        }




        [HttpGet, Route("/account/sign-up")]
        public IActionResult SignUp()
        {
            //ViewBag.ShopId = new SelectList(_context.Shops, "Id", "BusinessName");

            return View();
        }

        [HttpPost, Route("/account/sign-up")]
        public IActionResult SignUp(RegisterViewModel model)
        {
            //ViewBag.ShopId = new SelectList(_context.Shops, "Id", "BusinessName", model.ShopId);

            string EncodedResponse = Request.Form["g-recaptcha-response"];
            var isCaptchaValid = CaptchaResponse.Validate(EncodedResponse);
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Password != model.ConfirmPassword)
            {
                ModelState.AddModelError("", "Password and confirm-password does not match");
                return View();
            }

            var registrationCode = RandomString(6);
            if(isCaptchaValid)
            {
                User user = new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.FirstName + "" + model.LastName,
                    EmailAddress = model.EmailAddress.ToLower(),
                    LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Unverified,
                    LoginRetries = 0,
                    Password = BCryptHelper.HashPassword(model.Password, BCryptHelper.GenerateSalt(8)),
                    PhoneNumber = model.PhoneNumber,
                    RegistrationCode = registrationCode,
                    Gender = Infrastructures.Domain.Enums.Gender.Male,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    DateOfBirth = model.DateOfBirth,


                };

                this._context.UserRoles.Add(new UserRole()
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id.Value,
                    Role = Infrastructures.Domain.Enums.Role.User

                });

                this._context.UserGroups.Add(new UserGroup()
                {
                    UserId = user.Id.Value,
                    GroupId = Guid.NewGuid(),

                });


                this._context.Users.Add(user);
                this._context.SaveChanges();

                //Send email
                this.EmailSendNow(
                            WelcomeEmailTemplate(registrationCode, user.UserName),
                            model.EmailAddress,
                            user.UserName,
                            "Welcome To Fixit.PH"
                );
                return RedirectToAction("verify");

            }

            ModelState.AddModelError("", "Error From Google ReCaptcha :" + isCaptchaValid);
            return View();



        }

        
        [HttpGet,Route("account/welcome")]
        public IActionResult Welcome()
        {
            return View();
        }

        
        [HttpGet, Route("/account/verify")]
        public IActionResult Verify()
        {
            return View();
        }
       
        [HttpPost, Route("/account/verify")]
        public IActionResult Verify(VerifyViewModel model)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Verification code is required!");
                return View(model);
            }

            var user = this._context.Users.FirstOrDefault(u => u.RegistrationCode == model.RegistrationCode);
            if (user != null)
            {
                user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active;
                user.LoginRetries = 0;
                this._context.Users.Update(user);
                this._context.SaveChanges();


                return RedirectToAction("Welcome");
            }

            return View();
        }

        [HttpGet, Route("account/accessdenied")]
        public IActionResult AccessDenied(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpGet, Route("account/forgot-password")]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost, Route("account/forgot-password")]
        public IActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = this._context.Users.FirstOrDefault(u => u.EmailAddress.ToLower() == model.EmailAddress.ToLower());

            if (user != null)
            {
                var newPassword = RandomString(9);
                user.Password = BCryptHelper.HashPassword(newPassword, BCryptHelper.GenerateSalt(9));
                user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active;

                this._context.Users.Update(user);
                this._context.SaveChanges();

                this.EmailSendNow(
                           ForgotPasswordEmailTemplate(newPassword, user.UserName),
                           user.EmailAddress,
                           user.UserName,
                           "Fixit.ph Website - Forgot Password"
               );

                return RedirectToAction("OTP");
            }
            ModelState.AddModelError("", "Email-Address does'nt exist!");
            return View(model);
        }
        [HttpGet, Route("account/otp")]
        public IActionResult OTP()
        {
            return View();
        }

     


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("account/logout")]
        public async Task<IActionResult> Logout()
        {
            if(WebIDS.UserId != null)
            {
                //Send email login alert!
                this.EmailSendNow(
                            EmailLogoutAlert(WebIDS.Name),
                            WebIDS.EmailAddress,
                            WebIDS.Name,
                            " Thank you for visiting Fixit.PH"
                );
            }
          
            await this.SignOut();
            return RedirectToAction("login");
        }

        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("account/change-password/{userId}")]
        public IActionResult ChangePassword(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            if(user == null)
            {
                return RedirectToAction("~/account/login");
            
            }
            return View(new ChangePasswordViewModel
            {
                UserId = user.Id
            });
        }

        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("account/change-password")]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Invalid input!");
                return View();
            }

            if (model.NewPassword != model.ConfirmNewPassword)
            {
                ModelState.AddModelError("", "New Password does not match to Confirm New Password");
                return View();
            }

            var user = this._context.Users.FirstOrDefault(u =>u.Id == model.UserId);
            if (user != null)
            {
                if (BCryptHelper.CheckPassword(model.OldPassword, user.Password) == false)
                {
                    ModelState.AddModelError("", "Incorrect old Password.");
                    return View();
                }

                user.Password = BCryptHelper.HashPassword(model.NewPassword, BCryptHelper.GenerateSalt(8));
                user.LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active;

                this._context.Users.Update(user);
                this._context.SaveChanges();

               

                return RedirectPermanent("Notify");
            }

            return View();
        }

        [HttpGet, Route("/account/notify")]
        public IActionResult Notify()
        {
            return View();
        }


        [AllowAnonymous]
        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("account/update-profile/{userId}")]
        public IActionResult UserUpdateProfile(Guid? userId)
        {

            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);

            if(userId == null)
            {
                return RedirectToAction("~/account/login");
            }
            else
            {
                return View(
                   new UpdateProfileViewModel()
                   {
                       UserId = user.Id.Value,
                       FirstName = user.FirstName,
                       LastName = user.LastName,
                       PhoneNumber = user.PhoneNumber
                   }
               );
            }
           

        }

        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("account/update-profile")]
        public IActionResult UserUpdateProfile(UpdateProfileViewModel model)
        {

            if (!ModelState.IsValid)
                return View(model);

            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);

            if (user != null)
            {
                user.PhoneNumber = model.PhoneNumber;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Gender = model.Gender;
                user.UserName = model.FirstName + "" + model.LastName;

                this._context.Users.Update(user);
                this._context.SaveChanges();

               

                return RedirectToAction("Profile", new { UserId = model.UserId });
            }

            return View();
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("account/profile/{userId}")]
        public IActionResult Profile(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);

            var Books = this._context.Bookings.Where(ub => ub.UserId == userId)
                                          .OrderByDescending(ub => ub.CreatedAt == DateTime.Today)
                                          .Take(10)
                                          .Select(ub => new BookViewModel()
                                          {
                                              Id = ub.Id,
                                              ShopServiceName = ub.ShopServiceName,
                                              ShopServiceDescription = ub.ShopServiceDescription,
                                              ShopServicePrice = ub.ShopServicePrice,
                                              ShopServiceId = ub.ShopServiceId,
                                              AdditionalDescription = ub.AdditionalDescription,
                                              Address = ub.Address,
                                              ContactNumber = ub.ContactNumber,
                                              UserName = ub.UserName,
                                              DateAndTime = ub.DateAndTime,
                                              ReserveStatus = ub.ReserveStatus,
                                              PaymentType = ub.PaymentType,
                                              CreatedAt = ub.CreatedAt,
                                              UpdatedAt = ub.CreatedAt,
                                              TimeStamps = ub.TimeStamps,
                                              ShopId = ub.ShopId,
                                              UserId = ub.UserId
                                             

                                          }).ToList();

            if (user == null)
            {
                return NotFound();
            }


            return View(new ProfileViewModel
            {
                User = user,
                Bookings = Books
            });

        }



        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("/account/update-thumbnail/{userId}")]
        public IActionResult Thumbnail(Guid? userId)
        {
            return View(new ThumbnailViewModel() { UserId = userId });
        }


        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("/account/update-thumbnail")]
        public async Task<IActionResult> Thumbnail(ThumbnailViewModel model)
        {
            //Check file size of the uploaded thumbnail
            //reject if the file is greater than 2mb
            var fileSize = model.Thumbnail.Length;
            if ((fileSize / 1048576.0) > 2)
            {
                ModelState.AddModelError("", "The file you uploaded is too large. Filesize limit is 2mb.");
                return Redirect("Profile");
            }
            //Check file type of the uploaded thumbnail
            //reject if the file is not a jpeg or png
            if (model.Thumbnail.ContentType != "image/jpeg" && model.Thumbnail.ContentType != "image/png")
            {
                ModelState.AddModelError("", "Please upload a jpeg or png file for the thumbnail.");
                return Redirect("Profile");
            }
            //Formulate the directory where the file will be saved
            //create the directory if it does not exist
            var dirPath = _env.WebRootPath + "/userprofile/users/" + model.UserId.ToString();
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            //always name the file thumbnail.png
            var filePath = dirPath + "/thumbnail.png";
            if (model.Thumbnail.Length > 0)

            {
                //Open a file stream to read all the file data into a byte array
                byte[] bytes = await FileBytes(model.Thumbnail.OpenReadStream());
                //load the file into the third party (ImageSharp) Nuget Plugin                
                using (Image<Rgba32> image = Image.Load(bytes))
                {
                    //use the Mutate method to resize the image 150px wide by 150px long
                    image.Mutate(x => x.Resize(150, 150));
                    //save the image into the path formulated earlier
                    image.Save(filePath);
                }
            }
            return RedirectToAction("UserUpdateProfile", new { UserId = model.UserId });
        }







        #region Helpers
        //generate randomstring password
        private Random random = new Random();
        private string RandomString(int length)
        {
            const string chars = "abcedfghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public async Task<byte[]> FileBytes(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
        #endregion

        #region Sign In/Out
        #region Login
        private async Task SignIn()
        {
            var user = new User();

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = true,
                IssuedUtc = DateTimeOffset.UtcNow
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);
        }
        #endregion
        #region Logout
        private async Task SignOut()
        {
            await HttpContext.SignOutAsync();

            WebUser.EmailAddress = string.Empty;
            WebUser.FirstName = string.Empty;
            WebUser.LastName = string.Empty;
            WebUser.UserId = null;
            WebUser.Roles = new List<Role>();
            WebIDS.UserId = Guid.Empty;
            WebIDS.Name = string.Empty;
            WebIDS.Roles = new List<Role>();
            WebIDS.Groups = new List<Group>();
            WebIDS.EmailAddress = string.Empty;

            HttpContext.Session.Clear();
        }
        #endregion
        #endregion

        #region Notifications
        #region Email
        private void EmailSendNow(string message, string messageTo, string messageName, string emailSubject)
        {
            var fromAddress = new MailAddress(emailUserName, "ProjectBSIS401 Apps");
            string body = message;


            ///https://support.google.com/accounts/answer/6010255?hl=en
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, emailPassword),
                Timeout = 500000
            };

            var toAddress = new MailAddress(messageTo, messageName);
            try { 
            smtp.Send(new MailMessage(fromAddress, toAddress)
            {
                Subject = emailSubject,
                Body = body,
                IsBodyHtml = true
            });
            }
            catch (TimeoutException ex)
            {
                ex.Message.ToString();
            }
        }

        private string ForgotPasswordEmailTemplate(string password, string recepientName)
        {
            return EmailTemplateLayout(@"<tr>
                        <td><h3 style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:30px;'>Greetings from Fixit.ph!</h3></td>
                    </tr>
                    <tr>
                        <td>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:0 30px 20px;text-align:center;'>
                                You asked us to reset your password.<br />.
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:20px 30px 0; text-align:center;'>
                                <strong>Use this one-time password so you can login:</strong>
                            </p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif;color:#FF9046; font-weight:700; font-size:32px; text-align:center; margin:0;'>
                                " + password + @"
                            </p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:0 30px 20px;text-align:center;'>Please change your password once logged in.</p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:15px 30px 30px; text-align:center;'>
                                <span style='font-size:12px; color:#999;'>
                                    (Please do not reply this is a system generated email)
                                </span>
                            </p>
                        </td>
                    </tr>", recepientName, "Fixit.ph Website - Password Reset");
        }

        private string ChangePasswordEmailTemplate(string password, string recepientName)
        {
            return EmailTemplateLayout(@"<tr>
                        <td><h3 style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:30px;'>Greetings from Fixit.ph!</h3></td>
                    </tr>
                    <tr>
                        <td>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:0 30px 20px;text-align:center;'>
                                You've change your password at " + DateTime.Now.ToString("") + @".<br />.
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:20px 30px 0; text-align:center;'>
                                <strong>Use this new password so you can login:</strong>
                            </p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif;color:#FF9046; font-weight:700; font-size:32px; text-align:center; margin:0;'>
                                " + password + @"
                            </p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:0 30px 20px;text-align:center;'>we notify you to make sure it was you.</p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:15px 30px 30px; text-align:center;'>
                                <span style='font-size:12px; color:#999;'>
                                    (Please do not reply this is a system generated email)
                                </span>
                            </p>
                        </td>
                    </tr>", recepientName, "Fixit.ph Website - Password Reset");
        }


        private string WelcomeEmailTemplate(string registrationCode, string recepientName)
        {
            return EmailTemplateLayout(@"<tr>
                        <td><h3 style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:30px;'>Welcome to Fixit.ph!</h3></td>
                    </tr>
                    <tr>
                        <td>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:20px 30px 0; text-align:center;'>
                                <strong>Please use this registration code to activate your account :</strong>
                            </p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif;color:#FF9046; font-weight:700; font-size:32px; text-align:center; margin:0;'>
                                " + registrationCode + @"
                            </p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:0 30px 20px;text-align:center;'>You may activate your account <a href=\'\#\'>here</a>.</p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:0 30px 20px;text-align:center;'>Please change your password once logged in.</p>
                            <p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:15px 30px 30px; text-align:center;'>
                                <span style='font-size:12px; color:#999;'>
                                    (Please do not reply this is a system generated email)
                                </span>
                            </p>
                        </td>
                    </tr>", recepientName, "Welcome to Fixit.ph");
        }

        private string EmailTemplateLayout(string message, string recepientName, string title)
        {
            return @"<!doctype html>
                        <html>
                        <head>
                            <meta charset='utf-8'>
                            <title>" + title + @"</title>
                        </head>
                        <body style='background:#DDD; margin:0; padding:20px 0;'>
                            <a href='#' target='_blank'>
                                <p style='margin:0 auto; width:600px;'><img src='http://oi66.tinypic.com/29z98a1.jpg' width='600' height='140' /></p>
                            </a>
                            <table style='background:#FFF; width:600px; margin:0 auto;'>
                                <tr>
                                    <td>
                                        <h4 style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:30px 30px 0;'>Dear <i>" + recepientName + @"</i>,</h4>
                                    </td>
                                </tr>
                                " + message + @"
                                <tr>
                                    <td>
                                        <h4 style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:30px 30px 0;'>Kind Regards,</h4>
                                        <p style='margin:0 30px 30px;'>CSM Bataan Apps Team</p>
                                        <hr>
                                    </td>
                                </tr>
                                <tr>
                                    <td><p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:0; font-size:12px; color:#999; text-align:center;'>&copy; " + @DateTime.Now.Year + @" FIXIT.PH - DINALUPIHAN BATAAN | All Rights Reserved</p></td>         
                                </tr>
                        </table>
                    </body>
                    </html>";
        }

        private string EmailLoginAlert(string recepientName)
        {
            return @"<!doctype html>
                        <html>
                        <head>
                            <meta charset='utf-8'>
                            <title>" + recepientName + @"</title>
                        </head>
                        <body style='background:#DDD; margin:0; padding:20px 0;'>
                            <a href='#' target='_blank'>
                                <p style='margin:0 auto; width:600px;'><img src='~/image/webLogo/fixit.png' width='600' height='140' /></p>
                            </a>
                            <table style='background:#FFF; width:600px; margin:0 auto;'>
                                <tr>
                                    <td>
                                        <h4 style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:30px 30px 0;'>Dear <i>" + recepientName + @"</i>,</h4>
                                    </td>
                                </tr>
                                    <p style='text-align:justify; margin-left:20px;'></p>Your Fixit Account was just signed in. Date of " + @DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + @". You're getting this email to make sure it was you.
                                <tr>
                                    <td>
                                        <h4 style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:30px 30px 0;'>Kind Regards,</h4>
                                        <p style='margin:0 30px 30px;'>CSM Bataan Apps Team</p>
                                        <hr>
                                    </td>
                                </tr>
                                <tr>
                                    <td><p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:0; font-size:12px; color:#999; text-align:center;'>&copy; " + @DateTime.Now.Year + @" FIXIT.PH - DINALUPIHAN BATAAN | All Rights Reserved</p></td>         
                                </tr>
                        </table>
                    </body>
                    </html>";
        }

        private string EmailLogoutAlert(string recepientName)
        {
            return @"<!doctype html>
                        <html>
                        <head>
                            <meta charset='utf-8'>
                            <title>" + recepientName + @"</title>
                        </head>
                        <body style='background:#DDD; margin:0; padding:20px 0;'>
                            <a href='#' target='_blank'>
                                <p style='margin:0 auto; width:600px;'><img src='~/image/webLogo/fixit.png' width='600' height='140' /></p>
                            </a>
                            <table style='background:#FFF; width:600px; margin:0 auto;'>
                                <tr>
                                    <td>
                                        <h4 style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:30px 30px 0;'>Dear <i>" + recepientName + @"</i>,</h4>
                                    </td>
                                </tr>
                                    <p style='text-align:justify; margin-left:20px;'></p>Your Fixit Account was just signed out. Date of " + @DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + @". You're getting this email to make sure it was you.
                                <tr>
                                    <td>
                                        <h4 style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:30px 30px 0;'>Kind Regards,</h4>
                                        <p style='margin:0 30px 30px;'>CSM Bataan Apps Team</p>
                                        <hr>
                                    </td>
                                </tr>
                                <tr>
                                    <td><p style='font-family:Segoe, Segoe UI, Arial, sans-serif; margin:0; font-size:12px; color:#999; text-align:center;'>&copy; " + @DateTime.Now.Year + @" FIXIT.PH - DINALUPIHAN BATAAN | All Rights Reserved</p></td>         
                                </tr>
                        </table>
                    </body>
                    </html>";
        }
        #endregion
        #endregion


    }
}