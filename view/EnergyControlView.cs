using SpaceColony.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.view
{
	class EnergyControlView : BuildingView
	{
		public EnergyControlView(Colony colony, string groupName) : base(colony, groupName)
		{
			Text = BoxName;
			BuildingPicture.Image = Image.FromFile(BoxImagePath);

			BuildButton.Click += BuildButton_Click;
			ImproveButton.Click += ImproveButton_Click;
			BuildingsList.SelectedIndexChanged += BuildingsList_SelectedIndexChanged;

			for (int i = 0; i < colony.EnergyControlBuildings.Count; i++)
			{
				BuildingsList.Items.Add(i + 1);
				BuildingsList.Text = colony.EnergyControlBuildings.Count.ToString();

				BuildingLevel.Text = "Уровень: " + colony.EnergyControlBuildings[i].Level;

				if (!ImproveButton.Visible)
					ImproveButton.Visible = true;
				if (!BuildingsList.Visible)
					BuildingsList.Visible = true;
			}
		}
		public override string BoxName => "Управление энергетикой";
		public override string BoxImagePath => Path.Combine(Environment.CurrentDirectory, "Pictures", "energy_control.png");

		private void ImproveButton_Click(object sender, EventArgs e)
		{
			var item = colony.EnergyControlBuildings[BuildingsList.SelectedIndex];
			item.UpLevel();
			BuildingLevel.Text = "Уровень: " + item.Level;
		}

		private void BuildingsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var item = colony.EnergyControlBuildings[BuildingsList.SelectedIndex];
			BuildingLevel.Text = "Уровень: " + item.Level;
		}

		private void BuildButton_Click(object sender, EventArgs e)
		{
			if (colony.BuildControl(1))
			{
				BuildingsList.Items.Add(colony.EnergyControlBuildings.Count);
				BuildingsList.Text = colony.EnergyControlBuildings.Count.ToString();

				BuildingLevel.Text = "Уровень: " + 1;

				if (!ImproveButton.Visible)
					ImproveButton.Visible = true;
				if (!BuildingsList.Visible)
					BuildingsList.Visible = true;
			}
		}
	}
}
