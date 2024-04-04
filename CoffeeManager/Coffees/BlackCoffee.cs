using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeManager.Interfaces;

namespace CoffeeManager.Coffees
{
    public class BlackCoffee : ICoffee
    {
        public string GetName()
        {
            return "Black Coffee";
        }
    }
}
