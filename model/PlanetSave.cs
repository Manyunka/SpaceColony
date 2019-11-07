using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	class PlanetSave
	{
		public string Name { get; set; }
		public string Descript { get; set; }
		public string ImagePath { get; set; }
		public ResourcesSave Resources { get; set; }
		public ColonySave Colony { get; set; }
	}
}
