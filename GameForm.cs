using Newtonsoft.Json;
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
		private readonly Space space;
		private readonly Planet planet;
		private readonly Colony colony;

		public GameForm(Space space, Planet planet)
		{
			this.space = space;
			this.planet = planet;
			colony = planet.Colony;

			InitializeComponent();
		}

		private void GameForm_Load(object sender, EventArgs e)
		{
			planetName.Text = "Планета: " + planet.Name;
			colonyName.Text = "Колония: " + colony.Name;
			ShowResources();

			var baseView = new BaseView(colony, "base");
			var crystalsControlView = new CrystalsControlView(colony, "crystalsControl");
			var energyControlView = new EnergyControlView(colony, "energyControl");
			var crystalsMinerView = new CrystalsMinerView(colony, "crystalsMiner");
			var energyMinerView = new EnergyMinerView(colony, "energyMiner");

			buildingPanel.Controls.Add(baseView);
			buildingPanel.Controls.Add(crystalsControlView);
			buildingPanel.Controls.Add(energyControlView);
			buildingPanel.Controls.Add(crystalsMinerView);
			buildingPanel.Controls.Add(energyMinerView);

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

		private void MenuButton_Click(object sender, EventArgs e)
		{
			contextMenuStrip.Show(menuButton, new Point(-contextMenuStrip.Width + menuButton.Width, menuButton.Height));
		}

		private void MenuStripMenuItem_Click(object sender, EventArgs e)
		{
			Hide();
			MenuForm menu = new MenuForm();
			menu.ShowDialog();
			Close();
		}

		private void ExitStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void SaveStripMenuItem_Click(object sender, EventArgs e)
		{
			IList<Planet> planets = space.Planets;
			IList<Save> data = new List<Save>();

			foreach (Planet planet in planets)
			{
				data.Add(new Save()
				{
					Name = planet.Name,
					Descript = planet.Descript,
					ImagePath = planet.ImagePath,
					Crystals = planet.Resources.GetResource<Crystals>(),
					Energy = planet.Resources.GetResource<Energy>(),
					//Colony = planet.Colony
				}) ;
			}

			string json = JsonConvert.SerializeObject(data.ToArray());
			System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Save.text"), json);
		}
	}
}
