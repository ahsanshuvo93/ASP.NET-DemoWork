using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_DemoWork.Models
{
    public class City
    {
        public Guid CityId { get; set; }
        public string Name { get; set; }
        public string CityCode { get; set; }
        public string Status { get; set; }
    }
}

/*
 
CREATE TABLE [City] (
    CityID uniqueidentifier not null,
    [Name] varchar(1000),
    CityCode varchar(1000),
    [status] varchar(20),
	PRIMARY KEY (CityID)
)
 
 * */