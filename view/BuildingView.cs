using SpaceColony.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceColony.view
{
	abstract class BuildingView
	{
		protected Colony colony;
		public BuildingView(Colony colony, string name)
		{
			this.colony = colony;
			GroupName = name;
			BuildingBox = new GroupBox
			{
				Name = GroupName,
				Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
				ForeColor = SystemColors.Info,
				Location = new Point(3, 3),
				Size = new Size(320, 200),
				TabIndex = 2,
				TabStop = false,
			};

			BuildingPicture = new PictureBox
			{
				Name = GroupName + "Picture",
				BorderStyle = BorderStyle.FixedSingle,
				InitialImage = null,
				Location = new Point(6, 30),
				Size = new Size(125, 158),
				SizeMode = PictureBoxSizeMode.Zoom,
				TabIndex = 0,
				TabStop = false
			};

			BuildingsList = new ComboBox
			{
				Name = GroupName + "List",
				Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
				FormattingEnabled = true,
				Location = new Point(11, 11),
				Size = new Size(121, 26),
				TabIndex = 5,
				Visible = false
			};
			//BuildingsList.SelectedIndexChanged += BuildingsList_SelectedIndexChanged;

			BuildingLevel = new Label
			{
				Name = GroupName + "Level",
				AutoSize = true,
				Location = new Point(11, 44),
				Size = new Size(106, 23),
				TabIndex = 2,
			};

			ImproveButton = new Button
			{
				Name = GroupName + "ImproveButton",
				AutoSize = true,
				BackColor = Color.Black,
				Location = new Point(11, 67),
				Size = new Size(96, 33),
				TabIndex = 5,
				Text = "Улучшить",
				UseVisualStyleBackColor = false,
				Visible = false
		};
			//ImproveButton.Click += ImproveButton_Click;

			BuildingSettings = new FlowLayoutPanel
			{
				Name = GroupName + "Settings",
				BorderStyle = BorderStyle.FixedSingle,
				FlowDirection = FlowDirection.TopDown,
				Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
				Location = new Point(137, 29),
				Padding = new Padding(8),
				Size = new Size(177, 119),
				TabIndex = 1
			};
			BuildingSettings.Controls.Add(BuildingsList);
			BuildingSettings.Controls.Add(BuildingLevel);
			BuildingSettings.Controls.Add(ImproveButton);

			BuildButton = new Button
			{
				Name = GroupName + "BuildButton",
				AutoSize = true,
				BackColor = Color.Black,
				Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
				Location = new Point(137, 154),
				Size = new Size(177, 33),
				TabIndex = 2,
				Text = "Построить",
				UseVisualStyleBackColor = false
			};
			//BuildButton.Click += BuildButton_Click;

			BuildingBox.Controls.Add(BuildingPicture);
			BuildingBox.Controls.Add(BuildingSettings);
			BuildingBox.Controls.Add(BuildButton);
		}

		public string GroupName { get; }
		abstract public string BoxName { get; }
		abstract public string BoxImagePath { get; }
		public GroupBox BuildingBox { get; }
		public PictureBox BuildingPicture { get; }
		public ComboBox BuildingsList { get; }
		public Label BuildingLevel { get; }
		public Button ImproveButton { get; }
		public FlowLayoutPanel BuildingSettings { get; }
		public Button BuildButton { get; }

		public GroupBox GetBuildingView()
		{
			return BuildingBox;
		}

	}
}
