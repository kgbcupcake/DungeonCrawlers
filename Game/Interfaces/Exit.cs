using Pastel;
using static System.Console;
namespace DungeonCrawlers.Game.Interfaces
{
	class Exit
	{

		private string exitMsg = "I Hope you Enjoyed This Mini Adventure Game :) ";


		public void mainExit()
		{
			WriteLine();
			WriteLine();
			string Creator = "Creator ====KgbCupCake====";
			WriteLine(Creator.Pastel("#1C9090"));
			WriteLine();
			WriteLine();
			WriteLine(exitMsg.Pastel("#023541"));
			WriteLine("Press Any Key To Exit".Pastel("#E40049"));
			System.Threading.Thread.Sleep(2500);
			System.Environment.Exit(0);

		}



	}
}