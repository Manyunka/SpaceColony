using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceColony.Model
{
	class LifeCycle
	{
		public void Live(Colony colony)
		{
			Task.Run(() =>
			{
					var watch = new Stopwatch();
					watch.Start();
					//colony.CrystalsMiners.AsParallel().ForAll(item => item.MineResources());
					//colony.EnergyMiners.AsParallel().ForAll(item => item.MineResources());
					watch.Stop();

					Thread.Sleep(1000 - (int)watch.ElapsedMilliseconds);
			}).Wait();
		}
	}
}
