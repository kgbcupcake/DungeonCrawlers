using DungeonCrawlers.Items.Interfaces;

namespace DungeonCrawlers.Items.Models
{
	public class Item : IItem
	{
		public ItemType Name;
		public string? Description;
		public int ObjectiveNume;
		public int Weight;
		public int GodVaule;
	}

	public enum ItemType
	{
		Rope,
		Torch,
		HolySymbol,
		Water,
		Food,
		TindrBox
	}
}