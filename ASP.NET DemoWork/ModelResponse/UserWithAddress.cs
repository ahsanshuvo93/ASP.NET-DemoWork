using ASP.NET_DemoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_DemoWork.ModelResponse
{
    public class UserWithAddress
    {
        public IEnumerable<User> User { get; set; }
        public IEnumerable<UserAddress> UserAddress { get; set; }
    }
}