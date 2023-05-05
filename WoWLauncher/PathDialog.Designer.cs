namespace WoWRetroLauncher
{
    partial class PathDialog
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
            this.fieldPath = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonSavePath = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fieldPath
            // 
            this.fieldPath.Location = new System.Drawing.Point(34, 92);
            this.fieldPath.Name = "fieldPath";
            this.fieldPath.Size = new System.Drawing.Size(254, 20);
            this.fieldPath.TabIndex = 0;
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(294, 92);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.click_browse);
            // 
            // buttonSavePath
            // 
            this.buttonSavePath.Location = new System.Drawing.Point(160, 131);
            this.buttonSavePath.Name = "buttonSavePath";
            this.buttonSavePath.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePath.TabIndex = 2;
            this.buttonSavePath.Text = "Save";
            this.buttonSavePath.UseVisualStyleBackColor = true;
            this.buttonSavePath.Click += new System.EventHandler(this.click_save);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(34, 73);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(118, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "World of Warcraft path:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please select your World of Warcraft root directory, meaning the directory contai" +
    "ning all the game versions (retail, classic etc.)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(396, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonSavePath);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.fieldPath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set WoW path";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fieldPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonSavePath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label label1;
    }
}