using GatheringForGood.LocalizationResources;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;

namespace GatheringForGood.UnitTests
{
    public class LocalizerFactoryForTests
    {
        private ISharedCultureLocalizer _loc;

        public SharedCultureLocalizer InjectLocalizedParameterFromLocSourceFile()
        {
            var locOps = Options.Create(new LocalizationOptions { ResourcesPath = "LocalizationResources" });
            var sfactory = new ResourceManagerStringLocalizerFactory(locOps, NullLoggerFactory.Instance);
            var hfactory = new HtmlLocalizerFactory(sfactory);
            _loc = new SharedCultureLocalizer(hfactory, typeof(LocSource));

            return (SharedCultureLocalizer)_loc;
        }

    }
}
