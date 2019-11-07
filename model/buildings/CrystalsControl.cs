﻿using System;
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
		public CrystalsControl(Colony colony, int level = 1, int sCrystal = -1, int sEnergy = -1)
			: base(colony, level, sCrystal, sEnergy)
		{
		}
		protected override int StartedCrystalsCost => startedCrystalsCost;
		protected override int StartedEnergyCost => startedEnergyCost;
	}
}
