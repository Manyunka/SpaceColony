using SpaceColony.model;
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

		private IList<Planet> GetPlanets()
		{
			return new List<Planet>
			{
				new Planet("Проксима b",
				Path.Combine(Environment.CurrentDirectory, "Pictures", "Proxima-b.jpg"),
				"Планета, вращающаяся вокруг красного карлика Проксима Центавра, ближайшей к Солнцу звезды."),
				new Planet("Дульсинея",
				Path.Combine(Environment.CurrentDirectory, "Pictures", "Dulcinea.jpg"),
				"Планета-гигант, вращающаяся вокруг жёлтого карлика, в созвездии Жертвенник на расстоянии 50,6 св.л. от Земли."),
				new Planet("Эгир",
				Path.Combine(Environment.CurrentDirectory, "Pictures", "Egir.jpg"),
				"Планета, обнаруженная у подобной Солнцу звезды Эпсилон Эридана, находящейся на расстоянии примерно 10,5 световых лет от Солнечной системы в созвездии Эридан.")
			};
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			createNextButton.Enabled = false;

			space = new Space(GetPlanets());

			for (int i = 0; i < 3; i++)
			{
				PlanetView planetView = new PlanetView("Planet" + i, space.Planets[i]);
				planetView.PlanetFree.Click += PlanetButton_Click;
				planetView.PlanetFree.Tag = i;
				planetLayoutPanel.Controls.Add(planetView);
			}


		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			planetPanel.BringToFront();
		}

		private void PlanetBackButton_Click(object sender, EventArgs e)
		{
			startPanel.BringToFront();
		}

		private void PlanetButton_Click(object sender, EventArgs e)
		{
			PLANET_INDEX = (int)((Button)sender).Tag;
			colonyPlanetNote.Text = space.Planets[PLANET_INDEX].Name;
			createColonyPanel.BringToFront();
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
			GameForm game = new GameForm(colonyPlanet);
			game.ShowDialog();
			Close();
		}

	}
}
