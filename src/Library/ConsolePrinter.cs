using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// Depende de IRecipeContent
        /// </summary>
        /// <param name="recipe"></param>
        public void PrintRecipe(IRecipeContent recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}