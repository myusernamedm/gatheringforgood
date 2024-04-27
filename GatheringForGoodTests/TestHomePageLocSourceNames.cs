using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using URLStringsReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestHomePageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestHomePageLocSourceNames()
        {
            var ci = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.LCID);
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = ci;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = ci;
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForHomePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Change The World", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForHomePage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForHomePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "The place where ideas and expertise come together to solve the world's problems", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForHomePage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitle1NameReferenceForHomePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Collaborate on-site or across the world like never before", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceSubtitle1NameReferenceForHomePage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitle2NameReferenceForHomePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Harness ideas and talent to change the world in record time", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceSubtitle2NameReferenceForHomePage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGreatestChallengeTitleNameReferenceForHomePageIsCorrect()
        {
            string GreatestChallengeTitle = _loc.GetLocalizedString("en", "The Worlds Greatest Challenge", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceGreatestChallengeTitleLabelNameReference();
            Assert.Equal(GreatestChallengeTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGreatestChallengeParaNameReferenceForHomePageIsCorrect()
        {
            string GreatestChallengePara = _loc.GetLocalizedString("en", "The Greatest Challenge facing our planet in the last 66 million years (Since the last great extinction), is the exponential rise of greenhouse gases in our atmosphere. A 1.5°C increase will cause the climate impacts we already see on the news to go from bad - to terrifying! Across our planet many areas are already exceeding the 1.5°C threshold. But its getting worse fast - The clock is ticking!", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceGreatestChallengeParaLabelNameReference();
            Assert.Equal(GreatestChallengePara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNewsfeedIconNameReferenceForHomePageIsCorrect()
        {
            string NewsfeedIcon = _loc.GetLocalizedString("en", "Collaborate on Newsfeed", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceNewsfeedIconNameReferenceForHomePage();
            Assert.Equal(NewsfeedIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOffsetIconNameReferenceForHomePageIsCorrect()
        {
            string OffsetIcon = _loc.GetLocalizedString("en", "Offset My Carbon", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceOffsetIconNameReferenceForHomePage();
            Assert.Equal(OffsetIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBlogIconNameReferenceForHomePageIsCorrect()
        {
            string ArticlesIcon = _loc.GetLocalizedString("en", "View Article", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceArticleIconNameReferenceForHomePage();
            Assert.Equal(ArticlesIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTrackImpactIconNameReferenceForHomePageIsCorrect()
        {
            string TrackImpactIcon = _loc.GetLocalizedString("en", "Track My Impacts", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceTrackImpactIconNameReferenceForHomePage();
            Assert.Equal(TrackImpactIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAgileInitiativeIconNameReferenceForHomePageIsCorrect()
        {
            string AgileInitiativeIcon = _loc.GetLocalizedString("en", "Create an Agile Initiative", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceAgileInitiativeIconNameReferenceForHomePage();
            Assert.Equal(AgileInitiativeIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCarbonClockTitleNameReferenceForHomePageIsCorrect()
        {
            string CarbonClockTitle = _loc.GetLocalizedString("en", "The Carbon Clock", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceCarbonClockTitleLabelNameReference();
            Assert.Equal(CarbonClockTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCarbonClockPara1NameReferenceForHomePageIsCorrect()
        {
            string CarbonClockPara1 = _loc.GetLocalizedString("en", "The Mercator Institute Carbon Clock calculates how much of the worlds CO2 budget remains before the average temperature increase of the planet exceeds 1.5°C and 2.0°C respectively.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceCarbonClockPara1LabelNameReference();
            Assert.Equal(CarbonClockPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCarbonClockPara2NameReferenceForHomePageIsCorrect()
        {
            string CarbonClockPara2 = _loc.GetLocalizedString("en", "This is the time remaining before we as human beings, cause never before seen' damage to our planet. The time before we cause irreversible damage to our only home.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceCarbonClockPara2LabelNameReference();
            Assert.Equal(CarbonClockPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceExtinctionClockTitleLabelNameReferenceForHomePageIsCorrect()
        {
            string ExtinctionClockTitle = _loc.GetLocalizedString("en", "The Extinction Clock", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceExtinctionClockTitleLabelNameReference();
            Assert.Equal(ExtinctionClockTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceExtinctionClockPara1NameReferenceForHomePageIsCorrect()
        {
            string ExtinctionClockPara1 = _loc.GetLocalizedString("en", "The Extinction Clock was created by GatheringForGood, to highlight the desperate plight of wild animal life on our planet. Those of us born before the year 2000 were incredibly lucky, because for children being born now and in the next hundred years, many animal species will already be lost.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceExtinctionClockPara1LabelNameReference();
            Assert.Equal(ExtinctionClockPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceExtinctionClockPara2NameReferenceForHomePageIsCorrect()
        {
            string ExtinctionClockPara2 = _loc.GetLocalizedString("en", "Considering the acceleration in threats to nature over the past decade, the extinction rate is potentially higher than our clock indicates. Additionally, as more species go extinct, the loss rate is likely to increase exponentially. Our planet is facing the 6th mass extinction event, but this event has been caused by humans; caused by you and I. Animals are suffering from climate change; habitat loss; ocean warming and many other human-generated threats.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceExtinctionClockPara2LabelNameReference();
            Assert.Equal(ExtinctionClockPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCarbonClockLearnMoreLAbelNameReferenceForHomePageIsCorrect()
        {
            string CarbonClockLearnMore = _loc.GetLocalizedString("en", "Learn more.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceCarbonClockLearnMoreLabelNameReference();
            Assert.Equal(CarbonClockLearnMore, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceExtinctionClockLearnMoreLAbelNameReferenceForHomePageIsCorrect()
        {
            string ExtinctionClockLearnMore = _loc.GetLocalizedString("en", "Learn more.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceExtinctionClockLearnMoreLabelNameReference();
            Assert.Equal(ExtinctionClockLearnMore, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceForestClockLearnMoreLAbelNameReferenceForHomePageIsCorrect()
        {
            string ForestClockLearnMore = _loc.GetLocalizedString("en", "Learn more.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceForestClockLearnMoreLabelNameReference();
            Assert.Equal(ForestClockLearnMore, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTimeUntilTitleNameReferenceForHomePageIsCorrect()
        {
            string TimeUntilTitle = _loc.GetLocalizedString("en", "Time Until", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceTimeUntilTitleNameReference();
            Assert.Equal(TimeUntilTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOneHalfDegreeDepletedTitleNameReferenceForHomePageIsCorrect()
        {
            string OneHalfDegreeDepletedTitle = _loc.GetLocalizedString("en", "1.5°C CO2 Budget Depleted", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceOneHalfDegreeDepletedTitleNameReference();
            Assert.Equal(OneHalfDegreeDepletedTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTwoDegreeDepletedTitleNameReferenceForHomePageIsCorrect()
        {
            string TwoDegreeDepletedTitle = _loc.GetLocalizedString("en", "2.0°C CO2 Budget Depleted", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceTwoDegreeDepletedTitleNameReference();
            Assert.Equal(TwoDegreeDepletedTitle, ReturnedNameKeyValue);
        }





        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceForestClockTitleNameReferenceForHomePageIsCorrect()
        {
            string ForestClockTitle = _loc.GetLocalizedString("en", "The Forest Clock", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceForestClockTitleLabelNameReference();
            Assert.Equal(ForestClockTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceForestClockPara1NameReferenceForHomePageIsCorrect()
        {
            string ForestClockPara1 = _loc.GetLocalizedString("en", "The Forest Clock was created by GatheringForGood, to highlight the desperate plight of trees and forests on our planet. Forests are not only critical to consume carbon dioxide and produce oxygen, but they provide a cooling effect for the atmosphere and a habitat for countless animal species.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceForestClockPara1LabelNameReference();
            Assert.Equal(ForestClockPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceForestClockPara2NameReferenceForHomePageIsCorrect()
        {
            string ForestClockPara2 = _loc.GetLocalizedString("en", "At the current rate, all forests on the planet will be gone in a few hundred years. A staggering statistic when forests have covered our planet for hundreds of millions of years. Without forests the earth will be uninhabitable. Humans will not survive as a species to see all of the forests disappear.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceForestClockPara2LabelNameReference();
            Assert.Equal(ForestClockPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceForestClockLearnMoreNameReferenceForHomePageIsCorrect()
        {
            string ForestClockLearnMore = _loc.GetLocalizedString("en", "Learn more.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceForestClockLearnMoreLabelNameReference();
            Assert.Equal(ForestClockLearnMore, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceExtinctionsSinceTitleNameReferenceForHomePageIsCorrect()
        {
            string ExtinctionsSinceTitle = _loc.GetLocalizedString("en", "Extinctions Since", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceExtinctionsSinceTitleNameReference();
            Assert.Equal(ExtinctionsSinceTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAllForestLostTitleNameReferenceForHomePageIsCorrect()
        {
            string AllForestLostTitle = _loc.GetLocalizedString("en", "All Forests Have Been Lost", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceAllForestLostTitleNameReference();
            Assert.Equal(AllForestLostTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceForestLostSinceTitleNameReferenceForHomePageIsCorrect()
        {
            string ForestLostSinceTitle = _loc.GetLocalizedString("en", "Forest Lost Since", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceForestLostSinceTitleNameReference();
            Assert.Equal(ForestLostSinceTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMostSpeciesLostTitleNameReferenceForHomePageIsCorrect()
        {
            string MostSpeciesLostTitle = _loc.GetLocalizedString("en", "All Species Have Gone Extinct", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceMostSpeciesLostTitleNameReference();
            Assert.Equal(MostSpeciesLostTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGFGLaunchedTitleNameReferenceForHomePageIsCorrect()
        {
            string GFGLaunchedTitle = _loc.GetLocalizedString("en", "GatheringForGood Launched", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceGFGLaunchedTitleNameReference();
            Assert.Equal(GFGLaunchedTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNewsfeedCardTitleNameReferenceForHomePageIsCorrect()
        {
            string NewsfeedCardTitle = _loc.GetLocalizedString("en", "Newsfeed", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceNewsfeedCardTitleNameReference();
            Assert.Equal(NewsfeedCardTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNewsfeedCardContentNameReferenceForHomePageIsCorrect()
        {
            string NewsfeedCardContent = _loc.GetLocalizedString("en", "View and share insights. Engage with other members to contribute knowledge and expertise. Keep up to date about progress being made to save the world.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceNewsfeedCardContentNameReference();
            Assert.Equal(NewsfeedCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYourCausesCardTitleNameReferenceForHomePageIsCorrect()
        {
            string YourCausesCardTitle = _loc.GetLocalizedString("en", "Your Cause or Initiative", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceYourCauseCardTitleNameReference();
            Assert.Equal(YourCausesCardTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYourCausesCardContentNameReferenceForHomePageIsCorrect()
        {
            string YourCausesCardContent = _loc.GetLocalizedString("en", "Be the change you want to see. Create new causes and initiatives (From Local to Global) to help Change the World. Access the tools you need to promote and manage your cause; get the word out; reach the people you need to reach.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceYourCauseCardContentNameReference();
            Assert.Equal(YourCausesCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRallyForGoodCardTitleNameReferenceForHomePageIsCorrect()
        {
            string RallyForGoodTitle = _loc.GetLocalizedString("en", "Rally For Good", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceRallyForGoodCardTitleNameReference();
            Assert.Equal(RallyForGoodTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRallyForGoodCardContentNameReferenceForHomePageIsCorrect()
        {
            string RallyForGoodCardContent = _loc.GetLocalizedString("en", "Rally behind good causes and initiatives. Support and help others to make a positive difference.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceRallyForGoodCardContentNameReference();
            Assert.Equal(RallyForGoodCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBlogCardTitleNameReferenceForHomePageIsCorrect()
        {
            string BlogTitle = _loc.GetLocalizedString("en", "Articles for Good", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceArticleCardTitleNameReference();
            Assert.Equal(BlogTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBlogCardContentNameReferenceForHomePageIsCorrect()
        {
            string BlogCardContent = _loc.GetLocalizedString("en", "The latest interesting stories from around the world about progress being made to save our planet. A leader in your field?...become a contributor!", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceArticleCardContentNameReference();
            Assert.Equal(BlogCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCommunityCardTitleNameReferenceForHomePageIsCorrect()
        {
            string CommunityTitle = _loc.GetLocalizedString("en", "Community", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceCommunityCardTitleNameReference();
            Assert.Equal(CommunityTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCommunityCardContentNameReferenceForHomePageIsCorrect()
        {
            string CommunityCardContent = _loc.GetLocalizedString("en", "Build your real-world local communities online presence, to schedule and manage local meetups and initiatives to save the planet. Build and join global online communities to harness shared passion for good causes.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceCommunityCardContentNameReference();
            Assert.Equal(CommunityCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEventsCardTitleNameReferenceForHomePageIsCorrect()
        {
            string EventsTitle = _loc.GetLocalizedString("en", "Events", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceEventsCardTitleNameReference();
            Assert.Equal(EventsTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEventsCardContentNameReferenceForHomePageIsCorrect()
        {
            string EventsCardContent = _loc.GetLocalizedString("en", "Schedule and promote Events for Good. Build a buzz for small local events or large national events. Communicate with attendees before the big day and manage tickets online.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceEventsCardContentNameReference();
            Assert.Equal(EventsCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFundraiseCardTitleNameReferenceForHomePageIsCorrect()
        {
            string FundraiseTitle = _loc.GetLocalizedString("en", "Fundraise", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceFundraiseCardTitleNameReference();
            Assert.Equal(FundraiseTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFundraiseCardContentNameReferenceForHomePageIsCorrect()
        {
            string FundraiseCardContent = _loc.GetLocalizedString("en", "Fundraise and generate Donations for your cause or initiative to help make a tangible difference for good in the world.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceFundraiseCardContentNameReference();
            Assert.Equal(FundraiseCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEducationCardTitleNameReferenceForHomePageIsCorrect()
        {
            string EducationTitle = _loc.GetLocalizedString("en", "Education", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceEducationCardTitleNameReference();
            Assert.Equal(EducationTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEducationCardContentNameReferenceForHomePageIsCorrect()
        {
            string EducationCardContent = _loc.GetLocalizedString("en", "Create and manage environmental exercises and projects for your class or group. Students can share their progress and information in a safe, class-specific, ringfenced environment.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceEducationCardContentNameReference();
            Assert.Equal(EducationCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBusinessCardTitleNameReferenceForHomePageIsCorrect()
        {
            string BusinessTitle = _loc.GetLocalizedString("en", "Business", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceBusinessCardTitleNameReference();
            Assert.Equal(BusinessTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBusinessCardContentNameReferenceForHomePageIsCorrect()
        {
            string BusinessCardContent = _loc.GetLocalizedString("en", "Create a space online for your socially responsible business to market and sell your products, or simply promote your organisations green credentials.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceBusinessCardContentNameReference();
            Assert.Equal(BusinessCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAcademyCardTitleNameReferenceForHomePageIsCorrect()
        {
            string AcademyTitle = _loc.GetLocalizedString("en", "Academy", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceAcademyCardTitleNameReference();
            Assert.Equal(AcademyTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAcademyCardContentNameReferenceForHomePageIsCorrect()
        {
            string AcademyCardContent = _loc.GetLocalizedString("en", "Everything you need to know about the challenges facing our planet, grounded in real science, plus all the tools, techniques, courses, tricks and tips that can help you to save it.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceAcademyCardContentNameReference();
            Assert.Equal(AcademyCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAcademyJuniorCardTitleNameReferenceForHomePageIsCorrect()
        {
            string AcademyJuniorTitle = _loc.GetLocalizedString("en", "Academy Junior", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceAcademyJuniorCardTitleNameReference();
            Assert.Equal(AcademyJuniorTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAcademyJuniorCardContentNameReferenceForHomePageIsCorrect()
        {
            string AcademyJuniorCardContent = _loc.GetLocalizedString("en", "Information about the challenges facing our planet, grounded in real science, but specially formatted and structured to be fun and easy to understand for kids of all ages.", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetLocSourceAcademyJuniorCardContentNameReference();
            Assert.Equal(AcademyJuniorCardContent, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHowCanIHelpLabelNameReferenceForHomePageIsCorrect()
        {
            string HowCanIHelpLabel = _loc.GetLocalizedString("en", "How can I help?", null);
            var HomePageLocSourceNamesLibrary = new HomePageLocSourceNames();
            string ReturnedNameKeyValue = HomePageLocSourceNamesLibrary.GetHowCanIHelpLabelNameReferenceForHomePage();
            Assert.Equal(HowCanIHelpLabel, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUrlStringDownloadChromeUrlForHomePageIsCorrect()
        {
            string DownloadChromeUrl = _loc.GetLocalizedString("https://www.google.com/chrome/?brand=BNSD&gclid=CjwKCAjwjJmIBhA4EiwAQdCbxuGNWEWU-kGpW6cLFqYQqZGw0oiLgUWv5JW-VNe66rzrwS71u888ARoCWDEQAvD_BwE&gclsrc=aw.ds");
            var UrlStrings = new UrlStrings();
            string ReturnedNameKeyValue = UrlStrings.GetDownloadChromeUrl();
            Assert.Equal(DownloadChromeUrl, ReturnedNameKeyValue);
        }
    }
}
