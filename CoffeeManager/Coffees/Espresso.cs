using CoffeeManager.Interfaces;
using CoffeeManager.Milk;


namespace CoffeeManager.Coffees
{
    public class Espresso : ICoffee
    {

        public Espresso()  
        {
            BlackCoffee = 1;
            Sugar = 0;
            Milk = [new OatMilk()];
        }

        public int BlackCoffee { get; set; }
        public int Sugar { get; set; }
        public List<IMilk> Milk { get; set; }
    }
}
