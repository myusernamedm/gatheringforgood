using System;
using Xunit;
using GatheringForGood.Areas.FunctionalLogic;
using System.Collections.Generic;
using UITestStringsLibrary;
using System.Linq;
using System.Diagnostics;

namespace GatheringForGood.UnitTests
{
    public class TestGetUserAndSiteActionClicks
    {
        readonly CrossPageSharedUITestStrings GetTestString = new CrossPageSharedUITestStrings();

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RGWGetUserActionClicks_CorrectNumberReturnedFromDBForQuantityOfUIitemsOnPageTable()
        {
            List<string> actionsList = RGWGetUserActionClicks.GetClicks(GetTestString.Test7UserId());
            int actionsListCount = actionsList.Count();
            Assert.Equal(24, actionsListCount);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RAEGetUserActionClicks_CorrectNumberReturnedFromDBForQuantityOfUIitemsOnPageTable()
        {
            List<string> actionsList = RAEGetUserActionClicks.GetClicks(GetTestString.Test7UserId());
            int actionsListCount = actionsList.Count();
            Assert.Equal(15, actionsListCount);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RDFGetUserActionClicks_CorrectNumberReturnedFromDBForQuantityOfUIitemsOnPageTable()
        {
            List<string> actionsList = RDFGetUserActionClicks.GetClicks(GetTestString.Test7UserId());
            Assert.Equal(13, actionsList.Count());
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RGWGetClickTotals_CorrectNumberReturnedFromDBForQuantityOfUIitemsAtTopOfPage()
        {
            List<string> totalActionsList = RGWGetClickTotals.GetTotalClicks(GetTestString.Test7UserId(), true);
            Assert.Equal(5, totalActionsList.Count());
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RAEGetClickTotals_CorrectNumberReturnedFromDBForQuantityOfUIitemsAtTopOfPage()
        {
            List<string> totalActionsList = RAEGetClickTotals.GetTotalClicks(GetTestString.Test7UserId(), true);
            Assert.Equal(5, totalActionsList.Count());
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RDFGetClickTotals_CorrectNumberReturnedFromDBForQuantityOfUIitemsAtTopOfPage()
        {
            List<string> totalActionsList = RDFGetClickTotals.GetTotalClicks(GetTestString.Test7UserId(), true);
            Assert.Equal(5, totalActionsList.Count());
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RGWGetClickTotals_CorrectNumberReturnedFromDBForQuantityOfUIitemsAtTopOfPageNoUserActions()
        {
            List<string> totalActionsList = RGWGetClickTotals.GetTotalClicks(GetTestString.Test7UserId(), false);
            int totalActionsListCount = totalActionsList.Count();
            Assert.Equal(3, totalActionsListCount);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RAEGetClickTotals_CorrectNumberReturnedFromDBForQuantityOfUIitemsAtTopOfPageNoUserActions()
        {
            List<string> totalActionsList = RAEGetClickTotals.GetTotalClicks(GetTestString.Test7UserId(), false);
            int totalActionsListCount = totalActionsList.Count();
            Assert.Equal(3, totalActionsListCount);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RDFGetClickTotals_CorrectNumberReturnedFromDBForQuantityOfUIitemsAtTopOfPageNoUserActions()
        {
            List<string> totalActionsList = RDFGetClickTotals.GetTotalClicks(GetTestString.Test7UserId(), false);
            int totalActionsListCount = totalActionsList.Count();
            Assert.Equal(3, totalActionsListCount);
        }
    }
}
