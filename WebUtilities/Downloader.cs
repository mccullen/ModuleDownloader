
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;

namespace WebUtilities
{
    public class Downloader
    {
		public void DownloadFile(string address, string filename)
		{
			using (WebClient client = new WebClient())
			{
				client.DownloadFile(address, filename);
			}
		}
		public void DownloadCourse(string directoryName)
		{
			// Create directory to store course
			//Directory.CreateDirectory(directoryName);

			using (IWebDriver driver = new ChromeDriver())
			{
				// Get URL of course
				Console.WriteLine("Please login and navigate to the module you want to download and press ENTER");
				driver.Navigate().GoToUrl("https://www.pluralsight.com/");
				Console.ReadLine();

				// Get the modules
				driver.SwitchTo().Window(driver.WindowHandles[1]);
				IList<IWebElement> modules = driver.FindElements(By.ClassName("module"));
				foreach (IWebElement module in modules)
				{
					IWebElement element = module.FindElement(By.TagName("h2"));
					Console.WriteLine(element.Text);
				}
			}
			Console.WriteLine("Finished");
			Console.ReadLine();
		}
    }
}