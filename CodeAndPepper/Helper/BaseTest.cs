using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CodePepper.Tests
{
    public class BaseTest
    {
        private string _url;
        private double _waitSeconds;
        private double _waitSecondsMin;
        public IWebDriver driver;

        private TimeSpan timeToWait;

        public TimeSpan TimeToWait
        {
            get { return timeToWait = TimeSpan.FromSeconds(_waitSecondsMin); }
        }

        public BaseTest(string url)
        {
            if (_url == null && _waitSeconds <= 0 && _waitSecondsMin <= 0)
            {
                Initialize(url);
            }

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void TurnOnScriptDefaultWait()
        {
            driver.Manage().Timeouts().PageLoad = timeToWait;
        }

        public void TurnOnPageDefaultWait()
        {
            driver.Manage().Timeouts().PageLoad = timeToWait;
        }

        public void TurnOnElementDefaultWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeToWait;
        }

        public void SetMinScriptWait()
        {
            driver.Manage().Timeouts().PageLoad = timeToWait;
        }

        public void SetMinPageWait()
        {
            driver.Manage().Timeouts().PageLoad = timeToWait;
        }

        public void SetMinElementWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeToWait;
        }

        private void Initialize(string url)
        {
            _url = url;
            _waitSeconds = 5;
            _waitSecondsMin = 0;
        }

        public void TestSetup()
        {
            driver.Navigate().GoToUrl(_url);
        }

        public void TestCleanUp()
        {
            driver.Close();
        }

        public void OpenPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
