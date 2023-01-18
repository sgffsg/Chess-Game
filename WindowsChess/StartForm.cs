using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsChess
{
    public partial class StartForm : Form
    {
        string writePath = "settings.txt";
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            if (File.Exists(writePath))
            {
                string[] arStr = File.ReadAllLines(writePath);


                if (arStr.Length != 0)
                {
                    GameSettings.saveDirectory = arStr[0].ToString();
                }

                this.Hide();
                GameSettings.gameStatus = "play";
                ChessForm f = new ChessForm();
                f.Owner = this;
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    this.Show();
                }
            }
            else
            {
                while (true)
                {
                    string path = null;
                    MessageBox.Show("Пожалуйста укажите место где будут находиться сохранения", "Не выбран путь к сохранениям!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (var dialog = new FolderBrowserDialog())
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                path = dialog.SelectedPath;
                                sw.WriteLine(path);
                                sw.WriteLine(0);
                            }
                            GameSettings.saveDirectory = path;
                            break;
                        }
                }
            }
        }

        private void UploadSave(object sender, EventArgs e)
        {
            if (File.Exists(writePath))
            {
                string[] arStr = File.ReadAllLines(writePath);


                if (arStr.Length != 0)
                {
                    GameSettings.saveDirectory = arStr[0].ToString();
                }

                this.Hide();
                LoadForm l = new LoadForm();
                l.Owner = this;
                if (l.ShowDialog() == DialogResult.Yes)
                {
                    this.Show();
                }
                else
                {
                    this.Show();
                    ChessForm f = new ChessForm();
                    this.Hide();
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        this.Show();
                    }
                }
            }
            else
            {
                while (true)
                {
                    string path = null;
                    MessageBox.Show("Пожалуйста укажите место где будут находиться сохранения", "Не выбран путь к сохранениям!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (var dialog = new FolderBrowserDialog())
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                            {
                                path = dialog.SelectedPath;
                                sw.WriteLine(path);
                                sw.WriteLine(0);
                            }
                            GameSettings.saveDirectory = path;
                            break;
                        }
                }
            }
        }

        private void SettingsMenu(object sender, EventArgs e)
        {
            if (File.Exists(writePath))
            {
                string[] arStr = File.ReadAllLines(writePath);


                if (arStr.Length != 0)
                {
                    GameSettings.saveDirectory = arStr[0].ToString();
                }

                this.Hide();
                ConfigurationForm f = new ConfigurationForm();
                f.Owner = this;
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Вы можете указать место где будут находиться сохранения в этом окне", "Не выбран путь к сохранениям!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ConfigurationForm f = new ConfigurationForm();
                f.Owner = this;
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    this.Show();
                }
            }
        }

        private void ExitFromGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
