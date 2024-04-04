using CoffeeManager.Interfaces;

namespace CoffeeManager.Coffees
{
    public class EspressoCreator : CoffeeCreator
    {
        public override ICoffee CreateCoffee()
        {
            return new BlackCoffee();
        }
    }
}
