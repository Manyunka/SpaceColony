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
	class BaseView : BuildingView
	{
		public BaseView(Colony colony, string groupName) : base(colony, groupName)
		{
			Text = BoxName;
			BuildingPicture.Image = Image.FromFile(BoxImagePath);
			BuildButton.Click += BuildButton_Click;
			ImproveButton.Click += ImproveButton_Click;
			BuildingsList.SelectedIndexChanged += BuildingsList_SelectedIndexChanged;

			for (int i = 0; i < colony.BaseBuildings.Count; i++)
			{
				BuildingsList.Items.Add(i + 1);
				BuildingsList.Text = colony.BaseBuildings.Count.ToString();

				BuildingLevel.Text = "Уровень: " + colony.BaseBuildings[i].Level;

				if (!ImproveButton.Visible)
					ImproveButton.Visible = true;
				if (!BuildingsList.Visible)
					BuildingsList.Visible = true;
			}
		}

		private void ImproveButton_Click(object sender, EventArgs e)
		{
			var item = colony.BaseBuildings[BuildingsList.SelectedIndex];
			item.UpLevel();
			BuildingLevel.Text = "Уровень: " + item.Level;
		}

		private void BuildingsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var item = colony.BaseBuildings[BuildingsList.SelectedIndex];
			BuildingLevel.Text = "Уровень: " + item.Level;
		}

		private void BuildButton_Click(object sender, EventArgs e)
		{
			if (colony.BuildBase())
			{
				BuildingsList.Items.Add(colony.BaseBuildings.Count);
				BuildingsList.Text = colony.BaseBuildings.Count.ToString();

				BuildingLevel.Text = "Уровень: " + 1;

				if (!ImproveButton.Visible)
					ImproveButton.Visible = true;
				if (!BuildingsList.Visible)
					BuildingsList.Visible = true;
			}
		}

		public override string BoxName => "Базы";
		public override string BoxImagePath => Path.Combine(Environment.CurrentDirectory, "Pictures", "base.png");
	}
}
