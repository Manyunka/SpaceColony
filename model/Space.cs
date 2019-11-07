using SpaceColony.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.model
{
	class Space
	{
		public Space(IList<Planet> planets)
		{
			Planets = planets;
		}

		public IList<Planet> Planets { get; }
	}
}
