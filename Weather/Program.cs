using System;
using System.Net;
using System.Text;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
			//set an encoding
			Console.OutputEncoding = Encoding.ASCII;

			//checking if user gave town name
			if (args.Length <= 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Please enter the correct city name");
				Console.ResetColor();
				return;
			}

			//checking if user typed "-v" which stands for showing version
			if (args[0] == "-v")
			{
				Console.WriteLine("Version: 0.9");
				return;
			}

			//checks if user wants experimental or stable version
			if (args.Length == 1)
			{
				WebClient client = new WebClient();

				string page = client.DownloadString("http://wttr.in/" + args[0] + "?A&lang=en");

				Console.WriteLine(page);
			}
			else if (args.Length == 2)
			{
				//checks if user typed "-e" which stands for experimental version
				if (args[1] == "-e")
				{
					WebClient client = new WebClient();

					string page = client.DownloadString("http://v2.wttr.in/" + args[0] + "?A&lang=en");

					Console.WriteLine(page);
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Argument not recognized");
					Console.ResetColor();
					return;
				}
			}
		}
    }
}
