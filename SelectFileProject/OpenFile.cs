using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Principal;

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
            try
            {
                bool isFolderExist = Directory.Exists(filePathTextBox.Text);
                if (isFolderExist)
                {
                    errorMassageLabel.Text = "";
                    List<FileInfo> filesInfo = new List<FileInfo>();

                    GetFilesRecursive(ref filesInfo, filePathTextBox.Text.Trim());

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
            catch (Exception ex)
            {
                errorMassageLabel.Text = ex.Message;
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
            FileInfo selectedFile = (FileInfo)filesComboBox.SelectedItem;
            if (File.Exists(selectedFile.FileFullPath))
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = selectedFile.FileFullPath;
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
