using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.Extensions.Configuration;
using GatheringForGood.Data;

namespace GatheringForGood.UnitTests
{
    public class TestAppSettingsJSON
    {
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void DefaultDBConnectionStringIsCorrect()
        {
            string CorrectDefaultConnectionString = "Server=tcp:gfg-initial.database.windows.net,1433;Initial Catalog=Main;Persist Security Info=False;User ID=dmurphy;Password=F1tzgerald;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            var ConnectionStringsFactory = new DBConnectionStringFactory();
            string ReturnedDefaultConnectionString = ConnectionStringsFactory.DBConnectionString();
            Assert.Equal(CorrectDefaultConnectionString, ReturnedDefaultConnectionString);
        }
    }

}
