using CoffeeManager.Ingrediants;
using CoffeeManager.Interfaces;

namespace CoffeeManager
{
    public abstract class CoffeeCreator
    {  
        public abstract ICoffee CreateCoffee();
        public ICoffee AddIngredient(ICoffee baseCoffee, IIngredient extraIngredient)
        {
            return new CustomCoffee(baseCoffee, extraIngredient);
        }
    }
}