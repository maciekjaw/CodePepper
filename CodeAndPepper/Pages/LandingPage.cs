using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using CodePepper.Pages;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace CodePepper
{
    public class LandingPage : BasePage
    {
        string _burgerMenu = "Colour";
        int _timeToWait = 2;
        string _returnHome = "//*[@id='root']/div/div/div[1]/main/div/div/div/header/div/div[4]/ul/li[4]/a";
        
        #region PageFactory

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div/div[1]/main/div/div/div/div/div/div[1]/div[2]/div/button")]
        private IWebElement singleTripCover { get; set; }

        [FindsBy(How = How.Id, Using = "Colour")]
        private IWebElement burgerMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div/div[1]/main/div/div/div/header/div/div[4]/ul/li[4]/a")]
        private IWebElement returnHome { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#container-main-block > div.body-home > div.first-screen.first-screen--main > div > div.first-screen__container.first-screen__container--main > div > h1")]
        private IWebElement welcomeMsg { get; set; }

        #endregion
        public LandingPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(_driver, this);
        }

        public void ClickSingleTripCover()
        {
            Actions action = new Actions(_driver);
            action.Click(singleTripCover).Perform();
        }

        public void ClickBurgerMenu()
        {
            Actions action = new Actions(_driver);
            action.Click(burgerMenu).Perform();
        }

        public void ClickReturnHome()
        {
            returnHome.Click();
        }

        public string GetWelcomeMsg()
        {
            return welcomeMsg.Text;
        }
        public void WaitUntilBurgerMenuIsVisible()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_timeToWait)).Until(ExpectedConditions.ElementToBeClickable(By.Id(_burgerMenu)));
        }

        public void WaitUntilReturnHomeIsVisible()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_timeToWait)).Until(ExpectedConditions.ElementToBeClickable(By.XPath(_returnHome)));
        }
    }

}
