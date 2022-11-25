using System;
namespace Blog.Screens.MenuScreen
{
    public class MainMenuScreen
    {
        public int[] Load()
        {
            Console.Clear();
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine($"                 Blog                 ");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine("| 1 - Categories |2 - Posts |3 - Roles  |");
            Console.WriteLine("| 4 - Tags       |5 - Users |0 - Sair   |");
            Console.WriteLine(" --------------------------------------");
    
            var isInt = int.TryParse(Console.ReadLine(), out var model);
            
            if(isInt == true    && model  == 0)
                Environment.Exit(0);

            if(isInt == true    && model  > 0
                                && model <= 5)
            {
                var viewScreen = new ViewScreen();
                return new int[] {model,viewScreen.Load(model)};
            }
                
            else
            {
                Console.WriteLine("Opção invalida!\n Clique qualquer botão para continuar.");
                Console.ReadKey();
                return Load();
            }
        }
        
    }
}