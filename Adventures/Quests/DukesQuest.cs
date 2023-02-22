﻿using DungeonCrawlers.Adventures.Interfaces;
using DungeonCrawlers.Utilities.Functions;
using Pastel;
using static System.Console;

namespace DungeonCrawlers.Adventures.Quests
{

    public class DukesQuest
    {
        private readonly IAdventureService adventureServices;


        public DukesQuest(IAdventureService AdventureServices)
        {
            adventureServices = AdventureServices;
        }

		public static string Indent(int count)
		{
			return "".PadLeft(count);
		}



		public void DukesMainQuest()
        {
            var laodDukesquest = adventureServices.GetLoadDukesquest();

      
            string? q1 = "Quest One:".Pastel("#82282E");
            string? dec = "Description:".Pastel("#82282E");

            WriteLine(q1 + " You Have Chosen".Pastel("#154871") + laodDukesquest.Title.Pastel("#A02DA3"));
            WriteLine(dec + laodDukesquest.DescriptionD.Pastel("#154875"));
            WriteLine( Indent(5) + laodDukesquest.descriptionD.Pastel("#154875"));
            Write("                       Press Enter TO Enter Continue  : ".Pastel("#8A39A8"));
            ConsoleKeyInfo key = ReadKey();
            Clear();

            WriteLine("As you enter the Sewers you notice there is no lights...\njust one torch on the wall");
            Write("Do you take the torch? Yes/No:");

            switch (ReadLine().ToUpper())
            {
                case "YES":
                    Clear();
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
                    DukesMainQuest();
                    break;
            }
            Clear();
            WriteLine("As you continue your way down into the Sewers you come across a pile of bones from a creature that\n you have never seen before..");
            ReadKey();
            //TODO list
            //Rooms
            //Combat
        }



    }
}
