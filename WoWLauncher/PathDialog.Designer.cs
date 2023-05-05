using WoWRetroLauncher;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathDialog));
            this.fieldPath = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new WoWRetroLauncher.DialogButton();
            this.buttonSavePath = new WoWRetroLauncher.DialogButton();
            this.labelPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fieldPath
            // 
            this.fieldPath.Location = new System.Drawing.Point(34, 92);
            this.fieldPath.Name = "fieldPath";
            this.fieldPath.Size = new System.Drawing.Size(254, 20);
            this.fieldPath.TabIndex = 2;
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.Transparent;
            this.buttonBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBrowse.BackgroundImage")));
            this.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.buttonBrowse.Location = new System.Drawing.Point(294, 89);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.TabStop = false;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.click_browse);
            // 
            // buttonSavePath
            // 
            this.buttonSavePath.BackColor = System.Drawing.Color.Transparent;
            this.buttonSavePath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSavePath.BackgroundImage")));
            this.buttonSavePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavePath.FlatAppearance.BorderSize = 0;
            this.buttonSavePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSavePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.buttonSavePath.Location = new System.Drawing.Point(136, 122);
            this.buttonSavePath.Name = "buttonSavePath";
            this.buttonSavePath.Size = new System.Drawing.Size(127, 23);
            this.buttonSavePath.TabIndex = 0;
            this.buttonSavePath.TabStop = false;
            this.buttonSavePath.Text = "Save";
            this.buttonSavePath.UseVisualStyleBackColor = false;
            this.buttonSavePath.Click += new System.EventHandler(this.click_save);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.BackColor = System.Drawing.Color.Transparent;
            this.labelPath.ForeColor = System.Drawing.Color.White;
            this.labelPath.Location = new System.Drawing.Point(34, 73);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(118, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "World of Warcraft path:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::WoWRetroLauncher.Properties.Resources.dialog_pathBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonSavePath);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.fieldPath);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set WoW path";
            this.Load += new System.EventHandler(this.PathDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fieldPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private DialogButton buttonBrowse;
        private DialogButton buttonSavePath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label label1;
    }
}