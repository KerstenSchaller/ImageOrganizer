namespace ImageOrganizer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox_Imageview = new System.Windows.Forms.PictureBox();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Imageview)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Imageview
            // 
            this.picBox_Imageview.Location = new System.Drawing.Point(233, 26);
            this.picBox_Imageview.Name = "picBox_Imageview";
            this.picBox_Imageview.Size = new System.Drawing.Size(697, 497);
            this.picBox_Imageview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Imageview.TabIndex = 0;
            this.picBox_Imageview.TabStop = false;
            this.picBox_Imageview.Click += new System.EventHandler(this.picBox_Imageview_Click);
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Location = new System.Drawing.Point(13, 26);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(214, 29);
            this.SelectFolderButton.TabIndex = 2;
            this.SelectFolderButton.Text = "Select Folder";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 535);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.picBox_Imageview);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Imageview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Imageview;
        private System.Windows.Forms.Button SelectFolderButton;
    }
}

