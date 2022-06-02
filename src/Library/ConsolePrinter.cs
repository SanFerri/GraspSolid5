using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(RecipeContent recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}