using System;
using Xunit;
using GatheringForGood.Areas.FunctionalLogic;
using System.Collections.Generic;
using UITestStringsLibrary;
using System.Linq;
using System.Diagnostics;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GatheringForGood.UnitTests
{
    public class TestGetCountriesList
    {
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void TestGetCountriesList_CorrectNumberReturnedFromDBForCountriesList()
        {
            List<string> countriesList = GetCountriesList.GetCountries();
            int countriesListCount = countriesList.Count();
            Assert.Equal(198, countriesListCount);
        }
    }
}
