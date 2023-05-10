using WoWRetroLauncher;

namespace WoWRetroLauncher
{
    partial class SoftwareUpdateDialog
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
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonDownload = new WoWRetroLauncher.DialogButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNo = new WoWRetroLauncher.DialogButton();
            this.SuspendLayout();
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.Transparent;
            this.buttonDownload.BackgroundImage = global::WoWRetroLauncher.Properties.Resources.buttonDialog;
            this.buttonDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDownload.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDownload.FlatAppearance.BorderSize = 0;
            this.buttonDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.buttonDownload.Location = new System.Drawing.Point(66, 115);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(127, 23);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.TabStop = false;
            this.buttonDownload.Text = "Download now";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.click_download);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "An update is available.\r\nWorld of Warcraft Retro Launcher {0}\r\n(Your version: {1}" +
    ")\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.Transparent;
            this.buttonNo.BackgroundImage = global::WoWRetroLauncher.Properties.Resources.buttonDialog;
            this.buttonNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonNo.FlatAppearance.BorderSize = 0;
            this.buttonNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.buttonNo.Location = new System.Drawing.Point(200, 115);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(127, 23);
            this.buttonNo.TabIndex = 5;
            this.buttonNo.TabStop = false;
            this.buttonNo.Text = "No thanks!";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.click_no);
            // 
            // SoftwareUpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::WoWRetroLauncher.Properties.Resources.dialog_pathBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 161);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDownload);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoftwareUpdateDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set WoW path";
            this.Load += new System.EventHandler(this.SoftwareUpdateDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private DialogButton buttonDownload;
        private System.Windows.Forms.Label label1;
        private DialogButton buttonNo;
    }
}