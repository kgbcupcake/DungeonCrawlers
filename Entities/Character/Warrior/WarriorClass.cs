using DungeonCrawlers.Entities.Interfaces;
using static System.Console;
using Pastel;
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
			WriteLine(Warriorc.ClassName + " Stat's\n");
			WriteLine(Warriorc.coins);
			WriteLine($"Level: {Warriorc.Level}\n");
			WriteLine($"Create a name for your {Warriorc.ClassName}");
			string? PlayerName = ReadLine();
			//Thread.Sleep(100);
			Clear();
			WriteLine($"Your Character name is {PlayerName} the {Warriorc.ClassName}");
			Write(V.Pastel("#8A39A8"));
			ConsoleKeyInfo key = ReadKey();
			Clear();
		}






	}
}

