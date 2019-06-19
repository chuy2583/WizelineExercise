using NUnit.Framework;
using System;
using System.Threading;
using WizelineExercise.Common;
using WizelineExercise.Pages;

namespace WizelineExercise
{
    [TestFixture]
    public class Test : TestInitialize
    {
        [Test]
        public void LoginSucces()
        {
            var wlc = new WelcomePage();
            var login = new LoginPage();
            var home = new HomePage();

            wlc.ClickOnLogin();
            login.LoginAs("testuser@example.com", "test123");
            var result = home.AddNoteBtn.Displayed;

            Assert.True(result);

        }

        [Test]
        public void LoginWithEmtyPassword()
        {
            var wlc = new WelcomePage();
            var login = new LoginPage();


            wlc.ClickOnLogin();
            login.LoginAs("testuser@example.com", "");
            Thread.Sleep(2000);

            var result = login.GetTextFromElement(login.ErrorMessageLabel);

            Assert.IsNotEmpty(result);

        }


        [Test]
        public void LoginWithEmtyUser()
        {
            var wlc = new WelcomePage();
            var login = new LoginPage();


            wlc.ClickOnLogin();
            login.LoginAs("", "test123");
            Thread.Sleep(2000);

            var result = login.GetTextFromElement(login.ErrorMessageLabel);

            Assert.IsNotEmpty(result);

        }
    }
}
