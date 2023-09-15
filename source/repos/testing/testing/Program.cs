using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set ChromeDriver executable path
            string chromeDriverPath = @"C:\Users\LAKSH\Downloads\chromedriver-win64\chromedriver-win64\chromedriver.exe"; // Replace with your actual path
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--remote-allow-origins=*");
            IWebDriver driver = new ChromeDriver(chromeDriverPath, options);

            // Navigate to the webpage
            driver.Navigate().GoToUrl("http://app.cloudqa.io/home/AutomationPracticeForm");

            try
            {
                //Input First Name
                IWebElement firstName = driver.FindElement(By.Id("fname"));
                firstName.SendKeys("Sai Srija");
                //Input Last Name
                IWebElement lastName = driver.FindElement(By.Id("lname"));
                lastName.SendKeys("Appala");
                //Input Date of birth
                IWebElement dateOfBirth = driver.FindElement(By.Id("dob"));
                dateOfBirth.SendKeys("2002-03-09");
                IWebElement femaleRadioButton = driver.FindElement(By.Id("female"));

                // Check if the radio button is not already selected
                if (!femaleRadioButton.Selected)
                {
                    // Select the female radio button
                    femaleRadioButton.Click();
                }
                IWebElement dropdown = driver.FindElement(By.Id("state"));

                // Create a SelectElement from the dropdown element
                SelectElement select = new SelectElement(dropdown);

                // Select "India" by visible text (replace "India" with the option text you want to select)
                select.SelectByText("India");







            }
            catch (Exception e)
            {
                // Handle any exceptions or errors that may occur during the interactions
                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally
            {
                // Close the browser

            }
        }
    }
}