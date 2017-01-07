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
			DownloadCourse();

			Console.ReadLine();
		}

		private static void DownloadCourse()
		{
			Downloader downloader = new Downloader();

			Console.Write("Ender directory name: ");
			string directoryName = Console.ReadLine();
			downloader.DownloadCourse(directoryName);

			Console.ReadLine();
		}
	}
}