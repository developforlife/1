using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            IWebDriver driver = new ChromeDriver();
            driver.Url = @"http://drive.ru";
            //driver.Url = @"https://4pda.ru/";

            try
            {
                driver.FindElement(By.XPath(@".//form[@id='site-search']/input[@name='q']")).SendKeys("Kodiaq");
                //driver.FindElement(By.XPath(@".//*[@id='r9b19Sr1Ppw']/rahv/div/r9eb7e9ftir9x/div[1]/div/form/input[1]")).SendKeys("honor");

                //driver.FindElement(By.XPath(@".//form[@id='site-search']/button")).Click();
                //driver.FindElement(By.XPath(@".//*[@id='r9b19Sr1Ppw']/rahv/div/r9eb7e9ftir9x/div[1]/div/form/input[2]")).Click();
                Thread.Sleep(3000);

                var links = driver.FindElements(By.XPath(".//h2/a"));
                foreach (IWebElement link in links)
                    Console.WriteLine("{0} - {1}", link.Text, link.GetAttribute("href"));
                Console.ReadKey();

                driver.Close();
                driver.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                driver.Close();
                driver.Dispose();
                driver.Quit();
            }
            //driver.Quit();
        }
    }
}
