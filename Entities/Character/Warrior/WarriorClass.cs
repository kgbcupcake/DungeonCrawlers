using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Entities.Interfaces;
using DungeonCrawlers.Game.Interfaces;
using DungeonCrawlers.Game.TownSquare;
using Pastel;
using static System.Console;

namespace DungeonCrawlers.Entities.Character.Warrior
{
	internal class WarriorClass
	{
		private readonly ICharacterService characterService;

		public WarriorClass(ICharacterService CharacterService)
		{
			characterService = CharacterService;
		}
	public const string V = "                       Press Enter To Continue : ";
		public static  CharacterData currentPlayer = new CharacterData();
		public void LoadWarrior()
		{
			
			var Warriorc = characterService.GetLoadWarriorClass();


		

			WriteLine($"You Have Chosen the  {Warriorc.name} class \n");
			Thread.Sleep(2000);
			Clear();
			string? Wc = Warriorc.name.Pastel("#148794");
			WriteLine(Wc + " Stat's".Pastel("#A0276D"));
			Clear();
			Playerstats();
			WriteLine($"Your Character name is {MainScreen.currentPlayer.player} the {Warriorc.name}");
			Write(V.Pastel("#8A39A8"));
			ConsoleKeyInfo key = ReadKey();
			TownSquare.MainTownsquare();
			//Clear();
		}

		public void Playerstats()
		{
			var Warriorc = characterService.GetLoadWarriorClass();

			int G = Warriorc.coins;
			//ForegroundColor = ConsoleColor.DarkMagenta;
			WriteLine($"Gold: " + Warriorc.coins);
			ResetColor();
			WriteLine($"Level: {Warriorc.Level}");
			WriteLine($"Class:{Warriorc.Class}");
			
		}
	}
}