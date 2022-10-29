﻿using CookBook.Recipe.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserIOConsole myConsole = new UserIOConsole();
            string recipeName = MyRecipe.GetRecipeNameFromUser();
            int recipeCategory = MyRecipe.GetRecipeCategoryFromUser();
            List<Ingredients> ingredientsList = Ingredients.GetIngredientsListFromUser();
            Procedure newProcedure = Procedure.GetProcedureFromUser();
            MyRecipe myRecipe = new MyRecipe(recipeName, recipeCategory, newProcedure, ingredientsList);
            myRecipe.GetRecipeInfo();
            
            Console.WriteLine("Jsem na konci programu. Loučím se s tebou :)");
            Console.ReadLine();
        }
    }
}
