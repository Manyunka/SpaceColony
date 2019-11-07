using Newtonsoft.Json;
using SpaceColony.Model;
using SpaceColony.view;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SpaceColony
{
	public partial class MenuForm : Form
	{
		int PLANET_INDEX = -1;
		Space space;

		public MenuForm()
		{
			InitializeComponent();
		}

		private IList<Planet> GetNewPlanets()
		{
			return new List<Planet>
			{
				new Planet(space, "Проксима b",
				Path.Combine(Environment.CurrentDirectory, "Pictures", "Proxima-b.jpg"),
				"Планета, вращающаяся вокруг красного карлика Проксима Центавра, ближайшей к Солнцу звезды."),
				new Planet(space, "Дульсинея",
				Path.Combine(Environment.CurrentDirectory, "Pictures", "Dulcinea.jpg"),
				"Планета-гигант, вращающаяся вокруг жёлтого карлика, в созвездии Жертвенник на расстоянии 50,6 св.л. от Земли."),
				new Planet(space, "Эгир",
				Path.Combine(Environment.CurrentDirectory, "Pictures", "Egir.jpg"),
				"Планета, обнаруженная у подобной Солнцу звезды Эпсилон Эридана, находящейся на расстоянии примерно 10,5 световых лет от Солнечной системы в созвездии Эридан.")
			};
		}

		private IList<Planet> GetSavingPlanets()
		{
			IList<Planet> planets = new List<Planet>();
			List<PlanetSave> planetsSave = JsonConvert.DeserializeObject<List<PlanetSave>>(
				File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "Save.text")));
			foreach (var planetSave in planetsSave)
			{
				var planet = new Planet(
					space,
					planetSave.Name,
					planetSave.ImagePath,
					planetSave.Descript,
					planetSave.Resources.Crystals,
					planetSave.Resources.Energy
					);

				if (planetSave.Colony != null)
				{
					planet.CreateColony(
						planetSave.Colony.Name,
						planetSave.Colony.Resources.Crystals,
						planetSave.Colony.Resources.Energy
						);

					foreach (var building in planetSave.Colony.BaseBuildings)
					{
						planet.Colony.BaseBuildings.Add(new Base(
							planet.Colony,
							building.Level,
							building.Cost.Crystals,
							building.Cost.Energy
							));
					}

					foreach (var building in planetSave.Colony.CrystalsControlBuildings)
					{
						planet.Colony.CrystalsControlBuildings.Add(new CrystalsControl(
							planet.Colony,
							building.Level,
							building.Cost.Crystals,
							building.Cost.Energy
							));
					}

					foreach (var building in planetSave.Colony.EnergyControlBuildings)
					{
						planet.Colony.EnergyControlBuildings.Add(new EnergyControl(
							planet.Colony,
							building.Level,
							building.Cost.Crystals,
							building.Cost.Energy
							));
					}

					foreach (var building in planetSave.Colony.CrystalsMiners)
					{
						planet.Colony.CrystalsMiners.Add(new CrystalsMiner(
							planet.Colony,
							building.Level,
							building.Cost.Crystals,
							building.Cost.Energy
							));
					}

					foreach (var building in planetSave.Colony.EnergyMiners)
					{
						planet.Colony.EnergyMiners.Add(new EnergyMiner(
							planet.Colony,
							building.Level,
							building.Cost.Crystals,
							building.Cost.Energy
							));
					}
				}

				planets.Add(planet);
			}

			return planets;
		}

		private void MenuForm_Load(object sender, EventArgs e)
		{
			space = new Space();
			createNextButton.Enabled = false;
			if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "Save.text")))
				continueButton.Enabled = false;
		}

		private void LoadPlanets()
		{
			for (int i = 0; i < 3; i++)
			{
				PlanetView planetView = new PlanetView("Planet" + i, space.Planets[i]);
				planetView.PlanetFree.Click += PlanetButton_Click;
				planetView.PlanetFree.Tag = i;
				planetLayoutPanel.Controls.Add(planetView);
			}
		}

		private void NewGameButton_Click(object sender, EventArgs e)
		{
			if (File.Exists(Path.Combine(Environment.CurrentDirectory, "Save.text")))
				File.Delete(Path.Combine(Environment.CurrentDirectory, "Save.text"));
			space.Planets = GetNewPlanets();
			LoadPlanets();
			planetPanel.BringToFront();
		}


		private void ContinueButton_Click(object sender, EventArgs e)
		{
			space.Planets = GetSavingPlanets();
			LoadPlanets();
			planetPanel.BringToFront();
		}

		private void PlanetBackButton_Click(object sender, EventArgs e)
		{
			startPanel.BringToFront();
		}

		private void PlanetButton_Click(object sender, EventArgs e)
		{
			PLANET_INDEX = (int)((Button)sender).Tag;

			if (space.Planets[PLANET_INDEX].Colony != null)
			{
				Hide();
				GameForm game = new GameForm(space, space.Planets[PLANET_INDEX]);
				game.ShowDialog();
				Close();
			}
			else
			{
				colonyPlanetNote.Text = space.Planets[PLANET_INDEX].Name;
				createColonyPanel.BringToFront();
			}
		}

		private void CreateBackButton_Click(object sender, EventArgs e)
		{
			planetPanel.BringToFront();
		}

		private void EnterNameText_TextChanged(object sender, EventArgs e)
		{
			if (enterNameText.TextLength > 0) createNextButton.Enabled = true;
			else createNextButton.Enabled = false;
		}

		private void CreateNextButton_Click(object sender, EventArgs e)
		{
			space.Planets[PLANET_INDEX].CreateColony(enterNameText.Text);
			Planet colonyPlanet = space.Planets[PLANET_INDEX];

			Hide();
			GameForm game = new GameForm(space, colonyPlanet);
			game.ShowDialog();
			Close();
		}

	}
}
