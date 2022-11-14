using OpenQA.Selenium;
using PageObjectModelTest.Driver;
using System.Data;
using WebDriver = PageObjectModelTest.Driver.WebDriver;

namespace PageObjectModelTest.Page
{
    public class PracticeForm
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));
        public IWebElement LastName => driver.FindElement(By.Id("lastName"));
        public IWebElement Email => driver.FindElement(By.Id("userEmail"));
        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-2"));
        public IWebElement Mobile => driver.FindElement(By.Id("userNumber"));
        public IWebElement Subject => driver.FindElement(By.Id("subjectsContainer"));
        public IWebElement Hobbies => driver.FindElement(By.Id("hobbies-checkbox-1"));
        public IWebElement Button => driver.FindElement(By.Id("submit"));


        public void EnterFirstName(string name)
        {
            FirstName.SendKeys(name);
        }

        public void EnterLastName(string name)
        {
            LastName.SendKeys(name);
        }
        
        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void SelectGender()
        {
            Gender.Click();
        }

        public void EnterMobile(string number)
        {
            Mobile.SendKeys(number);
        }

        public void EnterSubject(string subject)
        {
            Subject.Click();
            Subject.SendKeys(subject);
            Subject.Click
        }

        public void SelectHobbies()
        {
            Hobbies.Click();
        }

        public void PressButton()
        {
            Button.Click();
        }
    }
}
