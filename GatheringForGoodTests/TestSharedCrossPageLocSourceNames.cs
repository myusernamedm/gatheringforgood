using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestSharedCrossPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestSharedCrossPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceButtonTextNameReferenceForMultiplePagesIsCorrect()
        {
            string ButtonText = _loc.GetLocalizedString("en", "Make A Difference - Click Here", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceButtonTextNameReference();
            Assert.Equal(ButtonText, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleTextNameReferenceForMultiplePagesIsCorrect()
        {
            string PageTabTitleText = _loc.GetLocalizedString("en", "Change The World", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReference();
            Assert.Equal(PageTabTitleText, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHomeLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string HomeLabelName = _loc.GetLocalizedString("en", "Home", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceHomeLabelNameReference();
            Assert.Equal(HomeLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFeaturesLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string FeaturesLabelName = _loc.GetLocalizedString("en", "Features", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceFeaturesLabelNameReference();
            Assert.Equal(FeaturesLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAboutLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string AboutLabelName = _loc.GetLocalizedString("en", "About", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceAboutLabelNameReference();
            Assert.Equal(AboutLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHelpCenterLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string HelpCenterLabelName = _loc.GetLocalizedString("en", "Help Center", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceHelpCenterLabelNameReference();
            Assert.Equal(HelpCenterLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRegisterLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string RegisterLabelName = _loc.GetLocalizedString("en", "Register", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceRegisterLabelNameReference();
            Assert.Equal(RegisterLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLoginLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string LoginLabelName = _loc.GetLocalizedString("en", "Login", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceLoginLabelNameReference();
            Assert.Equal(LoginLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLogoutLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string LogoutLabelName = _loc.GetLocalizedString("en", "Logout", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceLogoutLabelNameReference();
            Assert.Equal(LogoutLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAboutUsLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string AboutUsLabelName = _loc.GetLocalizedString("en", "About Us", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceAboutUsLabelNameReference();
            Assert.Equal(AboutUsLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string ArticleLabelName = _loc.GetLocalizedString("en", "Articles", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceArticlesLabelNameReference();
            Assert.Equal(ArticleLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCookiesNoticeLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string CookiesNoticeLabelName = _loc.GetLocalizedString("en", "Terms and Conditions", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCookiesNoticeLabelNameReference();
            Assert.Equal(CookiesNoticeLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePrivacyNoticeLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string PrivacyNoticeLabelName = _loc.GetLocalizedString("en", "Privacy Notice", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourcePrivacyNoticeLabelNameReference();
            Assert.Equal(PrivacyNoticeLabelName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubmitLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string Submit = _loc.GetLocalizedString("en", "Submit", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceSubmitLabelNameReference();
            Assert.Equal(Submit, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceComingSoonLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string ComingSoon = _loc.GetLocalizedString("en", "Coming Soon!", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceComingSoonLabelNameReference();
            Assert.Equal(ComingSoon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLikeToSeeLabelNameReferenceForMultiplePagesIsCorrect()
        {
            string LikeToSee = _loc.GetLocalizedString("en", "What collaboration functionality do you need most?", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceLikeToSeeLabelNameReference();
            Assert.Equal(LikeToSee, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTandCHeadingNameReferenceForSharedPageIsCorrect()
        {
            string TandCHeading = _loc.GetLocalizedString("en", "Accept Terms and Conditions", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceTandCHeadingNameReferenceForPage();
            Assert.Equal(TandCHeading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEmailHeadingNameReferenceForPageIsCorrect()
        {
            string EmailHeading = _loc.GetLocalizedString("en", "Email", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceEmailHeadingNameReferenceForPage();
            Assert.Equal(EmailHeading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePasswordHeadingNameReferenceForPageIsCorrect()
        {
            string PasswordHeading = _loc.GetLocalizedString("en", "Password", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourcePasswordHeadingNameReferenceForPage();
            Assert.Equal(PasswordHeading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceConfirmPasswordHeadingNameReferenceForPageIsCorrect()
        {
            string ConfirmPasswordHeading = _loc.GetLocalizedString("en", "Confirm Password", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceConfirmPasswordHeadingNameReferenceForPage();
            Assert.Equal(ConfirmPasswordHeading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEnableSharingNameReferenceForPageIsCorrect()
        {
            string EnableSharing = _loc.GetLocalizedString("en", "Enable Sharing (Click here)", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceEnableSharingNameReferenceForPage();
            Assert.Equal(EnableSharing, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceClickDetailsNameReferenceForPageIsCorrect()
        {
            string ClickDetails = _loc.GetLocalizedString("en", "Click Details", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceClickDetailsNameReferenceForPage();
            Assert.Equal(ClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceReduceMeatClickDetailsNameReferenceForPageIsCorrect()
        {
            string ReduceMeatClickDetails = _loc.GetLocalizedString("en", "100g Less Meat Intake - Skipped 1 meat portion", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceReduceMeatClickDetailsNameReferenceForPage();
            Assert.Equal(ReduceMeatClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFamilySizesClickDetailsNameReferenceForPageIsCorrect()
        {
            string FamilySizesClickDetails = _loc.GetLocalizedString("en", "Decided to have 1 less child", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceFamilySizesClickDetailsNameReferenceForPage();
            Assert.Equal(FamilySizesClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMinimisePlasticNameReferenceForPageIsCorrect()
        {
            string MinimisePlastic = _loc.GetLocalizedString("en", "Used 1 less 500ml plastic bottle", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceMinimisePlasticClickDetailsNameReferenceForPage();
            Assert.Equal(MinimisePlastic, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceGoVegetarianClickDetailsNameReferenceForPageIsCorrect()
        {
            string GoVegetarian = _loc.GetLocalizedString("en", "Had 1 meal with no meat", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceGoVegetarianClickDetailsNameReferenceForPage();
            Assert.Equal(GoVegetarian, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcGoVeganClickDetailsNameReferenceForPageIsCorrect()
        {
            string GoVeganClickDetails = _loc.GetLocalizedString("en", "Had 1 meal with no animal products", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceGoVeganClickDetailsNameReferenceForPage();
            Assert.Equal(GoVeganClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNotQuantifiableClickDetailsNameReferenceForPageIsCorrect()
        {
            string NotQuantifiableClickDetails = _loc.GetLocalizedString("en", "Valuable but not currently quantifiable", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage();
            Assert.Equal(NotQuantifiableClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRecyclingBinClickDetailsNameReferenceForPageIsCorrect()
        {
            string RecyclingBinClickDetails = _loc.GetLocalizedString("en", "Filled 1 recycling bin", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceRecyclingBinClickDetailsNameReferenceForPage();
            Assert.Equal(RecyclingBinClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantSomeTreesClickDetailsNameReferenceForPageIsCorrect()
        {
            string PlantSomeTreesClickDetails = _loc.GetLocalizedString("en", "Planted 1 tree", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourcePlantSomeTreesClickDetailsNameReferenceForPage();
            Assert.Equal(PlantSomeTreesClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEatOrganicClickDetailsNameReferenceForPageIsCorrect()
        {
            string EatOrganicClickDetails = _loc.GetLocalizedString("en", "Had 1 meal with organic ingredients", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceEatOrganicClickDetailsNameReferenceForPage();
            Assert.Equal(EatOrganicClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLiveCarFreeClickDetailsNameReferenceForPageIsCorrect()
        {
            string LiveCarFreeClickDetails = _loc.GetLocalizedString("en", "1 day without using a car", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceLiveCarFreeClickDetailsNameReferenceForPage();
            Assert.Equal(LiveCarFreeClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceBuyLocalClickDetailsNameReferenceForPageIsCorrect()
        {
            string BuyLocalClickDetails = _loc.GetLocalizedString("en", "Had 1 meal with local ingredients", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceBuyLocalClickDetailsNameReferenceForPage();
            Assert.Equal(BuyLocalClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCycleClickDetailsNameReferenceForPageIsCorrect()
        {
            string CycleClickDetails = _loc.GetLocalizedString("en", "Cycle 2km instead of public transport", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCycleClickDetailsNameReferenceForPage();
            Assert.Equal(CycleClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDriveElectricClickDetailsNameReferenceForPageIsCorrect()
        {
            string DriveElectricClickDetails = _loc.GetLocalizedString("en", "Used an electric vehicle for 1 day", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceDriveElectricClickDetailsNameReferenceForPage();
            Assert.Equal(DriveElectricClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePlantYourOwnVegClickDetailsNameReferenceForPageIsCorrect()
        {
            string PlantYourOwnVegClickDetails = _loc.GetLocalizedString("en", "Used only home grown veg today", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourcePlantYourOwnVegClickDetailsNameReferenceForPage();
            Assert.Equal(PlantYourOwnVegClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUsePublicTransportClickDetailsNameReferenceForPageIsCorrect()
        {
            string UsePublicTransportClickDetails = _loc.GetLocalizedString("en", "Used the bus today instead of a car", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceUsePublicTransportClickDetailsNameReferenceForPage();
            Assert.Equal(UsePublicTransportClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCarpoolClickDetailsNameReferenceForPageIsCorrect()
        {
            string CarpoolClickDetails = _loc.GetLocalizedString("en", "Carpooled Today", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCarpoolClickDetailsNameReferenceForPage();
            Assert.Equal(CarpoolClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceInsulateYourHouseClickDetailsNameReferenceForPageIsCorrect()
        {
            string InsulateYourHouseClickDetails = _loc.GetLocalizedString("en", "Completed an insulation refit - 1 Year with improved insulation", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceInsulateYourHouseClickDetailsNameReferenceForPage();
            Assert.Equal(InsulateYourHouseClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceShorterShowersClickDetailsNameReferenceForPageIsCorrect()
        {
            string ShorterShowersClickDetails = _loc.GetLocalizedString("en", "Reduced 1 shower by 5 minutes", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceShorterShowersClickDetailsNameReferenceForPage();
            Assert.Equal(ShorterShowersClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFluorescentLightbulbsClickDetailsNameReferenceForPageIsCorrect()
        {
            string FluorescentLightbulbsClickDetails = _loc.GetLocalizedString("en", "1 flourescent bulb used for 24 hours", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceFluorescentLightbulbsClickDetailsNameReferenceForPage();
            Assert.Equal(FluorescentLightbulbsClickDetails, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTurnOffLightsClickDetailsNameReferenceForPageIsCorrect()
        {
            string TurnOffLightsClickDetails = _loc.GetLocalizedString("en", "Turned off 1 lightbulb for 1 extra hour", null);
            var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
            string ReturnedNameKeyValue = SharedCrossPageLocSourceNamesLibrary.GetLocSourceTurnOffLightsClickDetailsNameReferenceForPage();
            Assert.Equal(TurnOffLightsClickDetails, ReturnedNameKeyValue);
        }
    }
}
