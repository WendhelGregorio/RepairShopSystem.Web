using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Helper
{
    public static class WebIDS
    {
        public static Guid? GetAdminUserId { get; set; }

        public static Guid? GetShopAdminId { get; set; }
        public static Guid? GetShopId { get; set; }

        public static Guid? GetPublicUserId { get; set; }

        public static Guid? GetBookingId { get; set; }

        public static Guid? UserId { get; set; }

        public static Guid? RoomId { get; set; }

        public static List<Role> Roles { get; set; }

        public static List<Group> Groups { get; set; }

        public static string Name { get; set; }

        public static void SetRoomId(Guid Id)
        {
            RoomId = Id;
        }

        public static void SetBookingId(Guid? Id)
        {
            GetBookingId = Id;
            
        }

        public static void SetShopId(Guid? Id)
        {
            GetShopId = Id;

        }

        public static void SetUserId(Guid? Id,string name, List<Role> roles, List<Group> groups)
        {

            UserId = Id;
            Roles = roles;
            Groups = groups;
            Name = name;
           
        }

        public static void SetPublicUserId(Guid? Id, List<Role> roles, List<Group> groups)
        {
            GetPublicUserId = Id;
            Roles = roles;
            Groups = groups;
        }

        public static void SetShopAdminId(Guid? Id, List<Role> roles, List<Group> groups)
        {
            GetShopAdminId = Id;
            Roles = roles;
            Groups = groups;
        }
        public static void SetAdminId(Guid? Id, List<Role> roles, List<Group> groups)
        {
            GetAdminUserId = Id;
            Roles = roles;
            Groups = groups;
        }
    }
}
