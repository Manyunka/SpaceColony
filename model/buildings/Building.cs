using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
    public abstract class Building
    {
		public Building(Colony colony)
        {
			Colony = colony;
            Level = 1;
			Crystals crystals = new Crystals(StartedCrystalsCost);
			Energy energy = new Energy(StartedEnergyCost);
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
