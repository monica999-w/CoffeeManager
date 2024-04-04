using CoffeeManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager
{
    public class CustomCoffee : ICoffee
    {
        private readonly ICoffee baseCoffee;
        private readonly IIngredient extraIngredient;

        public CustomCoffee(ICoffee baseCoffee, IIngredient extraIngredient)
        {
            this.baseCoffee = baseCoffee;
            this.extraIngredient = extraIngredient;
        }

        public string GetName()
        {
            return baseCoffee.GetName() + extraIngredient.GetName();
        }
    }
}
