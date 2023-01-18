
namespace WindowsChess
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FullSideMenu = new System.Windows.Forms.Panel();
            this.ExitGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.UpLoad = new System.Windows.Forms.Button();
            this.ExitInMenuIcon = new System.Windows.Forms.Button();
            this.SaveGameIcon = new System.Windows.Forms.Button();
            this.OpenNewGameIcon = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.FullSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(35, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Шахматы";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 53);
            this.panel2.TabIndex = 5;
            // 
            // FullSideMenu
            // 
            this.FullSideMenu.BackColor = System.Drawing.Color.Black;
            this.FullSideMenu.Controls.Add(this.ExitGame);
            this.FullSideMenu.Controls.Add(this.button2);
            this.FullSideMenu.Controls.Add(this.Settings);
            this.FullSideMenu.Controls.Add(this.Start);
            this.FullSideMenu.Controls.Add(this.UpLoad);
            this.FullSideMenu.Controls.Add(this.ExitInMenuIcon);
            this.FullSideMenu.Controls.Add(this.SaveGameIcon);
            this.FullSideMenu.Controls.Add(this.OpenNewGameIcon);
            this.FullSideMenu.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FullSideMenu.Location = new System.Drawing.Point(0, 52);
            this.FullSideMenu.Name = "FullSideMenu";
            this.FullSideMenu.Size = new System.Drawing.Size(250, 326);
            this.FullSideMenu.TabIndex = 7;
            // 
            // ExitGame
            // 
            this.ExitGame.BackColor = System.Drawing.Color.Brown;
            this.ExitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitGame.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.ExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitGame.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitGame.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitGame.Location = new System.Drawing.Point(80, 250);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(167, 68);
            this.ExitGame.TabIndex = 15;
            this.ExitGame.Text = "Выход";
            this.ExitGame.UseVisualStyleBackColor = false;
            this.ExitGame.Click += new System.EventHandler(this.ExitFromGame);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(12, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ExitFromGame);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.RoyalBlue;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.ForeColor = System.Drawing.SystemColors.Control;
            this.Settings.Location = new System.Drawing.Point(80, 170);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(167, 68);
            this.Settings.TabIndex = 13;
            this.Settings.Text = "Настройки";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.SettingsMenu);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Coral;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.Control;
            this.Start.Location = new System.Drawing.Point(80, 10);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(167, 68);
            this.Start.TabIndex = 11;
            this.Start.Text = "Начать новую игру";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.StartGame);
            // 
            // UpLoad
            // 
            this.UpLoad.BackColor = System.Drawing.Color.LimeGreen;
            this.UpLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpLoad.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.UpLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpLoad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.UpLoad.Location = new System.Drawing.Point(80, 90);
            this.UpLoad.Name = "UpLoad";
            this.UpLoad.Size = new System.Drawing.Size(167, 68);
            this.UpLoad.TabIndex = 12;
            this.UpLoad.Text = "Загрузить игру";
            this.UpLoad.UseVisualStyleBackColor = false;
            this.UpLoad.Click += new System.EventHandler(this.UploadSave);
            // 
            // ExitInMenuIcon
            // 
            this.ExitInMenuIcon.BackColor = System.Drawing.Color.RoyalBlue;
            this.ExitInMenuIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitInMenuIcon.BackgroundImage")));
            this.ExitInMenuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitInMenuIcon.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.ExitInMenuIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitInMenuIcon.Location = new System.Drawing.Point(12, 181);
            this.ExitInMenuIcon.Name = "ExitInMenuIcon";
            this.ExitInMenuIcon.Size = new System.Drawing.Size(50, 50);
            this.ExitInMenuIcon.TabIndex = 10;
            this.ExitInMenuIcon.UseVisualStyleBackColor = false;
            this.ExitInMenuIcon.Click += new System.EventHandler(this.SettingsMenu);
            // 
            // SaveGameIcon
            // 
            this.SaveGameIcon.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveGameIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveGameIcon.BackgroundImage")));
            this.SaveGameIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveGameIcon.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.SaveGameIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveGameIcon.Location = new System.Drawing.Point(12, 101);
            this.SaveGameIcon.Name = "SaveGameIcon";
            this.SaveGameIcon.Size = new System.Drawing.Size(50, 50);
            this.SaveGameIcon.TabIndex = 9;
            this.SaveGameIcon.UseVisualStyleBackColor = false;
            this.SaveGameIcon.Click += new System.EventHandler(this.UploadSave);
            // 
            // OpenNewGameIcon
            // 
            this.OpenNewGameIcon.BackColor = System.Drawing.Color.Coral;
            this.OpenNewGameIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenNewGameIcon.BackgroundImage")));
            this.OpenNewGameIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenNewGameIcon.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.OpenNewGameIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenNewGameIcon.Location = new System.Drawing.Point(12, 21);
            this.OpenNewGameIcon.Name = "OpenNewGameIcon";
            this.OpenNewGameIcon.Size = new System.Drawing.Size(50, 50);
            this.OpenNewGameIcon.TabIndex = 4;
            this.OpenNewGameIcon.UseVisualStyleBackColor = false;
            this.OpenNewGameIcon.Click += new System.EventHandler(this.StartGame);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 377);
            this.Controls.Add(this.FullSideMenu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.FullSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel FullSideMenu;
        private System.Windows.Forms.Button ExitGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button UpLoad;
        private System.Windows.Forms.Button ExitInMenuIcon;
        private System.Windows.Forms.Button SaveGameIcon;
        private System.Windows.Forms.Button OpenNewGameIcon;
    }
}