using ASP.NET_DemoWork.Models;
using ASP.NET_DemoWork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ASP.NET_DemoWork.Service
{
    public class UserService
    {
        private UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            var response = await _userRepository.GetAllUser();

            return response;
        }

        public async Task<User> GetUserById(Guid userId)
        {
            var response = await _userRepository.GetUserById(userId);

            return response;
        }

        public async Task<int> AddUser(User model)
        {
            var response = await _userRepository.AddUser(model);

            return response;
        }
    }
}