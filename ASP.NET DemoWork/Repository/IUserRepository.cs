using ASP.NET_DemoWork.ModelResponse;
using ASP.NET_DemoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_DemoWork.Repository
{
    interface IUserRepository: IDisposable
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> GetUserById(Guid id);
        Task<int> AddUser(User model);
        Task<int> UpdateUser(User model);
        Task DeleteUser(Guid id);
        Task<UserWithAddress> GetUserWithAddress();
    }
}
