using CoffeeManager.Interfaces;

namespace CoffeeManager.Ingrediants
{
    public class Sugar : IIngredient
    {
        public int Quality { get; private set; }

        public Sugar(int quality)
        {
            Quality = quality;
        }

        public string GetName()
        {
            return $" with  {Quality} Sugar";
        }
    }

}
