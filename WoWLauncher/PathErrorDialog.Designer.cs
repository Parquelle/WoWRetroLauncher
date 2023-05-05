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
            this.buttonOkay = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOkay
            // 
            this.buttonOkay.Location = new System.Drawing.Point(106, 63);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(75, 23);
            this.buttonOkay.TabIndex = 0;
            this.buttonOkay.Text = "Sorry";
            this.buttonOkay.UseVisualStyleBackColor = true;
            this.buttonOkay.Click += new System.EventHandler(this.click_okay);
            // 
            // labelError
            // 
            this.labelError.Location = new System.Drawing.Point(13, 21);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(261, 28);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "No World of Warcraft installation was found. Please check your game\'s path in Opt" +
    "ions > Set WoW Path";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PathErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 98);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonOkay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathErrorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invalid WoW path";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOkay;
        private System.Windows.Forms.Label labelError;
    }
}