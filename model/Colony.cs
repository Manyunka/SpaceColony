using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceColony.Model
{
	public class Colony
	{
		private const int startedCrystals = 150000;
		private const int startedEnergy = 200000;
		public Colony(string name, Planet planet, int sCrystal = startedCrystals, int sEnergy = startedEnergy)
		{
			Name = name;
			Crystals crystals = new Crystals(sCrystal);
			Energy energy = new Energy(sEnergy);
			List<BaseResource> resources = new List<BaseResource> { crystals, energy };
			Resources = new Resources(resources);
			Planet = planet;

			BaseBuildings = new List<Base>();
			CrystalsControlBuildings = new List<CrystalsControl>();
			EnergyControlBuildings = new List<EnergyControl>();
			CrystalsMiners = new List<CrystalsMiner>();
			EnergyMiners = new List<EnergyMiner>();
		}

		public Planet Planet { get; }
		public string Name { get; }
		public Resources Resources { get; private set; }
		public IList<Base> BaseBuildings { get; private set; }
		public IList<CrystalsControl> CrystalsControlBuildings { get; private set; }
		public IList<EnergyControl> EnergyControlBuildings { get; private set; }
		public IList<CrystalsMiner> CrystalsMiners { get; private set; }
		public IList<EnergyMiner> EnergyMiners { get; private set; }

		public bool BuildBase()
		{
			Base newBase = new Base(this);
			if (AllowedPay(newBase))
			{
				BaseBuildings.Add(newBase);
				return true;
			}
			return false;
		}

		public bool BuildControl(int type)
		{
			if (ControlISAllowed())
			{
				switch (type)
				{
					case 0:
						CrystalsControl crystalsControl = new CrystalsControl(this);
						if (AllowedPay(crystalsControl))
						{
							CrystalsControlBuildings.Add(crystalsControl);
							return true;
						}
						break;
					case 1:
						EnergyControl energyControl = new EnergyControl(this);
						if (AllowedPay(energyControl))
						{
							EnergyControlBuildings.Add(energyControl);
							return true;
						}
						break;
				}
			}

			return false;
		}

		public bool ControlISAllowed()
		{
			if (LevelCount(BaseBuildings) * 3 > CrystalsControlBuildings.Count + EnergyControlBuildings.Count)
				return true;
			MessageBox.Show("Уровень баз слишком низкий");
			return false;
		}

		public bool BuildMiner(int type)
		{
			if (MinerISAllowed(type))
			{
				switch (type)
				{
					case 0:
						CrystalsMiner crystalsMiner = new CrystalsMiner(this);
						if (AllowedPay(crystalsMiner))
						{
							CrystalsMiners.Add(crystalsMiner);
							return true;
						}
						break;
					case 1:
						EnergyMiner energyMiner = new EnergyMiner(this);
						if (AllowedPay(energyMiner))
						{
							EnergyMiners.Add(energyMiner);
							return true;
						}
						break;
				}
			}

			return false;
		}

		public bool MinerISAllowed(int type)
		{
			switch (type)
			{
				case 0:
					if (LevelCount(CrystalsControlBuildings) > CrystalsMiners.Count)
						return true;
					break;
				case 1:
					if (LevelCount(EnergyControlBuildings) > EnergyMiners.Count)
						return true;
					break;
			}
			MessageBox.Show("Уровень управлений слишком низкий");
			return false;
		}

		public bool AllowedPay<T>(T building) where T : Building
		{
			if (Resources - building.Cost != null)
			{
				Resources -= building.Cost;
				ChangeResources();
				return true;
			}
			MessageBox.Show("Недостаточно ресурсов");
			return false;
		}

		public void AddResources(Resources resources)
		{
			Resources += resources;
			ChangeResources();
		}

		private int LevelCount<T>(IList<T> ControlBuildings) where T : Building
		{
			int count = 0;
			foreach (Building item in ControlBuildings)
			{
				count += item.Level * 2;
			}

			return count;
		}

		public event Action ChangeResources;
	}
}
