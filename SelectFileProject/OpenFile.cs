using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SelectFileProject
{
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool isFolderExist = Directory.Exists(filePathTextBox.Text);
            if (isFolderExist)
            {
                errorMassageLabel.Text = "";
                filesComboBox.DataSource = null;
                List<FileInfo> filesInfo = new List<FileInfo>();
                GetFilesRecursive(ref filesInfo, filePathTextBox.Text);

                filesComboBox.Items.Clear();

                filesComboBox.DisplayMember = "FileName";
                filesComboBox.ValueMember = "FileFullPath";
                filesInfo.ForEach(fileInfo =>
                {
                    filesComboBox.Items.Add(new FileInfo { FileName = fileInfo.FileName, FileFullPath = fileInfo.FileFullPath });
                });

                chooseFileLabel.Visible = true;
                filesComboBox.Visible = true;
            }
            else
            {
                errorMassageLabel.Text = "Folder not exist";
                chooseFileLabel.Visible = false;
                filesComboBox.Visible = false;
            }

        }
        private List<FileInfo> GetFilesRecursive(ref List<FileInfo> filesInfo, string currentFolderPath)
        {
            foreach (string fileName in Directory.GetFiles(currentFolderPath))
            {
                filesInfo.Add(new FileInfo()
                {
                    FileName = Path.GetFileName(fileName),
                    FileFullPath = fileName
                });
            }
            foreach (var directory in Directory.GetDirectories(currentFolderPath))
            {
                GetFilesRecursive(ref filesInfo, directory);
            }
            return filesInfo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            filePathTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void filesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (File.Exists(((FileInfo)filesComboBox.SelectedItem).FileFullPath))
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = ((FileInfo)filesComboBox.SelectedItem).FileFullPath;
                    process.Start();

                    fileErrorMassageLabel.Text = "";
                }
                catch (Exception ex)
                {
                    fileErrorMassageLabel.Text = ex.Message;
                }
            }
        }
    }
}
