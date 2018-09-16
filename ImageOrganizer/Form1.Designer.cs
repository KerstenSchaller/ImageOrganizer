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
            this.ApplyLabelsButton = new System.Windows.Forms.Button();
            this.DeleteLabelTextbox = new System.Windows.Forms.TextBox();
            this.WeiterbearbeitenTextBox = new System.Windows.Forms.TextBox();
            this.SortierenTextBox = new System.Windows.Forms.TextBox();
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
            // ApplyLabelsButton
            // 
            this.ApplyLabelsButton.Location = new System.Drawing.Point(13, 61);
            this.ApplyLabelsButton.Name = "ApplyLabelsButton";
            this.ApplyLabelsButton.Size = new System.Drawing.Size(214, 29);
            this.ApplyLabelsButton.TabIndex = 3;
            this.ApplyLabelsButton.Text = "Apply Labels";
            this.ApplyLabelsButton.UseVisualStyleBackColor = true;
            this.ApplyLabelsButton.Click += new System.EventHandler(this.ApplyLabelsButton_Click);
            // 
            // DeleteLabelTextbox
            // 
            this.DeleteLabelTextbox.Location = new System.Drawing.Point(13, 117);
            this.DeleteLabelTextbox.Name = "DeleteLabelTextbox";
            this.DeleteLabelTextbox.Size = new System.Drawing.Size(214, 20);
            this.DeleteLabelTextbox.TabIndex = 4;
            this.DeleteLabelTextbox.Text = "Löschen";
            this.DeleteLabelTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WeiterbearbeitenTextBox
            // 
            this.WeiterbearbeitenTextBox.Location = new System.Drawing.Point(13, 143);
            this.WeiterbearbeitenTextBox.Name = "WeiterbearbeitenTextBox";
            this.WeiterbearbeitenTextBox.Size = new System.Drawing.Size(214, 20);
            this.WeiterbearbeitenTextBox.TabIndex = 5;
            this.WeiterbearbeitenTextBox.Text = "Bearbeiten";
            this.WeiterbearbeitenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SortierenTextBox
            // 
            this.SortierenTextBox.Location = new System.Drawing.Point(13, 169);
            this.SortierenTextBox.Name = "SortierenTextBox";
            this.SortierenTextBox.Size = new System.Drawing.Size(214, 20);
            this.SortierenTextBox.TabIndex = 6;
            this.SortierenTextBox.Text = "WeiterSortieren";
            this.SortierenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 535);
            this.Controls.Add(this.SortierenTextBox);
            this.Controls.Add(this.WeiterbearbeitenTextBox);
            this.Controls.Add(this.DeleteLabelTextbox);
            this.Controls.Add(this.ApplyLabelsButton);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.picBox_Imageview);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Imageview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Imageview;
        private System.Windows.Forms.Button SelectFolderButton;
        private System.Windows.Forms.Button ApplyLabelsButton;
        private System.Windows.Forms.TextBox DeleteLabelTextbox;
        private System.Windows.Forms.TextBox WeiterbearbeitenTextBox;
        private System.Windows.Forms.TextBox SortierenTextBox;
    }
}

