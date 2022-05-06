using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Cree FilePrinter, usando como interfaz Iprinter, usando el metodo definido en la interfaz
    //devolviendo el archivo tipo File.
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}