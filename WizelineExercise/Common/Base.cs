using System;
using OpenQA.Selenium.Remote;

namespace WizelineExercise.Common
{
    public class Base
    {
        public Base()
        {
        }

        public static RemoteWebDriver Driver { get; set; } 

    }
}
