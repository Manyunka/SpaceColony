﻿using SpaceColony.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony.view
{
	class CrystalsControlView : BuildingView
	{
		public CrystalsControlView(Colony colony, string groupName) : base(colony, groupName)
		{
			BuildingBox.Text = BoxName;
			BuildingPicture.Image = Image.FromFile(BoxImagePath);
			BuildButton.Click += BuildButton_Click;
			ImproveButton.Click += ImproveButton_Click;
			BuildingsList.SelectedIndexChanged += BuildingsList_SelectedIndexChanged;
		}
		public override string BoxName => "Управление добычи кристаллов";
		public override string BoxImagePath => Path.Combine(Environment.CurrentDirectory, @"Pictures\crystals_control.png");

		private void ImproveButton_Click(object sender, EventArgs e)
		{
			var item = colony.CrystalsControlBuildings[BuildingsList.SelectedIndex];
			item.UpLevel();
			BuildingLevel.Text = "Уровень: " + item.Level;
		}

		private void BuildingsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var item = colony.CrystalsControlBuildings[BuildingsList.SelectedIndex];
			BuildingLevel.Text = "Уровень: " + item.Level;
		}

		private void BuildButton_Click(object sender, EventArgs e)
		{
			if (colony.ControlISAllowed())
			{
				colony.BuildControl(0);

				BuildingsList.Items.Add(colony.CrystalsControlBuildings.Count);
				BuildingsList.Text = colony.CrystalsControlBuildings.Count.ToString();

				BuildingLevel.Text = "Уровень: " + 1;

				if (!ImproveButton.Visible)
					ImproveButton.Visible = true;
				if (!BuildingsList.Visible)
					BuildingsList.Visible = true;
			}
		}
	}
}