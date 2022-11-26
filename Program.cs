using Blog.Screens.MenuScreen;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Text;

// Cadastrar um usuario
// Cadastrar um Perfil
// Vincular um usuario a um Perfil

// Cadastrar uma categoria

// Cadastrar uma tag
// cadastrar um post

// vincular um post a uma tag

// listar os usuarios(Nome, email e perfis separados por virgula)
// Listar categorias com quantidade de posts
// listar tags co mquantidade de posts
// listar os posts de uma categoria
// listar todos os posts com sua categoria
// listar os posts com suas tags(separados por virgula)

namespace Blog
{
    public class Blog
    {
        public static void Main(string[] args)
        {
            var options = new MainMenuScreen().Draw();
        }
    }
}