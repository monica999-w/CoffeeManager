

using CoffeeManager.Ingrediants;
using CoffeeManager.Interfaces;

namespace CoffeeManager.Coffees
{
    public class CappuccinoCreator : CoffeeCreator
    {
        public override ICoffee CreateCoffee()
        {
            return AddIngredient(new BlackCoffee(), new Milk(1));
        }
    }
}

