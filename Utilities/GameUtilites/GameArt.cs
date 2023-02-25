using Pastel;
using static System.Console;

namespace DungeonCrawlers.Utilities.GameUtilites
{
	public class GameArt
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



			WriteLine(GameTitle);

		}








		public void DukesTitle()
		{
			string? DukesTitle = @"
  _______ _            _____        _                _____ _           _ _          
 |__   __| |          |  __ \      | |              / ____| |         | (_)         
    | |  | |__   ___  | |  | |_   _| | _____  ___  | |    | |__   __ _| |_  ___ ___ 
    | |  | '_ \ / _ \ | |  | | | | | |/ / _ \/ __| | |    | '_ \ / _` | | |/ __/ _ \
    | |  | | | |  __/ | |__| | |_| |   <  __/\__ \ | |____| | | | (_| | | | (_|  __/
    |_|  |_| |_|\___| |_____/ \__,_|_|\_\___||___/  \_____|_| |_|\__,_|_|_|\___\___|
";

			using (StringReader reader = new StringReader(DukesTitle))
			{
				string line = string.Empty;
				do
				{
					line = reader.ReadLine();
					if (line != null)
					{
						SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
						WriteLine(line.Pastel("#254874"));
					}
				} while (line != null);
			}
		}








	}
}