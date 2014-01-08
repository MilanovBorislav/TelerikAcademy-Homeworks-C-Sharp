using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Task_04_Download_file
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"C:\Users\bobi\Desktop\Logo-BASD.jpg");
				//webClient.DownloadFile("http://localhost/wordpress-3.5.zip", @"C:\Users\bobi\Desktop\wordpress-3.5.zip");
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Specify Url");
			}
			catch (WebException)
			{
				Console.WriteLine("May be path is not specified or url is not found");
			}
		}
	}
}
