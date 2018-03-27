namespace AutomationTests.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using NLog;
    using NLog.Config;
    using NLog.Targets;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;

    public static class DriverExtensions
    {
        public static IWebDriver TakeScreenshot(this IWebDriver driver, string name = "", string path = "")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = $"{DateTime.Now.ToString("dd-MMM-yyyy HH-mm-ss")}";
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                path = ConfigurationManager.AppSettings["screenshotsPath"].ToAbsolutePath();
            }

            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"{path}{name}.jpg", ScreenshotImageFormat.Jpeg);

            return driver;
        }

        public static void SwitchToWindow(this IWebDriver driver, Expression<Func<IWebDriver, bool>> predicateExp)
        {
            var predicate = predicateExp.Compile();
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                if (predicate(driver))
                {
                    return;
                }
            }

            throw new ArgumentException(string.Format("Unable to find window with condition: '{0}'", predicateExp.Body));
        }

        public static void Type(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static void ClickOnElements(this List<IWebElement> elements, string data)
        {
            var conditions = data.Split(',').Select(int.Parse).ToList();

            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i] == 1)
                {
                    elements[i].Click();
                }
            }
        }

        public static string ToAbsolutePath(this string relativePath)
        {
            return Path.GetFullPath(Path.Combine(TestContext.CurrentContext.TestDirectory, relativePath));
        }

        public static IWebDriver Log(this IWebDriver driver)
        {
            var today = DateTime.Now.ToString("dd-MMM-yyyy");
            var dirPath = ConfigurationManager.AppSettings["logsPath"].ToAbsolutePath() + today;
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            var logPath = $"{dirPath}\\{today}.log";
            var logger = GetLogger(logPath);

            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                {
                    logger.Log(NLog.LogLevel.Error, TestContext.CurrentContext.Result.Message);
                    driver.TakeScreenshot(TestContext.CurrentContext.Test.Name, $"{dirPath}\\");
                }
                else
                {
                    logger.Log(NLog.LogLevel.Trace, TestContext.CurrentContext.Result.Outcome.Status);
                }
            }
            catch (Exception ex)
            {
                logger.Log(NLog.LogLevel.Fatal, ex);
            }

            return driver;
        }

        private static Logger GetLogger(string logPath)
        {
            var logConfig = new LoggingConfiguration();
            var target = new FileTarget
            {
                Name = "file",
                FileName = logPath
            };
            logConfig.AddTarget(target);
            var rule = new LoggingRule("*", NLog.LogLevel.Trace, target);
            logConfig.LoggingRules.Add(rule);
            LogManager.Configuration = logConfig;
            return LogManager.GetLogger(TestContext.CurrentContext.Test.Name);
        }
    }
}
