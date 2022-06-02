using System;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Interfaz que implementara Recipe que solo contiene el metodo GetTextToPrint
    /// que es el unico que usa ConsolePrinter y FilePrinter. De esta forma ConsolePrinter
    /// y FilePrinter dependeran de una abstraccion de Recipe en vez de Recipe, como dicta
    /// el principio DIP.
    /// </summary>
    public interface IRecipeContent
    {
        string GetTextToPrint();
    }
}