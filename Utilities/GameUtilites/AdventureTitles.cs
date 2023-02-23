using Pastel;
using static System.Console;

namespace DungeonCrawlers.Utilities.GameUtilites
{
	internal class AdventureTitles
	{
		public void DukesTitle()
		{
			string? DukesTitle = @"
______       _                    _           _ _
|  _  \     | |                  | |         | (_)
| | | |_   _| | _____  ___    ___| |__   __ _| |_  ___ ___
| | | | | | | |/ / _ \/ __|  / __| '_ \ / _` | | |/ __/ _ \
| |/ /| |_| |   <  __/\__ \ | (__| | | | (_| | | | (_|  __/
|___/  \__,_|_|\_\___||___/  \___|_| |_|\__,_|_|_|\___\___|";

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