using CoffeeManager.Interfaces;

namespace CoffeeManager.Ingrediants
{
    public class Milk: IIngredient
    {
        public int Quality { get; private set; }

        public Milk(int quality)
        {
            Quality = quality;
        }

        public string GetName()
        {
            return $" with {Quality} Milk";
        }
    }
}
