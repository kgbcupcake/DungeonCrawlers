using DungeonCrawlers.Adventures.Interfaces;
using Newtonsoft.Json;

namespace DungeonCrawlers.Adventures.Services
{
	public class AdventureService : IAdventureService
	{
		//DukesQuest
		public AdventureData GetLoadDukesquest()
		{
			var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}adventures";
			var Dukesquest = new AdventureData();
			if (File.Exists($"{basePath}\\DukesQuest.json"))
			{
				var directory = new DirectoryInfo(basePath);
				var DukesQuestJson = directory.GetFiles("DukesQuest.json");

				using StreamReader fi = File.OpenText(DukesQuestJson[0].FullName);
				Dukesquest = JsonConvert.DeserializeObject<AdventureData>(fi.ReadToEnd());
			}
			else
			{
				throw new Exception("No Adventure found");
			}
			return Dukesquest;
		}
	}
}