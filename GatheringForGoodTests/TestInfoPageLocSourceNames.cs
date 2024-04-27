using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestInfoPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestInfoPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNewValueNameReferenceForInfoPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "New Value", null);
            var InfoPageLocSourceNamesLibrary = new InfoPageLocSourceNames();
            string ReturnedNameKeyValue = InfoPageLocSourceNamesLibrary.GetLocSourceNewValueNameReferenceForAboutPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
    }
}
