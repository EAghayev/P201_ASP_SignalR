﻿using PustokP201.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP201.ViewModels
{
    public class ProfileViewModel
    {
        public MemberUpdateViewModel Member { get; set; }
        public List<Order> Orders { get; set; }
    }
}
