using System;
using System.Windows.Forms;

namespace WindowsChess
{
    public partial class PawnTransform : Form
    {
        public PawnTransform()
        {
            InitializeComponent();
            ClearSelection();
            GameSettings.pawnPromotion = 'z';
            ShowPositions();
        }


        void ShowPositions()
        {
            if (GameSettings.curColor == "Черных")
            {
                label2.ForeColor = System.Drawing.Color.Black;
                this.BackColor = System.Drawing.Color.White;
                FR.BackColor = System.Drawing.Color.White;
                FN.BackColor = System.Drawing.Color.White;
                FB.BackColor = System.Drawing.Color.White;
                FQ.BackColor = System.Drawing.Color.White;
                FR.BackgroundImage = Properties.Resources.bR;
                FN.BackgroundImage = Properties.Resources.bN;
                FB.BackgroundImage = Properties.Resources.bB;
                FQ.BackgroundImage = Properties.Resources.bQ;
                RL.ForeColor = System.Drawing.Color.Black;
                NL.ForeColor = System.Drawing.Color.Black;
                BL.ForeColor = System.Drawing.Color.Black;
                QL.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                label2.ForeColor = System.Drawing.Color.White;
                this.BackColor = System.Drawing.Color.Black;
                FR.BackColor = System.Drawing.Color.Black;
                FN.BackColor = System.Drawing.Color.Black;
                FB.BackColor = System.Drawing.Color.Black;
                FQ.BackColor = System.Drawing.Color.Black;
                FR.BackgroundImage = Properties.Resources.wR;
                FN.BackgroundImage = Properties.Resources.wN;
                FB.BackgroundImage = Properties.Resources.wB;
                FQ.BackgroundImage = Properties.Resources.wQ;
                RL.ForeColor = System.Drawing.Color.White;
                NL.ForeColor = System.Drawing.Color.White;
                BL.ForeColor = System.Drawing.Color.White;
                QL.ForeColor = System.Drawing.Color.White;
            }
        }

        private void SelectRook(object sender, EventArgs e)
        {
            ClearSelection();
            RL.Visible = true;
            if (GameSettings.curColor == "Черных")
                GameSettings.pawnPromotion = 'r';
            else GameSettings.pawnPromotion = 'R';
        }

        private void SelectKnight(object sender, EventArgs e)
        {
            ClearSelection();
            NL.Visible = true;
            if (GameSettings.curColor == "Черных")
                GameSettings.pawnPromotion = 'n';
            else GameSettings.pawnPromotion = 'N';
        }

        private void selectBishop(object sender, EventArgs e)
        {
            ClearSelection();
            BL.Visible = true;
            if (GameSettings.curColor == "Черных")
                GameSettings.pawnPromotion = 'b';
            else GameSettings.pawnPromotion = 'B';
        }

        private void selectQueen(object sender, EventArgs e)
        {
            ClearSelection();
            QL.Visible = true;
            if (GameSettings.curColor == "Черных")
                GameSettings.pawnPromotion = 'q';
            else GameSettings.pawnPromotion = 'Q';
        }

        void ClearSelection()
        {
            RL.Visible = false;
            NL.Visible = false;
            BL.Visible = false;
            QL.Visible = false;
        }

        private void ConfirmSelection(object sender, EventArgs e)
        {
            if (GameSettings.pawnPromotion != 'z')
                this.DialogResult = DialogResult.Yes;
        }
    }
}
