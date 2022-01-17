using PustokP201.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP201.ViewModels
{
    public class CheckoutViewModel
    {
        public List<CheckoutItemViewModel> CheckoutItems { get; set; }
        public Order Order { get; set; }
    }
}
