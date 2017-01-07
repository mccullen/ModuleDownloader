/**
 * Name: Jeff McCullen
 * Get Github extension then File -> Add to Source Control
 */
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
			DownloadModule();

			Console.ReadLine();
		}

		private static void DownloadModule()
		{
			Downloader downloader = new Downloader();

			downloader.DownloadModule();

			Console.ReadLine();
		}
	}
}