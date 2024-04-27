using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;
using System.Globalization;

namespace GatheringForGood.UnitTests
{
    public class TestAboutPageLocSourceNames
    {
        
        private readonly ISharedCultureLocalizer _loc;

        public TestAboutPageLocSourceNames()
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
            string PageTabTitle = _loc.GetLocalizedString("en", "About Us", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForAboutPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForAboutPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "We believe that anyone's ideas can change the world", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForAboutPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForAboutPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "About Us", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForAboutPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWhereDoesNameComeFromTitleNameReferenceForAboutPageIsCorrect()
        {
            string WhereDoesNameComeFromTitle = _loc.GetLocalizedString("en", "Where does our name come from?", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceWhereDoesNameComeFromTitleNameReferenceForAboutPage();
            Assert.Equal(WhereDoesNameComeFromTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceWhereDoesNameComeFromParaNameReferenceForAboutPageIsCorrect()
        {
            string WhereDoesNameComeFromPara = _loc.GetLocalizedString("en", "GatheringForGood comes from a simple belief - That anyone can have a world-changing idea. To make a positive difference, your great ideas just need to meet up with the knowledge, skills and expertise to make them a reality. GatheringForGood is the digital space where the worlds best ideas, can come together with the knowledge needed to make meaningful change. By gathering together for good, we can change the world!", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceWhereDoesNameComeFromParaNameReferenceForAboutPage();
            Assert.Equal(WhereDoesNameComeFromPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOurMissionTitleNameReferenceForAboutPage()
        {
            string OurMissionTitle = _loc.GetLocalizedString("en", "Our Mission", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceOurMissionTitleNameReferenceForAboutPage();
            Assert.Equal(OurMissionTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOurMissionParaNameReferenceForAboutPage()
        {
            string OurMissionPara = _loc.GetLocalizedString("en", "We bring people, ideas and expertise together to create a better world.", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceOurMissionParaNameReferenceForAboutPage();
            Assert.Equal(OurMissionPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOurPromiseTitleNameReferenceForAboutPage()
        {
            string OurPromiseTitle = _loc.GetLocalizedString("en", "Our Promise", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceOurPromiseTitleNameReferenceForAboutPage();
            Assert.Equal(OurPromiseTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOurPromiseParaNameReferenceForAboutPage()
        {
            string OurPromisePara = _loc.GetLocalizedString("en", "We provide a positive optimistic platform where the seeds of great ideas can germinate and grow.", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceOurPromiseParaNameReferenceForAboutPage();
            Assert.Equal(OurPromisePara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOurEssenceTitleNameReferenceForAboutPage()
        {
            string OurEssenceTitle = _loc.GetLocalizedString("en", "Our Essence", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceOurEssenceTitleNameReferenceForAboutPage();
            Assert.Equal(OurEssenceTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOurEssenceParaNameReferenceForAboutPage()
        {
            string OurEssencePara = _loc.GetLocalizedString("en", "At our core, GatheringForGood operates on imagination, learning, inclusivity and mutual respect.", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceOurEssenceParaNameReferenceForAboutPage();
            Assert.Equal(OurEssencePara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOurVisionTitleNameReferenceForAboutPage()
        {
            string OurVisionTitle = _loc.GetLocalizedString("en", "Our Vision", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceVisionTitleNameReferenceForAboutPage();
            Assert.Equal(OurVisionTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOurVisionParaNameReferenceForAboutPage()
        {
            string VisionPara = _loc.GetLocalizedString("en", "To help humans save the world from humans", null);
            var AboutPageLocSourceNamesLibrary = new AboutPageLocSourceNames();
            string ReturnedNameKeyValue = AboutPageLocSourceNamesLibrary.GetLocSourceVisionParaNameReferenceForAboutPage();
            Assert.Equal(VisionPara, ReturnedNameKeyValue);
        }
    }
}
