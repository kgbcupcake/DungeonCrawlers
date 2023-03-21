using DungeonCrawlers.Entities.Character.Service;

using Newtonsoft.Json;
using static System.Console;
using Pastel;


namespace DungeonCrawlers.Utilities.GameUtilites.GameDoc
{
    internal class GameInfoService
    {

		public static string Indent(int count)
		{
			return "".PadLeft(count);
		}


		public static Player currentPlayer = new();
        public static void MainGameInfo()
        {

			var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}GameDoc";
			var LoadDocs = new GameInfoData();
			if (File.Exists($"{basePath}\\GameWiki.json"))
			{
				var directory = new DirectoryInfo(basePath);
				var LoadGameWikiJsonFile = directory.GetFiles("GameWiki.json");

				using StreamReader fi = File.OpenText(LoadGameWikiJsonFile[0].FullName);
				LoadDocs = JsonConvert.DeserializeObject<GameInfoData>(fi.ReadToEnd());
			}


			string? Title = "Description:".Pastel("#29188D");
			string? C = "Controls:".Pastel("#8D0E2E");
			string? A = " & ".Pastel("#09CBCB");



			WriteLine(Title + LoadDocs.Description);
			WriteLine();
			WriteLine(C +LoadDocs.Controls.Pastel("#09CBCB"));
			WriteLine(LoadDocs.YES.Pastel("#158745")+A + LoadDocs.NO.Pastel("#158745"));
			


			
			//ReadKey();
		}






    }
}
