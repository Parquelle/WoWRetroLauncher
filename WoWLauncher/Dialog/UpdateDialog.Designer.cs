using WoWRetroLauncher;

namespace WoWRetroLauncher
{
    partial class UpdateDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDialog));
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();
            this.buttonNo = new WoWRetroLauncher.DialogButton();
            this.buttonYes = new WoWRetroLauncher.DialogButton();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(79)))));
            this.labelHeader.Location = new System.Drawing.Point(12, 21);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(420, 23);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "You have x update(s) available on the Battle.net App.";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelList
            // 
            this.labelList.BackColor = System.Drawing.Color.Transparent;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelList.Location = new System.Drawing.Point(32, 60);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(374, 105);
            this.labelList.TabIndex = 0;
            this.labelList.Text = "- Retail\r\n- Classic\r\n- Classic WOTLK\r\nasd\r\nasd\r\nasd\r\n";
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.Transparent;
            this.buttonNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNo.BackgroundImage")));
            this.buttonNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonNo.FlatAppearance.BorderSize = 0;
            this.buttonNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.buttonNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.buttonNo.Location = new System.Drawing.Point(228, 184);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(127, 23);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.TabStop = false;
            this.buttonNo.Text = "No thank you.";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.click_no);
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.Transparent;
            this.buttonYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonYes.BackgroundImage")));
            this.buttonYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonYes.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonYes.FlatAppearance.BorderSize = 0;
            this.buttonYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.buttonYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.buttonYes.Location = new System.Drawing.Point(95, 184);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(127, 23);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.TabStop = false;
            this.buttonYes.Text = "Take me there!";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.click_yes);
            // 
            // UpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::WoWRetroLauncher.Properties.Resources.dialog_updateBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 241);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.labelHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.updateDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelList;
        private DialogButton buttonYes;
        private DialogButton buttonNo;
    }
}