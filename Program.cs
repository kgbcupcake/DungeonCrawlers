﻿
using DungeonCrawlers.Main.Interfaces;
using static System.Console;
using Pastel;
using DungeonCrawlers.Utilities.Functions;

namespace DungeonCrawler
{
	internal class Program
	{


		private static void Main(string[] args)
		{
			
			MainFunctions.ConsoleSize();

			//Login Screen
			//LoginScreen Login = new LoginScreen();
			//Login.MainLogin();

			//  ---------------------------------------------------//

			// Main Screen
			MainScreen screen = new MainScreen();
			screen.mainScreen();
		}







	}








}