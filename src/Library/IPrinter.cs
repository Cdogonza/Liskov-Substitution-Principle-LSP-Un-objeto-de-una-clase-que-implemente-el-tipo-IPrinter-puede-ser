namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    } 
}

//Utilizamos el patron LSP para crear una interfaz encargada de la operacion imprimir receta.
//Ademas creamos dos clases, una encargada de imprimir en la consola y otra encargada de imprimir en un 
// archivo txt, y ambas heredan el metodo imprimir receta antes mencionado.