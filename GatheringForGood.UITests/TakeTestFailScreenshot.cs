using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GatheringForGood.UITests
{
    public class TakeTestFailScreenshot
    {

        public void UITest(Action action, String filename, IWebDriver driver )
        {

            try
            {
                action();
            }
            catch (Exception ex)
            {
                var screenshot = driver.TakeScreenshot();
                var dateTime = DateTime.UtcNow.ToString();
                var dateTimeEdited1 = dateTime.Replace(' ', '_');
                StringBuilder sbresult = new StringBuilder();

                foreach (char c in dateTimeEdited1)
                {
                    if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                    {
                        sbresult.Append(c);
                    }
                }
                sbresult.ToString();

                var filePath = "../test_failure_screenshots/" + sbresult + "_" + filename + ".png";

                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);

                System.Diagnostics.Debug.WriteLine(filePath.ToString());

                File.WriteAllText(@"C:\Users\diarm\source\repos\GatheringForGood_Main\GatheringForGood.UITests\bin\Debug\test_failure_exceptions\" + sbresult + "_" + filename + ".txt", ex.ToString());

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                throw;
            }
        }
    }
}
