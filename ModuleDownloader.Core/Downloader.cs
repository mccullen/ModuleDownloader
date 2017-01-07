using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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
    }
}
