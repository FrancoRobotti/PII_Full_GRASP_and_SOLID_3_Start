using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Cree ConsolePrinter, usando como interfaz Iprinter, usando el metodo definido en la interfaz
    //devolviendo el Console.WriteLine.
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}