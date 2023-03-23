using DungeonCrawlers.Adventures.Quests;
using DungeonCrawlers.Adventures.Services;
using Pastel;
using static System.Console;

namespace DungeonCrawlers.Game.Interfaces
{
	internal class QuestMenu
	{
		private static AdventureService adventureService = new AdventureService();		
		private static DukesQuest LoadDukesQuest = new DukesQuest(adventureService);
		
		

		public void Questmenu(AdventureData? adventureData = null)
		{




			Clear();
			ResetColor();
			WriteLine("Plz Select Which Quest You Would Like To Begin With\n");
			WriteLine("=================================================================================".Pastel("#125874"));
			Write("(1)Quest One: Duke's Chalice                 (2)Still Being Work On\n");
			Write("(3)Still Being Work On                       (4)Still Being Work On\n");
			WriteLine("                         (5)Return To TownSquare                                        ");
			WriteLine("=================================================================================".Pastel("#125874"));
			switch (ReadLine().ToUpper())
			{
				case "1":
					Clear();
					
					LoadDukesQuest.DukesMainQuest();
					break;

				case "2":
					Clear();
					WriteLine("Quest Is Still Being Work On");
					Thread.Sleep(1500);
					Questmenu();
					break;

				case "3":
					Clear();
					WriteLine("Quest Is Still Being Work On");
					Thread.Sleep(1500);
					Questmenu();
					break;

				case "4":
					Clear();
					WriteLine("Quest Is Still Being Work On");
					Thread.Sleep(1500);
					Questmenu();
					break;

				case "5":
					Clear();
					WriteLine("Returning To TownSquare  ");
					Thread.Sleep(1500);
					Clear();
					TownSquare.TownSquare.MainTownsquare();
					
					break;

				default:
					Clear();
					WriteLine("Plz Enter The Right Letter ");
					Questmenu();
					break;
			}
		}
	}
}