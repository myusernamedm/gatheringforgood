using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestReduceDeforestationPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestReduceDeforestationPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Reduce Deforestation", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string PageTitle = _loc.GetLocalizedString("en", "How You Can Make A Difference Today", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(PageTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitle1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string PageSubTitle = _loc.GetLocalizedString("en", "Reduce Deforestation", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(PageSubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDoSomethingTodayTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string DoSomethingTodayTitle = _loc.GetLocalizedString("en", "Do Something Today to Reduce Deforestation", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceDoSomethingTodayTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(DoSomethingTodayTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDoSomethingTodayParaNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string DoSomethingTodayPara = _loc.GetLocalizedString("en", "Time is running out but there are lots of things you can do to help.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceDoSomethingTodayParaNameReferenceForReduceDeforestationPage();
            Assert.Equal(DoSomethingTodayPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDoSomethingTodayPara2NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string DoSomethingTodayPara = _loc.GetLocalizedString("en", "By using GatheringForGood to share your actions across social media, you can encourage others to take action too. You can make a difference!", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceDoSomethingTodayPara2NameReferenceForReduceDeforestationPage();
            Assert.Equal(DoSomethingTodayPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWhatCanIDoNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string WhatCanIDo = _loc.GetLocalizedString("en", "What Can I Do?", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatCanIDoNameReferenceForReduceDeforestationPage();
            Assert.Equal(WhatCanIDo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceInformationNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string Information = _loc.GetLocalizedString("en", "Information", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceInformationNameReferenceForReduceDeforestationPage();
            Assert.Equal(Information, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceImpactNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string Impact = _loc.GetLocalizedString("en", "Impact (5 = Greatest Benefit)", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceImpactNameReferenceForReduceDeforestationPage();
            Assert.Equal(Impact, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDidThisTodayNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string DidThisToday = _loc.GetLocalizedString("en", "I Did This Today (Click/Tap)", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceDidThisTodayNameReferenceForReduceDeforestationPage();
            Assert.Equal(DidThisToday, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReduceMeatIntakeTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string ReduceMeatIntakeTitle = _loc.GetLocalizedString("en", "Reduce your intake of beef, pork, lamb and chicken", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(ReduceMeatIntakeTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReduceMeatIntakePara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string ReduceMeatIntakePara1 = _loc.GetLocalizedString("en", "The single biggest impact you can have is again by simply eating less meat. The United Nations Food & Agriculture Organisation has said that land conversaion for large-scale agriculture is the leading cause of tropical deforestation. Palm oil is used in everything from toothpaste to construction, but the creation of palm oil plantations involves slashing and burning rain forests and killing large amounts of wildlife.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakePara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(ReduceMeatIntakePara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReduceMeatIntakePara2NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string ReduceMeatIntakePara2 = _loc.GetLocalizedString("en", "Nearly 70,000 acres of tropical rainforest are lost every day. Vast amounts of palm oil produced globally are used in animal feed. But this is completely unnecessary as research has shown that chickens fed on a diet of mealworm grew just as well and demonstrated improved meat quality.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakePara2NameReferenceForReduceDeforestationPage();
            Assert.Equal(ReduceMeatIntakePara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDonateTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string DonateTitle = _loc.GetLocalizedString("en", "Donate to a Forestry Trust", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceDonateTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(DonateTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDonatePara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string DonatePara1 = _loc.GetLocalizedString("en", "Forestry trusts and charities protect millions of acres of forests across the globe every year, but this work costs money. You can help by donating to one of the many worthwhile charities identifiable online.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceDonatePara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(DonatePara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSocialMediaTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string SocialMediaTitle = _loc.GetLocalizedString("en", "Follow on Social Media", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSocialMediaTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(SocialMediaTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSocialMediaPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string SocialMediaPara1 = _loc.GetLocalizedString("en", "Social media can be a powerful way for charities and trusts to reach members of the public and spread awareness of threats to forests globally. Liking, Sharing and Following on social media is a painless, almost effort-free way to help spread the word.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSocialMediaPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(SocialMediaPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSupportHabitatRestorationTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string SupportHabitatRestorationTitle = _loc.GetLocalizedString("en", "Support Habitat Restoration", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSupportHabitatRestorationTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(SupportHabitatRestorationTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSupportHabitatRestorationPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string SupportHabitatRestorationPara1 = _loc.GetLocalizedString("en", "Support the restoration of forests and habitat which has already suffered from deforestation. Research has shown that persistence times for animal species can be increased by a factor of 56, if we regenerate forests between the largest and closest segments of remaining forest cover.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSupportHabitatRestorationPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(SupportHabitatRestorationPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSupportHabitatRestorationPara2NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string SupportHabitatRestorationPara2 = _loc.GetLocalizedString("en", "You can make a difference by planting trees locally or supporting habitat restoration projects in some of the most diverse and threatened places on the planet.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSupportHabitatRestorationPara2NameReferenceForReduceDeforestationPage();
            Assert.Equal(SupportHabitatRestorationPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantSomeTreesTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string PlantSomeTreesTitle = _loc.GetLocalizedString("en", "Plant Some Trees", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourcePlantSomeTreesTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(PlantSomeTreesTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantSomeTreesPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string PlantSomeTreesPara1 = _loc.GetLocalizedString("en", "Trees suck CO2 out of the atmosphere and sequester it in the soil. They also facilitate 40% of the worlds rainfall through the small water cycle, reducing desertification.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourcePlantSomeTreesPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(PlantSomeTreesPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantSomeTreesPara2NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string PlantSomeTreesPara2 = _loc.GetLocalizedString("en", "A planet covered in plants is a healthy planet!", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourcePlantSomeTreesPara2NameReferenceForReduceDeforestationPage();
            Assert.Equal(PlantSomeTreesPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoPaperlessTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string GoPaperlessTitle = _loc.GetLocalizedString("en", "Go Paperless", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceGoPaperlessTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(GoPaperlessTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoPaperlessPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string GoPaperlessPara1 = _loc.GetLocalizedString("en", "Reduce or eliminate your use of paper-based products at home and in work. Simple steps like setting up dual monitors, enforcing print policies, reducing print margins and font sizes, or using automated electronic backups can add up to a big difference over time.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceGoPaperlessPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(GoPaperlessPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEatOrganicTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string EatOrganicTitle = _loc.GetLocalizedString("en", "Eat Organic", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceEatOrganicTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(EatOrganicTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEatOrganicPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string EatOrganicPara1 = _loc.GetLocalizedString("en", "Make informed food choices. Commercial factory-style farming intensifies climate change through soil desertification, fossil fuel energy input, creating marine dead zones, deforestation and more. Organic farming sequesters carbon in the soil where it belongs, eliminates periods where the land has no plant cover and it reduces fossil fuel transport and energy use.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceEatOrganicPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(EatOrganicPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceZeroDeforestationTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string ZeroDeforestationTitle = _loc.GetLocalizedString("en", "Zero Deforestation Policies", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceZeroDeforestationTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(ZeroDeforestationTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceZeroDeforestationPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string ZeroDeforestationPara1 = _loc.GetLocalizedString("en", "Businesses and commerical organisations can make a difference by implementing 'zero deforestation' policies for their supply chains. Maximise the use of recycled wood, paper and pulp; minimise the use of products which use palm oil; demand tranformation from their suppliers.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceZeroDeforestationPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(ZeroDeforestationPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBuyRecycledTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string BuyRecycledTitle = _loc.GetLocalizedString("en", "Buy Reusable or Recycled", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceBuyRecycledTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(BuyRecycledTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBuyRecycledPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string BuyRecycledPara1 = _loc.GetLocalizedString("en", "Reusable containers such as glass and stainless steel are vastly preferable to recyclable plastic, but recycled is better than single-use. Recycling lessens the need to extract new materias from the earth and protects ecosystems. Planting new trees cannot replace ancient or virgin woodland, and recycling paper and wood helps saves forests.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceBuyRecycledPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(BuyRecycledPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void GetLocSourceStandUpTitleNameReferenceForReduceDeforestationPage()
        {
            string StandUpTitle = _loc.GetLocalizedString("en", "Stand Up and Get Involved", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceStandUpTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(StandUpTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceStandUpPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string StandUpPara1 = _loc.GetLocalizedString("en", "While individual actions are needed and they help, for the world to avert the coming catastrophe we need to make change at a societal level. Contact your local and national representatives. Tell them you care about climate change. Tell them you care about positive measures, not punitive measures. Tell them you do not support measures such as biodiversity offsetting, the common agricultural policy or the common fisheries policies which support emptying the land and sea of natural habitat and resources.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceStandUpPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(StandUpPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVegetarianTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string GoVegetarianTitle = _loc.GetLocalizedString("en", "Go Vegetarian", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(GoVegetarianTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVegetarianPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string GoVegetarianPara1 = _loc.GetLocalizedString("en", "Stop eating farmed animals which were pastured using cleared wild habitat. The biggest difference you can make right now is to reduce your meat intake, as per the 1st item on our list. That alone will make a huge difference, but if you feel you can eliminate meat from your diet entirely, obviously the impact will be even greater.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceGoVegetarianPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(GoVegetarianPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVeganTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string GoVeganTitle = _loc.GetLocalizedString("en", "Go Vegan", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(GoVeganTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVeganPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string GoVeganPara1 = _loc.GetLocalizedString("en", "Animal agriculture accounts for a staggering 75% of global deforestation. If you want to have a bigger impact than vegetarianism, go vegan.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceGoVeganPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(GoVeganPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSignAPetitionTitleNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string SignAPetitionTitle = _loc.GetLocalizedString("en", "Sign A Petition", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceDeforestationPage();
            Assert.Equal(SignAPetitionTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSignAPetitionPara1NameReferenceForReduceDeforestationPageIsCorrect()
        {
            string SignAPetitionPara1 = _loc.GetLocalizedString("en", "Create or join a petition to support giving more space over to wildlife as protected areas. Support efforts to ensure that protected areas are properly protected. Make your voice heard. Every tiny step helps.", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSignAPetitionPara1NameReferenceForReduceDeforestationPage();
            Assert.Equal(SignAPetitionPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceComingSoonNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string ComingSoon = _loc.GetLocalizedString("en", "Coming Soon!", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
            Assert.Equal(ComingSoon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPageIsCorrect()
        {
            string WhatDidYouExpectPara = _loc.GetLocalizedString("en", "What did you expect to see here?", null);
            var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
            Assert.Equal(WhatDidYouExpectPara, ReturnedNameKeyValue);
        }
    }
}
