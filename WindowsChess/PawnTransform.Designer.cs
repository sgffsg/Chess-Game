
namespace WindowsChess
{
    partial class PawnTransform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PawnTransform));
            this.label2 = new System.Windows.Forms.Label();
            this.RL = new System.Windows.Forms.Label();
            this.NL = new System.Windows.Forms.Label();
            this.BL = new System.Windows.Forms.Label();
            this.QL = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.Button();
            this.FQ = new System.Windows.Forms.PictureBox();
            this.FB = new System.Windows.Forms.PictureBox();
            this.FN = new System.Windows.Forms.PictureBox();
            this.FR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FR)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(325, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 45);
            this.label2.TabIndex = 29;
            this.label2.Text = "Выберите фигуру для замены";
            // 
            // RL
            // 
            this.RL.AutoSize = true;
            this.RL.BackColor = System.Drawing.Color.Transparent;
            this.RL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RL.Location = new System.Drawing.Point(251, 282);
            this.RL.Name = "RL";
            this.RL.Size = new System.Drawing.Size(54, 55);
            this.RL.TabIndex = 30;
            this.RL.Text = "✓";
            // 
            // NL
            // 
            this.NL.AutoSize = true;
            this.NL.BackColor = System.Drawing.Color.Transparent;
            this.NL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NL.Location = new System.Drawing.Point(501, 282);
            this.NL.Name = "NL";
            this.NL.Size = new System.Drawing.Size(54, 55);
            this.NL.TabIndex = 31;
            this.NL.Text = "✓";
            // 
            // BL
            // 
            this.BL.AutoSize = true;
            this.BL.BackColor = System.Drawing.Color.Transparent;
            this.BL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BL.Location = new System.Drawing.Point(734, 282);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(54, 55);
            this.BL.TabIndex = 32;
            this.BL.Text = "✓";
            // 
            // QL
            // 
            this.QL.AutoSize = true;
            this.QL.BackColor = System.Drawing.Color.Transparent;
            this.QL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QL.Location = new System.Drawing.Point(973, 282);
            this.QL.Name = "QL";
            this.QL.Size = new System.Drawing.Size(54, 55);
            this.QL.TabIndex = 33;
            this.QL.Text = "✓";
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Select.Location = new System.Drawing.Point(417, 370);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(334, 68);
            this.Select.TabIndex = 34;
            this.Select.Text = "Подтвердить выбор";
            this.Select.UseVisualStyleBackColor = false;
            this.Select.Click += new System.EventHandler(this.ConfirmSelection);
            // 
            // FQ
            // 
            this.FQ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FQ.Location = new System.Drawing.Point(820, 139);
            this.FQ.Name = "FQ";
            this.FQ.Size = new System.Drawing.Size(207, 198);
            this.FQ.TabIndex = 6;
            this.FQ.TabStop = false;
            this.FQ.Click += new System.EventHandler(this.selectQueen);
            // 
            // FB
            // 
            this.FB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB.Location = new System.Drawing.Point(581, 139);
            this.FB.Name = "FB";
            this.FB.Size = new System.Drawing.Size(207, 198);
            this.FB.TabIndex = 5;
            this.FB.TabStop = false;
            this.FB.Click += new System.EventHandler(this.selectBishop);
            // 
            // FN
            // 
            this.FN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FN.Location = new System.Drawing.Point(348, 139);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(207, 198);
            this.FN.TabIndex = 4;
            this.FN.TabStop = false;
            this.FN.Click += new System.EventHandler(this.SelectKnight);
            // 
            // FR
            // 
            this.FR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FR.Location = new System.Drawing.Point(98, 139);
            this.FR.Name = "FR";
            this.FR.Size = new System.Drawing.Size(207, 198);
            this.FR.TabIndex = 3;
            this.FR.TabStop = false;
            this.FR.Click += new System.EventHandler(this.SelectRook);
            // 
            // PawnTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.QL);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.NL);
            this.Controls.Add(this.RL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FQ);
            this.Controls.Add(this.FB);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.FR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PawnTransform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PawnTransform";
            ((System.ComponentModel.ISupportInitialize)(this.FQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FR;
        private System.Windows.Forms.PictureBox FN;
        private System.Windows.Forms.PictureBox FB;
        private System.Windows.Forms.PictureBox FQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RL;
        private System.Windows.Forms.Label NL;
        private System.Windows.Forms.Label BL;
        private System.Windows.Forms.Label QL;
        private System.Windows.Forms.Button Select;
    }
}