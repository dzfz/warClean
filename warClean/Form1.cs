using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace warClean
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("load");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("1");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            this.warPath_textBox.Text = fbd.SelectedPath;
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            string warPath = this.warPath_textBox.Text;
            if (warPath != "" && warPath != null)
            {
                cleanWarFile(warPath);
                MessageBox.Show("清理成功！");
            }
            else
            {
                MessageBox.Show("war包路径为空,请选择路径。");
            }

        }

        private void cleanWarFile(string warPath)
        {
            string[] fileArray = Directory.GetFiles(warPath, "*.war");
            foreach (string file in fileArray)
            {
                string extractPath = warPath + "\\war_temp";
                if (Directory.Exists(extractPath))
                {
                    try
                    {
                        Directory.Delete(extractPath);
                    }catch()
                    {
                    }

                }
                ZipFile.ExtractToDirectory(file, extractPath);
                if (Directory.Exists(extractPath))
                {
                    DirectoryInfo extractPathFolder = new DirectoryInfo(extractPath);
                    foreach (DirectoryInfo nextFolder in extractPathFolder.GetDirectories())
                    {
                        Console.WriteLine(nextFolder.Name);
                    }
                    foreach (FileInfo nextFile in extractPathFolder.GetFiles())
                    {

                    }
                }
                //MessageBox.Show(returnVal.ToString());
            }

        }




    }
}
