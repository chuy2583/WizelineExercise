using System;
using System.Threading;
using OpenQA.Selenium;
using WizelineExercise.Common;

namespace WizelineExercise.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage()
        {
        }

        public IWebElement UserTxt => _driver.FindElementByXPath("//*[@name='login.username']");
        public IWebElement PasswordTXt => _driver.FindElementByXPath("//*[@name='login.password']");
        public IWebElement LoginBtn => _driver.FindElementByCssSelector(".btn.btn-lg.btn-primary.button-login");
        public IWebElement ErrorMessageLabel => _driver.FindElementByCssSelector(".btn.btn-lg.btn-default.button-cancel");
        public IWebElement CancelBtn => _driver.FindElementById("login-error-message");


        public void LoginAs(string user, string password)
        {
            UserTxt.SendKeys(user);
            PasswordTXt.SendKeys(password);
            LoginBtn.Click();
            Thread.Sleep(2000);
        }


        public string GetTextFromElement(IWebElement element)
        {
            string result = string.Empty;

            if(element.Displayed)
             result = element.Text;

            return result;
        }
    }
}
