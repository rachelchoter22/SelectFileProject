using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            bool isFolderExist = ValidateFilePath();
            if (isFolderExist)
            {
                errorMassageLabel.Text = "";
            }
            else
            {
                errorMassageLabel.Text = "Folder not exist";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            filePathTextBox.Text = folderBrowserDialog.SelectedPath;
        }
        private bool ValidateFilePath()
        {
           return Directory.Exists(filePathTextBox.Text);
        }
    }
}
