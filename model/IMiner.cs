using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	interface IMiner
	{
		int MinePerSecond { get; }
		void MineResources();
	}
}
