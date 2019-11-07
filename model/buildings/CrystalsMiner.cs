using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	public class CrystalsMiner : Building, IMiner
	{
		private const int startedCrystalsCost = 1500;
		private const int startedEnergyCost = 3000;
		private const int startedMine = 5;

		public CrystalsMiner(Colony colony, int level = 1, int sCrystal = -1, int sEnergy = -1)
			: base(colony, level, sCrystal, sEnergy)
		{
		}

		public int MinePerSecond { get => startedMine; }

		protected override int StartedCrystalsCost => startedCrystalsCost;
		protected override int StartedEnergyCost => startedEnergyCost;

		public void MineResources()
		{
			int mine = MinePerSecond * Level;
			ICollection<BaseResource> amount = new List<BaseResource> { new Crystals(mine), new Energy(0) };
			Resources resources = new Resources(amount);
			Resources res = Colony.Planet.TakeResource(resources);
			if (res != null)
			{
				Colony.AddResources(res);
			}
		}
	}
}
