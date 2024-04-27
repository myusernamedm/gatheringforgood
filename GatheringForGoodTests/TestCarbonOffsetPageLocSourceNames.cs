using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestCarbonOffsetPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestCarbonOffsetPageLocSourceNames()
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
        public void LocSourcePageTabTitleNameReferenceForAboutPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Offset Your Carbon", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourcePageTabTitleNameReferenceForCarbonOffsetsPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForAboutPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Offset Your Carbon For A Healthy Planet", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceTitleNameReferenceForCarbonOffsetsPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForAboutPageIsCorrect()
        {
            string Subtitle = _loc.GetLocalizedString("en", "Carbon Offsets", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceSubtitleNameReferenceForCarbonOffsetsPage();
            Assert.Equal(Subtitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOffsetMyCarbonNameReferenceForAboutPageIsCorrect()
        {
            string OffsetMyCarbon = _loc.GetLocalizedString("en", "Offset My Carbon", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceOffsetMyCarbonNameReferenceForCarbonOffsetsPage();
            Assert.Equal(OffsetMyCarbon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOffsetAJourneyNameReferenceForAboutPageIsCorrect()
        {
            string OffsetAJourney = _loc.GetLocalizedString("en", "Offset A Journey", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceOffsetAJourneyTitleNameReferenceForCarbonOffsetsPage();
            Assert.Equal(OffsetAJourney, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOffsetMyBusinessTitleNameReferenceForAboutPageIsCorrect()
        {
            string OffsetMyBusiness = _loc.GetLocalizedString("en", "Offset Business Carbon", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceOffsetMyBusinessCarbonNameReferenceForCarbonOffsetsPage();
            Assert.Equal(OffsetMyBusiness, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitlePara1NameReferenceForAboutPageIsCorrect()
        {
            string TitlePara1 = _loc.GetLocalizedString("en", "Carbon offsetting with GatheringForGood allows you to invest in carbon negative initiatives worldwide, to help offset the unavoidable carbon emissions created by a persons lifestyle or business. One tonne of carbon dioxide equivalent (CO2e) is approximate equal to the average monthly carbon footprint of someone living in Europe. While carbon offsetting alone is not a solution to the climate crises, the world needs lots of small changes which combined make great changes, and carbon offsetting is widely accepted as a way to be more accountable for your climate impact after having taken steps to reduce your overall carbon footprint.", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceTitlePara1NameReferenceForCarbonOffsetsPage();
            Assert.Equal(TitlePara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitlePara2aNameReferenceForAboutPageIsCorrect()
        {
            string TitlePara2a = _loc.GetLocalizedString("en", "GatheringForGood has partnered with", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceTitlePara2aNameReferenceForCarbonOffsetsPage();
            Assert.Equal(TitlePara2a, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitlePara2bNameReferenceForAboutPageIsCorrect()
        {
            string TitlePara2b = _loc.GetLocalizedString("en", ", a leading global climate and sustainability initiative to ensure that your money goes to where it is most effective. Our partnership allows you to plant trees in different locations around the globe which are most meaningful to you, but all of which have a great impact. By offsetting your carbon; the carbon of a friend or family member; your employees carbon; or the carbon generated by your business, you can change your climate impact and influence the front lines of climate change in ways that will have long term benefits for the health of the planet.", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceTitlePara2bNameReferenceForCarbonOffsetsPage();
            Assert.Equal(TitlePara2b, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOneTreePlantedTitleNameReferenceForAboutPageIsCorrect()
        {
            string OneTreePlanted = "OneTreePlanted";
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceOneTreePlantedNameReferenceForCarbonOffsetsPage();
            Assert.Equal(OneTreePlanted, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOffsetMyCarbonParaNameReferenceForAboutPageIsCorrect()
        {
            string OffsetMyCarbonPara = _loc.GetLocalizedString("en", "Offset your carbon, that of your friends and family, or that of your colleagues. Calculate your carbon footprint and choose a location to support a tree planting project which will sequester carbon from the atmosphere. Or just make a one-off contribution to planting, every little helps!", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceOffsetMyCarbonParaNameReferenceForCarbonOffsetsPage();
            Assert.Equal(OffsetMyCarbonPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOffsetByTonneParaNameReferenceForAboutPageIsCorrect()
        {
            string OffsetByTonne = _loc.GetLocalizedString("en", "Keep it simple! An average European generates 1 tonne of CO2e per month. Offset by the tonne.", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceOffsetByTonneParaNameReferenceForCarbonOffsetsPage();
            Assert.Equal(OffsetByTonne, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOffsetAJourneyParaNameReferenceForAboutPageIsCorrect()
        {
            string OffsetAJourney = _loc.GetLocalizedString("en", "Taking a trip? Calculate the carbon impact of your journey, no matter how short or long, and make a difference for the planet by offsetting the carbon your trip generates. Or show that your business pays more than just lip service to sustainability and plant trees against the carbon generated by business trips or your employee commutes.", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceOffsetAJourneyParaNameReferenceForCarbonOffsetsPage();
            Assert.Equal(OffsetAJourney, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOffsetMyBusinessParaNameReferenceForAboutPageIsCorrect()
        {
            string OffsetMyBusinessPara = _loc.GetLocalizedString("en", "Use our comprehensive calculator to establish the unavoidable carbon generated by your business and then help the planet by planting trees to counter-balance what you cant reduce or avoid.", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceOffsetMyBusinessParaNameReferenceForCarbonOffsetsPage();
            Assert.Equal(OffsetMyBusinessPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOurPartnerTextNameReferenceForAboutPageIsCorrect()
        {
            string OurPartnerText = _loc.GetLocalizedString("en", "We have partnered with OneTreePlanted to ensure your money has the greatest impact", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceOurPartnerTextNameReferenceForCarbonOffsetsPage();
            Assert.Equal(OurPartnerText, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYourMoneyTextNameReferenceForAboutPageIsCorrect()
        {
            string YourMoneyText = _loc.GetLocalizedString("en", "80% of your money goes to our partners, 20% covers our administration costs", null);
            var CarbonOffsetsPageLocSourceNames = new CarbonOffsetsPageLocSourceNames();
            string ReturnedNameKeyValue = CarbonOffsetsPageLocSourceNames.GetLocSourceYourMoneyTextNameReferenceForCarbonOffsetsPage();
            Assert.Equal(YourMoneyText, ReturnedNameKeyValue);
        }
    }
}
