

using CoffeeManager.Ingrediants;
using CoffeeManager.Interfaces;

namespace CoffeeManager.Coffees
{
    public class FlatWhiteCreator : CoffeeCreator
    {
        public override ICoffee CreateCoffee()
        {
            return AddIngredient(new BlackCoffee(), new Milk(2));
        }
    }
}

