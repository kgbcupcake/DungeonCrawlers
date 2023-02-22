using DungeonCrawlers.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
