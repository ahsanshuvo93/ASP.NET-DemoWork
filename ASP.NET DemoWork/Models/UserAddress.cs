using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_DemoWork.Models
{
    public class UserAddress
    {
        public Guid UserAddressId { get; set; }
        public Guid UserId { get; set; }
        public string AddreesDetails { get; set; }
        public Guid CityId { get; set; }
        public string Status { get; set; }
    }
}

/*

CREATE TABLE[UserAddress] (
    UserAddressID uniqueidentifier not null,
    UserID uniqueidentifier not null,
    AddreesDetails varchar(1000),
    CityID uniqueidentifier not null,
    [status] varchar(20),
	PRIMARY KEY(UserAddressID),
	FOREIGN KEY(UserID) REFERENCES[User](UserID),
	FOREIGN KEY(CityID) REFERENCES City(CityID),
);

*/