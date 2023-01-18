using System;
using System.Windows.Forms;

namespace WindowsChess
{
    public partial class Agreement_menu : Form
    {

        public Agreement_menu()
        {
            InitializeComponent();
            if (GameSettings.curColor == "Черных")
                print.Text = "Черные хотят предложить ничью";
            else print.Text = "Белые хотят предложить ничью";
        }

        private void Accept(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void Decline(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
