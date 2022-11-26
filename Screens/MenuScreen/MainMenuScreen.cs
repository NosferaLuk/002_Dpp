using System;
namespace Blog.Screens.MenuScreen
{
    public class MainMenuScreen
    {
        public int[] Draw()
        {
            Console.Clear();
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine($"                 Blog                 ");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine(" 1 - Categories |2 - Posts |3 - Roles  ");
            Console.WriteLine(" 4 - Tags       |5 - Users |0 - Sair   ");
            Console.WriteLine(" --------------------------------------");
    
            var isInt = int.TryParse(Console.ReadLine(), out var model);
            
            if(isInt == true && model  == 0)
                Environment.Exit(0);

            if(isInt == true    && model  > 0
                                && model <= 5)
            {
                var opt = new ViewScreen().Draw(model);
                if(opt == 0 )
                    return this.Draw();
                else
                    return new int[] {model,opt};
            }
            else
            {
                optInvalida();
                return this.Draw();
            }
        }

        public void optInvalida()
        {
            Console.Clear();
            Console.WriteLine("Opção invalida!\n Clique qualquer botão para continuar.");
            Console.ReadKey();
        }

        public void valorNulo()
        {
            Console.Clear();
            Console.WriteLine("Valor informado foi nulo!\n Clique qualquer botão para continuar.");
            Console.ReadKey();
        }

        public void dadosDuplicados()
        {
            Console.Clear();
            Console.WriteLine("Valor informado duplicado!\n Clique qualquer botão para continuar.");
            Console.ReadKey();
        }
    }
}