using CupCakesAdventure;
using DungeonCrawlers.Adventures.Interfaces;
using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Entities.Encounters;
using DungeonCrawlers.Game.Interfaces;
using DungeonCrawlers.Utilities.Functions;
using DungeonCrawlers.Utilities.GameUtilites;
using Pastel;
using static System.Console;

namespace DungeonCrawlers.Adventures.Quests
{
	internal class DukesQuest
	{
		private  IAdventureService adventureServices;
		private static GameArt gameArt = new GameArt();
		private static QuestMenu Questmenu = new QuestMenu();
		private static CharacterService characterService = new CharacterService();
		public static readonly Player currentPlayer = new Player();
		public DukesQuest(IAdventureService AdventureServices)
		{
			adventureServices = AdventureServices;
		}

		
		

		


		public static string Indent(int count)
		{
			return "".PadLeft(count);
		}

		public  void DukesMainQuest()
		{
			var loadDukesquest = adventureServices.GetLoadDukesquest();	
			//var Warriorc = characterService.GetLoadWarriorClass();

			string? q1 = "Quest One:".Pastel("#82282E");
			string? dec = "Description:".Pastel("#82282E");
			WriteLine(q1 + " You Have Chosen ".Pastel("#154871") + loadDukesquest.Title.Pastel("#A02DA3"));
			WriteLine(dec + loadDukesquest.DescriptionD.Pastel("#154875".ToUpper()));
			//Write("                       Press Enter TO Enter Continue  : ".Pastel("#8A39A8"));
			//ConsoleKeyInfo key = ReadKey();
			//Thread.Sleep(50000);
			//Clear();
			WriteLine();
			Write("Yes/No: ");
			MainFunctions.YesNoTwo();
			WriteLine("As you enter the Sewers you notice there is no lights...\njust torch's on the wall");
			Write("Do you take a torch off the wall? Yes/No:");
			switch (ReadLine().ToUpper())
			{
				case "YES":
					Clear();
					gameArt.DukesTitle();
					WriteLine(" You have successfully taken the torch off of the wall\n you now have a light source... This light source wont last for ever though.");
					WriteLine("You will either have to find a new torch or find the materials to relight the torch");
					//ReadKey();
					break;

				case "NO":
					Clear();
					MainFunctions.YesNo();
					ReadKey();
					break;

				default:
					Clear();
					WriteLine("Plz Enter The Right Word ");
					MainFunctions.YesNo();
					break;
			}
			Clear();
			gameArt.DukesTitle();
			WriteLine("As continue your way down into the Sewers you come across a pile of bones from a creature that" +
			"\n you have never seen before.. As you walk further into the Sewers you see this person just standing there... " +
			" you Whistle to get attention He Turn's");
			//Combat Scene.
			Entities.Encounters.MainEncounter.FirstEncounter();


			//Store
			MainFunctions.Runstore();
			WriteLine("Testing after running store");
			ReadKey();
			//WriteLine("Test After Running Store");
			//ReadKey();
			//TODO list
			//Rooms
			


		}
		
	}
}