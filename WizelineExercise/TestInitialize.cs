using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using WizelineExercise.Common;

namespace WizelineExercise
{
    [TestFixture]
    public class TestInitialize : Base
    {
        public TestInitialize()
        {
           
        }

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://testapp.galenframework.com");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [TearDown]
        public void CleanUp()
        {
            CloseDriver();

        }

        #region Methods
        private static void CloseDriver()
        {
            Driver.Close();
            Driver.Quit();
            Driver.Dispose();
        }
        #endregion∫
    }
}