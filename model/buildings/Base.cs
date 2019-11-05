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
		public Base(Colony colony) : base(colony)
        {
        }
		public override string Name => "База";
		public override string Descript => "";
		protected override int StartedCrystalsCost => startedCrystalsCost;
		protected override int StartedEnergyCost => startedEnergyCost;
	}
}
