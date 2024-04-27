using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestReduceGlobalWarmingPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestReduceGlobalWarmingPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Reduce Global Warming", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string PageTitle = _loc.GetLocalizedString("en", "How You Can Make A Difference Today", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(PageTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitle1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string PageSubTitle = _loc.GetLocalizedString("en", "Reduce Global Warming", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(PageSubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDoSomethingTodayTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string DoSomethingTodayTitle = _loc.GetLocalizedString("en", "Do Something Today to Reduce Global Warming", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceDoSomethingTodayTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(DoSomethingTodayTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDoSomethingTodayParaNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string DoSomethingTodayPara = _loc.GetLocalizedString("en", "Time is running out but there are lots of things you can do to help.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceDoSomethingTodayParaNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(DoSomethingTodayPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDoSomethingTodayPara2NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string DoSomethingTodayPara = _loc.GetLocalizedString("en", "By using GatheringForGood to share your actions across social media, you can encourage others to take action too. You can make a difference!", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceDoSomethingTodayPara2NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(DoSomethingTodayPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWhatCanIDoNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string WhatCanIDo = _loc.GetLocalizedString("en", "What Can I Do?", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatCanIDoNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(WhatCanIDo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceInformationNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string Information = _loc.GetLocalizedString("en", "Information", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceInformationNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(Information, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceImpactNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string Impact = _loc.GetLocalizedString("en", "Impact (5 = Greatest Benefit)", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceImpactNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(Impact, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDidThisTodayNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string DidThisToday = _loc.GetLocalizedString("en", "I Did This Today (Click/Tap)", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceDidThisTodayNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(DidThisToday, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReduceMeatIntakeTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string ReduceMeatIntakeTitle = _loc.GetLocalizedString("en", "Reduce your intake of fish, beef, pork, lamb and chicken", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(ReduceMeatIntakeTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReduceMeatIntakePara2NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string ReduceMeatIntakePara2 = _loc.GetLocalizedString("en", "Whales and Dolphins fertilise phytoplankton which absorbs 4 times more CO2 than the amazon each year, but are being hunted and killed by fishing gear. A single cow emits up to 500 litres of methane per day by burping; a gas which is 25 times more effective at trapping heat than CO2. Livestock farming produces 37% and 65% of our global methane and nitrous oxide emissions respectively. Cattle are also responsible for putting over 3 Gigatonnes of CO2 into the atmosphere each year.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakePara2NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(ReduceMeatIntakePara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantSomeTreesTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string PlantSomeTreesTitle = _loc.GetLocalizedString("en", "Plant Some Trees", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourcePlantSomeTreesTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(PlantSomeTreesTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantSomeTreesPara2NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string PlantSomeTreesPara2 = _loc.GetLocalizedString("en", "Trees suck CO2 out of the atmosphere and sequester it in the soil. They also facilitate 40% of the worlds rainfall through the small water cycle, reducing desertification.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourcePlantSomeTreesPara2NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(PlantSomeTreesPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantSomeTreesPara3NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string PlantSomeTreesPara3 = _loc.GetLocalizedString("en", "A planet covered in plants is a healthy planet!", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourcePlantSomeTreesPara3NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(PlantSomeTreesPara3, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEatOrganicTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string LocSourceEatOrganicTitle = _loc.GetLocalizedString("en", "Eat Organic", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceEatOrganicTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(LocSourceEatOrganicTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEatOrganicPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string LocSourceEatOrganicPara1 = _loc.GetLocalizedString("en", "Commercial factory-style farming intensifies climate change through soil desertification, fossil fuel energy input, creating marine dead zones, deforestation and more. Organic farming sequesters carbon in the soil where it belongs, eliminates periods where the land has no plant cover and it reduces fossil fuel transport and energy use.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceEatOrganicPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(LocSourceEatOrganicPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVegetarianTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string GoVegetarianTitle = _loc.GetLocalizedString("en", "Go Vegetarian", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(GoVegetarianTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVegetarianPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string GoVegetarianPara1 = _loc.GetLocalizedString("en", "The biggest difference you can make right now is to reduce your meat & fish intake, as per the 1st item on our list. That alone will make a huge difference, but if you feel you can eliminate meat and fish from your diet entirely, obviously the impact will be even greater.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceGoVegetarianPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(GoVegetarianPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVeganTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string GoVeganTitle = _loc.GetLocalizedString("en", "Go Vegan", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(GoVeganTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVeganPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string GoVeganPara1 = _loc.GetLocalizedString("en", "A study conducted by the Oxford University in the United Kingdom, indicates that 25% of all global greenhouse gas emissions are caused by food production, and 80% of that results from animals. If you want to have a bigger impact than vegetarianism, go vegan.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceGoVeganPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(GoVeganPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLiveCarFreeTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string LiveCarFreeTitle = _loc.GetLocalizedString("en", "Live Car Free", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceLiveCarFreeTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(LiveCarFreeTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLiveCarFreePara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string LiveCarFreePara1 = _loc.GetLocalizedString("en", "Passenger cars account for 60.7% of total CO2 emissions from road transport in Europe. Although not an option for everyone, especially outside cities, living car free can make a huge impact as a typical passenger vehicle emits about 4.6 metric tons of carbon dioxide per year.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceLiveCarFreePara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(LiveCarFreePara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGreenRecoveryTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string GreenRecoveryTitle = _loc.GetLocalizedString("en", "Support a 'Green Recovery' from Covid-19", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceGreenRecoveryTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(GreenRecoveryTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGreenRecoveryPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string GreenRecoveryPara1 = _loc.GetLocalizedString("en", "Tell your politicians that you want economic stimulus packages over coming years to focus on Green stimulus, low-carbon energy and energy efficiency. And that you want legislation which empowers employees to make their own decisions about when to travel to an office and when to work from home - cutting one day from an average commute can save almost 838lbs of carbon per year.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceGreenRecoveryPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(GreenRecoveryPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMinimisePlasticTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string MinimisePlasticTitle = _loc.GetLocalizedString("en", "Minimise Your Plastics Usage", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceMinimisePlasticTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(MinimisePlasticTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMinimisePlasticPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string MinimisePlasticPara1 = _loc.GetLocalizedString("en", "Globally 1 Trillion plastic bags are used every year. Plastic emits greenhouse gases in almost every phase of its life cycle. 1 Million plastic bottles are bought worldwide every minute. Avoid single-use plastic; bottled water; chewing gum; plastic cigarette lighters; bags; cutlery; straws; coffee cup lids; microbead products.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceMinimisePlasticPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(MinimisePlasticPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBuyLocalTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string BuyLocalTitle = _loc.GetLocalizedString("en", "Buy Local", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceBuyLocalTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(BuyLocalTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBuyLocalNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string BuyLocal = _loc.GetLocalizedString("en", "The food you eat travels on average more than 1500 miles to reach your plate. Buying locally grown produce reduces the amount of pollution your consumption is indirectly generating. A typical meal from a conventional supermarket chain, uses up to 17 times more petrol for transport than the same meal using local ingredients.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceBuyLocalNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(BuyLocal, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCycleTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string CycleTitle = _loc.GetLocalizedString("en", "Cycle", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceCycleTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(CycleTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceIncreaseCyclingPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string IncreaseCyclingPara1 = _loc.GetLocalizedString("en", "A 2015 study by the Institute for Transportation and Development Policy concluded that a dramatic increase (about 20 percent) in cycling worldwide could “cut carbon dioxide emissions from urban passenger transport by nearly 11 percent by 2050.”", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceIncreaseCyclingPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(IncreaseCyclingPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDriveElectricTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string DriveElectricTitle = _loc.GetLocalizedString("en", "Drive Electric", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceDriveElectricTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(DriveElectricTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDriveElectricPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string DriveElectricPara1 = _loc.GetLocalizedString("en", "The transport sector is the fastest-growing contributor to climate change; responsible for 14% of overall annual emissions and approximately 25% of fossil fuel emissions.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceDriveElectricPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(DriveElectricPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantYourOwnVegTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string PlantYourOwnVegTitle = _loc.GetLocalizedString("en", "Grow Your Own Vegetables", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourcePlantYourOwnVegTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(PlantYourOwnVegTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantYourOwnVegPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string PlantYourOwnVegPara1 = _loc.GetLocalizedString("en", "Buying local and buying organic are great. But if you want to step it up to the next level, grow your own vegetables. People grew their own food in their gardens for centuries. Its healthy, natural and will save the planet.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourcePlantYourOwnVegPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(PlantYourOwnVegPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSwitchToRenewableTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string SwitchToRenewableTitle = _loc.GetLocalizedString("en", "Switch to a Renewable Energy Provider", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceSwitchToRenewableTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(SwitchToRenewableTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSwitchToRenewablePara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string SwitchToRenewablePara1 = _loc.GetLocalizedString("en", "Switching to a renewable energy provider is one more way to contribute towards reducing climate change. Even better, many renewable providers globally now compete directly with old fossil fuel energy generators, meaning you can switch and also save money on your energy bills!", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceSwitchToRenewablePara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(SwitchToRenewablePara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUsePublicTransportTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string UsePublicTransportTitle = _loc.GetLocalizedString("en", "Use Public Transport", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceUsePublicTransportTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(UsePublicTransportTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceIncreasePublicTransportPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string IncreasePublicTransportPara1 = _loc.GetLocalizedString("en", "Reducing carbon intensity in the transport sector requires a shift from over reliance on the car to more sustainable transport options. But such a shift requires comprehensive public transport networks to be put in place.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceIncreasePublicTransportPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(IncreasePublicTransportPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceIncreasePublicTransportPara2NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string IncreasePublicTransportPara2 = _loc.GetLocalizedString("en", "Gradually and steadily increase your use of public transport. Where networks are not available, speak up, contact your public representatives.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceIncreasePublicTransportPara2NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(IncreasePublicTransportPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCarpoolTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string CarpoolTitle = _loc.GetLocalizedString("en", "Carpool With Colleagues and Neighbours", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceCarpoolTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(CarpoolTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceIncreaseCarpoolingPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string IncreaseCarpoolingPara1 = _loc.GetLocalizedString("en", "On average, sharing a ride with one other person to work and back will reduce greenhouse gas emissions by 3.72 kilograms. If you were to share a ride all year long, together you would reduce greenhouse gas emissions by approximately 893 kilograms.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceIncreaseCarpoolingPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(IncreaseCarpoolingPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFlyLessOftenTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string FlyLessOftenTitle = _loc.GetLocalizedString("en", "Fly Less Often", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceFlyLessOftenTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(FlyLessOftenTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFlyLessOftenPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string FlyLessOftenPara1 = _loc.GetLocalizedString("en", "Around 2.4% of global CO2 emissions come from air travel. When this is combined with other gas emissions and water vapour trails from aircraft, aviation is responsible for around 5% of global warming. A very significant percentage when we consider that just 3% of the global population take regular flights.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceFlyLessOftenPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(FlyLessOftenPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceStandUpTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string StandUpTitle = _loc.GetLocalizedString("en", "Stand Up and Get Involved", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceStandUpNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(StandUpTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceStandUpPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string StandUpPara1 = _loc.GetLocalizedString("en", "While individual actions are needed and they help, for the world to avert the coming catastrophe we need to make change at a societal level. Unfortunately, politicians are often incapable of thinking beyond punitive measures. Contact your local and national representatives. Tell them you care about climate change. Tell them you care about positive measures, not punitive measures.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceStandUpPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(StandUpPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUseABlueRecyclingBinTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string UseABlueRecyclingBinTitle = _loc.GetLocalizedString("en", "Use a Recycling Bin", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceUseABlueRecyclingBinTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(UseABlueRecyclingBinTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUseABlueRecyclingBinPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string UseABlueRecyclingBinPara1 = _loc.GetLocalizedString("en", "Almost every plastic is produced from fossil fuels. Every single item of plastic which is recycled reduces greenhouse gas emissions.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceUseABlueRecyclingBinPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(UseABlueRecyclingBinPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUseABrownCompostBinTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string UseABrownCompostBinTitle = _loc.GetLocalizedString("en", "Use a Compost Bin", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceUseABrownCompostBinTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(UseABrownCompostBinTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUseABrownCompostBinPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string UseABrownCompostBinPara1 = _loc.GetLocalizedString("en", "Globally we throw away approx. 1.3 billion tons of food per year. Over 51% of the waste that goes to landfill is compostable. 3.3 billion metric tons of CO2 are released each year from the production, harvesting, transport and packaging of wasted food.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceUseABrownCompostBinPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(UseABrownCompostBinPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceInsulateYourHouseTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string InsulateYourHouseTitle = _loc.GetLocalizedString("en", "Improve Your Home Insulation", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceInsulateYourHouseTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(InsulateYourHouseTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceInsulateYourHousePara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string InsulateYourHousePara1 = _loc.GetLocalizedString("en", "If insulation were to be installed in 4 million homes, the equivalent amount of carbon dioxide that would be removed from the atmosphere would be equal to “planting 667 million acres of trees”. Many countries and states offer incentives schemes so you can improve the insulation in your home at reduced or no cost.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceInsulateYourHousePara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(InsulateYourHousePara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceShorterShowersNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string ShorterShowers = _loc.GetLocalizedString("en", "Take Shorter Showers", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceShorterShowersNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(ShorterShowers, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceShorterShowersPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string ShorterShowersPara1 = _loc.GetLocalizedString("en", "An average shower consumes 15 liters of water per minute and it takes energy to heat that water. You can take cold showers to help the planet, but you will freeze, so the next best alternative is to heat less water by timing your showers and setting an alarm to reduce your shower time. It also takes energy to clean and pump each liter of water to your home, all of which can generate CO2.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceShorterShowersPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(ShorterShowersPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFluorescentLightbulbsNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string FluorescentLightbulbs = _loc.GetLocalizedString("en", "Switch to Fluorescent Lightbulbs", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceFluorescentLightbulbsNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(FluorescentLightbulbs, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFluorescentLightbulbsPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string FluorescentLightbulbsPara1 = _loc.GetLocalizedString("en", "Fluorescent Lightbulbs use approximately 75% less energy than a normal lightbulb, and last up to 15 times longer. So they can help save the planet while also saving you money. But dont forget to turn them off if you are leaving the room for longer than 15 minutes.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceFluorescentLightbulbsPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(FluorescentLightbulbsPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTurnOffLightsNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string TurnOffLights = _loc.GetLocalizedString("en", "Turn off the Lights When You Leave a Room", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceTurnOffLightsNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(TurnOffLights, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTurnOffLightsPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string TurnOffLightsPara1 = _loc.GetLocalizedString("en", "Approximately 0.69 kilograms of carbon dioxide are generated per kilowatt hour of electricity consumed. In countries with high-carbon electricity grids, this can be higher. Turning off lights and appliances in your home when you dont need them, helps reduce the requirement for electricity generation and hence your carbon footprint.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceTurnOffLightsPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(TurnOffLightsPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSignAPetitionTitleNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string SignAPetitionTitle = _loc.GetLocalizedString("en", "Sign A Petition", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(SignAPetitionTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSignAPetitionPara1NameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string SignAPetitionPara1 = _loc.GetLocalizedString("en", "There are many climate change petitions online and it involves very little energy to search for them and sign them. Make your voice heard with almost no effort on your part. Every tiny step helps.", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceSignAPetitionPara1NameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(SignAPetitionPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceComingSoonNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string ComingSoon = _loc.GetLocalizedString("en", "Coming Soon!", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(ComingSoon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPageIsCorrect()
        {
            string WhatDidYouExpectPara = _loc.GetLocalizedString("en", "What did you expect to see here?", null);
            var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
            Assert.Equal(WhatDidYouExpectPara, ReturnedNameKeyValue);
        }
    }
}

