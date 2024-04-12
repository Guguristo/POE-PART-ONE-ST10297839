
using System;
using System.Collections.Generic;

namespace recipeApp
{
    public class Ingredient
    {
        // Properties for ingredient details
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }
    public class Recipe
    {
        private List<Ingredient> ingredients;
        private List<string> steps;


        // Constructor to initialize lists
        public Recipe()
        {
            ingredients = new List<Ingredient>();
            steps = new List<string>();

        }

        // Method to enter recipe details 
        public void EnterRecipeDetails()
        {

            Console.WriteLine("Enter the number of ingredients: ");
            int numIngredients = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter the name of the ingredient {i + 1}: ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter the quantity of {name}");
                double quantity = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Enter the unit of measurement for {name}: ");
                string unit = Console.ReadLine();

                ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
            }

            Console.WriteLine("Enter the number of steps: ");
            int numSteps = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}: ");
                string step = Console.ReadLine();
                steps.Add(step);
            }
        }

        // Method to display the full recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe: ");
            Console.WriteLine("Ingredients: ");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine("\nSteps: ");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"Step {i + 1}: {steps[i]}");
            }

        }

        // Method to scale the recipe by a factor
        public void ScaleRecipe(Double factor)
        {
            Console.WriteLine($"\nScaling the recipe by a factor of {factor}...");

            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        // Method to reset ingredients quantities to original values
        public void ResetQuantities()
        {

            Console.WriteLine("\nResetting ingredient quantities to original values...");

        }

        // Method to clear all data
        public void ClearData()
        {
            Console.WriteLine("\nClearing all data...");
            ingredients.Clear();
            steps.Clear();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear all data");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipe.EnterRecipeDetails();
                        break;
                    case 2:
                        recipe.DisplayRecipe();
                        break;
                    case 3:
                        Console.WriteLine("Enter scaling factor (0.5, 2, or 3): ");
                        double factor = Convert.ToDouble(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                        break;
                    case 4:
                        recipe.ResetQuantities();
                        break;
                    case 5:
                        recipe.ClearData();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
