using DungeonCrawlers.Main.Interfaces;
using Newtonsoft.Json;
using Pastel;
using static System.Console;
namespace DungeonCrawlers.Utilities.GameUtilites.Credits
{
	internal class CreditService
	{

		public static void loadCredits()
		{

			//Git-Hub
			var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Credits";
			var Loadcredit = new CreditData();
			if (File.Exists($"{basePath}\\Credits.json"))
			{
				var directory = new DirectoryInfo(basePath);
				var LoadcreditJsonFile = directory.GetFiles("Credits.json");

				using StreamReader fi = File.OpenText(LoadcreditJsonFile[0].FullName);
				Loadcredit = JsonConvert.DeserializeObject<CreditData>(fi.ReadToEnd());
			}
			string? TitleG = "Title:".Pastel("#82282E");
			string? LinkG = "Description:".Pastel("#82282E");

			WriteLine(TitleG + Loadcredit.TitleG);
			WriteLine(LinkG + Loadcredit.LinkG);
			WriteLine();
			WriteLine();
			WriteLine(TitleG + Loadcredit.TitleY);
			WriteLine(LinkG + Loadcredit.LinkY);
			


			Write("                       Press Enter TO return to main menu : ".Pastel("#8A39A8"));
			ConsoleKeyInfo key = ReadKey();
			Clear();
			WriteLine("Returning to the main menu");
			Thread.Sleep(2000);
			Clear();
			MainMenu.Mainmenu();













		}
		














	}
}
