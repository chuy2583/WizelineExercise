using System;
using OpenQA.Selenium;
using WizelineExercise.Common;

namespace WizelineExercise.Pages
{
    public class HomePage : BasePage
    {
        public HomePage()
        {
        }

        public IWebElement AddNoteBtn => _driver.FindElementByCssSelector(".btn.btn-lg.btn-primary");
    }
}
