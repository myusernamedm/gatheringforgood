using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestUserBadgesPageLocSourceNames
    {

    private readonly ISharedCultureLocalizer _loc;

    public TestUserBadgesPageLocSourceNames()
    {
        var LocalizerFactoryForTests = new LocalizerFactoryForTests();
        _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourcePageTabTitleNameReferenceForUserBadgesPageIsCorrect()
    {
        string PageTabTitle = _loc.GetLocalizedString("en", "My Awards", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForUserBadgesPage();
        Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceTitleNameReferenceForUserBadgesPageIsCorrect()
    {
        string Title = _loc.GetLocalizedString("en", "My digital awards to date", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForUserBadgesPage();
        Assert.Equal(Title, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceSubtitleNameReferenceForUserBadgesPageIsCorrect()
    {
        string SubTitle = _loc.GetLocalizedString("en", "My Awards & Badges", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForUserBadgesPage();
        Assert.Equal(SubTitle, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceFirstStepNameReferenceForUserBadgesPageIsCorrect()
    {
        string FirstStep = _loc.GetLocalizedString("en", "First Step", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetFirstStepTitleForUserBadgesPage();
        Assert.Equal(FirstStep, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceGathererForGoodNameReferenceForUserBadgesPageIsCorrect()
    {
        string GathererForGood = _loc.GetLocalizedString("en", "Gatherer For Good", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetGathererForGoodTitleForUserBadgesPage();
        Assert.Equal(GathererForGood, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceBuildingBackBetterNameReferenceForUserBadgesPageIsCorrect()
    {
        string BuildingBackBetter = _loc.GetLocalizedString("en", "Building Back Better", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetBuildingBackBetterTitleForUserBadgesPage();
        Assert.Equal(BuildingBackBetter, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceKeyDriverOfChangeNameReferenceForUserBadgesPageIsCorrect()
    {
        string KeyDriverOfChange = _loc.GetLocalizedString("en", "Key Driver Of Change", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetKeyDriverOfChangeTitleForUserBadgesPage();
        Assert.Equal(KeyDriverOfChange, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceDefeatGlobalWarmingNameReferenceForUserBadgesPageIsCorrect()
    {
        string DefeatGlobalWarming = _loc.GetLocalizedString("en", "Defeat Global Warming", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetDefeatGlobalWarmingTitleForUserBadgesPage();
        Assert.Equal(DefeatGlobalWarming, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceDefeatAnimalExtinctionNameReferenceForUserBadgesPageIsCorrect()
    {
        string DefeatAnimalExtinction = _loc.GetLocalizedString("en", "Defeat Animal Extinction", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetDefeatAnimalExtinctionTitleForUserBadgesPage();
        Assert.Equal(DefeatAnimalExtinction, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceDefeatDeforestationNameReferenceForUserBadgesPageIsCorrect()
    {
        string DefeatDeforestation = _loc.GetLocalizedString("en", "Defeat Deforestation", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetDefeatDeforestationTitleForUserBadgesPage();
        Assert.Equal(DefeatDeforestation, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceDeeplyCareNameReferenceForUserBadgesPageIsCorrect()
    {
        string DeeplyCare = _loc.GetLocalizedString("en", "Deeply Care", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetDeeplyCareTitleForUserBadgesPage();
        Assert.Equal(DeeplyCare, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceCommunicatingForDifferenceNameReferenceForUserBadgesPageIsCorrect()
    {
        string CommunicatingForDifference = _loc.GetLocalizedString("en", "Communicating For Difference", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetCommunicatingForDifferenceTitleForUserBadgesPage();
        Assert.Equal(CommunicatingForDifference, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceContributorForGoodNameReferenceForUserBadgesPageIsCorrect()
    {
        string ContributorForGood = _loc.GetLocalizedString("en", "Contributor For Good", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetContributorForGoodTitleForUserBadgesPage();
        Assert.Equal(ContributorForGood, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceFeedbackHeroNameReferenceForUserBadgesPageIsCorrect()
    {
        string FeedbackHero = _loc.GetLocalizedString("en", "Feedback Hero", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetFeedbackHeroTitleForUserBadgesPage();
        Assert.Equal(FeedbackHero, ReturnedNameKeyValue);
    }

    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceHelpfulNameNameReferenceForUserBadgesPageIsCorrect()
    {
        string Helpful = _loc.GetLocalizedString("en", "Helpful", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetHelpfulTitleForUserBadgesPage();
        Assert.Equal(Helpful, ReturnedNameKeyValue);
    }
    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void LocSourceLeaderNameReferenceForUserBadgesPageIsCorrect()
    {
        string Leader = _loc.GetLocalizedString("en", "Leader", null);
        var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
        string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetLeaderTitleForUserBadgesPage();
        Assert.Equal(Leader, ReturnedNameKeyValue);
    }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceVisionaryNameReferenceForUserBadgesPageIsCorrect()
        {
            string Visionary = _loc.GetLocalizedString("en", "Visonary", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetVisionaryTitleForUserBadgesPage();
            Assert.Equal(Visionary, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceThankyouNameReferenceForUserBadgesPageIsCorrect()
        {
            string Thankyou = _loc.GetLocalizedString("en", "Thank you", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetThankyouTitleForUserBadgesPage();
            Assert.Equal(Thankyou, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLearningNameReferenceForUserBadgesPageIsCorrect()
        {
            string Learning = _loc.GetLocalizedString("en", "Learning For Good", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetLearningForGoodTitleForUserBadgesPage();
            Assert.Equal(Learning, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMakingADifferenceNameReferenceForUserBadgesPageIsCorrect()
        {
            string MakingADifference = _loc.GetLocalizedString("en", "Making A Difference", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetMakingADifferenceTitleForUserBadgesPage();
            Assert.Equal(MakingADifference, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFirstStepInfoForUserNameReferenceForUserBadgesPageIsCorrect()
        {
            string FirstStepInfoForUser = _loc.GetLocalizedString("en", "I have taken my first action to reduce global warming, animal extinction or deforestation.", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetFirstStepInfoForUserBadgesPage();
            Assert.Equal(FirstStepInfoForUser, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGathererForGoodInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string GathererForGoodInfo = _loc.GetLocalizedString("en", "5 Shares of GatheringForGood to encourage more people to make a difference (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetGathererForGoodInfoForUserBadgesPage();
            Assert.Equal(GathererForGoodInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBuildingBackBetterInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string BuildingBackBetterInfo = _loc.GetLocalizedString("en", "2 actions to promote a green recovery", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetBuildingBackBetterInfoForUserBadgesPage();
            Assert.Equal(BuildingBackBetterInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceKeyDriverOfChangeInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string KeyDriverOfChangeInfo = _loc.GetLocalizedString("en", "I have reduced my meat intake, gone vegetarian or gone vegan 25 times", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetKeyDriverOfChangeInfoForUserBadgesPage();
            Assert.Equal(KeyDriverOfChangeInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDefeatGlobalWarmingInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string DefeatGlobalWarmingInfo = _loc.GetLocalizedString("en", "I have taken 100 actions to reduce global warming", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetDefeatGlobalWarmingInfoForUserBadgesPage();
            Assert.Equal(DefeatGlobalWarmingInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDefeatAnimalExtinctionInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string DefeatAnimalExtinctionInfo = _loc.GetLocalizedString("en", "I have taken 100 actions to defeat animal extinction", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetDefeatAnimalExtinctionInfoForUserBadgesPage();
            Assert.Equal(DefeatAnimalExtinctionInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDefeatDeforestationInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string DefeatDeforestationInfo = _loc.GetLocalizedString("en", "I have taken 100 actions to defeat deforestation", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetDefeatDeforestationInfoForUserBadgesPage();
            Assert.Equal(DefeatDeforestationInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeeplyCareInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string DeeplyCareInfo = _loc.GetLocalizedString("en", "I have offset my carbon for 1 year (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetDeeplyCareInfoForUserBadgesPage();
            Assert.Equal(DeeplyCareInfo, ReturnedNameKeyValue);

        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCommunicatingForDifferenceInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string CommunicatingForDifferenceInfo = _loc.GetLocalizedString("en", "I posted 5 articles on GatheringForGood to help promote change and make a difference (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetCommunicatingForDifferenceInfoForUserBadgesPage();
            Assert.Equal(CommunicatingForDifferenceInfo, ReturnedNameKeyValue);

        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContributorForGoodInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string ContributorForGoodInfo = _loc.GetLocalizedString("en", "I have commented on at least 1 newsfeed post (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetContributorForGoodInfoForUserBadgesPage();
            Assert.Equal(ContributorForGoodInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFeedbackHeroInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string FeedbackHeroInfo = _loc.GetLocalizedString("en", "I have submitted at least 5 suggestions for improvements to the Gathering For Good website (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetFeedbackHeroInfoForUserBadgesPage();
            Assert.Equal(FeedbackHeroInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHelpfulInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string HelpfulInfo = _loc.GetLocalizedString("en", "Gifted by another user in return for being helpful (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetHelpfulInfoForUserBadgesPage();
            Assert.Equal(HelpfulInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLeaderInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string LeaderInfo = _loc.GetLocalizedString("en", "Gifted by another user in return for showing leadership for good (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetLeaderInfoForUserBadgesPage();
            Assert.Equal(LeaderInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceVisionaryInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string VisionaryInfo = _loc.GetLocalizedString("en", "Gifted by another user in return for being a visionary in your actions for good (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetVisionaryInfoForUserBadgesPage();
            Assert.Equal(VisionaryInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceThankyouInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string ThankyouInfo = _loc.GetLocalizedString("en", "Gifted by another user to say thank you (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetThankyouInfoForUserBadgesPage();
            Assert.Equal(ThankyouInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLearningForGoodInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string LearningForGoodInfo = _loc.GetLocalizedString("en", "I have read 10 articles on GatheringForGood (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetLearningForGoodInfoForUserBadgesPage();
            Assert.Equal(LearningForGoodInfo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMakingADifferenceInfoNameReferenceForUserBadgesPageIsCorrect()
        {
            string MakingADifferenceInfo = _loc.GetLocalizedString("en", "Created my 1st initiative for good to change the world and make a difference (Coming Soon)", null);
            var UserBadgesPageLocSourceNamesLibrary = new UserBadgesPageLocSourceNames();
            string ReturnedNameKeyValue = UserBadgesPageLocSourceNamesLibrary.GetMakingADifferenceInfoForUserBadgesPage();
            Assert.Equal(MakingADifferenceInfo, ReturnedNameKeyValue);
        }
    }
}