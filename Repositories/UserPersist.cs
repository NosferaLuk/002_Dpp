using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories 
{
    public class UserPersist : Repository<User>
    {
        public List<User> GetWithRoles()
        {
            var query = @"
            SELECT [User].*,[Role].*
            FROM [User]
                LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";
            var users = new List<User>();
            
            var items = DataBase.Connection.Query<User, Role, User>
            (
                query,
                (user, role)
                =>  {
                        var usr= users.FirstOrDefault(x => x.Id == user.Id);
                        if (usr == null)
                        {
                            usr = user;
                            if(role !=null)
                                usr.Roles.Add(role);
                            users.Add(usr);
                        }
                        else
                            usr.Roles.Add(role);
                            
                        return user;
                    }
                ,splitOn: "Id"
            );

            return users;
        }
    }
}