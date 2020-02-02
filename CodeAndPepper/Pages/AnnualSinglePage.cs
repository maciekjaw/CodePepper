using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using CodePepper.Pages;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace CodeAndPepper.Pages
{
    public class AnnualSinglePage :  BasePage
    {
        int timeToWait = 1;
        string _nextBtn = "//*[@id='root']/div/div/div[1]/main/div/div/div/div/div[2]/div/button";
        string _countryName = "Poland";
        string _countryPlaceholder = "//*[@id='country-0']/div/div/div/div[1]/p";

        #region PageFactory

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/main/div/div/div/div/div[2]/div/button")]
        private IWebElement nextButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='country-0']/div/div/div/div[1]/p")]
        private IWebElement countryPlaceholder { get; set; }

        #endregion
        public AnnualSinglePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(_driver, this);
        }
        public void WaitUntilNextBtnIsVisible()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeToWait)).Until(ExpectedConditions.ElementExists(By.XPath(_nextBtn)));

        }

        public void WaitUntilCountryPlaceholderIsVisible()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeToWait)).Until(ExpectedConditions.ElementExists(By.XPath(_countryPlaceholder)));

        }
        public bool IsNextBtnEnabled()
        {
            return nextButton.Enabled;
        }

        public void TypeInCountry()
        {
            Actions action = new Actions(_driver);
            action.Click(countryPlaceholder)
                .SendKeys(_countryName)
                .SendKeys(Keys.Enter)
                .Perform();
        }
    }
}
