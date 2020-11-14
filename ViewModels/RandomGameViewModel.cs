using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vid_Learn.Models;

namespace Vid_Learn.ViewModels
{
    public class RandomGameViewModel
    {
        public Game Game { get; set; }
        public List<Customer> Customers{get; set;}
    
    }
}