using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_DemoWork.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
    }
}


/*
 
  CREATE TABLE [User] (
    UserID uniqueidentifier not null,
    FullName varchar(100),
    Email varchar(100) not null,
	PhoneNumber varchar(100) not null,
	[Password]  varchar(1000) not null,
	BirthDate datetime,
    [Image] varchar(255),
    [status] varchar(20),
	PRIMARY KEY (UserID)
);
 
 */