using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestReduceAnimalExtinctionPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestReduceAnimalExtinctionPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Reduce Extinction Rates", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string PageTitle = _loc.GetLocalizedString("en", "How You Can Make A Difference Today", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(PageTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitle1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string PageSubTitle = _loc.GetLocalizedString("en", "Reduce Extinction Rates", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(PageSubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDoSomethingTodayTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string DoSomethingTodayTitle = _loc.GetLocalizedString("en", "Do Something Today to Reduce Extinction Rates", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceDoSomethingTodayTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(DoSomethingTodayTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDoSomethingTodayParaNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string DoSomethingTodayPara = _loc.GetLocalizedString("en", "Time is running out but there are lots of things you can do to help.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceDoSomethingTodayParaNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(DoSomethingTodayPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDoSomethingTodayPara2NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string DoSomethingTodayPara = _loc.GetLocalizedString("en", "By using GatheringForGood to share your actions across social media, you can encourage others to take action too. You can make a difference!", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceDoSomethingTodayPara2NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(DoSomethingTodayPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWhatCanIDoNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string WhatCanIDo = _loc.GetLocalizedString("en", "What Can I Do?", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatCanIDoNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(WhatCanIDo, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceInformationNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string Information = _loc.GetLocalizedString("en", "Information", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceInformationNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(Information, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceImpactNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string Impact = _loc.GetLocalizedString("en", "Impact (5 = Greatest Benefit)", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceImpactNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(Impact, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDidThisTodayNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string DidThisToday = _loc.GetLocalizedString("en", "I Did This Today (Click/Tap)", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceDidThisTodayNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(DidThisToday, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReduceMeatIntakeTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string ReduceMeatIntakeTitle = _loc.GetLocalizedString("en", "Reduce your intake of fish, beef, pork, lamb and chicken", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(ReduceMeatIntakeTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSixtyPercentLabelNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string SixtyPercentLabel = _loc.GetLocalizedString("en", "Nearly 50% of the great pacific garbage patch is commercial fishing gear. 60% of all living mammals are livestock.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSixtyPercentLabelNameReference();
            Assert.Equal(SixtyPercentLabel, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReduceMeatIntakePara2NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string ReduceMeatIntakePara2 = _loc.GetLocalizedString("en", "Whales and Dolphins fertilise phytoplankton which absorbs 4 times more CO2 than the amazon each year, but are being hunted and killed by fishing gear. A single cow emits up to 500 litres of methane per day by burping; a gas which is 25 times more effective at trapping heat than CO2. Livestock farming produces 37 % and 65 % of our global methane and nitrous oxide emissions respectively. Cattle are also responsible for putting over 3 Gigatonnes of CO2 into the atmosphere each year.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakePara2NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(ReduceMeatIntakePara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReducedFamilySizesTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string ReducedFamilySizesTitle = _loc.GetLocalizedString("en", "Support reduced family sizes", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceReducedFamilySizesTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(ReducedFamilySizesTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReducedFamilySizesPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string ReducedFamilySizes = _loc.GetLocalizedString("en", "Just two generations of humans have placed demands on our planet which have killed off more than half the worlds wildlife. We must choose to have smaller families.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceReducedFamilySizesPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(ReducedFamilySizes, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReducedFamilySizesPara2NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string ReducedFamilySizesPara2 = _loc.GetLocalizedString("en", "Unsustainable population growth and weak national family planning policies focus on what adults want today, at the expense of what children will need tomorrow. Humans are demanding more from the natural world than the planet can sustain. Support the drive for a smaller family model.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceReducedFamilySizesPara2NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(ReducedFamilySizesPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWildlifeRefugeTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string WildlifeRefugeTitle = _loc.GetLocalizedString("en", "Visit a Wildlife Refuge", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWildlifeRefugeTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(WildlifeRefugeTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWildlifeRefugePara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string WildlifeRefugePara1 = _loc.GetLocalizedString("en", "The science says that the best way to protect endangered species is to protect where they live. National wildlife refuges and parks provide habitat to endangered and at risk species.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWildlifeRefugePara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(WildlifeRefugePara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWildlifeRefugePara2NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string WildlifeRefugePara2 = _loc.GetLocalizedString("en", "Support your local nature center, wildlife refuge, open space or wildlife parks. Wildlife related recreation supports local business to discourage poaching and help save endangered species.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWildlifeRefugePara2NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(WildlifeRefugePara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHerbsAndPesticidesTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string HerbsAndPesticidesTitle = _loc.GetLocalizedString("en", "Stop Using Herbicides and Pesticides", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceHerbsAndPesticidesTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(HerbsAndPesticidesTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHerbsAndPesticidesPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string HerbsAndPesticidesPara1 = _loc.GetLocalizedString("en", "Predators and scavengers like foxes, eagles, owls, ravens and more can be killed by eating poisoned animals. Herbicides degrade slowly and build-up in the food chain. Critical insects such as bees are especially vulnerable to chemical pollutants.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceHerbsAndPesticidesPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(HerbsAndPesticidesPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHerbsAndPesticidesPara2NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string HerbsAndPesticidesPara2 = _loc.GetLocalizedString("en", "While products like weedkillers keep your garden looking nice, they are hazardous pollutants that affect wildlife at many levels.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceHerbsAndPesticidesPara2NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(HerbsAndPesticidesPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSupportHabitatRestorationTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string SupportHabitatRestorationTitle = _loc.GetLocalizedString("en", "Support Habitat Restoration", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSupportHabitatRestorationTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(SupportHabitatRestorationTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSupportHabitatRestorationPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string SupportHabitatRestorationPara1 = _loc.GetLocalizedString("en", "Research has shown that persistence times for animal species can be increased by a factor of 56, if we regenerate forests between the largest and closest segments of remaining forest cover.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSupportHabitatRestorationPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(SupportHabitatRestorationPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSupportHabitatRestorationPara2NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string SupportHabitatRestorationPara2 = _loc.GetLocalizedString("en", "The extinction of most species occurs after habitat loss. You can make a difference by planting trees locally or supporting habitat restoration projects in some of the most diverse and threatened places on the planet.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSupportHabitatRestorationPara2NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(SupportHabitatRestorationPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSlowDownTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string SlowDownTitle = _loc.GetLocalizedString("en", "Slow Down When Driving", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSlowDownTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(SlowDownTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSlowDownPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string SlowDownPara1 = _loc.GetLocalizedString("en", "Roads are a significant obstacle and hazard to wildlife living in proximity to humans. In the USA alone there are over 260,000 road accidents involving animals each year.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSlowDownPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(SlowDownPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantNativePlantsTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string PlantNativePlantsTitle = _loc.GetLocalizedString("en", "Plant Native Plants", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourcePlantNativePlantsTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(PlantNativePlantsTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantNativePlantsNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string PlantNativePlants = _loc.GetLocalizedString("en", "Native plants are key to maintaining the natural ecosystem in your local area. Plant native plants to support the species living in your local environment. Ensure you buy plants from reputable sources.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourcePlantNativePlantsPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(PlantNativePlants, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGreenRecoveryTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string GreenRecoveryTitle = _loc.GetLocalizedString("en", "Support a 'Green Recovery' from Covid-19", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceGreenRecoveryTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(GreenRecoveryTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGreenRecoveryPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string GreenRecoveryPara1 = _loc.GetLocalizedString("en", "Tell your politicians that you want economic stimulus packages over coming years to focus on Green stimulus. And that you want legislation which empowers employees to make their own decisions about when to travel to an office and when to work from home - reducing traffic on the roads decreases road kill and protects our native flora and fauna.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceGreenRecoveryPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(GreenRecoveryPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMinimisePlasticTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string MinimisePlasticTitle = _loc.GetLocalizedString("en", "Minimise Your Plastics Usage", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceMinimisePlasticTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(MinimisePlasticTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMinimisePlasticPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string MinimisePlasticPara1 = _loc.GetLocalizedString("en", "Plastic works it way into almost every part of the global food chain, killing sea life, birds and mammals. The worlds oceans have been called 'a soup of plastic'. Avoid single-use plastic; bottled water; chewing gum; plastic cigarette lighters; bags; cutlery; straws; coffee cup lids; microbead products.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceMinimisePlasticPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(MinimisePlasticPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBuyRecycledTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string BuyRecycledTitle = _loc.GetLocalizedString("en", "Buy Reusable or Recycled", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceBuyRecycledTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(BuyRecycledTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void GetLocSourceBuyRecycledPara1NameReferenceForReduceAnimalExtinctionPage()
        {
            string BuyRecycledPara1 = _loc.GetLocalizedString("en", "Reusable containers such as glass and stainless steel are vastly preferable to recyclable plastic, but recycled is better than single-use. Recycling lessens the need to extract new materias from the earth and protects ecosystems. Planting new trees cannot replace ancient or virgin woodland, and recycling paper and wood helps saves forests.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceBuyRecycledPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(BuyRecycledPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceStandUpNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string StandUp = _loc.GetLocalizedString("en", "Stand Up and Get Involved", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceStandUpNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(StandUp, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceStandUpPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string StandUpPara1 = _loc.GetLocalizedString("en", "While individual actions are needed and they help, for the world to avert the coming catastrophe we need to make change at a societal level. Contact your local and national representatives. Tell them you care about climate change. Tell them you care about positive measures, not punitive measures. Tell them you do not support measures such as biodiversity offsetting, the common agricultural policy or the common fisheries policies which support emptying the land and sea of natural habitat and resources.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceStandUpPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(StandUpPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUseARecyclingBinTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string UseARecyclingBinTitle = _loc.GetLocalizedString("en", "Use a Recycling Bin", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceUseARecyclingBinTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(UseARecyclingBinTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUseARecyclingBinPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string UseARecyclingBinPara1 = _loc.GetLocalizedString("en", "Almost every plastic is produced from fossil fuels, which damages the environment and animal habitats when extracted and transported. Every single item of plastic which is recycled reduces fossil fuel extraction.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceUseARecyclingBinPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(UseARecyclingBinPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVegetarianTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string GoVegetarianTitle = _loc.GetLocalizedString("en", "Go Vegetarian", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(GoVegetarianTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVegetarianPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string GoVegetarianPara1 = _loc.GetLocalizedString("en", "If you dont want wild animals to go extinct, stop eating them! Stop eating farmed animals which were pastured using cleared wild habitat. The biggest difference you can make right now is to reduce your meat & fish intake, as per the 1st item on our list. That alone will make a huge difference, but if you feel you can eliminate meat and fish from your diet entirely, obviously the impact will be even greater.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceGoVegetarianPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(GoVegetarianPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVeganTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string GoVeganTitle = _loc.GetLocalizedString("en", "Go Vegan", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(GoVeganTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVeganPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string GoVeganPara1 = _loc.GetLocalizedString("en", "Animal agriculture accounts for a staggering 75% of global deforestation. If you want to have a bigger impact than vegetarianism, go vegan.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceGoVeganPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(GoVeganPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSignAPetitionTitleNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string SignAPetitionTitle = _loc.GetLocalizedString("en", "Sign A Petition", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(SignAPetitionTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSignAPetitionPara1NameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string SignAPetitionPara1 = _loc.GetLocalizedString("en", "Create or join a petition to support giving more space over to wildlife as protected areas. Support efforts to ensure that protected areas are properly protected. Make your voice heard. Every tiny step helps.", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSignAPetitionPara1NameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(SignAPetitionPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceComingSoonNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string ComingSoon = _loc.GetLocalizedString("en", "Coming Soon!", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(ComingSoon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPageIsCorrect()
        {
            string WhatDidYouExpectPara = _loc.GetLocalizedString("en", "What did you expect to see here?", null);
            var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
            string ReturnedNameKeyValue = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
            Assert.Equal(WhatDidYouExpectPara, ReturnedNameKeyValue);
        }
    }
}