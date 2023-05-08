using DungeonCrawlers.Game.Interfaces;
using DungeonCrawlers.Game.TownSquare;
using Pastel;
using static DungeonCrawlers.Utilities.Functions.MainFunctions;
using static System.Console;

namespace DungeonCrawlers.Entities.Encounters.CumstomEncounters
{
	internal  class Bosses
	{




		public  void Wizardboss()
		{
			// if Player health is greater then 15 we run this 
			//if (MainScreen.currentPlayer.health > 15)
			//{
				//Clear();
				WriteLine("Raider: You Think You Can Defeat me?");
			WaitForAnyKeyPress();
			MainEncounter.Combat(false, "Dark Wizard Raider".Pastel("#D60B18"), 5, 10);
			//WriteLine("The door rips open, as you stand there You see a tall man with a");
			//WriteLine("long bead looking at a large tome");
			//WaitForAnyKeyPress();
			
			//}
			// if Player health is More then 15 we run this 
			//else if (MainScreen.currentPlayer.health < 15 && MainScreen.currentPlayer.armorValue == 3)
			//{

			//}
		}




		/// <summary>
		/// Boss Right you can call 
		/// </summary>
		public void RatBoss()
		{
			
			Clear();
			WriteLine("We Have Run into a Boss,Can you handle him");
			WaitForAnyKeyPress();
			MainEncounter.Combat(false, "RatBoss".Pastel("#D60B18"), 15, 25);

			if (MainScreen.currentPlayer.health > 0)
			{
				WriteLine("You Have Defeated me ");
				TownSquare.MainTownsquare();
			}
		}



	}
}
