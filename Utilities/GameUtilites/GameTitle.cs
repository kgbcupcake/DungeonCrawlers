using Pastel;
using static System.Console;

namespace DungeonCrawlers.Utilities.GameUtilites
{
	public class GameTitle
	{
		public void MainGameTitle()
		{
			string GameTitle = @"
  _____                                      _____                    _
 |  __ \                                    / ____|                  | |
 | |  | |_   _ _ __   __ _  ___  ___  _ __ | |     _ __ __ ___      _| | ___ _ __
 | |  | | | | | '_ \ / _` |/ _ \/ _ \| '_ \| |    | '__/ _` \ \ /\ / / |/ _ \ '__|
 | |__| | |_| | | | | (_| |  __/ (_) | | | | |____| | | (_| |\ V  V /| |  __/ |
 |_____/ \__,_|_| |_|\__, |\___|\___/|_| |_|\_____|_|  \__,_| \_/\_/ |_|\___|_|
                      __/ |
                     |___/
";

			WriteLine(GameTitle.Pastel("#339595"));
		}
	}
}