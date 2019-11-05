using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	public class EnergyMiner : Building, IMiner
	{
		private const int startedCrystalsCost = 2000;
		private const int startedEnergyCost = 3000;
		private const int startedMine = 5;

		public EnergyMiner(Colony colony) : base(colony)
		{
		}

		public override string Name => "Электростанция";
		public override string Descript => "";

		public int MinePerSecond => startedMine;

		protected override int StartedCrystalsCost => startedCrystalsCost;
		protected override int StartedEnergyCost => startedEnergyCost;

		public void MineResources()
		{
			int mine = MinePerSecond * Level;
			ICollection<BaseResource> amount = new List<BaseResource> { new Crystals(0), new Energy(mine) };
			Resources resources = new Resources(amount);
			if (Colony.Planet.TakeResource(resources))
			{
				Colony.AddResources(new Resources(amount));

			}
		}
	}
}
