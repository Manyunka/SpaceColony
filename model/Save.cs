using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	class Save
	{
		public string Name { get; set; }
		public string Descript { get; set; }
		public string ImagePath { get; set; }
		public int Crystals { get; set; }
		public int Energy { get; set; }
		public Colony Colony { get; set; }
	}
}
