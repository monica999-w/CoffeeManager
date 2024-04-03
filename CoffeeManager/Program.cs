﻿using CoffeeManager;
using CoffeeManager.Coffees;
using CoffeeManager.Interfaces;
using CoffeeManager.Milk;

class Program
{
    static void Main(string[] args)
    {
        CoffeeMaker coffeeMaker = new CoffeeMaker();

        Cappuccino cappuccino = new Cappuccino();
        Espresso espresso = new Espresso(); 
        FlatWhite flatWhite = new FlatWhite();

        coffeeMaker.AddMoreSugar(espresso, 4);
        coffeeMaker.MakeCoffee(espresso);
        Console.WriteLine(coffeeMaker.OrderInfo(espresso));

        SoyMilk soyMilk = new SoyMilk();
        coffeeMaker.AddMoreMilk(flatWhite, soyMilk);
        coffeeMaker.AddMoreSugar(flatWhite, 4);
        coffeeMaker.MakeCoffee(flatWhite);
        Console.WriteLine(coffeeMaker.OrderInfo(flatWhite));

        RegularMilk regularMilk = new RegularMilk();
        coffeeMaker.AddMoreMilk(cappuccino, regularMilk);
        coffeeMaker.MakeCoffee(cappuccino);
        Console.WriteLine(coffeeMaker.OrderInfo(cappuccino));
    }
}
