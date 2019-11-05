using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	public class CrystalsControl : Building
	{
		private const int startedCrystalsCost = 1000;
		private const int startedEnergyCost = 2000;
		public CrystalsControl(Colony colony) : base(colony)
		{
		}

		public override string Name => "Управление добычи кристаллов";
		public override string Descript => "";
		protected override int StartedCrystalsCost => startedCrystalsCost;
		protected override int StartedEnergyCost => startedEnergyCost;
	}
}
