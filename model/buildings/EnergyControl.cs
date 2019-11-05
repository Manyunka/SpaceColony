using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	public class EnergyControl : Building
	{
		private const int startedCrystalsCost = 1500;
		private const int startedEnergyCost = 2000;
		public EnergyControl(Colony colony) : base(colony)
		{
		}

		public override string Name => "Управление энергетикой";
		public override string Descript => "";
		protected override int StartedCrystalsCost => startedCrystalsCost;
		protected override int StartedEnergyCost => startedEnergyCost;
	}
}
