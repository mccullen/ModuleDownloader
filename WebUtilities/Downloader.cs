
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
		public void DownloadModule()
		{
			Console.WriteLine("Please login and navigate to the module you want to download and press ENTER");
			using (IWebDriver driver = new ChromeDriver())
			{
				driver.Navigate().GoToUrl("https://www.pluralsight.com/");
				Console.ReadLine();
			}
		}
    }
}