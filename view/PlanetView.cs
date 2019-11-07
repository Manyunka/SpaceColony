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
	class PlanetView : GroupBox
	{
		public PlanetView(string boxName, Planet planet)
		{
			BoxName = boxName;

			Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			ForeColor = SystemColors.Info;
			Location = new Point(3, 3);
			Name = BoxName + "Box";
			Size = new Size(215, 290);
			TabIndex = 0;
			TabStop = false;
			Text = planet.Name;

			PlanetPicture = new PictureBox
			{
				Location = new Point(26, 28),
				Name = BoxName + "Picture",
				Size = new Size(160, 160),
				SizeMode = PictureBoxSizeMode.Zoom,
				TabIndex = 0,
				TabStop = false,
				Image = Image.FromFile(planet.ImagePath)
			};


			PlanetResources = new Label
			{
				AutoSize = true,
				Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
				Location = new Point(10, 191),
				Name = BoxName + "Resources",
				Size = new Size(154, 26),
				TabIndex = 2,
				Text = "Кристаллы: " + planet.Resources.GetResource<Crystals>().ToString()
				+ "\nЭнергия: " + planet.Resources.GetResource<Energy>().ToString(),
				TextAlign = ContentAlignment.TopLeft
			};

			PlanetFree = new Button
			{
				//AutoSize = true,
				AutoSize = false,
				Dock = DockStyle.None,
				Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, ((byte)(204))),
				Location = new Point(10, 250),
				//PlanetNeme.Name = "planetName";
				Size = new Size(200, 35),
				TabIndex = 1,
				Text = planet.Colony == null ? "Свободно" : "Колонизировано",
				ForeColor = planet.Colony == null ? Color.Green : Color.Red,
				TextAlign = ContentAlignment.MiddleCenter
			};

			Controls.Add(PlanetPicture);
			Controls.Add(PlanetResources);
			Controls.Add(PlanetFree);

		}

		//public string PlanetName { get; }
		public string BoxName { get; }
		//public string BoxImagePath { get; }
		public PictureBox PlanetPicture { get; }
		public Button PlanetFree { get; }
		public Label PlanetResources { get; }

	}
}
