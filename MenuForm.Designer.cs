namespace SpaceColony
{
    partial class MenuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
			this.newGameButton = new System.Windows.Forms.Button();
			this.logo = new System.Windows.Forms.Label();
			this.startPanel = new System.Windows.Forms.Panel();
			this.continueButton = new System.Windows.Forms.Button();
			this.planetPanel = new System.Windows.Forms.Panel();
			this.planetLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.planetBackButton = new System.Windows.Forms.Button();
			this.planetNote = new System.Windows.Forms.Label();
			this.createColonyPanel = new System.Windows.Forms.Panel();
			this.createBackButton = new System.Windows.Forms.Button();
			this.createNextButton = new System.Windows.Forms.Button();
			this.colonyPlanetNote = new System.Windows.Forms.Label();
			this.enterNameText = new System.Windows.Forms.TextBox();
			this.createColonyNote = new System.Windows.Forms.Label();
			this.startPanel.SuspendLayout();
			this.planetPanel.SuspendLayout();
			this.createColonyPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// newGameButton
			// 
			this.newGameButton.BackColor = System.Drawing.Color.Black;
			this.newGameButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.newGameButton.ForeColor = System.Drawing.SystemColors.Info;
			this.newGameButton.Location = new System.Drawing.Point(325, 306);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(200, 56);
			this.newGameButton.TabIndex = 0;
			this.newGameButton.Text = "Новая игра";
			this.newGameButton.UseVisualStyleBackColor = false;
			this.newGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
			// 
			// logo
			// 
			this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.logo.AutoSize = true;
			this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logo.ForeColor = System.Drawing.SystemColors.Info;
			this.logo.Location = new System.Drawing.Point(100, 86);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(639, 108);
			this.logo.TabIndex = 1;
			this.logo.Text = "Space Colony";
			// 
			// startPanel
			// 
			this.startPanel.BackColor = System.Drawing.Color.Transparent;
			this.startPanel.Controls.Add(this.continueButton);
			this.startPanel.Controls.Add(this.logo);
			this.startPanel.Controls.Add(this.newGameButton);
			this.startPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startPanel.Location = new System.Drawing.Point(0, 0);
			this.startPanel.Name = "startPanel";
			this.startPanel.Size = new System.Drawing.Size(844, 521);
			this.startPanel.TabIndex = 2;
			// 
			// continueButton
			// 
			this.continueButton.BackColor = System.Drawing.Color.Black;
			this.continueButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.continueButton.ForeColor = System.Drawing.SystemColors.Info;
			this.continueButton.Location = new System.Drawing.Point(325, 382);
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(200, 56);
			this.continueButton.TabIndex = 2;
			this.continueButton.Text = "Продолжить";
			this.continueButton.UseVisualStyleBackColor = false;
			this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
			// 
			// planetPanel
			// 
			this.planetPanel.BackColor = System.Drawing.Color.Transparent;
			this.planetPanel.Controls.Add(this.planetLayoutPanel);
			this.planetPanel.Controls.Add(this.planetBackButton);
			this.planetPanel.Controls.Add(this.planetNote);
			this.planetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.planetPanel.ForeColor = System.Drawing.SystemColors.Info;
			this.planetPanel.Location = new System.Drawing.Point(0, 0);
			this.planetPanel.Name = "planetPanel";
			this.planetPanel.Size = new System.Drawing.Size(844, 521);
			this.planetPanel.TabIndex = 2;
			// 
			// planetLayoutPanel
			// 
			this.planetLayoutPanel.BackColor = System.Drawing.Color.Black;
			this.planetLayoutPanel.Location = new System.Drawing.Point(89, 107);
			this.planetLayoutPanel.Name = "planetLayoutPanel";
			this.planetLayoutPanel.Size = new System.Drawing.Size(665, 299);
			this.planetLayoutPanel.TabIndex = 4;
			// 
			// planetBackButton
			// 
			this.planetBackButton.AutoSize = true;
			this.planetBackButton.BackColor = System.Drawing.Color.Black;
			this.planetBackButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.planetBackButton.ForeColor = System.Drawing.SystemColors.Info;
			this.planetBackButton.Location = new System.Drawing.Point(82, 427);
			this.planetBackButton.Name = "planetBackButton";
			this.planetBackButton.Size = new System.Drawing.Size(76, 36);
			this.planetBackButton.TabIndex = 2;
			this.planetBackButton.Text = "Назад";
			this.planetBackButton.UseVisualStyleBackColor = false;
			this.planetBackButton.Click += new System.EventHandler(this.PlanetBackButton_Click);
			// 
			// planetNote
			// 
			this.planetNote.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.planetNote.AutoSize = true;
			this.planetNote.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.planetNote.ForeColor = System.Drawing.SystemColors.Info;
			this.planetNote.Location = new System.Drawing.Point(75, 55);
			this.planetNote.Name = "planetNote";
			this.planetNote.Size = new System.Drawing.Size(490, 38);
			this.planetNote.TabIndex = 0;
			this.planetNote.Text = "Выберите планету для колонизации";
			// 
			// createColonyPanel
			// 
			this.createColonyPanel.BackColor = System.Drawing.Color.Transparent;
			this.createColonyPanel.Controls.Add(this.createBackButton);
			this.createColonyPanel.Controls.Add(this.createNextButton);
			this.createColonyPanel.Controls.Add(this.colonyPlanetNote);
			this.createColonyPanel.Controls.Add(this.enterNameText);
			this.createColonyPanel.Controls.Add(this.createColonyNote);
			this.createColonyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.createColonyPanel.Location = new System.Drawing.Point(0, 0);
			this.createColonyPanel.Name = "createColonyPanel";
			this.createColonyPanel.Size = new System.Drawing.Size(844, 521);
			this.createColonyPanel.TabIndex = 3;
			// 
			// createBackButton
			// 
			this.createBackButton.AutoSize = true;
			this.createBackButton.BackColor = System.Drawing.Color.Black;
			this.createBackButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.createBackButton.ForeColor = System.Drawing.SystemColors.Info;
			this.createBackButton.Location = new System.Drawing.Point(82, 427);
			this.createBackButton.Name = "createBackButton";
			this.createBackButton.Size = new System.Drawing.Size(76, 36);
			this.createBackButton.TabIndex = 5;
			this.createBackButton.Text = "Назад";
			this.createBackButton.UseVisualStyleBackColor = false;
			this.createBackButton.Click += new System.EventHandler(this.CreateBackButton_Click);
			// 
			// createNextButton
			// 
			this.createNextButton.AutoSize = true;
			this.createNextButton.BackColor = System.Drawing.Color.Black;
			this.createNextButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.createNextButton.ForeColor = System.Drawing.SystemColors.Info;
			this.createNextButton.Location = new System.Drawing.Point(682, 427);
			this.createNextButton.Name = "createNextButton";
			this.createNextButton.Size = new System.Drawing.Size(79, 36);
			this.createNextButton.TabIndex = 4;
			this.createNextButton.Text = "Далее";
			this.createNextButton.UseVisualStyleBackColor = false;
			this.createNextButton.Click += new System.EventHandler(this.CreateNextButton_Click);
			// 
			// colonyPlanetNote
			// 
			this.colonyPlanetNote.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.colonyPlanetNote.ForeColor = System.Drawing.Color.Salmon;
			this.colonyPlanetNote.Location = new System.Drawing.Point(320, 93);
			this.colonyPlanetNote.Name = "colonyPlanetNote";
			this.colonyPlanetNote.Size = new System.Drawing.Size(200, 29);
			this.colonyPlanetNote.TabIndex = 2;
			this.colonyPlanetNote.Text = "planetNote";
			this.colonyPlanetNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// enterNameText
			// 
			this.enterNameText.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.enterNameText.Location = new System.Drawing.Point(218, 259);
			this.enterNameText.MaxLength = 30;
			this.enterNameText.Name = "enterNameText";
			this.enterNameText.Size = new System.Drawing.Size(400, 41);
			this.enterNameText.TabIndex = 1;
			this.enterNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.enterNameText.TextChanged += new System.EventHandler(this.EnterNameText_TextChanged);
			// 
			// createColonyNote
			// 
			this.createColonyNote.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.createColonyNote.ForeColor = System.Drawing.SystemColors.Info;
			this.createColonyNote.Location = new System.Drawing.Point(263, 156);
			this.createColonyNote.Name = "createColonyNote";
			this.createColonyNote.Size = new System.Drawing.Size(302, 38);
			this.createColonyNote.TabIndex = 0;
			this.createColonyNote.Text = "Введите имя колонии";
			this.createColonyNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MenuForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(844, 521);
			this.Controls.Add(this.startPanel);
			this.Controls.Add(this.planetPanel);
			this.Controls.Add(this.createColonyPanel);
			this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(860, 560);
			this.MinimumSize = new System.Drawing.Size(860, 560);
			this.Name = "MenuForm";
			this.Text = "Space Colony";
			this.Load += new System.EventHandler(this.MenuForm_Load);
			this.startPanel.ResumeLayout(false);
			this.startPanel.PerformLayout();
			this.planetPanel.ResumeLayout(false);
			this.planetPanel.PerformLayout();
			this.createColonyPanel.ResumeLayout(false);
			this.createColonyPanel.PerformLayout();
			this.ResumeLayout(false);

        }


		#endregion

		private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label logo;
		private System.Windows.Forms.Panel startPanel;
		private System.Windows.Forms.Panel planetPanel;
		private System.Windows.Forms.Label planetNote;
		private System.Windows.Forms.Button planetBackButton;
		private System.Windows.Forms.Panel createColonyPanel;
		private System.Windows.Forms.TextBox enterNameText;
		private System.Windows.Forms.Label createColonyNote;
		private System.Windows.Forms.Button createBackButton;
		private System.Windows.Forms.Button createNextButton;
		private System.Windows.Forms.Label colonyPlanetNote;
		private System.Windows.Forms.FlowLayoutPanel planetLayoutPanel;
		private System.Windows.Forms.Button continueButton;
	}
}

