using DungeonCrawlers.Main.Interfaces;
using DungeonCrawlers.Utilities.Functions;
using Newtonsoft.Json;
using Pastel;
using static System.Console;
namespace DungeonCrawlers.Utilities.GameUtilites.Credits
{
	internal class CreditService
	{




		public static string Indent(int count)
		{
			return "".PadLeft(count);
		}






		public static void loadCredits()
		{
			//string? Tab = "\t";

			








			var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Credits";
			var Loadcredit = new CreditData();
			if (File.Exists($"{basePath}\\Credits.json"))
			{
				var directory = new DirectoryInfo(basePath);
				var LoadcreditJsonFile = directory.GetFiles("Credits.json");

				using StreamReader fi = File.OpenText(LoadcreditJsonFile[0].FullName);
				Loadcredit = JsonConvert.DeserializeObject<CreditData>(fi.ReadToEnd());
			}
			string? Title = "Title:".Pastel("#29188D");
			string? Link = "Link:".Pastel("#8D0E2E");
			//GitHub
			WriteLine(Title + Loadcredit.TitleG);
			WriteLine(Indent(1) + Link + Loadcredit.LinkG .Pastel("#26BE2D"));
			
			

			WriteLine();
			//You-tube
			WriteLine(Title + Loadcredit.TitleY);
			WriteLine(Indent(1) + Link + Loadcredit.LinkY.Pastel("#26BE2D"));
			WriteLine();
			//Discord
			WriteLine(Title + Loadcredit.TitleD);
			WriteLine(Indent(1) + Link + Loadcredit.LinkD.Pastel("#26BE2D"));
			MainFunctions.LineBreak();
			//Exit
			Write((Indent(30)+"Press Enter To return to main menu : ".Pastel("#8A39A8")));
			ConsoleKeyInfo key = ReadKey();
			Clear();
			WriteLine("Returning to the main menu");
			Thread.Sleep(2000);
			Clear();
			MainMenu.Mainmenu();
		}
	}
}
