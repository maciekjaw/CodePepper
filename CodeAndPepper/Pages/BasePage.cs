using OpenQA.Selenium;

namespace CodePepper.Pages
{
    public class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Get

        public string GetPageTitle()
        {
            return _driver.Title;
        }

        public string GetPageUrl()
        {
            return _driver.Url;
        }

        #endregion

        #region Actions

        public void RefreshPage()
        {
            _driver.Navigate().Refresh();
        }

        public void WaitForUrlLoad(string url, int secondsWait)
        {
            while (this.GetPageUrl() != url && secondsWait > 0)
            {
                secondsWait--;
            }
        }

        public void WaitForUrlStartsWithLoad(string url, int secondsWait)
        {
            while (!this.GetPageUrl().StartsWith(url) && secondsWait > 0)
            {
                secondsWait--;
            }
        }
        #endregion

  }
}
