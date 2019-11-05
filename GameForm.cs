using SpaceColony.Model;
using SpaceColony.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceColony
{
	public partial class GameForm : Form
	{
		private Planet planet;
		private Colony colony;
		private LifeCycle lifeCycle;

		private BaseView baseView;
		private CrystalsControlView crystalsControlView;
		private EnergyControlView energyControlView;
		private CrystalsMinerView crystalsMinerView;
		private EnergyMinerView energyMinerView;
		public GameForm(Planet planet)
		{
			this.planet = planet;
			colony = planet.Colony;
			lifeCycle = new LifeCycle();

			InitializeComponent();
		}

		private void GameForm_Load(object sender, EventArgs e)
		{
			planetName.Text = "Планета: " + planet.Name;
			colonyName.Text = "Колония: " + colony.Name;
			ShowResources();

			baseView = new BaseView(colony, "base");
			crystalsControlView = new CrystalsControlView(colony, "crystalsControl");
			energyControlView = new EnergyControlView(colony, "energyControl");
			crystalsMinerView = new CrystalsMinerView(colony, "crystalsMiner");
			energyMinerView = new EnergyMinerView(colony, "energyMiner");

			buildingPanel.Controls.Add(baseView.GetBuildingView());
			buildingPanel.Controls.Add(crystalsControlView.GetBuildingView());
			buildingPanel.Controls.Add(energyControlView.GetBuildingView());
			buildingPanel.Controls.Add(crystalsMinerView.GetBuildingView());
			buildingPanel.Controls.Add(energyMinerView.GetBuildingView());

			colony.ChangeResources += () =>
			{
				ShowResources();
			};

			mineTimer.Start();
		}

		private void ShowResources()
		{ 
			crystalsScore.Text = "Кристаллы: " + colony.Resources.GetResource<Crystals>() + "/" + planet.Resources.GetResource<Crystals>();
			energyScore.Text = "Энергия: " + colony.Resources.GetResource<Energy>() + "/" + planet.Resources.GetResource<Energy>();
		}

		private void MineTimer_Tick(object sender, EventArgs e)
		{
			foreach (CrystalsMiner crystalsMiner in colony.CrystalsMiners)
				crystalsMiner.MineResources();
			foreach (EnergyMiner energyMiner in colony.EnergyMiners)
				energyMiner.MineResources();
		}
	}
}
