using System;
using System.Threading;
using OpenQA.Selenium;
using WizelineExercise.Common;

namespace WizelineExercise.Pages
{
    public class WelcomePage : BasePage
    {
        public WelcomePage()
        {
        }

        public IWebElement LoginBtn => _driver.FindElementByCssSelector(".btn.btn-lg.btn-primary.button-login");

        public void ClickOnLogin()
        {
            LoginBtn.Click();
            Thread.Sleep(2000);
        }
    }
}
