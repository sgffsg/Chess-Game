
namespace WindowsChess
{
    partial class LoadForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.SaveList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConfirmLoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SaveList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveList
            // 
            this.SaveList.AllowUserToAddRows = false;
            this.SaveList.AllowUserToDeleteRows = false;
            this.SaveList.AllowUserToResizeColumns = false;
            this.SaveList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SaveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaveList.DefaultCellStyle = dataGridViewCellStyle2;
            this.SaveList.EnableHeadersVisualStyles = false;
            this.SaveList.Location = new System.Drawing.Point(0, 53);
            this.SaveList.MultiSelect = false;
            this.SaveList.Name = "SaveList";
            this.SaveList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaveList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SaveList.RowHeadersVisible = false;
            this.SaveList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SaveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SaveList.ShowCellErrors = false;
            this.SaveList.ShowCellToolTips = false;
            this.SaveList.ShowEditingIcon = false;
            this.SaveList.ShowRowErrors = false;
            this.SaveList.Size = new System.Drawing.Size(800, 240);
            this.SaveList.TabIndex = 0;
            this.SaveList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConfirmLoadSave);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название сохранения";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата создания";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BackToMainMenu);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(267, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 49);
            this.label2.TabIndex = 29;
            this.label2.Text = "Диспетчер Сохранений";
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.BackToMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackToMainMenu.BackgroundImage")));
            this.BackToMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            // ConfirmLoadButton
            // 
            this.ConfirmLoadButton.BackColor = System.Drawing.Color.Snow;
            this.ConfirmLoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfirmLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmLoadButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmLoadButton.ForeColor = System.Drawing.Color.Maroon;
            this.ConfirmLoadButton.Location = new System.Drawing.Point(329, 305);
            this.ConfirmLoadButton.Name = "ConfirmLoadButton";
            this.ConfirmLoadButton.Size = new System.Drawing.Size(167, 68);
            this.ConfirmLoadButton.TabIndex = 12;
            this.ConfirmLoadButton.Text = "Выбрать сохранение";
            this.ConfirmLoadButton.UseVisualStyleBackColor = false;
            this.ConfirmLoadButton.Click += new System.EventHandler(this.ConfirmLoad);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.ConfirmLoadButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadForm";
            ((System.ComponentModel.ISupportInitialize)(this.SaveList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SaveList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button ConfirmLoadButton;
        private System.Windows.Forms.Label label2;
    }
}