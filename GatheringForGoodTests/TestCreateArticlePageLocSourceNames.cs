using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.AspNetCore.Mvc.Localization;
using GatheringForGood.LocalizationResources;

namespace GatheringForGood.UnitTests
{
    public class TestCreateArticlePageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestCreateArticlePageLocSourceNames()
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
        public void LocSourcePageTabTitleNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Create Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourcePageTabTitleNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Create an article on gatheringforgood to make a difference", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceTitleNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Create Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceSubtitleNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleTitleNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Title of Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleTitleNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleSnippetNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Short Description for Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleSnippetNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara2NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 2 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara2NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara3NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 3 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara3NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara4NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 4 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara4NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara5NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 5 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara5NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara6NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 6 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara6NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara7NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 7 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara7NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara8NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 8 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara8NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara9NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 9 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara9NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara10NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 10 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara10NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara11NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 11 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara11NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara12NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 12 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara12NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara13NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 13 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara13NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara14NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 14 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara14NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticlePara15NameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Paragraph 15 For Your Article", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticlePara15NameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleAddNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Please add your name to your account info", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleAddNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleYourCardNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Your Article Card", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleYourCardNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleAddParagraphReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Add Another Paragraph", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleAddParagraphNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleAddFirstParagraphNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Add 1st Paragraph", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleAddFirstParagraphNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleDeleteParagraphNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Delete", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleDeleteParagraphNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleTitleImageNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Add Title Image", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleAddTitleImageNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleAddImageNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Add Image or Video", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleAddImageNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleFirstImageNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Add 1st Image", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleAddFirstImageNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleTitleImageLabelNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Your Title Image", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleTitleImageLabelNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleTitleVideoLabelNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "- Or - Embed a Title Video (Youtube link)", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleTitleVideoLabelNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRecommendedDimensionsLabelNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Recommended Dimensions: 16 x 9 (1280 x 720 | 1920 x 1080)", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceRecommendedDimensionsLabelNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMaxFileSizeLabelNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Max File Size: 2Mb", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceMaxFileSizeLabelNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceFileTypesLabelNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Accepted File Types: jpg | jpeg | png", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceFileTypesLabelNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYoutubeUrlLabelNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Entry must be a valid URL for a Youtube video", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceYoutubeUrlLabelNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleParaVideoUrlNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "- Or - Embed a Video (Youtube link)", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceArticleParaVideoUrlNameReferenceForCreateArticlePage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceArticleCaptionLabelNameReferenceForCreateArticlePageIsCorrect()
        {
            string correctValue = _loc.GetLocalizedString("en", "Image/Video Caption", null);
            var CreateArticlePageLocSourceNames = new CreateArticlePageLocSourceNames();
            string ReturnedNameKeyValue = CreateArticlePageLocSourceNames.GetLocSourceImageCaptionNameReferenceForArticlesPage();
            Assert.Equal(correctValue, ReturnedNameKeyValue);
        }
    }
}
