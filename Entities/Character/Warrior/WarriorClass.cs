using DungeonCrawlers.Entities.Interfaces;
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

		public void LoadWarrior()
		{
			var Warriorc = characterService.GetLoadWarriorClass();

			WriteLine($"You Have Chosen the  {Warriorc.ClassName} class \n");
			Thread.Sleep(2000);
			Clear();
			string? Wc = Warriorc.ClassName.Pastel("#148794");
			WriteLine(Wc + " Stat's".Pastel("#A0276D"));
			Playerstats();
			WriteLine($"Create a name for your {Warriorc.ClassName}");
			string? PlayerName = ReadLine().Pastel("#154897");
			//Thread.Sleep(100);
			Clear();
			WriteLine($"Your Character name is {PlayerName} the {Warriorc.ClassName}");
			Write(V.Pastel("#8A39A8"));
			ConsoleKeyInfo key = ReadKey();
			Clear();
		}

		public void Playerstats()
		{
			var Warriorc = characterService.GetLoadWarriorClass();

			int G = Warriorc.coins;
			//ForegroundColor = ConsoleColor.DarkMagenta;
			WriteLine($"Gold: " + Warriorc.coins);
			ResetColor();
			WriteLine($"Level: {Warriorc.Level}\n");
		}
	}
}