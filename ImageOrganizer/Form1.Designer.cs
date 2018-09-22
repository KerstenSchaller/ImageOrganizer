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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
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
            this.DeleteLabelTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DeleteLabelTextbox.Location = new System.Drawing.Point(13, 117);
            this.DeleteLabelTextbox.Name = "DeleteLabelTextbox";
            this.DeleteLabelTextbox.ReadOnly = true;
            this.DeleteLabelTextbox.Size = new System.Drawing.Size(214, 20);
            this.DeleteLabelTextbox.TabIndex = 4;
            this.DeleteLabelTextbox.Text = "Löschen";
            this.DeleteLabelTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteLabelTextbox.TextChanged += new System.EventHandler(this.DeleteLabelTextbox_TextChanged);
            // 
            // WeiterbearbeitenTextBox
            // 
            this.WeiterbearbeitenTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WeiterbearbeitenTextBox.Location = new System.Drawing.Point(13, 143);
            this.WeiterbearbeitenTextBox.Name = "WeiterbearbeitenTextBox";
            this.WeiterbearbeitenTextBox.ReadOnly = true;
            this.WeiterbearbeitenTextBox.Size = new System.Drawing.Size(214, 20);
            this.WeiterbearbeitenTextBox.TabIndex = 5;
            this.WeiterbearbeitenTextBox.Text = "Bearbeiten";
            this.WeiterbearbeitenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SortierenTextBox
            // 
            this.SortierenTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SortierenTextBox.Location = new System.Drawing.Point(13, 169);
            this.SortierenTextBox.Name = "SortierenTextBox";
            this.SortierenTextBox.ReadOnly = true;
            this.SortierenTextBox.Size = new System.Drawing.Size(214, 20);
            this.SortierenTextBox.TabIndex = 6;
            this.SortierenTextBox.Text = "WeiterSortieren";
            this.SortierenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(13, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "CustomLabel";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Location = new System.Drawing.Point(13, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(214, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "CustomLabel";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Location = new System.Drawing.Point(13, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(214, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "customLabel";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Location = new System.Drawing.Point(13, 325);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox4.Size = new System.Drawing.Size(214, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "CustomLabel";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(13, 299);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(214, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "CustomLabel";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox6.Location = new System.Drawing.Point(13, 273);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(214, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "CustomLabel";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(13, 494);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(214, 29);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset Changes";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 535);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button resetButton;
    }
}

