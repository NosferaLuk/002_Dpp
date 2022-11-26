using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.MenuScreen;

namespace DPP.Repositories
{
    public class CategoryPersist : Repository<Category>
    {
        public void Create()
        {
            Console.Clear();
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine(" Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine(" Slug: ");
            var slug = Console.ReadLine();
            
            var repository = new Repository<Category>();

            if(name == null || slug == null)
                new MainMenuScreen().valorNulo();
            if(repository.Get(name) != null)
                new MainMenuScreen().dadosDuplicados();
            else
            {
                var model = new Category()
                {
                    Name = name,
                    Slug = slug
                };
                repository.Create(model);
            }
            this.Create();    
        }
    }
}