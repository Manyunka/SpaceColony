﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceColony.Model
{
    public class Planet
    {
		private const int startedCrystals = 105000;
		private const int startedEnergy = 200000;
		public Planet(string name, string image, string descript)
        {
            Name = name;
			ImagePath = image;
			Descript = descript;
			Crystals crystals = new Crystals(startedCrystals);
			Energy energy = new Energy(startedEnergy);
			List<BaseResource> resources = new List<BaseResource> { crystals, energy };
			Resources = new Resources(resources);
		}

		public Resources Resources { get; private set; }

		public string Name { get; }
        public string Descript { get; }
		public string ImagePath { get; }
		public Colony Colony { get; private set; }
        public void CreateColony(string name)
        {
			if (Colony == null)
			{
				Colony = new Colony(name, this);
			}
			else MessageBox.Show("Колония уже создана");

		}

		public bool TakeResource(Resources resources)
		{
			if (Resources - resources != null)
			{
				Resources -= resources;
				return true;
			}
			return false;
		}
	}
}
