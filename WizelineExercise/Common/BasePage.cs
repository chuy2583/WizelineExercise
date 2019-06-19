using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace WizelineExercise.Common
{
    public class BasePage : Base
    {
        protected readonly RemoteWebDriver _driver;
        protected WebDriverWait _wait { get; set; }
        public BasePage()
        {
            _driver = Driver;
            _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        }


    }
}
