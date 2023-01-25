using ASP.NET_DemoWork.Models;
using ASP.NET_DemoWork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASP.NET_DemoWork.Controllers
{
    public class UserController : ApiController
    {
        private UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }

        [Route("api/user/getall")]
        public async Task<IEnumerable<User>> GetAll()
        {
            var response = await _userService.GetAllUser();

            return response;
        }

        [Route("api/user/getbyid")]
        public async Task<User> GetById(Guid userId)
        {
            var response = await _userService.GetUserById(userId);

            return response;
        }

        [Route("api/user/add")]
        public async Task<int> AddUser(User model)
        {
            var response = await _userService.AddUser(model);

            return response;
        }

        [Route("api/user/update")]
        public async Task<int> UpdateUser(User model)
        {
            var response = await _userService.UpdateUser(model);

            return response;
        }
    }
}
