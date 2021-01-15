using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;

namespace ProjectBSIS401.WEB.Areas.Manage.Controllers
{
    public class DataInitController : Controller
    {
        private readonly DefaultDbContext _context;
        public DataInitController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("manage/data-init/execute")]
        public IActionResult DataInit()
        {

            #region Group
            if (this._context.Groups.Count() < 1)
            {
                this._context.Groups.Add(
                    new Infrastructures.Domain.Models.Group()
                    {
                        Id = Guid.Parse("c1f0dd75-0d8e-420d-8da5-88a34d8946d0"),
                        Description = "All including business owner online",
                        Name = "Business Owner",
                        Status = Infrastructures.Domain.Enums.Status.Active
                    });


                this._context.Groups.Add(
                   new Infrastructures.Domain.Models.Group()
                   {
                       Id = Guid.Parse("51c735d4-43fb-43c5-84f4-903954495b4e"),
                       Description = "All  available services",
                       Name = "Services",
                       Status = Infrastructures.Domain.Enums.Status.Active
                   });


                this._context.Groups.Add(
                   new Infrastructures.Domain.Models.Group()
                   {
                       Id = Guid.Parse("ab87ef3d-61b1-4820-b5e4-ac8cec774ceb"),
                       Description = "All list of categories",
                       Name = "Categories",
                       Status = Infrastructures.Domain.Enums.Status.Active
                   });


                this._context.Groups.Add(
                   new Infrastructures.Domain.Models.Group()
                   {
                       Id = Guid.Parse("08830640-92bd-496d-84d8-04eb483801cf"),
                       Description = "All including loyal costumers",
                       Name = "Costumers",
                       Status = Infrastructures.Domain.Enums.Status.Active
                   });


                this._context.Groups.Add(
                   new Infrastructures.Domain.Models.Group()
                   {
                       Id = Guid.Parse("f24ee0e7-c436-4b94-9b9d-075ccba388ad"),
                       Description = "All active users",
                       Name = "Active Users",
                       Status = Infrastructures.Domain.Enums.Status.Active
                   });
            }
            #endregion

            #region Shops
            {
                if (this._context.Shops.Count() < 1)
                {
                    this._context.Shops.Add(
                    new Infrastructures.Domain.Models.Shop()
                    {

                        Id = Guid.Parse("3c29d5fd-269b-419e-9313-22c891116137"),
                        OwnerShop = "Wendhel Aton",
                        BusinessEmailAddress = "wendhelgregorio@gmail.com",
                        BusinessContact = "09663218416",
                        BusinessLocation = "San_Benito,Dinalupihan,Bataan",
                        BusinessName = "Desktop Repair Shop",
                        UserId = Guid.Parse("f341fbee-5c25-44c0-ba19-979c7d136d09"),
                        OpenAt = "8:00 AM",
                        CloseAt = "8:00 PM",
                        CreatedAt = DateTime.UtcNow,
                        BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                        UpdatedAt = DateTime.UtcNow,
                        IsPublished = true,
                        BusinessDescription = "we offer all the service !",
                        Status = Infrastructures.Domain.Enums.Status.Active


                    });


                    this._context.Shops.Add(
                     new Infrastructures.Domain.Models.Shop()
                     {

                         Id = Guid.Parse("de01e8e4-3131-47fb-97f9-055f0cf1c703"),
                         OwnerShop = "Jane Ticar",
                         BusinessEmailAddress = "janeticar@gmail.com",
                         BusinessContact = "09663218416",
                         BusinessLocation = "St.Isabel,Dinalupihan,Bataan",
                         BusinessName = "Laptop Repair Shop",
                         OpenAt = "8:00 AM",
                         CloseAt = "8:00 PM",
                         UserId = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                         CreatedAt = DateTime.UtcNow,
                         BusinessType = Infrastructures.Domain.Enums.BusinessType.Laptop,
                         UpdatedAt = DateTime.UtcNow,
                         IsPublished = true,
                         BusinessDescription = "we offer all the service !",
                         Status = Infrastructures.Domain.Enums.Status.Active


                     });

                    this._context.Shops.Add(
                   new Infrastructures.Domain.Models.Shop()
                   {

                       Id = Guid.Parse("ef17b261-6a9a-4a02-a8dd-1c0f406609dc"),
                       OwnerShop = "Jake Carlo Renzo",
                       BusinessEmailAddress = "jakecarlorenzo@gmail.com",
                       BusinessContact = "09663218416",
                       BusinessLocation = "St.Isabel,Dinalupihan,Bataan",
                       BusinessName = "Tablet Repair Shop",
                       OpenAt = "8:00 AM",
                       CloseAt = "8:00 PM",
                       UserId = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                       CreatedAt = DateTime.UtcNow,
                       BusinessType = Infrastructures.Domain.Enums.BusinessType.Tablet,
                       UpdatedAt = DateTime.UtcNow,
                       IsPublished = true,
                       BusinessDescription = "we offer all the service !",
                       Status = Infrastructures.Domain.Enums.Status.Active

                   });



                    this._context.Shops.Add(
                 new Infrastructures.Domain.Models.Shop()
                 {

                     Id = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                     OwnerShop = "Eren jaeger",
                     BusinessEmailAddress = "erenjaeger@gmail.com",
                     BusinessContact = "09663218416",
                     BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                     BusinessName = "Tablet Repair Shop",
                     OpenAt = "8:00 AM",
                     CloseAt = "8:00 PM",
                     UserId = Guid.Parse("ffa44221-691c-4f82-ae45-e7f28a988d0e"),
                     CreatedAt = DateTime.UtcNow,
                     BusinessType = Infrastructures.Domain.Enums.BusinessType.Tablet,
                     UpdatedAt = DateTime.UtcNow,
                     IsPublished = true,
                     BusinessDescription = "we offer all the service !",
                     Status = Infrastructures.Domain.Enums.Status.Active

                 });

                    this._context.Shops.Add(
             new Infrastructures.Domain.Models.Shop()
             {

                 Id = Guid.Parse("9966c022-2237-4506-88ce-5ac68844c70f"),
                 OwnerShop = "Mikasa jaeger",
                 BusinessEmailAddress = "mikasajaeger@gmail.com",
                 BusinessContact = "09663218416",
                 BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                 BusinessName = "Tablet Repair Shop",
                 OpenAt = "8:00 AM",
                 CloseAt = "8:00 PM",
                 UserId = Guid.Parse("9efc57bb-d4d0-44cb-ad88-1c29e4dd1c9f"),
                 CreatedAt = DateTime.UtcNow,
                 BusinessType = Infrastructures.Domain.Enums.BusinessType.Tablet,
                 UpdatedAt = DateTime.UtcNow,
                 IsPublished = true,
                 BusinessDescription = "we offer all the service !",
                 Status = Infrastructures.Domain.Enums.Status.Active

             });

                    this._context.Shops.Add(
            new Infrastructures.Domain.Models.Shop()
            {

                Id = Guid.Parse("0413b680-91ca-49f0-8485-0af0ec711593"),
                OwnerShop = "Zoro Hunter",
                BusinessEmailAddress = "zorohunter@gmail.com",
                BusinessContact = "09663218416",
                BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                BusinessName = "Tablet Repair Shop",
                OpenAt = "8:00 AM",
                CloseAt = "8:00 PM",
                UserId = Guid.Parse("569a1974-15fb-4b99-8f1c-331b5f2eb699"),
                CreatedAt = DateTime.UtcNow,
                BusinessType = Infrastructures.Domain.Enums.BusinessType.Tablet,
                UpdatedAt = DateTime.UtcNow,
                IsPublished = true,
                BusinessDescription = "we offer all the service !",
                Status = Infrastructures.Domain.Enums.Status.Active

            });


                        this._context.Shops.Add(
                new Infrastructures.Domain.Models.Shop()
                {

                    Id = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                    OwnerShop = "Luffy Dragon",
                    BusinessEmailAddress = "luffydragon@gmail.com",
                    BusinessContact = "09663218416",
                    BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                    BusinessName = "Tablet Repair Shop",
                    OpenAt = "8:00 AM",
                    CloseAt = "8:00 PM",
                    UserId = Guid.Parse("a05537f4-0662-4338-a22b-8486eca71243"),
                    CreatedAt = DateTime.UtcNow,
                    BusinessType = Infrastructures.Domain.Enums.BusinessType.Tablet,
                    UpdatedAt = DateTime.UtcNow,
                    IsPublished = true,
                    BusinessDescription = "we offer all the service !",
                    Status = Infrastructures.Domain.Enums.Status.Active

                });

                                this._context.Shops.Add(
                new Infrastructures.Domain.Models.Shop()
                {

                    Id = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                    OwnerShop = "Levi Ackerman",
                    BusinessEmailAddress = "leviackerman@gmail.com",
                    BusinessContact = "09663218416",
                    BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                    BusinessName = "Tablet Repair Shop",
                    OpenAt = "8:00 AM",
                    CloseAt = "8:00 PM",
                    UserId = Guid.Parse("5b6c03f9-6ba9-4063-9418-d1c849585136"),
                    CreatedAt = DateTime.UtcNow,
                    BusinessType = Infrastructures.Domain.Enums.BusinessType.Tablet,
                    UpdatedAt = DateTime.UtcNow,
                    IsPublished = true,
                    BusinessDescription = "we offer all the service !",
                    Status = Infrastructures.Domain.Enums.Status.Active

                });






                }
            }
            #endregion

      


            #region User
            if (this._context.Users.Count() < 1)
            {



                this._context.Users.Add(
                           new Infrastructures.Domain.Models.User()
                           {
                               Id = Guid.Parse("f341fbee-5c25-44c0-ba19-979c7d136d09"),
                               FirstName = "Wendhel",
                               LastName = "Aton,",
                               LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                               LoginRetries = 0,
                               RegistrationCode = "ABCDEFG",
                               EmailAddress = "gregorio.wendhel@gmail.com",
                               Gender = Infrastructures.Domain.Enums.Gender.Male,
                               Password = BCrypt.BCryptHelper.HashPassword("Wendhelaton23", BCrypt.BCryptHelper.GenerateSalt(9)),
                               PhoneNumber = "09504145737",
                               DateOfBirth = DateTime.Parse("06-23-1998"),
                               UserName = "Wendhel Aton",




                           });

                this._context.Users.Add(
                          new Infrastructures.Domain.Models.User()
                          {
                              Id = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                              FirstName = "Jake Carlo",
                              LastName = "Renzo,",
                              LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                              LoginRetries = 0,
                              RegistrationCode = "ABCDEFG",
                              EmailAddress = "jakecarlorenzo@gmail.com",
                              Gender = Infrastructures.Domain.Enums.Gender.Male,
                              Password = BCrypt.BCryptHelper.HashPassword("jakecarlorenzo", BCrypt.BCryptHelper.GenerateSalt(9)),
                              PhoneNumber = "09504145737",
                              DateOfBirth = DateTime.Parse("06-23-1998"),
                              UserName = "jake carlo renzo",




                          });


                this._context.Users.Add(
                         new Infrastructures.Domain.Models.User()
                         {
                             Id = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                             FirstName = "Jane",
                             LastName = "Ticar",
                             LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                             LoginRetries = 0,
                             RegistrationCode = "ABCDEFG",
                             EmailAddress = "janeticar@gmail.com",
                             Gender = Infrastructures.Domain.Enums.Gender.Female,
                             Password = BCrypt.BCryptHelper.HashPassword("janeticar", BCrypt.BCryptHelper.GenerateSalt(9)),
                             PhoneNumber = "09504145737",
                             DateOfBirth = DateTime.Parse("06-23-1998"),
                             UserName = "Jane Ticar",




                         });

                                this._context.Users.Add(
                         new Infrastructures.Domain.Models.User()
                         {
                             Id = Guid.Parse("ffa44221-691c-4f82-ae45-e7f28a988d0e"),
                             FirstName = "eren",
                             LastName = "jaeger",
                             LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                             LoginRetries = 0,
                             RegistrationCode = "ABCDEFG",
                             EmailAddress = "erenjaeger@gmail.com",
                             Gender = Infrastructures.Domain.Enums.Gender.Male,
                             Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                             PhoneNumber = "09504145737",
                             DateOfBirth = DateTime.Parse("06-23-1998"),
                             UserName = "Eren Jaeger",




                         });


                                this._context.Users.Add(
                         new Infrastructures.Domain.Models.User()
                         {
                             Id = Guid.Parse("9efc57bb-d4d0-44cb-ad88-1c29e4dd1c9f"),
                             FirstName = "Mikasa",
                             LastName = "jaeger",
                             LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                             LoginRetries = 0,
                             RegistrationCode = "ABCDEFG",
                             EmailAddress = "mikasajaeger@gmail.com",
                             Gender = Infrastructures.Domain.Enums.Gender.Female,
                             Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                             PhoneNumber = "09504145737",
                             DateOfBirth = DateTime.Parse("06-23-1998"),
                             UserName = "Mikasa Jaeger",




                         });

                this._context.Users.Add(
                  new Infrastructures.Domain.Models.User()
                  {
                      Id = Guid.Parse("5b6c03f9-6ba9-4063-9418-d1c849585136"),
                      FirstName = "Levi",
                      LastName = "Ackerman",
                      LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                      LoginRetries = 0,
                      RegistrationCode = "ABCDEFG",
                      EmailAddress = "leviackerman@gmail.com",
                      Gender = Infrastructures.Domain.Enums.Gender.Female,
                      Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                      PhoneNumber = "09504145737",
                      DateOfBirth = DateTime.Parse("06-23-1998"),
                      UserName = "levi ackerman",




                  });


                this._context.Users.Add(
                  new Infrastructures.Domain.Models.User()
                  {
                      Id = Guid.Parse("a05537f4-0662-4338-a22b-8486eca71243"),
                      FirstName = "Luffy",
                      LastName = "Dragon",
                      LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                      LoginRetries = 0,
                      RegistrationCode = "ABCDEFG",
                      EmailAddress = "luffydragon@gmail.com",
                      Gender = Infrastructures.Domain.Enums.Gender.Female,
                      Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                      PhoneNumber = "09504145737",
                      DateOfBirth = DateTime.Parse("06-23-1998"),
                      UserName = "Luffy Dragon",




                  });



                this._context.Users.Add(
                  new Infrastructures.Domain.Models.User()
                  {
                      Id = Guid.Parse("569a1974-15fb-4b99-8f1c-331b5f2eb699"),
                      FirstName = "Zoro",
                      LastName = "Hunter",
                      LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                      LoginRetries = 0,
                      RegistrationCode = "ABCDEFG",
                      EmailAddress = "zorohunter@gmail.com",
                      Gender = Infrastructures.Domain.Enums.Gender.Female,
                      Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                      PhoneNumber = "09504145737",
                      DateOfBirth = DateTime.Parse("06-23-1998"),
                      UserName = "Zoro Hunter",




                  });



                this._context.Users.Add(
                  new Infrastructures.Domain.Models.User()
                  {
                      Id = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                      FirstName = "User1",
                      LastName = "Person",
                      LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                      LoginRetries = 0,
                      RegistrationCode = "ABCDEFG",
                      EmailAddress = "user1@gmail.com",
                      Gender = Infrastructures.Domain.Enums.Gender.Female,
                      Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                      PhoneNumber = "09504145737",
                      DateOfBirth = DateTime.Parse("06-23-1998"),
                      UserName = "User1 Person",




                  });
            }
            #endregion

            #region UserGroup
            if (this._context.UserGroups.Count() < 1)
            {

                this._context.UserGroups.Add(
                           new Infrastructures.Domain.Models.UserGroup()
                           {
                               Id = Guid.Parse("f341fbee-5c25-44c0-ba19-979c7d136d09"),
                               UserId = Guid.Parse("f341fbee-5c25-44c0-ba19-979c7d136d09"),
                               GroupId = Guid.Parse("55145c1f-f32a-424e-a43b-1098410e73d7")



                           });

                this._context.UserGroups.Add(
                           new Infrastructures.Domain.Models.UserGroup()
                           {
                               Id = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                               UserId = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                               GroupId = Guid.Parse("1fc9883a-6e1e-44a6-9efe-9794992aca6b")





                           });


                this._context.UserGroups.Add(
                          new Infrastructures.Domain.Models.UserGroup()
                          {
                              Id = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                              UserId = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                              GroupId = Guid.Parse("574287aa-ec9a-4901-85d2-c1d02ff679f3")



                          });
            }
            #endregion

            #region UserRole
            if (this._context.UserRoles.Count() < 1)
            {

                this._context.UserRoles.Add(
                           new Infrastructures.Domain.Models.UserRole()
                           {
                               Id = Guid.Parse("f341fbee-5c25-44c0-ba19-979c7d136d09"),
                               UserId = Guid.Parse("f341fbee-5c25-44c0-ba19-979c7d136d09"),
                               Role = Infrastructures.Domain.Enums.Role.Admin,




                           });

                this._context.UserRoles.Add(
                           new Infrastructures.Domain.Models.UserRole()
                           {
                               Id = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                               UserId = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                               Role = Infrastructures.Domain.Enums.Role.User,





                           });


                this._context.UserRoles.Add(
                          new Infrastructures.Domain.Models.UserRole()
                          {
                              Id = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                              UserId = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                              Role = Infrastructures.Domain.Enums.Role.User,



                          });


                this._context.UserRoles.Add(
                          new Infrastructures.Domain.Models.UserRole()
                          {
                              Id = Guid.Parse("ffa44221-691c-4f82-ae45-e7f28a988d0e"),
                              UserId = Guid.Parse("ffa44221-691c-4f82-ae45-e7f28a988d0e"),
                              Role = Infrastructures.Domain.Enums.Role.User,



                          });

                this._context.UserRoles.Add(
                       new Infrastructures.Domain.Models.UserRole()
                       {
                           Id = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                           UserId = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                           Role = Infrastructures.Domain.Enums.Role.User,



                       });

            }
            #endregion


            #region Booking

            if (this._context.Bookings.Count() < 1)
            {
                this._context.Bookings.Add(
                        new Infrastructures.Domain.Models.Booking()
                        {

                            Id = Guid.Parse("79b8b2ab-71af-4fe7-b0a3-b784c4d58f7b"),
                            UserName = "Wendhel aton costumer",
                            Address = "San benito,Dinalupihan,Bataan",
                            ContactNumber = "1234566789",
                            DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                            Description = "sira ang laptop ko sir parefair po",
                            TimeStamps = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            UserId = Guid.Parse("f341fbee-5c25-44c0-ba19-979c7d136d09"),
                            CreatedAt = DateTime.UtcNow,
                            ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending


                        });


                this._context.Bookings.Add(
                        new Infrastructures.Domain.Models.Booking()
                        {

                           Id = Guid.Parse("8f698ae0-5a17-4c79-9f6c-003cd1863c35"),
                           UserName = "Jake Renzo costumer",
                           Address = "St Isabel,Dinalupihan,Bataan",
                           ContactNumber = "1234566789",
                           DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                           Description = "sira ang laptop ko sir parefair po",
                           TimeStamps = DateTime.UtcNow,
                           UpdatedAt = DateTime.UtcNow,
                           UserId = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                           CreatedAt = DateTime.UtcNow,
                           ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending


                       });

                this._context.Bookings.Add(
                       new Infrastructures.Domain.Models.Booking()
                       {

                           Id = Guid.Parse("8d9db2d5-f801-438b-a06d-544c81cc93b9"),
                           UserName = "Jane ticar costumer",
                           Address = "St Isabel,Dinalupihan,Bataan",
                           ContactNumber = "1234566789",
                           DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                           Description = "sira ang laptop ko sir parefair po",
                           TimeStamps = DateTime.UtcNow,
                           UpdatedAt = DateTime.UtcNow,
                           UserId = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                           CreatedAt = DateTime.UtcNow,
                           ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending


                       });

                this._context.Bookings.Add(
                         new Infrastructures.Domain.Models.Booking()
                         {

                          Id = Guid.Parse("0a5b3034-b3c9-4ef3-ab32-241c0d4c799a"),
                          UserName = "Eren jaeger costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          Description = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          UserId = Guid.Parse("ffa44221-691c-4f82-ae45-e7f28a988d0e"),
                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending


                      });

                this._context.Bookings.Add(
                        new Infrastructures.Domain.Models.Booking()
                        {

                              Id = Guid.Parse("3b9fd91a-42f5-4211-98b1-2367f77ed014"),
                              UserName = "Mikasa jaeger costumer",
                              Address = "St Isabel,Dinalupihan,Bataan",
                              ContactNumber = "1234566789",
                              DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                              Description = "sira ang laptop ko sir parefair po",
                              TimeStamps = DateTime.UtcNow,
                              UpdatedAt = DateTime.UtcNow,
                              UserId = Guid.Parse("9efc57bb-d4d0-44cb-ad88-1c29e4dd1c9f"),
                              CreatedAt = DateTime.UtcNow,
                              ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending


                          });
            }
            #endregion




            #region Services

            if (this._context.Services.Count() < 1)
            {
                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {
                            Name = "Android Phone",
                            //Name = "Battery Replacement Phone",
                            //BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                            //Description = "Replacing battery for you mobile phone",
                            //IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("b7003ea2-c2e4-48a5-b532-77b46e068a1e"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone
                        });

                this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {

                         Name = "Android Tablet",
                         //Name = "Buttons not working to phone",
                         //BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                         //Description = "Repair the buttons of phone",
                         IsPublished = true,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("55e81c32-1023-4fbe-962e-1c5191f15032"),
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet
                     });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "Ipad",
                      //Name = "Charge Port Repair Phone",
                      //BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                      //Description = "Repair the charge port of phone",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("8ebf118e-7f9a-4fe0-aac1-9a24be513a8d"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad
                  });

                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {

                            Name = "Ipad",
                            //Name = "Charge Port Replacement Repair",
                            //BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                            //Description = "Repair and repalce the charge port of phone",
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("230925be-0eba-4835-94c4-afc9142d006e"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone
                        });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {
                          Name = "Laptops",
                          //Name = "Computer Setup or Laptop",
                          //BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                          //Description = "Setup The Desktop or Laptop, Install Anti-Virus, Perform system updates, Remove unwanted programs and trial ware, Create User Accounts, Clean exterior of device, Create Recovery Disk",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("7d0bcd40-361d-4253-bb38-a84fdee5c4de"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                      });



                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {

                          Name = "Laptop Repair",
                          //Name = "Data Recovery Deskptop or Phone",
                          //BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                          //Description = "Recover deleted files from the device that is in good working order, Drives that require advanced recovery methods for a formatted or failing drive - costumer is subject to additional costs based on individual circumstances",
                          //IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("6c86c6fc-3265-4686-be8b-8e690924fa2d"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone

                      });




                //     this._context.Services.Add(
                //           new Infrastructures.Domain.Models.Service()
                //           {

                //               Name = "Diagnostic",
                //               BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //               Description = "Full System, Hardware, Internet Performance, Sound or Webcam problem, Slow performance,lockups and freezing, Unexpected System Restart,",
                //               IsPublished = true,
                //               CreatedAt = DateTime.UtcNow,
                //               UpdatedAt = DateTime.UtcNow,
                //               Id = Guid.Parse("95d2c689-3939-4a89-b8a8-f9a45ed60e94"),
                //               ServiceType = Infrastructures.Domain.Enums.ServiceType.DiagnosticEvaluation

                //           });




                //     this._context.Services.Add(
                //           new Infrastructures.Domain.Models.Service()
                //           {

                //               Name = "Hard Drive Recovery Desktop or Laptop",
                //               BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //               Description = "Recover all the data that deleted or corrupted in hard drive",
                //               IsPublished = true,
                //               CreatedAt = DateTime.UtcNow,
                //               UpdatedAt = DateTime.UtcNow,
                //               Id = Guid.Parse("f3ca5a8a-1e45-4bf0-890d-aebe548d7e0b"),
                //               ServiceType = Infrastructures.Domain.Enums.ServiceType.HardDriveRecovery

                //           });



                //     this._context.Services.Add(
                //           new Infrastructures.Domain.Models.Service()
                //           {

                //               Name = "Upgrade Hard Drive Desktop or Laptop",
                //               BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //               Description = "Upgradingd device or gadgets to make a good performance",
                //               IsPublished = true,
                //               CreatedAt = DateTime.UtcNow,
                //               UpdatedAt = DateTime.UtcNow,
                //               Id = Guid.Parse("3f5c5f58-a147-47a1-b56b-1323c9885457"),
                //               ServiceType = Infrastructures.Domain.Enums.ServiceType.HardDriveUpgrades

                //           });


                //     this._context.Services.Add(
                //         new Infrastructures.Domain.Models.Service()
                //         {

                //             Name = "Keyboard Replacement Desktop or Laptop",
                //             BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //             Description = "Replace the old keyboard to new keyboard.",
                //             IsPublished = true,
                //             CreatedAt = DateTime.UtcNow,
                //             UpdatedAt = DateTime.UtcNow,
                //             Id = Guid.Parse("4555eab0-6bd3-412e-8180-f281bc88e7df"),
                //             ServiceType = Infrastructures.Domain.Enums.ServiceType.KeyBoardReplacement

                //         });

                //     this._context.Services.Add(
                //        new Infrastructures.Domain.Models.Service()
                //        {

                //            Name = "LCD Digitizer Replacement",
                //            BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                //            Description = "Replacing the LCD of device or desktop",
                //            IsPublished = true,
                //            CreatedAt = DateTime.UtcNow,
                //            UpdatedAt = DateTime.UtcNow,
                //            Id = Guid.Parse("30ecfc3e-b75e-440f-b7a9-ff22d9f47aeb"),
                //          ServiceType = Infrastructures.Domain.Enums.ServiceType.LCDDigitizerReplacement
                //        });


                //     this._context.Services.Add(
                //        new Infrastructures.Domain.Models.Service()
                //        {

                //            Name = "LCD Replacement",
                //            BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                //            Description = "LCD Replacement",
                //            IsPublished = true,
                //            CreatedAt = DateTime.UtcNow,
                //            UpdatedAt = DateTime.UtcNow,
                //            Id = Guid.Parse("86d7e134-1f97-46de-8eb2-373b954dc8b1"),
                //          ServiceType = Infrastructures.Domain.Enums.ServiceType.LCDReplacements
                //        });



                //     this._context.Services.Add(
                //      new Infrastructures.Domain.Models.Service()
                //      {

                //          Name = "Liquid Damage",
                //          BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //          Description = "Cleaning the liquid damage, and replace a new.",
                //          IsPublished = true,
                //          CreatedAt = DateTime.UtcNow,
                //          UpdatedAt = DateTime.UtcNow,
                //          Id = Guid.Parse("8b0f2cc3-26db-4018-9b2f-bd05c26c4f95"),
                //          ServiceType = Infrastructures.Domain.Enums.ServiceType.LiquidDamage
                //      });

                //     this._context.Services.Add(
                //    new Infrastructures.Domain.Models.Service()
                //    {

                //        Name = "Operating System Upgrade",
                //        BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //        Description = "Upgrade your OS into window 7,8 or 10 in desktop or laptop",
                //        IsPublished = true,
                //        CreatedAt = DateTime.UtcNow,
                //        UpdatedAt = DateTime.UtcNow,
                //        Id = Guid.Parse("e432471e-6b9f-4e7c-b7cb-2e9d362999ae"),
                //        ServiceType = Infrastructures.Domain.Enums.ServiceType.OSUpdgrade,

                //    });


                //     this._context.Services.Add(
                //    new Infrastructures.Domain.Models.Service()
                //    {

                //        Name = "Ram Upgrades",
                //        BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //        Description = "Upgrade the ram, 2gb Ram, 4gb Ram, 8gb Ram, 16gb Ram, 32gb Ram",
                //        IsPublished = true,
                //        CreatedAt = DateTime.UtcNow,
                //        UpdatedAt = DateTime.UtcNow,
                //        Id = Guid.Parse("cf0c2c3a-9e10-4f31-beb1-ea6266509ff8"),

                //        ServiceType = Infrastructures.Domain.Enums.ServiceType.RamUpgrades,

                //    });

                // }



                // this._context.Services.Add(
                //    new Infrastructures.Domain.Models.Service()
                //    {

                //        Name = "Software Update",
                //        BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //        Description = "Update your software in desktop or laptop",
                //        IsPublished = true,
                //        CreatedAt = DateTime.UtcNow,
                //        UpdatedAt = DateTime.UtcNow,
                //        Id = Guid.Parse("55cfd14a-3d0a-4d7d-ba4c-04aa11fc982b"),
                //        ServiceType = Infrastructures.Domain.Enums.ServiceType.SoftwareUpdate,

                //    });

                // this._context.Services.Add(
                // new Infrastructures.Domain.Models.Service()
                // {

                //     Name = "Speaker Repair",
                //     BusinessType = Infrastructures.Domain.Enums.BusinessType.Laptop,
                //     Description = "Repair the speaker. Laptop or Phone",
                //     IsPublished = true,
                //     CreatedAt = DateTime.UtcNow,
                //     UpdatedAt = DateTime.UtcNow, 
                //     Id = Guid.Parse("8dad3b42-82fd-4854-97ff-d8ad48134603"),
                //     ServiceType = Infrastructures.Domain.Enums.ServiceType.SpeakerRepair,

                // });


                // this._context.Services.Add(
                // new Infrastructures.Domain.Models.Service()
                // {

                //     Name = "Touch Screen Repair",
                //     BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                //     Description = "Repair the screen of phone",
                //     IsPublished = true,
                //     CreatedAt = DateTime.UtcNow,
                //     UpdatedAt = DateTime.UtcNow,
                //     Id = Guid.Parse("2130b49f-0e51-4da7-8dbe-d805a2a936ce"),
                //     ServiceType = Infrastructures.Domain.Enums.ServiceType.TouchScreenRepair,

                // });




                // this._context.Services.Add(
                // new Infrastructures.Domain.Models.Service()
                // {

                //     Name = "Tune Ups",
                //     BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                //     Description = "Tune Ups the phone or laptop",
                //     IsPublished = true,
                //     CreatedAt = DateTime.UtcNow,
                //     UpdatedAt = DateTime.UtcNow,
                //     Id = Guid.Parse("a3822d7c-53db-4fc0-852b-abd477502e75"),
                //     ServiceType = Infrastructures.Domain.Enums.ServiceType.TuneUps,

                // });

                // this._context.Services.Add(
                //new Infrastructures.Domain.Models.Service()
                //{

                //    Name = "Unlock",
                //    BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //    Description = "Unlocking the Desktop,Laptop,Phone",
                //    IsPublished = true,
                //    CreatedAt = DateTime.UtcNow,
                //    UpdatedAt = DateTime.UtcNow,
                //    Id = Guid.Parse("c58c03ba-7143-4f2a-b248-55caaf4f9571"),
                //    ServiceType = Infrastructures.Domain.Enums.ServiceType.Unlock

                //});



                // this._context.Services.Add(
                //new Infrastructures.Domain.Models.Service()
                //{

                //    Name = "Virus Removal",
                //    BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                //    Description = "Remove the virus in Desktop,Laptop,Phone",
                //    IsPublished = true,
                //    CreatedAt = DateTime.UtcNow,
                //    UpdatedAt = DateTime.UtcNow,
                //    Id = Guid.Parse("df3a272f-f168-423a-9672-543621a301d2"),
                //     ServiceType = Infrastructures.Domain.Enums.ServiceType.VirusRemoval,

                //});
            }


            #endregion


          

            this._context.SaveChanges();
            return Ok("Ok");
        }
    }
 }
    

    
