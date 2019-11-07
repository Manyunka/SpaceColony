using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	class ColonySave
	{
		public string Name { get; set; }
		public ResourcesSave Resources { get; set; }
		public List<BuildingSave> BaseBuildings { get; set; }
		public List<BuildingSave> CrystalsControlBuildings { get; set; }
		public List<BuildingSave> EnergyControlBuildings { get; set; }
		public List<BuildingSave> CrystalsMiners { get; set; }
		public List<BuildingSave> EnergyMiners { get; set; }
	}
}
