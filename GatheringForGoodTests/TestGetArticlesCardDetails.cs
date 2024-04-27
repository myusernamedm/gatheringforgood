using GatheringForGood.Areas.FunctionalLogic;
using GatheringForGood.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace GatheringForGood.UnitTests
{
    public class TestGetArticlesCardDetails
    {
        private static readonly ApplicationDbContext _context = new();
        
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public async Task ArticlesDataTableReturnsRandomRowAndChecksValuesAreCorrectTypeForEachColumnAsync()
        {
            List<GetArticlesCardDetails> articles = await GetArticlesCardDetails.GetCardDetailsAsync(_context, 0, 0, "Blob");
            // DataTable articles = _context.DataTable("SELECT * FROM [dbo].[ArticlesList]", new SqlParameter("paramName", SqlDbType.NVarChar) { Value = "a" });

            var ArticlesDataTable_RowCount = articles.Count();
            Random rand = new Random();
            int randomRow = rand.Next(0, ArticlesDataTable_RowCount);

            var ArticlesDataTable_SelectRow = articles[randomRow];

            var Column1 = ArticlesDataTable_SelectRow.TitleImgRef;
            var Column2 = ArticlesDataTable_SelectRow.UserIdRef;
            var Column3 = ArticlesDataTable_SelectRow.TitleRef;
            var Column4 = ArticlesDataTable_SelectRow.SnippetRef;
            var Column5 = ArticlesDataTable_SelectRow.PostedRef;
            var Column7 = ArticlesDataTable_SelectRow.TitleVidRef;
            var Column8 = ArticlesDataTable_SelectRow.HREFRef;
            var Column9 = ArticlesDataTable_SelectRow.RazorRef;

            Assert.NotNull(Column1);
            Assert.NotNull(Column2);
            Assert.NotNull(Column3);
            Assert.NotNull(Column4);
            Assert.NotNull(Column5);
            Assert.NotNull(Column7);
            Assert.NotNull(Column8);
            Assert.NotNull(Column9);

            Assert.NotEqual("", (Column1));
            Assert.NotEqual("", (Column2));
            Assert.NotEqual("", (Column3));
            Assert.NotEqual("", (Column4));
            Assert.NotEqual("", (Column5));
            Assert.NotEqual("", (Column7));
            Assert.NotEqual("", (Column8));
            Assert.NotEqual("", (Column9));

            Assert.IsType<string>(Column1);
            Assert.IsType<string>(Column2);
            Assert.IsType<string>(Column3);
            Assert.IsType<string>(Column4);
            Assert.IsType<string>(Column5);
            Assert.IsType<string>(Column7);
            Assert.IsType<string>(Column8);
            Assert.IsType<string>(Column9);
        } 
    }
}
