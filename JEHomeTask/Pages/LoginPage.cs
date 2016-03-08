using System;
using System.Drawing.Text;
using System.Threading;
using JEHomeTask.Utils;
using OpenQA.Selenium;

namespace JEHomeTask.Pages
{
    internal class LoginPage
    {
        private string EmailID = "Email";
        private string PasswordID = "Password";
        private string CheckBoxClass = "#recaptchaContainer .g-recaptcha";
        private string LoginButtonClass = "submit";

        public void LoginWithUser(string email, string password)
        {
            BrowserUtils.Browser.FindElement(By.Id(EmailID)).SendKeys(email);
            BrowserUtils.Browser.FindElement(By.Id(PasswordID)).SendKeys(password);
            BrowserUtils.Browser.FindElement(By.CssSelector(CheckBoxClass)).Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));
            BrowserUtils.Browser.FindElement(By.ClassName(LoginButtonClass)).Click();
        }
    }
}