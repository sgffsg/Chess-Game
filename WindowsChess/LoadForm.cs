using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsChess
{
    public partial class LoadForm : Form
    {
        string sourceDirectory;
        public LoadForm()
        {
            InitializeComponent();

            sourceDirectory = GameSettings.saveDirectory;
            string[] files = Directory.GetFiles(sourceDirectory, "*.txt");
            foreach (string file in files)
            {
                SaveList.Rows.Add(Path.GetFileName(file), File.GetCreationTime(sourceDirectory + "/" + Path.GetFileName(file))); //arStr[0]);
            }

            SaveList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BackToMenu(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void ConfirmLoadSave(object sender, DataGridViewCellEventArgs e)
        {
            string[] arStr = File.ReadAllLines(sourceDirectory + "/" + SaveList.SelectedRows[0].Cells[0].Value.ToString());
            
            GameSettings.gameStatus = "load";

            GameSettings.fenToLoad = arStr[0];

            this.DialogResult = DialogResult.OK;
           
        }

        private void ConfirmLoad(object sender, EventArgs e)
        {
            string[] arStr = File.ReadAllLines(sourceDirectory + "/" + SaveList.SelectedRows[0].Cells[0].Value.ToString());

            GameSettings.gameStatus = "load";

            GameSettings.fenToLoad = arStr[0];

            this.DialogResult = DialogResult.OK;

        }

    }
}
