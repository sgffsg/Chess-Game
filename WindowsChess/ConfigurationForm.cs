using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsChess
{
    public partial class ConfigurationForm : Form
    {
        string writePath = "settings.txt";
        string path = GameSettings.saveDirectory;
        public ConfigurationForm()
        {
            InitializeComponent();
            GameSavePath.Text = GameSettings.saveDirectory;
        }

        private void EditPath(object sender, EventArgs e)
        {
            
            MessageBox.Show("Укажите новую папку для загрузки сохранений", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        path = dialog.SelectedPath;
                        sw.WriteLine(path);
                    }
                    GameSavePath.Text = path;
                }
        }


        private void BackToMenu(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
