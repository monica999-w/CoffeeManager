using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager
{
        public class CoffeeRecipeManager
        {
            private static CoffeeRecipeManager? instance;
            public Dictionary<string, string> recipes;

            public CoffeeRecipeManager()
            {
                recipes = new Dictionary<string, string>();
                InitializeRecipe();
            }

            public static CoffeeRecipeManager Instance
            {
                get
                {
                    if (instance == null)
                    {

                        instance = new CoffeeRecipeManager();

                    }
                    return instance;

                }
            }

            public void InitializeRecipe()
            {
                recipes["Espresso"] = "Black coffee";
                recipes["Cappuccino"] = "Black coffee + Milk";
                recipes["Flat White"] = "Black coffee + Black coffee + Milk";
            }
            public void AddCustemerRecipe(string name, string ingrediants)
            {
                if (!recipes.ContainsKey(name))
                {
                    recipes[name] = ingrediants;
                    Console.WriteLine($"Custermer recipe:  {name}  - add successful \n");

                }
                else
                {
                    Console.WriteLine($"Recipe :  {name} -  exist \n");
                }
            }

            public void DisplayRecipes()
            {
                Console.WriteLine(" Recipes : \n");

                foreach (var recipe in recipes)
                {
                    Console.WriteLine($"{recipe.Key} : {recipe.Value}");
                }

            }


        }
    
}