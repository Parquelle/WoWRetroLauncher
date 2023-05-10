using WoWRetroLauncher;

namespace WoWRetroLauncher
{
    partial class PathErrorDialog
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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonNo = new WoWRetroLauncher.DialogButton();
            this.buttonChange = new WoWRetroLauncher.DialogButton();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(40, 19);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(215, 28);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "No World of Warcraft installation was found.\r\nPlease check your game\'s path.";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonNo.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.buttonNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.buttonNo.Location = new System.Drawing.Point(158, 56);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(127, 23);
            this.buttonNo.TabIndex = 0;
            this.buttonNo.Text = "No thanks";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.click_no);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.Transparent;
            this.buttonChange.BackgroundImage = global::WoWRetroLauncher.Properties.Resources.buttonDialog;
            this.buttonChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonChange.FlatAppearance.BorderSize = 0;
            this.buttonChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.buttonChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.buttonChange.Location = new System.Drawing.Point(25, 56);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(127, 23);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Change path ...";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.click_change);
            // 
            // PathErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::WoWRetroLauncher.Properties.Resources.dialog_errorBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 91);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonChange);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathErrorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invalid WoW path";
            this.Load += new System.EventHandler(this.PathErrorDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DialogButton buttonChange;
        private System.Windows.Forms.Label labelError;
        private DialogButton buttonNo;
    }
}