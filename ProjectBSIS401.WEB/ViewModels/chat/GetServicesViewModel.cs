﻿using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.ViewModels.chat
{
    public class GetServicesViewModel
    {

        public string Name { get; set; }

        public ServiceType ServiceType { get; set; }

        public bool IsPublished { get; set; }


    }
}