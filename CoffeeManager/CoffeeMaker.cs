using CoffeeManager.Coffees;
using CoffeeManager.Interfaces;
using CoffeeManager.Milk;
using System.Text;


namespace CoffeeManager
{
    public class CoffeeMaker : ICoffeeMaker
    {
        private  List<ICoffee> _coffees;
        public CoffeeMaker()
        {
            _coffees = new List<ICoffee>();
        }

        private bool isValidMilk(IMilk milk)
        {
            var milkName = milk.GetType().Name;

            if (milkName != nameof(SoyMilk) && milkName != nameof(RegularMilk) && milkName != nameof(OatMilk))
            {
                return false;
            }

            return true;
        }
        private bool isValidCoffee(ICoffee coffee)
        {
            var coffeeName = coffee.GetType().Name;

            if (coffeeName != nameof(Espresso) && coffeeName != nameof(FlatWhite) && coffeeName != nameof(Cappuccino))
            {
                return false;
            }

            return true;
        }
        public void AddMoreMilk(ICoffee coffee, IMilk milk)
        {
            if (!isValidCoffee(coffee))
            {
                throw new ArgumentException("Invalid coffee name!");
            }

            if (!isValidMilk(milk))
            {
                throw new ArgumentException("Invalid milk name!");
            }
            coffee.Milk.Add(milk);
        }

        public void AddMoreSugar(ICoffee coffee, int countSugar)
        {
            if (!isValidCoffee(coffee))
            {
                throw new ArgumentException("Invalid coffee name!");
            }

            coffee.Sugar += countSugar;
        }

        public void MakeCoffee(ICoffee coffee)
        {
            if (!isValidCoffee(coffee))
            {
                throw new ArgumentException("Invalid coffee name!");
            }

            _coffees.Add(coffee);
        }


        public string OrderInfo(ICoffee coffee)
        {
            var name = new StringBuilder();

            name.Append("Coffee: ");
            name.Append("Black Coffee");

            if (coffee.Milk.Count != 0)
            {
                name.Append(" with ");
                foreach (var milk in coffee.Milk)
                {
                    name.Append($"+ {milk.GetType().Name} ");
                }
            }

            if (coffee.Sugar > 0)
            {
                string sugarString = coffee.Sugar == 1 ? " sugar." : " sugars.";
                name.Append($" and {coffee.Sugar}{sugarString}");
            }

            return name.ToString();
        }
    }

}