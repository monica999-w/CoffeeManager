using CoffeeManager.Ingrediants;
using CoffeeManager;
using CoffeeManager.Coffees;
using CoffeeManager.Interfaces;

class Program
{
    static void Main(string[] args)

    {
        CoffeeCreator espressoCreator = new EspressoCreator();
        ICoffee espresso = espressoCreator.CreateCoffee();
        var customEspresso = espressoCreator.AddIngredient(espresso, new Milk(1));
        Console.WriteLine("Custom Espresso: " + customEspresso.GetName());

        // Creating a cappuccino with two sugars
        CoffeeCreator cappuccinoCreator = new CappuccinoCreator();
        ICoffee cappuccino = cappuccinoCreator.CreateCoffee();
        var customCappuccino = cappuccinoCreator.AddIngredient(cappuccino, new Sugar(2));
        Console.WriteLine("Custom Cappuccino: " + customCappuccino.GetName());

        // Creating a flat white with brown sugar
        CoffeeCreator flatWhiteCreator = new FlatWhiteCreator();
        ICoffee flatWhite = flatWhiteCreator.CreateCoffee();
        var customFlatWhite = flatWhiteCreator.AddIngredient(flatWhite, new Sugar(1));
        Console.WriteLine("Custom Flat White: " + customFlatWhite.GetName());
    }
}

