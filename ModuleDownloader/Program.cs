using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUtilities;

namespace ModuleDownloader
{
	class Program
	{
		static void Main(string[] args)
		{
			 Downloader downloader = new Downloader();
			string address = "http://vid20.pluralsight.com/clip-videos/scott-allen/c-sharp-fundamentals-with-visual-studio-2015-m0/c-sharp-fundamentals-with-visual-studio-2015-m0-01/1280x720mp4/20160721231755.mp4?OLUy-XYNM5nBL1y-aCQ7NeoKjY0ZUOX0wDMb_hT0rLkrsdKVG6UZUDfPT9O9JL5pmicDrVB30-BEkNg0G7loGoQmlKHNtNbkCSWQbki3FMfvC2_l1ebNyOxhNKHXLg0SA_CD-ew69T7b6nKwc4yBTo5rlOmhSW6I5FubsAXuo-poxc864agYHdkHZFUbJl6wwq0ztJbPOlM5FxiohN0naqMHVyeyZ4RkjXITY-jo2Bxh4o9lkaj9F_zKEVNHZbICZW1TbAox5wUlz6FCz6xm_iDHS6rVSBZt";
			string filename = @"C:\Users\jeff\Videos\intro.mp4";
			downloader.DownloadFile(address, filename);

			Console.ReadLine();
		}
	}
}
