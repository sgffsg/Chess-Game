
namespace WindowsChess
{
    partial class Agreement_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agreement_menu));
            this.print = new System.Windows.Forms.Label();
            this.Agree = new System.Windows.Forms.Label();
            this.Reject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.AutoSize = true;
            this.print.BackColor = System.Drawing.Color.Transparent;
            this.print.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.print.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.print.ForeColor = System.Drawing.Color.Maroon;
            this.print.Location = new System.Drawing.Point(116, 28);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(601, 49);
            this.print.TabIndex = 29;
            this.print.Text = "Черные хотят предложить ничью\"";
            // 
            // Agree
            // 
            this.Agree.AutoSize = true;
            this.Agree.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Agree.ForeColor = System.Drawing.Color.LimeGreen;
            this.Agree.Location = new System.Drawing.Point(240, 105);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(72, 73);
            this.Agree.TabIndex = 33;
            this.Agree.Text = "✓";
            this.Agree.Click += new System.EventHandler(this.Accept);
            // 
            // Reject
            // 
            this.Reject.AutoSize = true;
            this.Reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reject.ForeColor = System.Drawing.Color.Red;
            this.Reject.Location = new System.Drawing.Point(474, 105);
            this.Reject.Name = "Reject";
            this.Reject.Size = new System.Drawing.Size(75, 73);
            this.Reject.TabIndex = 34;
            this.Reject.Text = "✗";
            this.Reject.Click += new System.EventHandler(this.Decline);
            // 
            // Agreement_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 212);
            this.Controls.Add(this.Reject);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agreement_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agreement_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label print;
        private System.Windows.Forms.Label Agree;
        private System.Windows.Forms.Label Reject;
    }
}