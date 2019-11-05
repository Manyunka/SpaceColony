namespace SpaceColony
{
	partial class GameForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			this.buildingPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MenuButton = new System.Windows.Forms.Button();
			this.dataBox = new System.Windows.Forms.GroupBox();
			this.crystalsPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.crystalsScore = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.energyScore = new System.Windows.Forms.Label();
			this.colonyName = new System.Windows.Forms.Label();
			this.planetName = new System.Windows.Forms.Label();
			this.mineTimer = new System.Windows.Forms.Timer(this.components);
			this.dataBox.SuspendLayout();
			this.crystalsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// buildingPanel
			// 
			this.buildingPanel.AutoScroll = true;
			this.buildingPanel.BackColor = System.Drawing.Color.Black;
			this.buildingPanel.ForeColor = System.Drawing.SystemColors.Info;
			this.buildingPanel.Location = new System.Drawing.Point(31, 30);
			this.buildingPanel.Name = "buildingPanel";
			this.buildingPanel.Size = new System.Drawing.Size(360, 469);
			this.buildingPanel.TabIndex = 0;
			// 
			// MenuButton
			// 
			this.MenuButton.AutoSize = true;
			this.MenuButton.BackColor = System.Drawing.Color.Black;
			this.MenuButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MenuButton.ForeColor = System.Drawing.SystemColors.Info;
			this.MenuButton.Location = new System.Drawing.Point(750, 21);
			this.MenuButton.Name = "MenuButton";
			this.MenuButton.Size = new System.Drawing.Size(82, 36);
			this.MenuButton.TabIndex = 3;
			this.MenuButton.Text = "Меню";
			this.MenuButton.UseVisualStyleBackColor = false;
			// 
			// dataBox
			// 
			this.dataBox.BackColor = System.Drawing.Color.Black;
			this.dataBox.Controls.Add(this.crystalsPanel);
			this.dataBox.Controls.Add(this.flowLayoutPanel1);
			this.dataBox.Controls.Add(this.colonyName);
			this.dataBox.Controls.Add(this.planetName);
			this.dataBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dataBox.ForeColor = System.Drawing.SystemColors.Info;
			this.dataBox.Location = new System.Drawing.Point(441, 311);
			this.dataBox.Name = "dataBox";
			this.dataBox.Size = new System.Drawing.Size(391, 188);
			this.dataBox.TabIndex = 4;
			this.dataBox.TabStop = false;
			this.dataBox.Text = "Данные";
			// 
			// crystalsPanel
			// 
			this.crystalsPanel.AutoSize = true;
			this.crystalsPanel.Controls.Add(this.pictureBox1);
			this.crystalsPanel.Controls.Add(this.crystalsScore);
			this.crystalsPanel.Location = new System.Drawing.Point(25, 89);
			this.crystalsPanel.Name = "crystalsPanel";
			this.crystalsPanel.Size = new System.Drawing.Size(343, 42);
			this.crystalsPanel.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SpaceColony.Properties.Resources.crystal;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// crystalsScore
			// 
			this.crystalsScore.AutoSize = true;
			this.crystalsScore.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalsScore.Location = new System.Drawing.Point(39, 0);
			this.crystalsScore.Name = "crystalsScore";
			this.crystalsScore.Size = new System.Drawing.Size(134, 36);
			this.crystalsScore.TabIndex = 2;
			this.crystalsScore.Text = "crystalsScore";
			this.crystalsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
			this.flowLayoutPanel1.Controls.Add(this.energyScore);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 137);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(343, 36);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::SpaceColony.Properties.Resources.energy;
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// energyScore
			// 
			this.energyScore.AutoSize = true;
			this.energyScore.Dock = System.Windows.Forms.DockStyle.Fill;
			this.energyScore.Location = new System.Drawing.Point(39, 0);
			this.energyScore.Name = "energyScore";
			this.energyScore.Size = new System.Drawing.Size(123, 36);
			this.energyScore.TabIndex = 3;
			this.energyScore.Text = "energyScore";
			this.energyScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// colonyName
			// 
			this.colonyName.AutoSize = true;
			this.colonyName.Location = new System.Drawing.Point(20, 60);
			this.colonyName.Name = "colonyName";
			this.colonyName.Size = new System.Drawing.Size(117, 26);
			this.colonyName.TabIndex = 1;
			this.colonyName.Text = "colonyName";
			// 
			// planetName
			// 
			this.planetName.AutoSize = true;
			this.planetName.Location = new System.Drawing.Point(20, 34);
			this.planetName.Name = "planetName";
			this.planetName.Size = new System.Drawing.Size(115, 26);
			this.planetName.TabIndex = 0;
			this.planetName.Text = "planetName";
			// 
			// mineTimer
			// 
			this.mineTimer.Interval = 1000;
			this.mineTimer.Tick += new System.EventHandler(this.MineTimer_Tick);
			// 
			// GameForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(844, 521);
			this.Controls.Add(this.dataBox);
			this.Controls.Add(this.MenuButton);
			this.Controls.Add(this.buildingPanel);
			this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(860, 560);
			this.MinimumSize = new System.Drawing.Size(860, 560);
			this.Name = "GameForm";
			this.Text = "Space Colony";
			this.Load += new System.EventHandler(this.GameForm_Load);
			this.dataBox.ResumeLayout(false);
			this.dataBox.PerformLayout();
			this.crystalsPanel.ResumeLayout(false);
			this.crystalsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel buildingPanel;
		private System.Windows.Forms.GroupBox dataBox;
		private System.Windows.Forms.Label crystalsScore;
		private System.Windows.Forms.Label colonyName;
		private System.Windows.Forms.Label planetName;
		private System.Windows.Forms.Label energyScore;
		private System.Windows.Forms.FlowLayoutPanel crystalsPanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button MenuButton;
		private System.Windows.Forms.Timer mineTimer;
	}
}