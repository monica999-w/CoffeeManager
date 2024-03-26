using CoffeeManager;

class Program
{
    static void Main(string[] args)
    {
        CoffeeRecipeManager recipeManager = new CoffeeRecipeManager();
        //recipeManager.DisplayRecipes();

        recipeManager.AddCustemerRecipe("Regular Milk", "Espresso + Soy milk + Sugar");
        recipeManager.AddCustemerRecipe("Oat Milk", "Cappuccino + Sugar+ Sugar");
        recipeManager.AddCustemerRecipe("Soy Milk", "Flat white + Sugar");

        recipeManager.AddCustemerRecipe("Regular Milk", "Cappuccino + Sugar+ Sugar");

        recipeManager.DisplayRecipes();
    }
}