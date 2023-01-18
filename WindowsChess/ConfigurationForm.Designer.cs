
namespace WindowsChess
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.GameSavePath = new System.Windows.Forms.TextBox();
            this.GameInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditGameSavePath = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BackToMainMenu);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(295, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 49);
            this.label2.TabIndex = 28;
            this.label2.Text = "Настройки";
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.BackToMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackToMainMenu.BackgroundImage")));
            this.BackToMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackToMainMenu.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackToMainMenu.ForeColor = System.Drawing.Color.White;
            this.BackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(35, 35);
            this.BackToMainMenu.TabIndex = 7;
            this.BackToMainMenu.UseVisualStyleBackColor = false;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMenu);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.ForeColor = System.Drawing.Color.Maroon;
            this.ExitButton.Location = new System.Drawing.Point(1057, 7);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(35, 35);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // GameSavePath
            // 
            this.GameSavePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameSavePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameSavePath.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameSavePath.Location = new System.Drawing.Point(168, 35);
            this.GameSavePath.Name = "GameSavePath";
            this.GameSavePath.ReadOnly = true;
            this.GameSavePath.ShortcutsEnabled = false;
            this.GameSavePath.Size = new System.Drawing.Size(450, 30);
            this.GameSavePath.TabIndex = 23;
            this.GameSavePath.TabStop = false;
            this.GameSavePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GameSavePath.WordWrap = false;
            // 
            // GameInfo
            // 
            this.GameInfo.AutoSize = true;
            this.GameInfo.BackColor = System.Drawing.Color.Transparent;
            this.GameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameInfo.Location = new System.Drawing.Point(66, 25);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(96, 40);
            this.GameInfo.TabIndex = 25;
            this.GameInfo.Text = "Путь для \r\nсохранений";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.GameSavePath);
            this.panel2.Controls.Add(this.EditGameSavePath);
            this.panel2.Controls.Add(this.GameInfo);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 103);
            this.panel2.TabIndex = 27;
            // 
            // EditGameSavePath
            // 
            this.EditGameSavePath.BackColor = System.Drawing.Color.Transparent;
            this.EditGameSavePath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditGameSavePath.BackgroundImage")));
            this.EditGameSavePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditGameSavePath.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.EditGameSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditGameSavePath.Location = new System.Drawing.Point(624, 28);
            this.EditGameSavePath.Name = "EditGameSavePath";
            this.EditGameSavePath.Size = new System.Drawing.Size(50, 50);
            this.EditGameSavePath.TabIndex = 24;
            this.EditGameSavePath.UseVisualStyleBackColor = false;
            this.EditGameSavePath.Click += new System.EventHandler(this.EditPath);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 157);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigurationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EditGameSavePath;
        private System.Windows.Forms.TextBox GameSavePath;
        private System.Windows.Forms.Label GameInfo;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}