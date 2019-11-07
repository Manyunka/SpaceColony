using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
    public abstract class Building
    {
		public Building(Colony colony, int level, int sCrystal, int sEnergy)
        {
			Colony = colony;
            Level = level;
			Crystals crystals = new Crystals(sCrystal != -1 ? sCrystal : StartedCrystalsCost);
			Energy energy = new Energy(sEnergy != -1 ? sEnergy : StartedEnergyCost);
			List<BaseResource> resources = new List<BaseResource> { crystals, energy };
			Cost = new Resources(resources);
			//Colony.Planet.Resource.Empty += () => { 
			//...
			//};
		}

		abstract protected int StartedCrystalsCost { get; }
		abstract protected int StartedEnergyCost { get; }

		public Colony Colony { get;}
        public int Level { get; private set; }
		public Resources Cost { get; protected set; }

        public void UpLevel()
        {
			if (Colony.AllowedPay(this))
			{
				Level++;
				Cost *= 2;
			}
		}
    }
}
