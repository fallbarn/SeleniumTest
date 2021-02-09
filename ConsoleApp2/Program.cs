using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Creating Selenium driver");

            IWebDriver browser = new ChromeDriver();

            browser.Navigate().GoToUrl("https://google.com");
        }
    }
}
