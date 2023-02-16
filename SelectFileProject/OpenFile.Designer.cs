namespace SelectFileProject
{
    partial class OpenFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenFile));
            this.ChooseFolderLabel = new System.Windows.Forms.Label();
            this.chooseFileLabel = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.OpenFoldetBtn = new System.Windows.Forms.Button();
            this.errorMassageLabel = new System.Windows.Forms.Label();
            this.filesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ChooseFolderLabel
            // 
            this.ChooseFolderLabel.AutoSize = true;
            this.ChooseFolderLabel.Location = new System.Drawing.Point(35, 60);
            this.ChooseFolderLabel.Name = "ChooseFolderLabel";
            this.ChooseFolderLabel.Size = new System.Drawing.Size(158, 15);
            this.ChooseFolderLabel.TabIndex = 0;
            this.ChooseFolderLabel.Text = "Choose folder or enter path :";
            // 
            // chooseFileLabel
            // 
            this.chooseFileLabel.AutoSize = true;
            this.chooseFileLabel.Location = new System.Drawing.Point(35, 146);
            this.chooseFileLabel.Name = "chooseFileLabel";
            this.chooseFileLabel.Size = new System.Drawing.Size(72, 15);
            this.chooseFileLabel.TabIndex = 1;
            this.chooseFileLabel.Text = "Choose file :";
            this.chooseFileLabel.Visible = false;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(35, 88);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(623, 23);
            this.filePathTextBox.TabIndex = 2;
            this.filePathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OpenFoldetBtn
            // 
            this.OpenFoldetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenFoldetBtn.BackgroundImage")));
            this.OpenFoldetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFoldetBtn.Location = new System.Drawing.Point(673, 72);
            this.OpenFoldetBtn.Name = "OpenFoldetBtn";
            this.OpenFoldetBtn.Size = new System.Drawing.Size(59, 50);
            this.OpenFoldetBtn.TabIndex = 3;
            this.OpenFoldetBtn.UseVisualStyleBackColor = true;
            this.OpenFoldetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorMassageLabel
            // 
            this.errorMassageLabel.AutoSize = true;
            this.errorMassageLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.errorMassageLabel.Location = new System.Drawing.Point(35, 114);
            this.errorMassageLabel.Name = "errorMassageLabel";
            this.errorMassageLabel.Size = new System.Drawing.Size(0, 15);
            this.errorMassageLabel.TabIndex = 4;
            // 
            // filesComboBox
            // 
            this.filesComboBox.FormattingEnabled = true;
            this.filesComboBox.Location = new System.Drawing.Point(35, 172);
            this.filesComboBox.Name = "filesComboBox";
            this.filesComboBox.Size = new System.Drawing.Size(623, 23);
            this.filesComboBox.TabIndex = 5;
            this.filesComboBox.Visible = false;
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filesComboBox);
            this.Controls.Add(this.errorMassageLabel);
            this.Controls.Add(this.OpenFoldetBtn);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.chooseFileLabel);
            this.Controls.Add(this.ChooseFolderLabel);
            this.Name = "OpenFile";
            this.Text = "OpenFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ChooseFolderLabel;
        private Label chooseFileLabel;
        private TextBox filePathTextBox;
        private Button OpenFoldetBtn;
        private Label errorMassageLabel;
        private ComboBox filesComboBox;
    }
}