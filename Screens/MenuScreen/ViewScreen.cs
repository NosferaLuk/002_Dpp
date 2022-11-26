using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.MenuScreen
{
    public class ViewScreen
    {
        public int Draw(int model)
        {
            Console.Clear();
            var models = new string[] {"Categories","Posts","Roles","Tags","Users"};
            var mod = models[model-1];
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine($"                  {mod}                ");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine(" 1 - Criar|2 - Visualizar|3 - Atualizar");
            Console.WriteLine(" 4 - Excluir             |0 - Voltar   ");
            Console.WriteLine(" --------------------------------------");
            
            var isInt = int.TryParse(Console.ReadLine(), out var option);
                
            if(isInt == true    && option >= 0
                                && option <= 4)
                return option;
            else
            {
                new MainMenuScreen().optInvalida();
                return this.Draw(model);
            }
        }
    }
}