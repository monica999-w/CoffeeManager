using CoffeeManager.Interfaces;
using CoffeeManager.Milk;
using System;
using System.Collections.Generic;

namespace CoffeeManager.Coffees
{
    public class FlatWhite: ICoffee
    {
        public FlatWhite()
        {
            BlackCoffee = 1;
            Sugar = 0;
            Milk = [new RegularMilk()];
        }

        public int BlackCoffee { get; set; }
        public int Sugar { get; set; }
        public List<IMilk> Milk { get; set; }
    }
}

