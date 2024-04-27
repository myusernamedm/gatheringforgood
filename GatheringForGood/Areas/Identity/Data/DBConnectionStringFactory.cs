using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GatheringForGood.Data
{
    public class DBConnectionStringFactory
    {
        public string DBConnectionString()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = config["ConnectionStrings:DefaultConnection"];

            return connectionString;
        }

        public string gfgImagesConnectionString()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = config["ConnectionStrings:gatheringforgoodimages"];

            return connectionString;
        }
    }
}
