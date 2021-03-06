﻿using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Models
{
    public class Booking : BaseModel
    {
        public Guid? UserId { get; set; }

        public Guid? ShopId { get; set; }

        public Guid? ShopServiceId { get; set; }

        public string ShopServiceName { get; set; }

        public decimal ShopServicePrice { get; set; }

        public string ShopServiceDescription { get; set; }

        public string UserName { get; set; }

        public string AdditionalDescription { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }

        public DateTime DateAndTime { get; set; }

        public DateTime TimeStamps { get; set; }

        public ReserveStatus ReserveStatus { get; set; }

        public PaymentType PaymentType { get; set; }

        public virtual ShopService ShopService { get; set; }

        public virtual User User { get; set; }

        public List<Shop> Shop { get; set; }

        public Guid? TermAndConditionId { get; set; }

        public virtual TermAndCondition TermAndCondition {get; set;}

    }
}