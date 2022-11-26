using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.MenuScreen
{
    public class CrudScreen<Tmodel> where Tmodel : class
    {
        public int[] models { get; set; }
        public void Create()
        {  
            
        }            
    }
}