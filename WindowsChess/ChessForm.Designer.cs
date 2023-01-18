
namespace WindowsChess
{
    partial class ChessForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChessForm));
            this.gameboard = new System.Windows.Forms.Panel();
            this.MoveInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.FenPrint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Surrend = new System.Windows.Forms.Button();
            this.Offer = new System.Windows.Forms.Button();
            this.MoveCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameResult = new System.Windows.Forms.Label();
            this.shahPrint = new System.Windows.Forms.Label();
            this.selectedFigure = new System.Windows.Forms.Panel();
            this.FenCopyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameboard
            // 
            this.gameboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gameboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameboard.Location = new System.Drawing.Point(113, 68);
            this.gameboard.Name = "gameboard";
            this.gameboard.Size = new System.Drawing.Size(720, 720);
            this.gameboard.TabIndex = 0;
            this.gameboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // MoveInfo
            // 
            this.MoveInfo.AutoSize = true;
            this.MoveInfo.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MoveInfo.Location = new System.Drawing.Point(878, 160);
            this.MoveInfo.Name = "MoveInfo";
            this.MoveInfo.Size = new System.Drawing.Size(86, 33);
            this.MoveInfo.TabIndex = 1;
            this.MoveInfo.Text = "Moves";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 53);
            this.panel1.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(1057, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(35, 35);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.Firebrick;
            this.SideMenu.Controls.Add(this.ExitGameButton);
            this.SideMenu.Controls.Add(this.SaveGameButton);
            this.SideMenu.Controls.Add(this.NewGameButton);
            this.SideMenu.Location = new System.Drawing.Point(0, 53);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(61, 264);
            this.SideMenu.TabIndex = 18;
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExitGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitGameButton.BackgroundImage")));
            this.ExitGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitGameButton.Location = new System.Drawing.Point(5, 210);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(50, 50);
            this.ExitGameButton.TabIndex = 19;
            this.ExitGameButton.UseVisualStyleBackColor = false;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitInMainMenu);
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveGameButton.BackgroundImage")));
            this.SaveGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveGameButton.Location = new System.Drawing.Point(5, 112);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(50, 50);
            this.SaveGameButton.TabIndex = 18;
            this.SaveGameButton.UseVisualStyleBackColor = false;
            this.SaveGameButton.Click += new System.EventHandler(this.SaveCurrentGame);
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.SystemColors.Control;
            this.NewGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewGameButton.BackgroundImage")));
            this.NewGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewGameButton.Location = new System.Drawing.Point(5, 15);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(50, 50);
            this.NewGameButton.TabIndex = 17;
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.OpenNewGame);
            // 
            // FenPrint
            // 
            this.FenPrint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FenPrint.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FenPrint.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FenPrint.Location = new System.Drawing.Point(179, 816);
            this.FenPrint.Name = "FenPrint";
            this.FenPrint.ReadOnly = true;
            this.FenPrint.Size = new System.Drawing.Size(719, 27);
            this.FenPrint.TabIndex = 21;
            this.FenPrint.TabStop = false;
            this.FenPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FenPrint.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 814);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Текущий Fen";
            // 
            // Surrend
            // 
            this.Surrend.BackColor = System.Drawing.Color.Maroon;
            this.Surrend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Surrend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Surrend.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surrend.ForeColor = System.Drawing.SystemColors.Control;
            this.Surrend.Location = new System.Drawing.Point(884, 619);
            this.Surrend.Name = "Surrend";
            this.Surrend.Size = new System.Drawing.Size(167, 68);
            this.Surrend.TabIndex = 24;
            this.Surrend.Text = "Сдаться";
            this.Surrend.UseVisualStyleBackColor = false;
            this.Surrend.Click += new System.EventHandler(this.Surrender);
            // 
            // Offer
            // 
            this.Offer.BackColor = System.Drawing.Color.ForestGreen;
            this.Offer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Offer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Offer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Offer.ForeColor = System.Drawing.SystemColors.Control;
            this.Offer.Location = new System.Drawing.Point(884, 522);
            this.Offer.Name = "Offer";
            this.Offer.Size = new System.Drawing.Size(167, 68);
            this.Offer.TabIndex = 25;
            this.Offer.Text = "Предложить ничью";
            this.Offer.UseVisualStyleBackColor = false;
            this.Offer.Click += new System.EventHandler(this.DrawMenu);
            // 
            // MoveCount
            // 
            this.MoveCount.AutoSize = true;
            this.MoveCount.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MoveCount.Location = new System.Drawing.Point(878, 127);
            this.MoveCount.Name = "MoveCount";
            this.MoveCount.Size = new System.Drawing.Size(101, 33);
            this.MoveCount.TabIndex = 26;
            this.MoveCount.Text = "Counter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(879, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Выбранная фигура";
            // 
            // GameResult
            // 
            this.GameResult.AutoSize = true;
            this.GameResult.BackColor = System.Drawing.Color.Transparent;
            this.GameResult.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GameResult.Location = new System.Drawing.Point(247, 345);
            this.GameResult.Name = "GameResult";
            this.GameResult.Size = new System.Drawing.Size(0, 49);
            this.GameResult.TabIndex = 29;
            this.GameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shahPrint
            // 
            this.shahPrint.AutoSize = true;
            this.shahPrint.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shahPrint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.shahPrint.Location = new System.Drawing.Point(879, 378);
            this.shahPrint.Name = "shahPrint";
            this.shahPrint.Size = new System.Drawing.Size(0, 29);
            this.shahPrint.TabIndex = 30;
            // 
            // selectedFigure
            // 
            this.selectedFigure.BackColor = System.Drawing.Color.Maroon;
            this.selectedFigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectedFigure.Location = new System.Drawing.Point(927, 233);
            this.selectedFigure.Name = "selectedFigure";
            this.selectedFigure.Size = new System.Drawing.Size(100, 100);
            this.selectedFigure.TabIndex = 1;
            // 
            // FenCopyButton
            // 
            this.FenCopyButton.BackColor = System.Drawing.SystemColors.Window;
            this.FenCopyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FenCopyButton.BackgroundImage")));
            this.FenCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FenCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FenCopyButton.Location = new System.Drawing.Point(904, 812);
            this.FenCopyButton.Name = "FenCopyButton";
            this.FenCopyButton.Size = new System.Drawing.Size(35, 35);
            this.FenCopyButton.TabIndex = 22;
            this.FenCopyButton.UseVisualStyleBackColor = false;
            this.FenCopyButton.Click += new System.EventHandler(this.CopyFen);
            // 
            // ChessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1095, 861);
            this.Controls.Add(this.shahPrint);
            this.Controls.Add(this.GameResult);
            this.Controls.Add(this.selectedFigure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoveCount);
            this.Controls.Add(this.Offer);
            this.Controls.Add(this.gameboard);
            this.Controls.Add(this.Surrend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FenCopyButton);
            this.Controls.Add(this.FenPrint);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MoveInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChessGame";
            this.panel1.ResumeLayout(false);
            this.SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameboard;
        private System.Windows.Forms.Label MoveInfo;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.Button SaveGameButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.TextBox FenPrint;
        private System.Windows.Forms.Button FenCopyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Surrend;
        private System.Windows.Forms.Button Offer;
        private System.Windows.Forms.Label MoveCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel selectedFigure;
        private System.Windows.Forms.Label GameResult;
        private System.Windows.Forms.Label shahPrint;
    }
}

