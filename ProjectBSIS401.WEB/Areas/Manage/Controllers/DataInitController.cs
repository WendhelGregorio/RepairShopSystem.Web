using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;

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

                    //Desktop Shop
                    this._context.Shops.Add(
                    new Infrastructures.Domain.Models.Shop()
                    {

                        Id = Guid.Parse("3c29d5fd-269b-419e-9313-22c891116137"),
                        OwnerShop = "Goshen Jimenze",
                        BusinessEmailAddress = "goshenjimenez@gmail.com",
                        BusinessContact = "123456789",
                        BusinessLocation = "Lincoln,Dinalupihan,Bataan",
                        BusinessName = "Desktop Repair Shop",
                        UserId = Guid.Parse("65546B99-35EF-45AE-BF73-E92C6F416F01"),
                        OpenAt = "8:00 AM",
                        CloseAt = "8:00 PM",
                        CreatedAt = DateTime.UtcNow,
                        BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                        UpdatedAt = DateTime.UtcNow,
                        IsPublished = true,
                        BusinessDescription = "we offer all the service !",
                        Status = Infrastructures.Domain.Enums.Status.Active,
                        Banner = true,
                        Logo = true,
                        Thumbnail = true,
                        

                    });


                    this._context.Shops.Add(
                     new Infrastructures.Domain.Models.Shop()
                     {

                         Id = Guid.Parse("de01e8e4-3131-47fb-97f9-055f0cf1c703"),
                         OwnerShop = "Jane Ticar",
                         BusinessEmailAddress = "janeticar@gmail.com",
                         BusinessContact = "09663218416",
                         BusinessLocation = "St.Isabel,Dinalupihan,Bataan",
                         BusinessName = "Desktop Repair Shop",
                         OpenAt = "8:00 AM",
                         CloseAt = "8:00 PM",
                         UserId = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                         CreatedAt = DateTime.UtcNow,
                         BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                         UpdatedAt = DateTime.UtcNow,
                         IsPublished = true,
                         BusinessDescription = "we offer all the service !",
                         Status = Infrastructures.Domain.Enums.Status.Active,
                         Banner = true,
                         Logo = true,
                         Thumbnail = true,

                     });

                    this._context.Shops.Add(
                   new Infrastructures.Domain.Models.Shop()
                   {

                       Id = Guid.Parse("ef17b261-6a9a-4a02-a8dd-1c0f406609dc"),
                       OwnerShop = "Jake Carlo Renzo",
                       BusinessEmailAddress = "jakecarlorenzo@gmail.com",
                       BusinessContact = "09663218416",
                       BusinessLocation = "St.Isabel,Dinalupihan,Bataan",
                       BusinessName = "Desktop Repair Shop",
                       OpenAt = "8:00 AM",
                       CloseAt = "8:00 PM",
                       UserId = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                       CreatedAt = DateTime.UtcNow,
                       BusinessType = Infrastructures.Domain.Enums.BusinessType.Desktop,
                       UpdatedAt = DateTime.UtcNow,
                       IsPublished = true,
                       BusinessDescription = "we offer all the service !",
                       Status = Infrastructures.Domain.Enums.Status.Active,
                       Banner = true,
                       Logo = true,
                       Thumbnail = true,

                   });

                    //Laptop Shop

                    this._context.Shops.Add(
                 new Infrastructures.Domain.Models.Shop()
                 {

                     Id = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                     OwnerShop = "Eren jaeger",
                     BusinessEmailAddress = "erenjaeger@gmail.com",
                     BusinessContact = "09663218416",
                     BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                     BusinessName = "Laptop Repair Shop",
                     OpenAt = "8:00 AM",
                     CloseAt = "8:00 PM",
                     UserId = Guid.Parse("ffa44221-691c-4f82-ae45-e7f28a988d0e"),
                     CreatedAt = DateTime.UtcNow,
                     BusinessType = Infrastructures.Domain.Enums.BusinessType.Laptop,
                     UpdatedAt = DateTime.UtcNow,
                     IsPublished = true,
                     BusinessDescription = "we offer all the service !",
                     Status = Infrastructures.Domain.Enums.Status.Active,
                     Banner = true,
                     Logo = true,
                     Thumbnail = true,

                 });

                    this._context.Shops.Add(
             new Infrastructures.Domain.Models.Shop()
             {

                 Id = Guid.Parse("9966c022-2237-4506-88ce-5ac68844c70f"),
                 OwnerShop = "Mikasa jaeger",
                 BusinessEmailAddress = "mikasajaeger@gmail.com",
                 BusinessContact = "09663218416",
                 BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                 BusinessName = "Laptop Repair Shop",
                 OpenAt = "8:00 AM",
                 CloseAt = "8:00 PM",
                 UserId = Guid.Parse("9efc57bb-d4d0-44cb-ad88-1c29e4dd1c9f"),
                 CreatedAt = DateTime.UtcNow,
                 BusinessType = Infrastructures.Domain.Enums.BusinessType.Laptop,
                 UpdatedAt = DateTime.UtcNow,
                 IsPublished = true,
                 BusinessDescription = "we offer all the service !",
                 Status = Infrastructures.Domain.Enums.Status.Active,
                 Banner = true,
                 Logo = true,
                 Thumbnail = true,

             });

                    this._context.Shops.Add(
            new Infrastructures.Domain.Models.Shop()
            {

                Id = Guid.Parse("0413b680-91ca-49f0-8485-0af0ec711593"),
                OwnerShop = "Zoro Hunter",
                BusinessEmailAddress = "zorohunter@gmail.com",
                BusinessContact = "09663218416",
                BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                BusinessName = "Laptop Repair Shop",
                OpenAt = "8:00 AM",
                CloseAt = "8:00 PM",
                UserId = Guid.Parse("569a1974-15fb-4b99-8f1c-331b5f2eb699"),
                CreatedAt = DateTime.UtcNow,
                BusinessType = Infrastructures.Domain.Enums.BusinessType.Laptop,
                UpdatedAt = DateTime.UtcNow,
                IsPublished = true,
                BusinessDescription = "we offer all the service !",
                Status = Infrastructures.Domain.Enums.Status.Active,
                Banner = true,
                Logo = true,
                Thumbnail = true,

            });

                //CellPhone Shop
                        this._context.Shops.Add(
                new Infrastructures.Domain.Models.Shop()
                {

                    Id = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                    OwnerShop = "Luffy Dragon",
                    BusinessEmailAddress = "luffydragon@gmail.com",
                    BusinessContact = "09663218416",
                    BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                    BusinessName = "CellPhone Repair Shop",
                    OpenAt = "8:00 AM",
                    CloseAt = "8:00 PM",
                    UserId = Guid.Parse("a05537f4-0662-4338-a22b-8486eca71243"),
                    CreatedAt = DateTime.UtcNow,
                    BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                    UpdatedAt = DateTime.UtcNow,
                    IsPublished = true,
                    BusinessDescription = "we offer all the service !",
                    Status = Infrastructures.Domain.Enums.Status.Active,
                    Banner = true,
                    Logo = true,
                    Thumbnail = true,

                });

                                this._context.Shops.Add(
                new Infrastructures.Domain.Models.Shop()
                {

                    Id = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                    OwnerShop = "Levi Ackerman",
                    BusinessEmailAddress = "leviackerman@gmail.com",
                    BusinessContact = "09663218416",
                    BusinessLocation = "Maria Rose,Dinalupihan,Bataan",
                    BusinessName = "CellPhone Repair Shop",
                    OpenAt = "8:00 AM",
                    CloseAt = "8:00 PM",
                    UserId = Guid.Parse("5b6c03f9-6ba9-4063-9418-d1c849585136"),
                    CreatedAt = DateTime.UtcNow,
                    BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                    UpdatedAt = DateTime.UtcNow,
                    IsPublished = true,
                    BusinessDescription = "we offer all the service !",
                    Status = Infrastructures.Domain.Enums.Status.Active,
                    Banner = true,
                    Logo = true,
                    Thumbnail = true,

                });

                this._context.Shops.Add(
                new Infrastructures.Domain.Models.Shop()
                {

                    Id = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                    OwnerShop = "Gon Pricks",
                    BusinessEmailAddress = "gon@gmail.com",
                    BusinessContact = "09663218416",
                    BusinessLocation = "Hunter x Hunter,Dinalupihan,Bataan",
                    BusinessName = "CellPhone Repair Shop",
                    OpenAt = "8:00 AM",
                    CloseAt = "8:00 PM",
                    UserId = Guid.Parse("06D7F17B-7BA2-43E3-8EC2-E8AC12A35757"),
                    CreatedAt = DateTime.UtcNow,
                    BusinessType = Infrastructures.Domain.Enums.BusinessType.CellPhone,
                    UpdatedAt = DateTime.UtcNow,
                    IsPublished = true,
                    BusinessDescription = "we offer all the service !",
                    Status = Infrastructures.Domain.Enums.Status.Active,
                    Banner = true,
                    Logo = true,
                    Thumbnail = true,

                });



                    //Tablet Shop
                  this._context.Shops.Add(
                new Infrastructures.Domain.Models.Shop()
                {

                    Id = Guid.Parse("6378E6DD-84F2-41C7-9C46-ED4FF19F68B8"),
                    OwnerShop = "Killua Zoldycks",
                    BusinessEmailAddress = "killua@gmail.com",
                    BusinessContact = "09663218416",
                    BusinessLocation = "Hunter x Hunter,Dinalupihan,Bataan",
                    BusinessName = "Tablet Repair Shop",
                    OpenAt = "8:00 AM",
                    CloseAt = "8:00 PM",
                    UserId = Guid.Parse("C51F2E53-09CA-4460-9F12-466B862299E8"),
                    CreatedAt = DateTime.UtcNow,
                    BusinessType = Infrastructures.Domain.Enums.BusinessType.Tablet,
                    UpdatedAt = DateTime.UtcNow,
                    IsPublished = true,
                    BusinessDescription = "we offer all the service !",
                    Status = Infrastructures.Domain.Enums.Status.Active,
                    Banner = true,
                    Logo = true,
                    Thumbnail = true,

                });






                }
            }
            #endregion

            #region User
            if (this._context.Users.Count() < 1)
            {
                // 1 Admin
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
                                 Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                                 PhoneNumber = "09504145737",
                                 DateOfBirth = DateTime.Parse("06-23-1998"),
                                 UserName = "Wendhel Aton",
                                 Thumbnail = true,
                             });


                // 10 Users with shop
                this._context.Users.Add(
                         new Infrastructures.Domain.Models.User()
                         {
                             Id = Guid.Parse("65546B99-35EF-45AE-BF73-E92C6F416F01"),
                             FirstName = "Goshen ",
                             LastName = "Jimenez,",
                             LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                             LoginRetries = 0,
                             RegistrationCode = "ABCDEFG",
                             EmailAddress = "goshenjimenez@gmail.com",
                             Gender = Infrastructures.Domain.Enums.Gender.Male,
                             Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                             PhoneNumber = "123456789",
                             DateOfBirth = DateTime.Parse("06-23-1998"),
                             UserName = "Goshen Jimenez",
                             
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
                             Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
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
                      Gender = Infrastructures.Domain.Enums.Gender.Male,
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
                      Gender = Infrastructures.Domain.Enums.Gender.Male,
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
                      Gender = Infrastructures.Domain.Enums.Gender.Male,
                      Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                      PhoneNumber = "09504145737",
                      DateOfBirth = DateTime.Parse("06-23-1998"),
                      UserName = "Zoro Hunter",
                  });



                this._context.Users.Add(
                new Infrastructures.Domain.Models.User()
                {
                    Id = Guid.Parse("06D7F17B-7BA2-43E3-8EC2-E8AC12A35757"),
                    FirstName = "Gon",
                    LastName = "Pricks",
                    LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                    LoginRetries = 0,
                    RegistrationCode = "ABCDEFG",
                    EmailAddress = "gon@gmail.com",
                    Gender = Infrastructures.Domain.Enums.Gender.Male,
                    Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                    PhoneNumber = "09504145737",
                    DateOfBirth = DateTime.Parse("06-23-1998"),
                    UserName = "Gon Pricks",
                });


                this._context.Users.Add(
                new Infrastructures.Domain.Models.User()
                {
                    Id = Guid.Parse("C51F2E53-09CA-4460-9F12-466B862299E8"),
                    FirstName = "Killua",
                    LastName = "Zoldycks",
                    LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                    LoginRetries = 0,
                    RegistrationCode = "ABCDEFG",
                    EmailAddress = "killua@gmail.com",
                    Gender = Infrastructures.Domain.Enums.Gender.Male,
                    Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                    PhoneNumber = "09504145737",
                    DateOfBirth = DateTime.Parse("06-23-1998"),
                    UserName = "Killua Zoldycks",
                });


                // 6 Users without shop yet
                this._context.Users.Add(
                  new Infrastructures.Domain.Models.User()
                  {
                      Id = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                      FirstName = "Dog",
                      LastName = "Army",
                      LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                      LoginRetries = 0,
                      RegistrationCode = "ABCDEFG",
                      EmailAddress = "dog@gmail.com",
                      Gender = Infrastructures.Domain.Enums.Gender.Male,
                      Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                      PhoneNumber = "09504145737",
                      DateOfBirth = DateTime.Parse("06-23-1998"),
                      UserName = "Dog army",
                      Thumbnail = true,




                  });

                this._context.Users.Add(
                new Infrastructures.Domain.Models.User()
                {
                    Id = Guid.Parse("ADBA3390-540F-40F6-A888-FAEFFFEFF92D"),
                    FirstName = "Tom",
                    LastName = "Cat",
                    LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                    LoginRetries = 0,
                    RegistrationCode = "ABCDEFG",
                    EmailAddress = "tom@gmail.com",
                    Gender = Infrastructures.Domain.Enums.Gender.Male,
                    Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                    PhoneNumber = "09504145737",
                    DateOfBirth = DateTime.Parse("06-23-1998"),
                    UserName = "Tom Cat",




                });


                this._context.Users.Add(
               new Infrastructures.Domain.Models.User()
               {
                   Id = Guid.Parse("06146021-502D-48EB-9BFD-0C10C855EE42"),
                   FirstName = "Jerry",
                   LastName = "Mouse",
                   LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                   LoginRetries = 0,
                   RegistrationCode = "ABCDEFG",
                   EmailAddress = "jerry@gmail.com",
                   Gender = Infrastructures.Domain.Enums.Gender.Male,
                   Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                   PhoneNumber = "09504145737",
                   DateOfBirth = DateTime.Parse("06-23-1998"),
                   UserName = "Jerry Mouse",




               });


                this._context.Users.Add(
               new Infrastructures.Domain.Models.User()
               {
                   Id = Guid.Parse("F7996510-5551-45F8-9E56-6E820747443A"),
                   FirstName = "Dexter",
                   LastName = "Monkey",
                   LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                   LoginRetries = 0,
                   RegistrationCode = "ABCDEFG",
                   EmailAddress = "dexter@gmail.com",
                   Gender = Infrastructures.Domain.Enums.Gender.Male,
                   Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                   PhoneNumber = "09504145737",
                   DateOfBirth = DateTime.Parse("06-23-1998"),
                   UserName = "Dexter Monkey",




               });


                this._context.Users.Add(
            new Infrastructures.Domain.Models.User()
            {
                Id = Guid.Parse("A861F572-72BA-46A5-A820-02FDABC8772D"),
                FirstName = "Chimera",
                LastName = "Ant",
                LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                LoginRetries = 0,
                RegistrationCode = "ABCDEFG",
                EmailAddress = "chimera@gmail.com",
                Gender = Infrastructures.Domain.Enums.Gender.Male,
                Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                PhoneNumber = "09504145737",
                DateOfBirth = DateTime.Parse("06-23-1998"),
                UserName = "Chimera Ant",




            });

                this._context.Users.Add(
            new Infrastructures.Domain.Models.User()
            {
                Id = Guid.Parse("A27F0531-4041-49AB-9ED5-90E4C19025F4"),
                FirstName = "Rimeru",
                LastName = "Slime",
                LoginStatus = Infrastructures.Domain.Enums.LoginStatus.Active,
                LoginRetries = 0,
                RegistrationCode = "ABCDEFG",
                EmailAddress = "rimeru@gmail.com",
                Gender = Infrastructures.Domain.Enums.Gender.Female,
                Password = BCrypt.BCryptHelper.HashPassword("123456789", BCrypt.BCryptHelper.GenerateSalt(9)),
                PhoneNumber = "09504145737",
                DateOfBirth = DateTime.Parse("06-23-1998"),
                UserName = "Rimeru Slime",




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
                //Admin
                //Wendhel Aton
                this._context.UserRoles.Add(
                           new Infrastructures.Domain.Models.UserRole()
                           {
                               Id = Guid.Parse("f341fbee-5c25-44c0-ba19-979c7d136d09"),
                               UserId = Guid.Parse("f341fbee-5c25-44c0-ba19-979c7d136d09"),
                               Role = Infrastructures.Domain.Enums.Role.Admin,




                           });


                //Shop Admin
                //Jake renzo
                this._context.UserRoles.Add(
                           new Infrastructures.Domain.Models.UserRole()
                           {
                               Id = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                               UserId = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                               Role = Infrastructures.Domain.Enums.Role.ShopAdmin,





                           });

                //Jane ticar
                this._context.UserRoles.Add(
                          new Infrastructures.Domain.Models.UserRole()
                          {
                              Id = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                              UserId = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                              Role = Infrastructures.Domain.Enums.Role.ShopAdmin,



                          });

                //Eren Jaeger
                this._context.UserRoles.Add(
                          new Infrastructures.Domain.Models.UserRole()
                          {
                              Id = Guid.Parse("ffa44221-691c-4f82-ae45-e7f28a988d0e"),
                              UserId = Guid.Parse("ffa44221-691c-4f82-ae45-e7f28a988d0e"),
                              Role = Infrastructures.Domain.Enums.Role.ShopAdmin,



                          });

                //Mikasa Ackerman
                this._context.UserRoles.Add(
                     new Infrastructures.Domain.Models.UserRole()
                     {
                         Id = Guid.Parse("2A365725-59A1-4E8D-8355-CCD7AFDD38A9"),
                         UserId = Guid.Parse("06D7F17B-7BA2-43E3-8EC2-E8AC12A35757"),
                         Role = Infrastructures.Domain.Enums.Role.ShopAdmin,



                     });


                //Levi Ackerman
                this._context.UserRoles.Add(
                   new Infrastructures.Domain.Models.UserRole()
                   {
                       Id = Guid.Parse("F0451041-33F6-4C79-BB20-29C25CF9BD04"),
                       UserId = Guid.Parse("C51F2E53-09CA-4460-9F12-466B862299E8"),
                       Role = Infrastructures.Domain.Enums.Role.ShopAdmin,



                   });

                //Luffy Monkey
                this._context.UserRoles.Add(
                 new Infrastructures.Domain.Models.UserRole()
                 {
                     Id = Guid.Parse("9824667E-ECBD-46B3-811D-9A7C0B386EEB"),
                     UserId = Guid.Parse("65546B99-35EF-45AE-BF73-E92C6F416F01"),
                     Role = Infrastructures.Domain.Enums.Role.ShopAdmin,



                 });
                //Zoro Hunter
                this._context.UserRoles.Add(
                  new Infrastructures.Domain.Models.UserRole()
                  {
                      Id = Guid.Parse("B7CB8EDB-3470-49A9-9263-CBC0C97819F5"),
                      UserId = Guid.Parse("9efc57bb-d4d0-44cb-ad88-1c29e4dd1c9f"),
                      Role = Infrastructures.Domain.Enums.Role.ShopAdmin,



                  });
                //Gon Pricks
                this._context.UserRoles.Add(
                    new Infrastructures.Domain.Models.UserRole()
                    {
                        Id = Guid.Parse("31DA2667-BF0C-4757-B5E9-381B5E713DFA"),
                        UserId = Guid.Parse("5b6c03f9-6ba9-4063-9418-d1c849585136"),
                        Role = Infrastructures.Domain.Enums.Role.ShopAdmin,



                    });
                
                //Killua Zoldycks
                this._context.UserRoles.Add(
                    new Infrastructures.Domain.Models.UserRole()
                    {
                        Id = Guid.Parse("E6E83FD5-711D-4C41-BBB5-F01CFF69B2DB"),
                        UserId = Guid.Parse("a05537f4-0662-4338-a22b-8486eca71243"),
                        Role = Infrastructures.Domain.Enums.Role.ShopAdmin,



                    });

                //Goshen Jimenez
                this._context.UserRoles.Add(
                new Infrastructures.Domain.Models.UserRole()
                {
                    Id = Guid.Parse("8B888D13-5BFA-4C67-9408-43B44D2B6009"),
                    UserId = Guid.Parse("569a1974-15fb-4b99-8f1c-331b5f2eb699"),
                    Role = Infrastructures.Domain.Enums.Role.ShopAdmin,



                });
          

                // 6 Users Role
                //Dog Army
                this._context.UserRoles.Add(
                       new Infrastructures.Domain.Models.UserRole()
                       {
                           Id = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                           UserId = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                           Role = Infrastructures.Domain.Enums.Role.User,



                       });

                //Tom Cat
                this._context.UserRoles.Add(
                      new Infrastructures.Domain.Models.UserRole()
                      {
                          Id = Guid.Parse("FD503276-08B5-4268-AD4E-8D2962AEDABE"),
                          UserId = Guid.Parse("ADBA3390-540F-40F6-A888-FAEFFFEFF92D"),
                          Role = Infrastructures.Domain.Enums.Role.User,



                      });
                //Jerry Mouse
                this._context.UserRoles.Add(
                     new Infrastructures.Domain.Models.UserRole()
                     {
                         Id = Guid.Parse("F687E530-FB13-402A-80CC-9EBD02DE2A4A"),
                         UserId = Guid.Parse("06146021-502D-48EB-9BFD-0C10C855EE42"),
                         Role = Infrastructures.Domain.Enums.Role.User,



                     });

                //Dexter Monkey
                this._context.UserRoles.Add(
                     new Infrastructures.Domain.Models.UserRole()
                     {
                         Id = Guid.Parse("7AF1529C-CDEF-4C5D-AEDC-C7654382BCFF"),
                         UserId = Guid.Parse("F7996510-5551-45F8-9E56-6E820747443A"),
                         Role = Infrastructures.Domain.Enums.Role.User,



                     });

                //Chimera Ant
                this._context.UserRoles.Add(
                new Infrastructures.Domain.Models.UserRole()
                {
                    Id = Guid.Parse("B028EB39-EE86-48CB-89A0-F074B90CBEC8"),
                    UserId = Guid.Parse("A861F572-72BA-46A5-A820-02FDABC8772D"),
                    Role = Infrastructures.Domain.Enums.Role.User,



                });

                //Rimeru Slime
                this._context.UserRoles.Add(
                new Infrastructures.Domain.Models.UserRole()
                {
                    Id = Guid.Parse("F0F6ED89-A0B1-4DDD-86F0-537F99FC6E8E"),
                    UserId = Guid.Parse("A27F0531-4041-49AB-9ED5-90E4C19025F4"),
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
                            // Goshen Book in Eren Shop
                            Id = Guid.Parse("79b8b2ab-71af-4fe7-b0a3-b784c4d58f7b"),
                            UserId = Guid.Parse("65546B99-35EF-45AE-BF73-E92C6F416F01"),
                            ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),

                            UserName = "Goshen Jimenez costumer",
                            Address = "Lincoln ,Dinalupihan,Bataan",
                            ContactNumber = "1234566789",
                            DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                            AdditionalDescription = "sira ang laptop ko sir parefair po",
                            TimeStamps = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            CreatedAt = DateTime.UtcNow,
                            ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                            PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                        });


                this._context.Bookings.Add(
                        new Infrastructures.Domain.Models.Booking()
                        {
                            // Jake Book in Mikasa shop
                            Id = Guid.Parse("8f698ae0-5a17-4c79-9f6c-003cd1863c35"),
                            UserId = Guid.Parse("d8865a43-9d3c-4423-af12-f67609db4f70"),
                            ShopId = Guid.Parse("9966c022-2237-4506-88ce-5ac68844c70f"),
                            UserName = "Jake Renzo costumer",
                           Address = "St Isabel,Dinalupihan,Bataan",
                           ContactNumber = "1234566789",
                           DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                            AdditionalDescription = "sira ang laptop ko sir parefair po",
                           TimeStamps = DateTime.UtcNow,
                           UpdatedAt = DateTime.UtcNow,
                           
                           CreatedAt = DateTime.UtcNow,
                           ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                            PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid

                        });

                this._context.Bookings.Add(
                       new Infrastructures.Domain.Models.Booking()
                       {
                           // Jane Book in Jake shop
                           Id = Guid.Parse("8d9db2d5-f801-438b-a06d-544c81cc93b9"),
                           UserId = Guid.Parse("69a63d76-cd54-43e2-bd1a-9f798217a3a8"),
                           ShopId = Guid.Parse("ef17b261-6a9a-4a02-a8dd-1c0f406609dc"),
                           UserName = "Jane ticar costumer",
                           Address = "St Isabel,Dinalupihan,Bataan",
                           ContactNumber = "1234566789",
                           DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                           AdditionalDescription = "sira ang laptop ko sir parefair po",
                           TimeStamps = DateTime.UtcNow,
                           UpdatedAt = DateTime.UtcNow,
                          
                           CreatedAt = DateTime.UtcNow,
                           ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                           PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid

                       });

                this._context.Bookings.Add(
                         new Infrastructures.Domain.Models.Booking()
                         {

                             // Eren Book in Luffy shop
                          Id = Guid.Parse("0a5b3034-b3c9-4ef3-ab32-241c0d4c799a"),
                          UserId = Guid.Parse("ffa44221-691c-4f82-ae45-e7f28a988d0e"),
                          ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                          UserName = "Eren jaeger costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                             AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                         
                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid

                         });

                this._context.Bookings.Add(
                        new Infrastructures.Domain.Models.Booking()
                        {
                            // Mikasa Book in Levi shop
                            Id = Guid.Parse("3b9fd91a-42f5-4211-98b1-2367f77ed014"),
                            UserId = Guid.Parse("9efc57bb-d4d0-44cb-ad88-1c29e4dd1c9f"),
                            ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                            UserName = "Mikasa jaeger costumer",
                              Address = "St Isabel,Dinalupihan,Bataan",
                              ContactNumber = "1234566789",
                              DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                            AdditionalDescription = "sira ang laptop ko sir parefair po",
                              TimeStamps = DateTime.UtcNow,
                              UpdatedAt = DateTime.UtcNow,
                            
                              CreatedAt = DateTime.UtcNow,
                              ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                             PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                        });

                // 3 Booking of Goshen shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                            // Dog Army Book in Goshen shop
                            Id = Guid.Parse("C2773387-0320-4D7E-9BE1-3A8B2C62DA67"),
                          UserId = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                          ShopId = Guid.Parse("3c29d5fd-269b-419e-9313-22c891116137"),
                          UserName = "Dog Army costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                          // Tom Cat Book in Goshen shop
                          Id = Guid.Parse("9BDDEC96-FD62-462C-A86B-A84E01646482"),
                       UserId = Guid.Parse("ADBA3390-540F-40F6-A888-FAEFFFEFF92D"),
                       ShopId = Guid.Parse("3c29d5fd-269b-419e-9313-22c891116137"),
                       UserName = "Tom Cat costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                       // Tom Cat Book in Goshen shop
                       Id = Guid.Parse("37DB15BD-ECE2-444E-BE10-FEFC363F8C12"),
                      UserId = Guid.Parse("06146021-502D-48EB-9BFD-0C10C855EE42"),
                      ShopId = Guid.Parse("3c29d5fd-269b-419e-9313-22c891116137"),
                      UserName = "Tom Cat costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });


                // 3 Booking of Jane shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                          // Dexter Monkey Book in Jane shop
                          Id = Guid.Parse("CB1E1090-A1A0-4525-AD56-A1DC85569A8D"),
                          UserId = Guid.Parse("F7996510-5551-45F8-9E56-6E820747443A"),
                          ShopId = Guid.Parse("de01e8e4-3131-47fb-97f9-055f0cf1c703"),
                          UserName = "Dexter Monkey costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                       // Chimera Ant Book in Jane shop
                       Id = Guid.Parse("6F3AD5A1-805F-4343-AED6-8882FE31B197"),
                       UserId = Guid.Parse("A861F572-72BA-46A5-A820-02FDABC8772D"),
                       ShopId = Guid.Parse("de01e8e4-3131-47fb-97f9-055f0cf1c703"),
                       UserName = "Chimera Ant costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                      //Rimeru Slime Book in Jane shop
                      Id = Guid.Parse("25A03930-0C3C-4F17-BFE6-7E946F8C6DFE"),
                      UserId = Guid.Parse("A27F0531-4041-49AB-9ED5-90E4C19025F4"),
                      ShopId = Guid.Parse("de01e8e4-3131-47fb-97f9-055f0cf1c703"),
                      UserName = "Rimeru Slime costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });

                // 3 Booking of Jake shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                          // Dog Army Book in Jake shop
                          Id = Guid.Parse("47fb6400-0868-4adc-85e2-e07ba956c60e"),
                          UserId = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                          ShopId = Guid.Parse("ef17b261-6a9a-4a02-a8dd-1c0f406609dc"),
                          UserName = "Dog Army costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                       // Tom Cat Book in Jake shop
                       Id = Guid.Parse("d567e2d3-5a58-455d-b54b-dae9eee7adf8"),
                       UserId = Guid.Parse("ADBA3390-540F-40F6-A888-FAEFFFEFF92D"),
                       ShopId = Guid.Parse("ef17b261-6a9a-4a02-a8dd-1c0f406609dc"),
                       UserName = "Tom Cat costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                      //Jerry mouse Book in Jake shop
                      Id = Guid.Parse("c6dd9993-b894-46d6-9594-33c38e36394f"),
                      UserId = Guid.Parse("06146021-502D-48EB-9BFD-0C10C855EE42"),
                      ShopId = Guid.Parse("ef17b261-6a9a-4a02-a8dd-1c0f406609dc"),
                      UserName = "Jerry mouse costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });


                // 3 Booking of Eren shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                          // Dexter Monkey Book in Eren shop
                          Id = Guid.Parse("67adccac-56da-4f1d-b7d3-9c236dd9f0ac"),
                          UserId = Guid.Parse("F7996510-5551-45F8-9E56-6E820747443A"),
                          ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                          UserName = "Dexter Monkey costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                       // Chimera Ant Book in Eren shop
                       Id = Guid.Parse("a209c063-5716-4830-93e7-fb5236514b47"),
                       UserId = Guid.Parse("A861F572-72BA-46A5-A820-02FDABC8772D"),
                       ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                       UserName = "Chimera Ant costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                      //Rimeru Slime Book in Eren shop
                      Id = Guid.Parse("b95f9e04-aa58-4e68-94a7-98cd0bc6c2bd"),
                      UserId = Guid.Parse("A27F0531-4041-49AB-9ED5-90E4C19025F4"),
                      ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                      UserName = "Rimeru Slime costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });



                // 3 Booking of Mikasa shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                          // Dog Army Book in Mikasa shop
                          Id = Guid.Parse("954023f0-2b08-4519-a874-9da40099b739"),
                          UserId = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                          ShopId = Guid.Parse("9966c022-2237-4506-88ce-5ac68844c70f"),
                          UserName = "Dog Army costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                       // Tom Cat Book in Mikasa shop
                       Id = Guid.Parse("e87a851f-4ec7-44a3-a71d-e81b568f350e"),
                       UserId = Guid.Parse("ADBA3390-540F-40F6-A888-FAEFFFEFF92D"),
                       ShopId = Guid.Parse("9966c022-2237-4506-88ce-5ac68844c70f"),
                       UserName = "Tom Cat costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                      //Jerry mouse Book in Mikasa shop
                      Id = Guid.Parse("4e8fb37a-52f4-41bd-ad2c-4d459b0bf2e0"),
                      UserId = Guid.Parse("06146021-502D-48EB-9BFD-0C10C855EE42"),
                      ShopId = Guid.Parse("9966c022-2237-4506-88ce-5ac68844c70f"),
                      UserName = "Jerry mouse costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });




                // 3 Booking of Zoro shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                          // Dexter Monkey Book in Zoro shop
                          Id = Guid.Parse("c005ed89-d6c6-438d-a2b9-ee3e4a79f5c7"),
                          UserId = Guid.Parse("F7996510-5551-45F8-9E56-6E820747443A"),
                          ShopId = Guid.Parse("0413b680-91ca-49f0-8485-0af0ec711593"),
                          UserName = "Dexter Monkey costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                       // Chimera Ant Book in Zoro shop
                       Id = Guid.Parse("debb19b4-9e27-4b21-8b9a-2d95d1e5a7a7"),
                       UserId = Guid.Parse("A861F572-72BA-46A5-A820-02FDABC8772D"),
                       ShopId = Guid.Parse("0413b680-91ca-49f0-8485-0af0ec711593"),
                       UserName = "Chimera Ant costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                      //Rimeru Slime Book in Zoro shop
                      Id = Guid.Parse("490b1126-cd60-4408-b60d-4ceb0ec7271f"),
                      UserId = Guid.Parse("A27F0531-4041-49AB-9ED5-90E4C19025F4"),
                        ShopId = Guid.Parse("0413b680-91ca-49f0-8485-0af0ec711593"),
                      UserName = "Rimeru Slime costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });



                // 3 Booking of Luffy shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                          // Dog Army Book in Luffy shop
                          Id = Guid.Parse("ce3be841-3808-4203-8d6e-81bcd0129804"),
                          UserId = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                          ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                          UserName = "Dog Army costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                       // Tom Cat Book in Luffy shop
                       Id = Guid.Parse("615f09a0-6733-47e9-b913-459363481daa"),
                       UserId = Guid.Parse("ADBA3390-540F-40F6-A888-FAEFFFEFF92D"),
                       ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                       UserName = "Tom Cat costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                      //Jerry mouse Book in Luffy shop
                      Id = Guid.Parse("4150e19f-8d43-4e69-ab2b-71377623cedc"),
                      UserId = Guid.Parse("06146021-502D-48EB-9BFD-0C10C855EE42"),
                      ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                      UserName = "Jerry mouse costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });


                // 3 Booking of Levi shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                          // Dexter Monkey Book in Levi shop
                          Id = Guid.Parse("8ec8112f-7f49-41d8-98ac-ae0f99ef9db1"),
                          UserId = Guid.Parse("F7996510-5551-45F8-9E56-6E820747443A"),
                          ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                          UserName = "Dexter Monkey costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                       // Chimera Ant Book in Levi shop
                       Id = Guid.Parse("e23f6a32-c88a-4986-af32-61ecafe7a64e"),
                       UserId = Guid.Parse("A861F572-72BA-46A5-A820-02FDABC8772D"),
                       ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                       UserName = "Chimera Ant costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                      //Rimeru Slime Book in Levi shop
                      Id = Guid.Parse("7fe2b96b-7cea-4ae6-a853-00329cbee40c"),
                      UserId = Guid.Parse("A27F0531-4041-49AB-9ED5-90E4C19025F4"),
                      ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                      UserName = "Rimeru Slime costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });



                // 3 Booking of Gon shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                          // Dog Army Book in Gon shop
                          Id = Guid.Parse("930721e4-2539-4173-9772-3a9e2f515c2a"),
                          UserId = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                          ShopId = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                          UserName = "Dog Army costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                       // Tom Cat Book in Gon shop
                       Id = Guid.Parse("a01cea7c-d463-4c67-9033-048076c839fb"),
                       UserId = Guid.Parse("ADBA3390-540F-40F6-A888-FAEFFFEFF92D"),
                       ShopId = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                       UserName = "Tom Cat costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                      //Jerry mouse Book in Gon shop
                      Id = Guid.Parse("70273baf-3b97-41c6-9cc0-33863685fd88"),
                      UserId = Guid.Parse("06146021-502D-48EB-9BFD-0C10C855EE42"),
                      ShopId = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                      UserName = "Jerry mouse costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });


                // 3 Booking of Killua shop
                this._context.Bookings.Add(
                      new Infrastructures.Domain.Models.Booking()
                      {
                          // Dexter Monkey Book in Killua shop
                          Id = Guid.Parse("570e7d88-bee7-4392-8dc0-881ddb81630b"),
                          UserId = Guid.Parse("F7996510-5551-45F8-9E56-6E820747443A"),
                          ShopId = Guid.Parse("6378E6DD-84F2-41C7-9C46-ED4FF19F68B8"),
                          UserName = "Dexter Monkey costumer",
                          Address = "St Isabel,Dinalupihan,Bataan",
                          ContactNumber = "1234566789",
                          DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                          AdditionalDescription = "sira ang laptop ko sir parefair po",
                          TimeStamps = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,

                          CreatedAt = DateTime.UtcNow,
                          ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                          PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                      });

                this._context.Bookings.Add(
                   new Infrastructures.Domain.Models.Booking()
                   {
                       // Chimera Ant Book in Killua shop
                       Id = Guid.Parse("55b310a7-fa69-4d3b-99fe-ca46695247b4"),
                       UserId = Guid.Parse("A861F572-72BA-46A5-A820-02FDABC8772D"),
                       ShopId = Guid.Parse("6378E6DD-84F2-41C7-9C46-ED4FF19F68B8"),
                       UserName = "Chimera Ant costumer",
                       Address = "St Isabel,Dinalupihan,Bataan",
                       ContactNumber = "1234566789",
                       DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                       AdditionalDescription = "sira ang laptop ko sir parefair po",
                       TimeStamps = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,

                       CreatedAt = DateTime.UtcNow,
                       ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                       PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                   });

                this._context.Bookings.Add(
                  new Infrastructures.Domain.Models.Booking()
                  {
                      //Rimeru Slime Book in Killua shop
                      Id = Guid.Parse("eba7da2c-a39e-49e8-8b91-f9b94081772a"),
                      UserId = Guid.Parse("A27F0531-4041-49AB-9ED5-90E4C19025F4"),
                      ShopId = Guid.Parse("6378E6DD-84F2-41C7-9C46-ED4FF19F68B8"),
                      UserName = "Rimeru Slime costumer",
                      Address = "St Isabel,Dinalupihan,Bataan",
                      ContactNumber = "1234566789",
                      DateAndTime = DateTime.Parse("12/7/2019 5:39 PM"),
                      AdditionalDescription = "sira ang laptop ko sir parefair po",
                      TimeStamps = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,

                      CreatedAt = DateTime.UtcNow,
                      ReserveStatus = Infrastructures.Domain.Enums.ReserveStatus.Pending,
                      PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid


                  });

            }
            #endregion

            #region Services

            if (this._context.Services.Count() < 1)
            {
                //Android Phone

                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {
                      
                            Name = "Battery Replacement",
                            Description = "Replacing battery for you mobile phone",
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("b7003ea2-c2e4-48a5-b532-77b46e068a1e"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone
                        });

                this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {

                         Name = "Buttons not working to phone",
                         Description = "Repair the buttons of phone",
                         IsPublished = true,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("55e81c32-1023-4fbe-962e-1c5191f15032"),
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone
                     });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "Charge Port Damage",
                      Description = "Repair the charge port of phone",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("8ebf118e-7f9a-4fe0-aac1-9a24be513a8d"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone
                  });

                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {
                            Name = "Charge Port Replacement",
                            Description = "Repair and replace the charge port of phone",
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("230925be-0eba-4835-94c4-afc9142d006e"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone
                        });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {
                          Name = "Data Recovery",
                          Description = "Recover deleted files from the device that is in good working order, Drives that require advanced recovery methods for a formatted or failing drive - costumer is subject to additional costs based on individual circumstances",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("6c86c6fc-3265-4686-be8b-8e690924fa2d"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone

                      });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "LCD Digitizer Replacement",
                       Description = "Replacing the LCD of device or desktop",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("30ecfc3e-b75e-440f-b7a9-ff22d9f47aeb"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone
                   });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "LCD Replacement",
                       Description = "Replace a new chip of LCD for your devices.",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("86d7e134-1f97-46de-8eb2-373b954dc8b1"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone
                   });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {

                     Name = "Software Update",
                     Description = "Update your software in android-phone",
                     IsPublished = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("E6B664A5-8416-4B27-BAD2-47830906351C"),
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone,

                 });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Speaker Repair",
                        Description = "Repair the speaker of Android-Phone",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("8dad3b42-82fd-4854-97ff-d8ad48134603"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone,

                    });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Touch Screen Repair",
                        Description = "Repair the screen of phone",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("2130b49f-0e51-4da7-8dbe-d805a2a936ce"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone,

                    });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Tune Ups",
                        Description = "Tune Ups the Android-phone",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("a3822d7c-53db-4fc0-852b-abd477502e75"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone,

                    });


                this._context.Services.Add(
               new Infrastructures.Domain.Models.Service()
               {

                   Name = "Unlock",
                   Description = "Unlocking the Android-phone",
                   IsPublished = true,
                   CreatedAt = DateTime.UtcNow,
                   UpdatedAt = DateTime.UtcNow,
                   Id = Guid.Parse("c58c03ba-7143-4f2a-b248-55caaf4f9571"),
                   ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone

               });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {

                    Name = "Virus Removal",
                    Description = "Remove the virus in Android-phone",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("df3a272f-f168-423a-9672-543621a301d2"),
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidPhone,

                });


                // Android Tablet 
                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {

                            Name = "Battery Replacement",
                            Description = "Replacing battery for you mobile tablet",
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("291615F4-122D-461B-A8ED-76E6A5A99BA3"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet
                        });

                this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {

                         Name = "Buttons not working to tablet",
                         Description = "Repair the buttons of tablet",
                         IsPublished = true,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("62F98A00-96A6-44DE-BF65-FFA3B0E0D471"),
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet
                     });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "Charge Port Damage",
                      Description = "Repair the charge port of phone",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("7888321F-F8FD-4A8E-99E3-F9E166A64AA1"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet
                  });

                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {
                            Name = "Charge Port Replacement",
                            Description = "Repair and replace the charge port of tablet",
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("430057C7-F73B-4938-9050-25B36EDFC3E8"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet
                        });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {
                          Name = "Data Recovery",
                          Description = "Recover deleted files from the device that is in good working order, Drives that require advanced recovery methods for a formatted or failing drive - costumer is subject to additional costs based on individual circumstances",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("D4E66518-337F-4671-888D-A325CEE864FB"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet

                      });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "LCD Digitizer Replacement",
                       Description = "Replacing the LCD of tablet",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("ADA798B7-7270-46ED-B511-836E3DC881E5"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet
                   });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "LCD Replacement",
                       Description = "Replace a new chip of LCD for your tablet.",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("14FD5426-9C0B-4A17-BED7-70737D6425BA"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet
                   });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {

                     Name = "Software Update",
                     Description = "Update your software in tablet",
                     IsPublished = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("4C62D24F-49FE-4FA6-9942-00965E6B7DA2"),
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet,

                 });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Speaker Repair",
                        Description = "Repair the speaker of tablet",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("1F0A1803-109A-49E7-A9A1-3F91F1981939"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet,

                    });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Touch Screen Repair",
                        Description = "Repair the screen of tablet",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("9F756253-5C44-4E96-8A9A-F088BDC0DCE8"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet,

                    });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Tune Ups",
                        Description = "Tune Ups the Android-tablet",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("0DF60396-5CA5-4737-83F3-F89262EA8518"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet,

                    });


                this._context.Services.Add(
               new Infrastructures.Domain.Models.Service()
               {

                   Name = "Unlock",
                   Description = "Unlocking the Android-tablet",
                   IsPublished = true,
                   CreatedAt = DateTime.UtcNow,
                   UpdatedAt = DateTime.UtcNow,
                   Id = Guid.Parse("2D712862-F95A-43DA-8583-92EEAA299469"),
                   ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet

               });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {

                    Name = "Virus Removal",
                    Description = "Remove the virus in Android-tablet",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("8F34D06D-EF87-4D10-9597-46155999C87C"),
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.AndroidTablet,

                });

                // Iphone 
                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {

                            Name = "Corrupted Device",
                            Description = "Repair your device",
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("ED5E6FFF-A45E-4330-8761-554E72A63A1C"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone
                        });

                this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {

                         Name = "Buttons not working to iphone",
                         Description = "Repair the buttons of Iphone",
                         IsPublished = true,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("C525F543-5028-4DEF-B300-FF3A1169620E"),
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone
                     });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "Charge Port Damage",
                      Description = "Repair the charge port of Iphone",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("5B4A01EA-3728-4E09-BCCC-82F300AF9D7A"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone
                  });

                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {
                            Name = "Charge Port Replacement",
                            Description = "Repair and replace the charge port of Iphone",
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("744F4730-6D6E-4FAB-A725-D426950C9C4B"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone
                        });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {
                          Name = "Data Recovery",
                          Description = "Recover deleted files from the device that is in good working order, Drives that require advanced recovery methods for a formatted or failing drive - costumer is subject to additional costs based on individual circumstances",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("9b0d9ba8-e11d-490d-9e4b-5bb0ae58cc8d"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone

                      });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "LCD Digitizer Replacement",
                       Description = "Replacing the LCD of Iphone",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("215F4D0C-96B0-49A6-9405-A99A2F60F5E3"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone
                   });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "LCD Replacement",
                       Description = "Replace a new chip of LCD for your Iphone.",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("22E383CE-035F-4109-AD19-9F4540272DEF"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone
                   });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {

                     Name = "Software Update",
                     Description = "Update your software in Iphone",
                     IsPublished = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("A4160560-3FF4-40E5-B454-33D55D6680C0"),
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone,

                 });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Speaker Repair",
                        Description = "Repair the speaker of Iphone",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("0B925A40-ACD9-4EC1-A928-BB4F4C0751E8"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone,

                    });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Touch Screen Repair",
                        Description = "Repair the screen of Iphone",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("64588D4C-1530-48C6-B700-CEECBD6C7279"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone,

                    });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Tune Ups",
                        Description = "Tune Ups the Iphone",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("315B329A-B36D-40F5-9856-5F6BDEEC8CE7"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone,

                    });


                this._context.Services.Add(
               new Infrastructures.Domain.Models.Service()
               {

                   Name = "Unlock",
                   Description = "Unlocking the Iphone",
                   IsPublished = true,
                   CreatedAt = DateTime.UtcNow,
                   UpdatedAt = DateTime.UtcNow,
                   Id = Guid.Parse("420A0003-B5EF-482E-9833-8AABE63C1163"),
                   ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone

               });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {

                    Name = "Virus Removal",
                    Description = "Remove the virus in Iphone",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("E1CD6C7F-A018-4EB6-8707-51C8D2A6FC97"),
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.IPhone,

                });

                // Ipad 
                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {

                            Name = "Corrupted Device",
                            Description = "Repair your device",
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("696915E6-3E33-4574-A0AF-5801856A6D6E"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad
                        });

                this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {

                         Name = "Buttons not working to Ipad",
                         Description = "Repair the buttons of Ipad",
                         IsPublished = true,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("0A273FFF-2DEF-40CB-A035-D9F66A9C7408"),
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad
                     });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "Charge Port Damage",
                      Description = "Repair the charge port of Ipad",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("404F9A52-FB46-408A-8319-D15ABE89C6D1"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad
                  });

                this._context.Services.Add(
                        new Infrastructures.Domain.Models.Service()
                        {
                            Name = "Charge Port Replacement",
                            Description = "Repair and replace the charge port of Ipad",
                            IsPublished = true,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                            Id = Guid.Parse("7F3FBBE2-C9C2-4946-A5BC-D046BD5521AE"),
                            ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad
                        });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {
                          Name = "Data Recovery",
                          Description = "Recover deleted files from the device that is in good working order, Drives that require advanced recovery methods for a formatted or failing drive - costumer is subject to additional costs based on individual circumstances",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("DF5DA201-A1A7-44F4-8740-A8F32C71B6AB"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad

                      });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "LCD Digitizer Replacement",
                       Description = "Replacing the LCD of Ipad",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("DBD94154-89D0-44C2-B8B1-E84ACBD68AA6"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad
                   });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "LCD Replacement",
                       Description = "Replace a new chip of LCD for your Ipad.",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("24CB3D2E-A514-4504-8BBF-6165896AC8C1"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad
                   });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {

                     Name = "Software Update",
                     Description = "Update your software in Ipad",
                     IsPublished = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("83A12D5C-BE66-49DF-A955-C37B6106D041"),
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad,

                 });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Speaker Repair",
                        Description = "Repair the speaker of Ipad",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("1364A5DD-E43D-430D-B9FE-5D6F25D7122E"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad,

                    });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Touch Screen Repair",
                        Description = "Repair the screen of Ipad",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("3B161C60-6499-4563-AB05-E506C6AC4B5B"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad,

                    });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Tune Ups",
                        Description = "Tune Ups the Ipad",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("CC66F692-665E-4E65-B2A7-75BF45DCAFD4"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad,

                    });


                this._context.Services.Add(
               new Infrastructures.Domain.Models.Service()
               {

                   Name = "Unlock",
                   Description = "Unlocking the Ipad",
                   IsPublished = true,
                   CreatedAt = DateTime.UtcNow,
                   UpdatedAt = DateTime.UtcNow,
                   Id = Guid.Parse("1ACEBE3E-3F58-4E57-9C0B-3BACB9A4E6C7"),
                   ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad

               });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {

                    Name = "Virus Removal",
                    Description = "Remove the virus in Ipad",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("13EC0288-1A8B-48B1-A1C4-3E5292AE509B"),
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.IPad,

                });


                //Desktop
                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                      Name = "Computer Setup",
                      Description = "Computer Setup, Install Anti-Virus, Perform system updates, Remove unwanted programs and trial ware, Create User Accounts, Clean exterior of device, Create Recovery Disk",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("7d0bcd40-361d-4253-bb38-a84fdee5c4de"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                  });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {

                          Name = "Diagnostic",
                          Description = "Full System, Hardware, Internet Performance, Sound or Webcam problem, Slow performance,lockups and freezing, Unexpected System Restart,",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("95d2c689-3939-4a89-b8a8-f9a45ed60e94"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                      });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {

                          Name = "Hard Drive Recovery",
                          Description = "Recover all the data that deleted or corrupted in hard drive",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("f3ca5a8a-1e45-4bf0-890d-aebe548d7e0b"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                      });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {

                          Name = "Upgrade Hard Drive 2GB",
                          Description = "Upgrading device or gadgets to make a good performance",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("3f5c5f58-a147-47a1-b56b-1323c9885457"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                      });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {
                        Name = "Upgrade Hard Drive 4GB",
                        Description = "Upgrading device or gadgets to make a good performance",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("B309468D-2B1D-4B73-BC6F-49DC4B56CEDC"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                    });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {
                   
                        Name = "Upgrade Hard Drive 8GB",
                        Description = "Upgrading device or gadgets to make a good performance",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("8A48AD31-1F89-4F52-98A4-78DB374FF4DB"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                    });

                this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {
                  
                         Name = "Upgrade Hard Drive 16GB",
                         Description = "Upgrading device or gadgets to make a good performance",
                         IsPublished = true,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("D62225E5-251C-4DF7-BF71-C9A2E58837D3"),
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                     });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                      Name = "Upgrade Hard Drive 32GB",
                      Description = "Upgrading device or gadgets to make a good performance",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("00DFEEBB-0A12-4186-8E00-AA36708A8F39"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                  });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {
                  
                        Name = "Upgrade Hard Drive 64GB",
                        Description = "Upgrading device or gadgets to make a good performance",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("D818071C-3A73-4429-A93F-8A6FC5105C31"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                    });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                   
                      Name = "Upgrade Hard Drive 128GB",
                      Description = "Upgrading device or gadgets to make a good performance",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("171C53DB-6957-4A1A-826D-D55418F53357"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                  });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
               
                      Name = "Upgrade Hard Drive 256GB",
                      Description = "Upgrading device or gadgets to make a good performance",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("87317D78-FBC7-4BA5-988F-09A46032606A"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                  });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Keyboard Replacement",
                        Description = "Replace the old keyboard to new keyboard.",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("4555eab0-6bd3-412e-8180-f281bc88e7df"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

                    });

                 this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {

                         Name = "Operating System Upgrade Window 7 w/ licence",
                         Description = "Upgrade your OS into window 7 licence",
                         IsPublished = true,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("e432471e-6b9f-4e7c-b7cb-2e9d362999ae"),
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                     });


                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Operating System Upgrade Window 7 w/o licence",
                        Description = "Upgrade your OS into window 7 no licence",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("321693E2-4FEC-4822-B84A-4F463F051724"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                    });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "Operating System Upgrade Window 8 w/ licence",
                       Description = "Upgrade your OS into window 8 licence",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,    
                       Id = Guid.Parse("3679C0E5-5A16-40BC-AA79-8C2E64DFECA0"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                   });


                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Operating System Upgrade Window 8 w/o licence",
                        Description = "Upgrade your OS into window 8 no licence",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("A012D114-A5AE-443E-9CFF-0E468CBEA682"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                    });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
              
                      Name = "Operating System Upgrade Window 10 w/ licence",
                      Description = "Upgrade your OS into window 10 licence",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("D6CD71E5-6EA1-4E54-98E6-45FDEC4F37DD"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                  });


                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {
                  
                        Name = "Operating System Upgrade Window 10 w/o licence",
                        Description = "Upgrade your OS into window 10 no licence",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("9D1D5AD8-99E9-4B14-BAC6-1FE0BA230F2F"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                    });


                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "2GB RAM Upgrades",
                        Description = "Upgrade the RAM to 2000 Mega Bytes.",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("cf0c2c3a-9e10-4f31-beb1-ea6266509ff8"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                    });


                 this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "4GB RAM Upgrades",
                        Description = "Upgrade the RAM to 4000 Mega Bytes.",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("11FD383C-692A-4707-8BFF-7EBDC489BD68"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                    });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "8GB RAM Upgrades",
                      Description = "Upgrade the RAM to 8000 Mega Bytes.",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("A900AC64-1073-4460-8D5D-4D2EC94EEC24"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                  });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {

                    Name = "16GB RAM Upgrades",
                    Description = "Upgrade the RAM to 16000 Mega Bytes.",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("AF3E3797-AB8B-4829-9711-F3B929623619"),
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {

                     Name = "32GB RAM Upgrades",
                     Description = "Upgrade the RAM to 32000 Mega Bytes.",
                     IsPublished = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("19EF05A4-50BF-47ED-88E4-719188DB8055"),
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                 });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {

                    Name = "64GB RAM Upgrades",
                    Description = "Upgrade the RAM to 32000 Mega Bytes.",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("8919E47C-E22A-4C0B-B5D3-5D283F384D66"),
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                });


                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "128GB RAM Upgrades",
                      Description = "Upgrade the RAM to 32000 Mega Bytes.",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("9495B46F-53AE-48CE-8FDD-727FF7F92516"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                  });

                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "Software Update",
                       Description = "Update your software in desktop",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("55cfd14a-3d0a-4d7d-ba4c-04aa11fc982b"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                   });

                this._context.Services.Add(
               new Infrastructures.Domain.Models.Service()
               {

                   Name = "Unlock",
                   Description = "Unlocking the desktop",
                   IsPublished = true,
                   CreatedAt = DateTime.UtcNow,
                   UpdatedAt = DateTime.UtcNow,
                   Id = Guid.Parse("19CD1235-EF54-4511-B810-9C51B12980FA"),
                   ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop

               });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {

                     Name = "Virus Removal",
                     Description = "Remove the virus in Desktop",
                     IsPublished = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("d9064865-c047-4ee2-8a74-b8cea00166cd"),
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Desktop,

                 });



                //Laptop
                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                      Name = "Laptop Setup",
                      Description = "Laptop Setup, Install Anti-Virus, Perform system updates, Remove unwanted programs and trial ware, Create User Accounts, Clean exterior of device, Create Recovery Disk",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("01a41cd0-0214-4de5-994f-58359dad745f"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                  });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {

                          Name = "Diagnostic",
                          Description = "Full System, Hardware, Internet Performance, Sound or Webcam problem, Slow performance,lockups and freezing, Unexpected System Restart,",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("9de94ef1-ae55-4a1f-9c1e-1595860c30fd"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                      });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {

                          Name = "Hard Drive Recovery",
                          Description = "Recover all the data that deleted or corrupted in hard drive",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("0dd22310-543c-47ac-b5c5-dbd888f004a5"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                      });

                this._context.Services.Add(
                      new Infrastructures.Domain.Models.Service()
                      {

                          Name = "Upgrade Hard Drive 2GB",
                          Description = "Upgrading laptop to make a good performance",
                          IsPublished = true,
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Id = Guid.Parse("DD575A87-D723-449C-AEBA-79A5944B819E"),
                          ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                      });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {
                        Name = "Upgrade Hard Drive 4GB",
                        Description = "Upgrading laptop to make a good performance",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("8CAB2B5E-06D2-4402-B1C3-80159AFA0704"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                    });



                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Upgrade Hard Drive 8GB",
                        Description = "Upgrading laptop to make a good performance",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("4F1B4DC6-78C0-4588-B546-7853FC8D3472"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                    });

                this._context.Services.Add(
                     new Infrastructures.Domain.Models.Service()
                     {

                         Name = "Upgrade Hard Drive 16GB",
                         Description = "Upgrading laptop to make a good performance",
                         IsPublished = true,
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                         Id = Guid.Parse("33ED0039-4C3F-464F-BD0C-BB683DF8B2DF"),
                         ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                     });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {
                      Name = "Upgrade Hard Drive 32GB",
                      Description = "Upgrading laptop to make a good performance",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("D0280C12-9223-438F-9D19-8011B7480EB8"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                  });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Upgrade Hard Drive 64GB",
                        Description = "Upgrading laptop to make a good performance",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("CD66586A-4116-4E07-A3F0-6A665C0191E0"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                    });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "Upgrade Hard Drive 128GB",
                      Description = "Upgrading laptop to make a good performance",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("F6E7E685-C1B0-424D-8AD3-DE4704952FFF"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                  });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "Upgrade Hard Drive 256GB",
                      Description = "Upgrading laptop to make a good performance",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("7A8A3BF9-00A4-4BB9-A510-857906EEBBEA"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                  });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Keyboard Replacement",
                        Description = "Replace the old keyboard to new keyboard.",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("2AA2B5BB-B88D-4A82-AF00-4C07B4868C21"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

                    });

                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Operating System Upgrade Window 7 w/ licence",
                        Description = "Upgrade your OS into window 7 licence",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("3859735B-4B72-4954-B79E-9F74F039ECF1"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                    });


                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Operating System Upgrade Window 7 w/o licence",
                        Description = "Upgrade your OS into window 7 no licence",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("AC78D6F4-1B5A-41BE-9FA2-2EAA2FBE9223"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                    });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "Operating System Upgrade Window 8 w/ licence",
                       Description = "Upgrade your OS into window 8 licence",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("D70335CF-3993-41E8-BC3D-887D1DB59D6F"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                   });


                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Operating System Upgrade Window 8 w/o licence",
                        Description = "Upgrade your OS into window 8 no licence",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("03FB334C-9515-44A1-84E2-4E03DB9ACD7B"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                    });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "Operating System Upgrade Window 10 w/ licence",
                      Description = "Upgrade your OS into window 10 licence",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("aa26b685-d97a-4613-a19b-cd0d2f1f0b3c"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                  });


                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "Operating System Upgrade Window 10 w/o licence",
                        Description = "Upgrade your OS into window 10 no licence",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("CA671013-1C0C-4F49-A62F-701A313E3C93"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                    });


                this._context.Services.Add(
                    new Infrastructures.Domain.Models.Service()
                    {

                        Name = "2GB RAM Upgrades",
                        Description = "Upgrade the RAM to 2000 Mega Bytes.",
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Id = Guid.Parse("B9433245-759A-4C86-B07A-E2D70A4017D5"),
                        ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                    });


                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "4GB RAM Upgrades",
                       Description = "Upgrade the RAM to 4000 Mega Bytes.",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("43CCDCFB-48A4-4852-9C12-8E323378F78B"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                   });

                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "8GB RAM Upgrades",
                      Description = "Upgrade the RAM to 8000 Mega Bytes.",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("21753ECC-1D31-4A0E-A8EA-889BEA9B8BFD"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                  });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {

                    Name = "16GB RAM Upgrades",
                    Description = "Upgrade the RAM to 16000 Mega Bytes.",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("C2C8BDB4-D4B9-4454-8919-8AE08BB6412C"),
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {

                     Name = "32GB RAM Upgrades",
                     Description = "Upgrade the RAM to 32000 Mega Bytes.",
                     IsPublished = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("706B3E07-3368-49CB-84E1-D84ED9251DA7"),
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                 });

                this._context.Services.Add(
                new Infrastructures.Domain.Models.Service()
                {

                    Name = "64GB RAM Upgrades",
                    Description = "Upgrade the RAM to 32000 Mega Bytes.",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Id = Guid.Parse("BE120BB9-5C4A-4DB6-8911-672C643809B4"),
                    ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                });


                this._context.Services.Add(
                  new Infrastructures.Domain.Models.Service()
                  {

                      Name = "128GB RAM Upgrades",
                      Description = "Upgrade the RAM to 32000 Mega Bytes.",
                      IsPublished = true,
                      CreatedAt = DateTime.UtcNow,
                      UpdatedAt = DateTime.UtcNow,
                      Id = Guid.Parse("8F984358-E8C5-4737-9E0A-0E81ADB709E2"),
                      ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                  });

                this._context.Services.Add(
                   new Infrastructures.Domain.Models.Service()
                   {

                       Name = "Software Update",
                       Description = "Update your software in Laptop",
                       IsPublished = true,
                       CreatedAt = DateTime.UtcNow,
                       UpdatedAt = DateTime.UtcNow,
                       Id = Guid.Parse("ACDFE8EB-0BD6-489C-981C-C71121EC25CA"),
                       ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                   });

                this._context.Services.Add(
               new Infrastructures.Domain.Models.Service()
               {

                   Name = "Unlock",
                   Description = "Unlocking the Laptop",
                   IsPublished = true,
                   CreatedAt = DateTime.UtcNow,
                   UpdatedAt = DateTime.UtcNow,
                   Id = Guid.Parse("2D377AD7-9B83-4587-9887-D4F046C6FE92"),
                   ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop

               });

                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {

                     Name = "Virus Removal",
                     Description = "Remove the virus in Laptop",
                     IsPublished = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("A72E9354-36B3-4EF5-81A2-4B3E31A5DEA3"),
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Laptop,

                 });


                //Printer
                this._context.Services.Add(
                 new Infrastructures.Domain.Models.Service()
                 {

                     Name = "Liquid Damage",
                     Description = "Cleaning the liquid damage, and replace a new.",
                     IsPublished = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Id = Guid.Parse("8b0f2cc3-26db-4018-9b2f-bd05c26c4f95"),
                     ServiceType = Infrastructures.Domain.Enums.ServiceType.Printer
                 });

            }


            #endregion

            #region ShopServices
            if (this._context.ShopServices.Count() < 1)
            {
                // 3 Desktop Shop-Services Goshen Jimenez

                this._context.ShopServices.Add(
                        new Infrastructures.Domain.Models.ShopService()
                        {

                            Id = Guid.Parse("57ddda4d-c523-4a97-9bf9-5fffdba17ac5"),
                            ServiceId = Guid.Parse("7d0bcd40-361d-4253-bb38-a84fdee5c4de"),
                            ShopId = Guid.Parse("3c29d5fd-269b-419e-9313-22c891116137"),
                            Price = 20,
                            Service = "Computer Setup",
                            Description = "Computer Setup, Install Anti-Virus, Perform system updates, Remove unwanted programs and trial ware, Create User Accounts, Clean exterior of device, Create Recovery Disk",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,                            
                        });

                this._context.ShopServices.Add(
                        new Infrastructures.Domain.Models.ShopService()
                        {

                            Id = Guid.Parse("f86c0d2c-bed5-41e9-8f31-74c698c50153"),
                            ServiceId = Guid.Parse("95d2c689-3939-4a89-b8a8-f9a45ed60e94"),
                            ShopId = Guid.Parse("3c29d5fd-269b-419e-9313-22c891116137"),
                            Price = 20,
                            Service = "Diagnostic",
                            Description = "Full System, Hardware, Internet Performance, Sound or Webcam problem, Slow performance,lockups and freezing, Unexpected System Restart,",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                        });


                this._context.ShopServices.Add(
                        new Infrastructures.Domain.Models.ShopService()
                        {

                            Id = Guid.Parse("1c6e19ea-956a-490a-b012-83fb6bddf68b"),
                            ServiceId = Guid.Parse("f3ca5a8a-1e45-4bf0-890d-aebe548d7e0b"),
                            ShopId = Guid.Parse("3c29d5fd-269b-419e-9313-22c891116137"),
                            Price = 20,
                            Service = "Hard Drive Recovery",
                            Description = "Recover all the data that deleted or corrupted in hard drive",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,
                        });

                // 3 Desktop Shop-Services Jane Ticar

                this._context.ShopServices.Add(
                       new Infrastructures.Domain.Models.ShopService()
                       {

                           Id = Guid.Parse("f69644ba-e8e7-43d9-b5f6-ad7623960e9d"),
                           ServiceId = Guid.Parse("3f5c5f58-a147-47a1-b56b-1323c9885457"),
                           ShopId = Guid.Parse("de01e8e4-3131-47fb-97f9-055f0cf1c703"),
                           Price = 20,
                           Service = "Upgrade Hard Drive 2GB",
                           Description = "Upgrading device or gadgets to make a good performance",
                           CreatedAt = DateTime.UtcNow,
                           UpdatedAt = DateTime.UtcNow,
                       });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("3e8ababa-98bf-4779-9baa-62ec0b057e5d"),
                        ServiceId = Guid.Parse("B309468D-2B1D-4B73-BC6F-49DC4B56CEDC"),
                        ShopId = Guid.Parse("de01e8e4-3131-47fb-97f9-055f0cf1c703"),
                        Price = 20,
                        Service = "Upgrade Hard Drive 4GB",
                        Description = "Upgrading device or gadgets to make a good performance",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("e8afd5d2-0559-441c-ad50-9a4b846948ef"),
                        ServiceId = Guid.Parse("8A48AD31-1F89-4F52-98A4-78DB374FF4DB"),
                        ShopId = Guid.Parse("de01e8e4-3131-47fb-97f9-055f0cf1c703"),
                        Price = 20,
                        Service = "Upgrade Hard Drive 8GB",
                        Description = "Upgrading device or gadgets to make a good performance",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });
                // 3 Desktop Shop-Services Jake Renzo
                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("2009cd07-fa19-4392-aad6-9f3426718956"),
                        ServiceId = Guid.Parse("7d0bcd40-361d-4253-bb38-a84fdee5c4de"),
                        ShopId = Guid.Parse("ef17b261-6a9a-4a02-a8dd-1c0f406609dc"),
                        Price = 20,
                        Service = "Computer Setup",
                        Description = "Computer Setup, Install Anti-Virus, Perform system updates, Remove unwanted programs and trial ware, Create User Accounts, Clean exterior of device, Create Recovery Disk",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                 new Infrastructures.Domain.Models.ShopService()
                 {

                     Id = Guid.Parse("a571a67d-5d8a-4588-970c-164d4f6f5587"),
                     ServiceId = Guid.Parse("95d2c689-3939-4a89-b8a8-f9a45ed60e94"),
                     ShopId = Guid.Parse("ef17b261-6a9a-4a02-a8dd-1c0f406609dc"),
                     Price = 20,
                     Service = "Diagnostic",
                     Description = "Full System, Hardware, Internet Performance, Sound or Webcam problem, Slow performance,lockups and freezing, Unexpected System Restart,",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                 });

                this._context.ShopServices.Add(
                 new Infrastructures.Domain.Models.ShopService()
                 {

                     Id = Guid.Parse("fc37a228-e3f6-45c9-87ba-1b766598793a"),
                     ServiceId = Guid.Parse("f3ca5a8a-1e45-4bf0-890d-aebe548d7e0b"),
                     ShopId = Guid.Parse("ef17b261-6a9a-4a02-a8dd-1c0f406609dc"),
                     Price = 20,
                     Service = "Hard Drive Recovery",
                     Description = "Recover all the data that deleted or corrupted in hard drive",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                 });


                // 3 Laptop Shop-Services Eren Jaeger
                this._context.ShopServices.Add(
                 new Infrastructures.Domain.Models.ShopService()
                 {

                     Id = Guid.Parse("6d0aaa1d-9491-42a9-87ce-2e8ca64be7cf"),
                     ServiceId = Guid.Parse("33ED0039-4C3F-464F-BD0C-BB683DF8B2DF"),
                     ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                     Price = 20,
                     Service = "Upgrade Hard Drive 16GB",
                     Description = "Upgrading laptop to make a good performance",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                 });

                this._context.ShopServices.Add(
                new Infrastructures.Domain.Models.ShopService()
                {

                    Id = Guid.Parse("7f23f480-f52e-47ec-bb5c-0b13563df35b"),
                    ServiceId = Guid.Parse("D0280C12-9223-438F-9D19-8011B7480EB8"),
                    ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                    Price = 20,
                    Service = "Upgrade Hard Drive 32GB",
                    Description = "Upgrading laptop to make a good performance",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                });

                this._context.ShopServices.Add(
                new Infrastructures.Domain.Models.ShopService()
                {

                    Id = Guid.Parse("284414c8-d3ea-44ce-b15c-9aff3d8b9b3a"),
                    ServiceId = Guid.Parse("CD66586A-4116-4E07-A3F0-6A665C0191E0"),
                    ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                    Price = 20,
                    Service = "Upgrade Hard Drive 64GB",
                    Description = "Upgrading laptop to make a good performance",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                });

                // 3 Laptop Shop-Services Mikasa Ackerman
                this._context.ShopServices.Add(
                new Infrastructures.Domain.Models.ShopService()
                {

                    Id = Guid.Parse("8f34488c-d096-4930-a980-b258220941f4"),
                    ServiceId = Guid.Parse("F6E7E685-C1B0-424D-8AD3-DE4704952FFF"),
                    ShopId = Guid.Parse("9966c022-2237-4506-88ce-5ac68844c70f"),
                    Price = 20,
                    Service = "Upgrade Hard Drive 128GB",
                    Description = "Upgrading laptop to make a good performance",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                });

                    this._context.ShopServices.Add(
                 new Infrastructures.Domain.Models.ShopService()
                 {

                     Id = Guid.Parse("9ceed031-1b58-433a-9183-8cc10fc8ae7b"),
                     ServiceId = Guid.Parse("7A8A3BF9-00A4-4BB9-A510-857906EEBBEA"),
                     ShopId = Guid.Parse("9966c022-2237-4506-88ce-5ac68844c70f"),
                     Price = 20,
                     Service = "Upgrade Hard Drive 256GB",
                     Description = "Upgrading laptop to make a good performance",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                 });

                    this._context.ShopServices.Add(
                 new Infrastructures.Domain.Models.ShopService()
                 {

                     Id = Guid.Parse("cde4cf1d-8971-4579-bd6d-d9344baca0fb"),
                     ServiceId = Guid.Parse("2AA2B5BB-B88D-4A82-AF00-4C07B4868C21"),
                     ShopId = Guid.Parse("9966c022-2237-4506-88ce-5ac68844c70f"),
                     Price = 20,
                     Service = "Keyboard Replacement",
                     Description = "Replace the old keyboard to new keyboard.",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                 });


                // 3 Laptop Shop-Services Zoro Hunter
                    this._context.ShopServices.Add(
                     new Infrastructures.Domain.Models.ShopService()
                     {

                         Id = Guid.Parse("6983e7ef-ea99-4787-85ae-e0da49861668"),
                         ServiceId = Guid.Parse("33ED0039-4C3F-464F-BD0C-BB683DF8B2DF"),
                         ShopId = Guid.Parse("0413b680-91ca-49f0-8485-0af0ec711593"),
                         Price = 20,
                         Service = "Upgrade Hard Drive 16GB",
                         Description = "Upgrading laptop to make a good performance",
                         CreatedAt = DateTime.UtcNow,
                         UpdatedAt = DateTime.UtcNow,
                     });

                    this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("b3cf0e1f-92c5-4d3a-aa56-00df3eebb900"),
                        ServiceId = Guid.Parse("D0280C12-9223-438F-9D19-8011B7480EB8"),
                        ShopId = Guid.Parse("0413b680-91ca-49f0-8485-0af0ec711593"),
                        Price = 20,
                        Service = "Upgrade Hard Drive 32GB",
                        Description = "Upgrading laptop to make a good performance",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                    this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("83d6c35c-df1b-426d-9b91-6a8f61ae6c09"),
                        ServiceId = Guid.Parse("CD66586A-4116-4E07-A3F0-6A665C0191E0"),
                        ShopId = Guid.Parse("0413b680-91ca-49f0-8485-0af0ec711593"),
                        Price = 20,
                        Service = "Upgrade Hard Drive 64GB",
                        Description = "Upgrading laptop to make a good performance",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                // 6 Cellphone Shop-Services Luffy Monkey
                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("47ff2b56-1c53-491e-928a-04e85ff21f1c"),
                        ServiceId = Guid.Parse("CC66F692-665E-4E65-B2A7-75BF45DCAFD4"),
                        ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                        Price = 20,
                        Service = "Tune Ups",
                        Description = "Tune Ups the Ipad",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("059a648b-85b3-4750-87ab-bcf395a71090"),
                        ServiceId = Guid.Parse("1ACEBE3E-3F58-4E57-9C0B-3BACB9A4E6C7"),
                        ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                        Price = 20,
                        Service = "Unlock",
                        Description = "Unlocking the Ipad",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("829d622e-bdd3-46c9-998a-77be1348d485"),
                        ServiceId = Guid.Parse("A4160560-3FF4-40E5-B454-33D55D6680C0"),
                        ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                        Price = 20,
                        Service = "Software Update",
                        Description = "Update your software in Iphone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("9f8f3a97-a0df-4476-abf7-19ee8582127f"),
                        ServiceId = Guid.Parse("0B925A40-ACD9-4EC1-A928-BB4F4C0751E8"),
                        ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                        Price = 20,
                        Service = "Speaker Repair",
                        Description = "Repair the speaker of Iphone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("4e6b4745-769f-4d24-aa26-8f4cc9feee67"),
                        ServiceId = Guid.Parse("6c86c6fc-3265-4686-be8b-8e690924fa2d"),
                        ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                        Price = 20,
                        Service = "Data Recovery",
                        Description = "Recover deleted files from the device that is in good working order, Drives that require advanced recovery methods for a formatted or failing drive - costumer is subject to additional costs based on individual circumstances",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("97a4772e-6650-4cb0-82fb-683726a561af"),
                        ServiceId = Guid.Parse("30ecfc3e-b75e-440f-b7a9-ff22d9f47aeb"),
                        ShopId = Guid.Parse("3aee9d0f-9fbe-49b6-97be-4c4901207df6"),
                        Price = 20,
                        Service = "LCD Digitizer Replacement",
                        Description = "Replacing the LCD of AndroidPhone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });



                // 6 Cellphone Shop-Services Levi Ackerman
                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("396c8af7-31ac-4337-a419-906bcc6fabb7"),
                        ServiceId = Guid.Parse("CC66F692-665E-4E65-B2A7-75BF45DCAFD4"),
                        ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                        Price = 20,
                        Service = "Tune Ups",
                        Description = "Tune Ups the Ipad",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("9ed90cec-8eb3-4d96-8437-03aad488a8da"),
                        ServiceId = Guid.Parse("1ACEBE3E-3F58-4E57-9C0B-3BACB9A4E6C7"),
                        ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                        Price = 20,
                        Service = "Unlock",
                        Description = "Unlocking the Ipad",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("d6a68353-8947-4731-aacb-1027d263aa39"),
                        ServiceId = Guid.Parse("A4160560-3FF4-40E5-B454-33D55D6680C0"),
                        ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                        Price = 20,
                        Service = "Software Update",
                        Description = "Update your software in Iphone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {
                        Id = Guid.Parse("5b7b03d7-017c-49b8-a0b6-0a7e1c9b3dbc"),
                        ServiceId = Guid.Parse("0B925A40-ACD9-4EC1-A928-BB4F4C0751E8"),
                        ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                        Price = 20,
                        Service = "Speaker Repair",
                        Description = "Repair the speaker of Iphone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("7e5ab0d3-c800-4517-93ea-15345c1503d2"),
                        ServiceId = Guid.Parse("6c86c6fc-3265-4686-be8b-8e690924fa2d"),
                        ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                        Price = 20,
                        Service = "Data Recovery",
                        Description = "Recover deleted files from the device that is in good working order, Drives that require advanced recovery methods for a formatted or failing drive - costumer is subject to additional costs based on individual circumstances",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("cdb8e044-a6d6-4388-ba01-cb6a7aa1861a"),
                        ServiceId = Guid.Parse("30ecfc3e-b75e-440f-b7a9-ff22d9f47aeb"),
                        ShopId = Guid.Parse("4d35affc-a369-49fc-a408-56f75d35da9c"),
                        Price = 20,
                        Service = "LCD Digitizer Replacement",
                        Description = "Replacing the LCD of AndroidPhone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });



                // 6 Cellphone Shop-Services Gon Pricks
                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("d243693d-a8ce-4490-a976-740e3da87e3b"),
                        ServiceId = Guid.Parse("CC66F692-665E-4E65-B2A7-75BF45DCAFD4"),
                        ShopId = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                        Price = 20,
                        Service = "Tune Ups",
                        Description = "Tune Ups the Ipad",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("cbf321f0-bbd5-4e70-94da-3ac62c715514"),
                        ServiceId = Guid.Parse("1ACEBE3E-3F58-4E57-9C0B-3BACB9A4E6C7"),
                        ShopId = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                        Price = 20,
                        Service = "Unlock",
                        Description = "Unlocking the Ipad",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("42f5b492-f152-41bb-ab22-332aa1d203e3"),
                        ServiceId = Guid.Parse("A4160560-3FF4-40E5-B454-33D55D6680C0"),
                        ShopId = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                        Price = 20,
                        Service = "Software Update",
                        Description = "Update your software in Iphone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {
                        Id = Guid.Parse("75acfed0-2738-4b10-9dd8-a1b711393947"),
                        ServiceId = Guid.Parse("0B925A40-ACD9-4EC1-A928-BB4F4C0751E8"),
                        ShopId = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                        Price = 20,
                        Service = "Speaker Repair",
                        Description = "Repair the speaker of Iphone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("f4ea50a5-9048-426d-bbf0-0bdc7990358e"),
                        ServiceId = Guid.Parse("6c86c6fc-3265-4686-be8b-8e690924fa2d"),
                        ShopId = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                        Price = 20,
                        Service = "Data Recovery",
                        Description = "Recover deleted files from the device that is in good working order, Drives that require advanced recovery methods for a formatted or failing drive - costumer is subject to additional costs based on individual circumstances",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("5449c825-56ad-4880-82f3-81d55c29ed3b"),
                        ServiceId = Guid.Parse("30ecfc3e-b75e-440f-b7a9-ff22d9f47aeb"),
                        ShopId = Guid.Parse("C6F983F4-A743-4F98-9563-F94A00893F34"),
                        Price = 20,
                        Service = "LCD Digitizer Replacement",
                        Description = "Replacing the LCD of AndroidPhone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });


                //3 Tablet Shop-Services Killu Zoldycks
                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("ebd9cb3f-31ca-4e1a-bdc0-6d296d2117e1"),
                        ServiceId = Guid.Parse("291615F4-122D-461B-A8ED-76E6A5A99BA3"),
                        ShopId = Guid.Parse("6378E6DD-84F2-41C7-9C46-ED4FF19F68B8"),
                        Price = 20,
                        Service = "Battery Replacement",
                        Description = "Replacing battery for you mobile tablet",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("f7746de0-708a-44b6-aab5-4dd46c276fb4"),
                        ServiceId = Guid.Parse("62F98A00-96A6-44DE-BF65-FFA3B0E0D471"),
                        ShopId = Guid.Parse("6378E6DD-84F2-41C7-9C46-ED4FF19F68B8"),
                        Price = 20,
                        Service = "Buttons not working to tablet",
                        Description = "Repair the buttons of tablet",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                this._context.ShopServices.Add(
                    new Infrastructures.Domain.Models.ShopService()
                    {

                        Id = Guid.Parse("2de3130f-65f8-495e-80ea-93fe0bce9c0e"),
                        ServiceId = Guid.Parse("7888321F-F8FD-4A8E-99E3-F9E166A64AA1"),
                        ShopId = Guid.Parse("6378E6DD-84F2-41C7-9C46-ED4FF19F68B8"),
                        Price = 20,
                        Service = "Charge Port Damage",
                        Description = "Repair the charge port of phone",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    });

                //this._context.ShopServices.Add(
                //    new Infrastructures.Domain.Models.ShopService()
                //    {

                //        Id = Guid.Parse(""),
                //        ServiceId = Guid.Parse(""),
                //        ShopId = Guid.Parse(""),
                //        Price = 20,
                //        Service = "",
                //        Description = "",
                //        CreatedAt = DateTime.UtcNow,
                //        UpdatedAt = DateTime.UtcNow,
                //    });

            }
            #endregion

            #region ShopFeedBacks
            if (this._context.FeedBacks.Count() < 1)
            {
                // 3 Feedbacks in  Shop Eren Jaeger

                this._context.FeedBacks.Add(
                        new Infrastructures.Domain.Models.FeedBack()
                        {

                           Id = Guid.Parse("ce3f7c52-7fd1-4b5b-85e8-579ce5e5b411"),
                           ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                           UserId = Guid.Parse("f35af118-8790-4a3f-b37f-25cf1228dc81"),
                           FullName = "Dog Army",
                           Email = "Dog@gmail.com",
                           Comment = "You have a nice services there Bro-bark. its a five star for me.",
                           CreatedAt = DateTime.UtcNow,
                           UpdatedAt = DateTime.UtcNow,
                           Rating = Infrastructures.Domain.Enums.RatingNumber.Five,
                          
                        });

                this._context.FeedBacks.Add(
                      new Infrastructures.Domain.Models.FeedBack()
                      {

                          Id = Guid.Parse("d4ea9701-82a7-4224-8934-81e546b38db3"),
                          ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                          UserId = Guid.Parse("ADBA3390-540F-40F6-A888-FAEFFFEFF92D"),
                          FullName = "Tom Cat",
                          Email = "Tom@gmail.com",
                          Comment = "Thanks meow, good work my gadget is good.",
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Rating = Infrastructures.Domain.Enums.RatingNumber.Five,

                      });

                this._context.FeedBacks.Add(
                      new Infrastructures.Domain.Models.FeedBack()
                      {

                          Id = Guid.Parse("4949de35-0f09-4f8f-9464-3b40d6804374"),
                          ShopId = Guid.Parse("528aeca1-004b-4c28-a52a-bfc6ae23e5f6"),
                          UserId = Guid.Parse("06146021-502D-48EB-9BFD-0C10C855EE42"),
                          FullName = "Jerry Mouse",
                          Email = "Jerry@gmail.com",
                          Comment = "Five stars bro. Thanks for repair",
                          CreatedAt = DateTime.UtcNow,
                          UpdatedAt = DateTime.UtcNow,
                          Rating = Infrastructures.Domain.Enums.RatingNumber.Five,

                      });

            }
            #endregion


            #region Pricing
            if (this._context.Pricings.Count() < 1)
            {
                // Pricing //
                this._context.Pricings.Add(
                    new Infrastructures.Domain.Models.Pricing()
                    {
                        Id = Guid.Parse("e9b18bd6-2d23-406f-9939-d3482409249a"),
                        Title = "Basic",
                        Month = 1,
                        Price = 299,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        
                        
                    });
                // 3 Pricing Content //

                // 1
                this._context.PricingContents.Add(new PricingContent()
                {
                     Id = Guid.Parse("05432ada-a6e5-4e49-a7e2-1e4d2d75885b"),
                     PricingId = Guid.Parse("e9b18bd6-2d23-406f-9939-d3482409249a"),
                     Content = "Create your own shop online",
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,

                });
                // 2
                this._context.PricingContents.Add(new PricingContent()
                {
                    Id = Guid.Parse("b0ee92ca-6c41-448e-8269-448d3c8ebac3"),
                    PricingId = Guid.Parse("e9b18bd6-2d23-406f-9939-d3482409249a"),
                    Content = "Take a limited services we offer for your shop",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                });

                // 3
                this._context.PricingContents.Add(new PricingContent()
                {
                    Id = Guid.Parse("445d7717-92b1-490e-96ab-63ea38160d9b"),
                    PricingId = Guid.Parse("e9b18bd6-2d23-406f-9939-d3482409249a"),
                    Content = "No time-limit for your own shop",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                });


                // Pricing //
                this._context.Pricings.Add(
                new Infrastructures.Domain.Models.Pricing()
                {
                    Id = Guid.Parse("b8ab1d95-8acc-49ed-9cba-337207149b3e"),
                    Title = "Business",
                    Month = 6,
                    Price = 1399,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,


                });

                // 3 Pricing Content //

                // 1
                this._context.PricingContents.Add(new PricingContent()
                {
                    Id = Guid.Parse("96bb0030-0d3b-4404-9cb7-8e9dfe23fd49"),
                    PricingId = Guid.Parse("b8ab1d95-8acc-49ed-9cba-337207149b3e"),
                    Content = "Create your virtual business",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                });

                //2
                this._context.PricingContents.Add(new PricingContent()
                {
                    Id = Guid.Parse("7d142767-11d4-473b-a224-251939cabf4f"),
                    PricingId = Guid.Parse("b8ab1d95-8acc-49ed-9cba-337207149b3e"),
                    Content = "Take a unli service provided by Fixit.PH",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                });


                //3
                this._context.PricingContents.Add(new PricingContent()
                {
                    Id = Guid.Parse("a883b52d-b454-4fa6-8f74-7e29604f9470"),
                    PricingId = Guid.Parse("b8ab1d95-8acc-49ed-9cba-337207149b3e"),
                    Content = "Advertizing your business for 6 months.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                });



                // Pricing //
                this._context.Pricings.Add(
                new Infrastructures.Domain.Models.Pricing()
                {
                    Id = Guid.Parse("43935dca-57e1-4793-824a-92a8626a4dea"),
                    Title = "Pro",
                    Month = 9,
                    Price = 3299,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,


                });

                // 3 Pricing Content //

                // 1
                this._context.PricingContents.Add(new PricingContent()
                {
                    Id = Guid.Parse("c7632014-06f9-48dc-a789-6c23fc0a5d86"),
                    PricingId = Guid.Parse("43935dca-57e1-4793-824a-92a8626a4dea"),
                    Content = "Create your virtual business and advertize by FIxit.PH",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                });

                //2
                this._context.PricingContents.Add(new PricingContent()
                {
                    Id = Guid.Parse("ab99563b-fce2-4b0e-9f9f-02254738cb44"),
                    PricingId = Guid.Parse("43935dca-57e1-4793-824a-92a8626a4dea"),
                    Content = "Create your own services and unli services ",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                });


                //3
                this._context.PricingContents.Add(new PricingContent()
                {
                    Id = Guid.Parse("846c3b4d-c3ac-44f3-af19-fa77333e399a"),
                    PricingId = Guid.Parse("43935dca-57e1-4793-824a-92a8626a4dea"),
                    Content = "Advertizing your business for 9 months.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                });


            }
            #endregion

            #region
            if (this._context.TermAndConditions.Count() < 1)
            {
                // Pricing //
                this._context.TermAndConditions.Add(
                    new Infrastructures.Domain.Models.TermAndCondition()
                    {
                        Id = Guid.Parse("0919fe8a-f05b-4f1f-a0ee-db37664fad38"),
                        Title = "Term and Condition",
                        Description = "TERMS AND CONDITIONS OF USE :"+
                                        " " +
                                        "Welcome to our digital information network." +
                                        "These our terms and conditions for use of the network," +
                                        "which you may access in several ways," +
                                        "including but not limited to the World Wide Web" +
                                        ".Users must always try to advise the shop owners via messaging as soon as possible in accordance of cancellation of appointment." +
                                      " For shop owners the cancellation of appointments must be within 24 hours after the booking of the user,",
                                      
                        IsPublished = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,


                    });
            }
                #endregion
                this._context.SaveChanges();
            return Ok("OK");
        }
    }
 }
    

    
