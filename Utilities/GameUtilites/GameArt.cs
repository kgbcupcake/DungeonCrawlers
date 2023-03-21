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







		public void Townsquare()

		{
			string? TownSquare = @"
~         ~~          __
       _T      .,,.    ~--~ ^^
 ^^   // \                    ~
      ][O]    ^^      ,-~ ~
   /''-I_I         _II____
__/_  /   \ ______/ ''   /'\_,__
  | II--'''' \,--:--..,_/,.-{ },
; '/__\,.--';|   |[] .-.| O{ _ }
:' |  | []  -|   ''--:.;[,.'\,/
'  |[]|,.--'' '',   ''-,.    |
  ..    ..-''    ;       ''. '
";



			using (StringReader reader = new StringReader(TownSquare))
			{
				string line = string.Empty;
				do
				{
					line = reader.ReadLine();
					if (line != null)
					{
						SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
						WriteLine(line);
					}
				} while (line != null);
			}
		}




		public void TownSquareTilte()
		{






			string? TownSquareTitle = @"
  _______                   _____                            
 |__   __|                 / ____|                           
    | | _____      ___ __ | (___   __ _ _   _  __ _ _ __ ___ 
    | |/ _ \ \ /\ / / '_ \ \___ \ / _` | | | |/ _` | '__/ _ \
    | | (_) \ V  V /| | | |____) | (_| | |_| | (_| | | |  __/
    |_|\___/ \_/\_/ |_| |_|_____/ \__, |\__,_|\__,_|_|  \___|
                                     | |                     
                                     |_|                     
";


			using (StringReader reader = new StringReader(TownSquareTitle))
			{
				string line = string.Empty;
				do
				{
					line = reader.ReadLine();
					if (line != null)
					{
						SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
						WriteLine(line);
					}
				} while (line != null);
			}





		}

		










	}
}