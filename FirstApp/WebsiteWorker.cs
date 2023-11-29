using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace RpaChallange
{
    class WebsiteWorker
    {
        public WebsiteWorker(List<Person> personsList)
        {

            var driver = new ChromeDriver();
            driver.Url = "https://rpachallenge.com";
            driver.FindElement(By.XPath("//button[contains(text(), 'Start')]")).Click();
            foreach(var person in personsList)
            {
                driver.FindElement(By.XPath("//input[@ng-reflect-name='labelPhone']")).SendKeys(person.PhoneNumber);
                driver.FindElement(By.XPath("//input[@ng-reflect-name='labelRole']")).SendKeys(person.RoleInCompany);
                driver.FindElement(By.XPath("//input[@ng-reflect-name='labelCompanyName']")).SendKeys(person.CompanyName);
                driver.FindElement(By.XPath("//input[@ng-reflect-name='labelAddress']")).SendKeys(person.Address);
                driver.FindElement(By.XPath("//input[@ng-reflect-name='labelFirstName']")).SendKeys(person.FirstName);
                driver.FindElement(By.XPath("//input[@ng-reflect-name='labelEmail']")).SendKeys(person.Email);
                driver.FindElement(By.XPath("//input[@ng-reflect-name='labelLastName']")).SendKeys(person.LastName);
                driver.FindElement(By.XPath("//input[@value='Submit']")).Click();
            }
            Console.ReadKey();
            driver.Quit();
        }
    }
}