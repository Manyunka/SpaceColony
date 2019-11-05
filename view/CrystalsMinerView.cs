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
	class CrystalsMinerView : BuildingView
	{
		public CrystalsMinerView(Colony colony, string groupName) : base(colony, groupName)
		{
			BuildingBox.Text = BoxName;
			BuildingPicture.Image = Image.FromFile(BoxImagePath);

			BuildButton.Click += BuildButton_Click;
			ImproveButton.Click += ImproveButton_Click;
			BuildingsList.SelectedIndexChanged += BuildingsList_SelectedIndexChanged;
		}
		public override string BoxName => "Кристальный рудник";
		public override string BoxImagePath => Path.Combine(Environment.CurrentDirectory, @"Pictures\crystals_miner.png");

		private void ImproveButton_Click(object sender, EventArgs e)
		{
			var item = colony.CrystalsMiners[BuildingsList.SelectedIndex];
			item.UpLevel();
			BuildingLevel.Text = "Уровень: " + item.Level;
		}

		private void BuildingsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var item = colony.CrystalsMiners[BuildingsList.SelectedIndex];
			BuildingLevel.Text = "Уровень: " + item.Level;
		}

		private void BuildButton_Click(object sender, EventArgs e)
		{
			if (colony.MinerISAllowed(0))
			{
				colony.BuildMiner(0);

				BuildingsList.Items.Add(colony.CrystalsMiners.Count);
				BuildingsList.Text = colony.CrystalsMiners.Count.ToString();

				BuildingLevel.Text = "Уровень: " + 1;

				if (!ImproveButton.Visible)
					ImproveButton.Visible = true;
				if (!BuildingsList.Visible)
					BuildingsList.Visible = true;
			}
		}
	}
}
