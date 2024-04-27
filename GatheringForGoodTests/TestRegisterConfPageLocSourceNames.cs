using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestRegisterConfPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestRegisterConfPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForRegisterConfPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Register Confirmation", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForRegisterConfPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForRegisterConfPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Make A Difference", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForRegisterConfPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitleNameReferenceForRegisterConfPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Register Confirmation", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForRegisterConfPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForRegisterConfPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Register Confirmation", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForRegisterConfPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCheckEmailNameReferenceForRegisterConfPageIsCorrect()
        {
            string CheckEmail = _loc.GetLocalizedString("en", "Please check your email to confirm your account", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceCheckEmail1NameReferenceForRegisterConfPage();
            Assert.Equal(CheckEmail, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFirstnameNameReferenceForRegisterConfPageIsCorrect()
        {
            string Firstname = _loc.GetLocalizedString("en", "First Name", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceFirstnameNameReferenceForRegisterConfPage();
            Assert.Equal(Firstname, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSurnameNameReferenceForRegisterConfPageIsCorrect()
        {
            string Surname = _loc.GetLocalizedString("en", "Surname", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceSurnameNameReferenceForRegisterConfPage();
            Assert.Equal(Surname, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAgeNameReferenceForRegisterConfPageIsCorrect()
        {
            string Age = _loc.GetLocalizedString("en", "Your Age", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceAgeNameReferenceForRegisterConfPage();
            Assert.Equal(Age, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCompanynameNameReferenceForRegisterConfPageIsCorrect()
        {
            string Companyname = _loc.GetLocalizedString("en", "Company/Business Name", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceCompanynameNameReferenceForRegisterConfPage();
            Assert.Equal(Companyname, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSkillNameReferenceForRegisterConfPageIsCorrect()
        {
            string Skill = _loc.GetLocalizedString("en", "Skills you have which can help benefit initiatives and causes for good", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceSkillNameReferenceForRegisterConfPage();
            Assert.Equal(Skill, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAreaofInterestNameReferenceForRegisterConfPageIsCorrect()
        {
            string AreaofInterest = _loc.GetLocalizedString("en", "Your main areas of interest", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceAreaofInterestNameReferenceForRegisterConfPage();
            Assert.Equal(AreaofInterest, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCountryNameReferenceForRegisterConfPageIsCorrect()
        {
            string Country = _loc.GetLocalizedString("en", "Select Your Country", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceCountryNameReferenceForRegisterConfPage();
            Assert.Equal(Country, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRegionNameReferenceForRegisterConfPageIsCorrect()
        {
            string Region = _loc.GetLocalizedString("en", "Select Your Region", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceRegionNameReferenceForRegisterConfPage();
            Assert.Equal(Region, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCountryMatchLabelNameReferenceForRegisterConfPageIsCorrect()
        {
            string CountryMatchLabel = _loc.GetLocalizedString("en", "Country", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceCountryMatchLabelNameReferenceForRegisterConfPage();
            Assert.Equal(CountryMatchLabel, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRegionMatchLabelNameReferenceForRegisterConfPageIsCorrect()
        {
            string RegionMatchLabel = _loc.GetLocalizedString("en", "Region", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceRegionMatchLabelNameReferenceForRegisterConfPage();
            Assert.Equal(RegionMatchLabel, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSeparateSkillCommaNameReferenceForRegisterConfPageIsCorrect()
        {
            string SeparateSkillComma = _loc.GetLocalizedString("en", "Separate each skill with a comma", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceSeparateSkillCommaHeadingNameReferenceForRegisterConfPage();
            Assert.Equal(SeparateSkillComma, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSeparateAreaCommaNameReferenceForRegisterConfPageIsCorrect()
        {
            string SeparateAreaComma = _loc.GetLocalizedString("en", "Separate each area with a comma", null);
            var RegisterConfPageLocSourceNamesLibrary = new RegisterConfPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterConfPageLocSourceNamesLibrary.GetLocSourceSeparateAreaCommaHeadingNameReferenceForRegisterConfPage();
            Assert.Equal(SeparateAreaComma, ReturnedNameKeyValue);
        }
    }
}
