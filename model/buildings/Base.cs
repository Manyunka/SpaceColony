using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
    public class Base : Building
    {
		private const int startedCrystalsCost = 5000;
		private const int startedEnergyCost = 7000;
		public Base(Colony colony, int level = 1, int sCrystal = -1, int sEnergy = -1)
			: base(colony, level, sCrystal, sEnergy)
        {
        }
		protected override int StartedCrystalsCost => startedCrystalsCost;
		protected override int StartedEnergyCost => startedEnergyCost;
	}
}
