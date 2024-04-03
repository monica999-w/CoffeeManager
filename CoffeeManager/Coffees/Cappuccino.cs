using CoffeeManager.Interfaces;
using CoffeeManager.Milk;


namespace CoffeeManager.Coffees
{
    public class Cappuccino : ICoffee
    {
        public Cappuccino()
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

