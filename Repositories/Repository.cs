using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<TModel> where TModel : class
    {          
        public IEnumerable<TModel> Get()
            =>DataBase.Connection.GetAll<TModel>();
        public TModel Get(int id)
            =>DataBase.Connection.Get<TModel>(id);
        public void Create(TModel model)
            =>DataBase.Connection.Insert<TModel>(model);
        public void Update(TModel model)
            =>DataBase.Connection.Update<TModel>(model);
        public void Delete(TModel model)
            =>DataBase.Connection.Delete<TModel>(model);
        public void Delete(int id)
        {
            var model = DataBase.Connection.Get<TModel>(id);
            DataBase.Connection.Delete<TModel>(model);
        }
    }
}
