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
    public partial class MenuForm : Form
    {
		int PLANET_INDEX = -1;
		List<Planet> planets;

		public MenuForm()
        {
            InitializeComponent();
        }

		private List<Planet> GetPlanets()
		{
			List<Planet> planets = new List<Planet>
			{
				new Planet("Проксима b",
				Path.Combine(Environment.CurrentDirectory, @"Pictures\Proxima-b.jpg"),
				"Планета, вращающаяся вокруг красного карлика Проксима Центавра, ближайшей к Солнцу звезды."),
				new Planet("Дульсинея",
				Path.Combine(Environment.CurrentDirectory, @"Pictures\Dulcinea.jpg"),
				"Планета-гигант, вращающаяся вокруг жёлтого карлика, в созвездии Жертвенник на расстоянии 50,6 св.л. от Земли."),
				new Planet("Эгир",
				Path.Combine(Environment.CurrentDirectory, @"Pictures\Egir.jpg"),
				"Планета, обнаруженная у подобной Солнцу звезды Эпсилон Эридана, находящейся на расстоянии примерно 10,5 световых лет от Солнечной системы в созвездии Эридан.")
			};

			return planets;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//planetNextButton.Enabled = false;
			createNextButton.Enabled = false;

			planets = GetPlanets();
			//string[] names = new string[3];
			//string[] descripts = new string[3];

			for (int i = 0; i < 3; i++)
			{
				PlanetView planetView = new PlanetView("Planet" + i, planets[i]);
				//tableLayoutPanel1.Controls.Add(planetView.GetPlanetView());
				//planetView.Tag = i;
				//planetView.Click += PlanetButton_Click;
				planetView.PlanetFree.Click += PlanetButton_Click;
				planetView.PlanetFree.Tag = i;
				planetLayoutPanel.Controls.Add(planetView.GetPlanetView());
				//names[i] = planets[i].Name;
				//descripts[i] = planets[i].Descript;
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

		/*private void ListViewPlanets_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewPlanets.SelectedItems.Count > 0)
			{
				PLANET_INDEX = listViewPlanets.SelectedIndices[0];
				planetNextButton.Enabled = true;
			}
	
		}*/

		private void PlanetButton_Click(object sender, EventArgs e)
		{
			PLANET_INDEX = (int)((Button)sender).Tag;
			colonyPlanetNote.Text = planets[PLANET_INDEX].Name;
			createColonyPanel.BringToFront();
		}

		private void CreateBackButton_Click(object sender, EventArgs e)
		{
			//planetNextButton.Enabled = false;
			//listViewPlanets.SelectedIndices.Clear();
			planetPanel.BringToFront();
		}

		private void EnterNameText_TextChanged(object sender, EventArgs e)
		{
			if (enterNameText.TextLength > 0) createNextButton.Enabled = true;
			else createNextButton.Enabled = false;
		}

		private void CreateNextButton_Click(object sender, EventArgs e)
		{
			planets[PLANET_INDEX].CreateColony(enterNameText.Text);
			Planet colonyPlanet = planets[PLANET_INDEX];

			this.Hide();
			GameForm game = new GameForm(colonyPlanet);
			game.ShowDialog();
			Close();
		}

	}
}
