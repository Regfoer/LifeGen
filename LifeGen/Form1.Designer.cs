namespace LifeGen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.charactersList = new System.Windows.Forms.ListBox();
            this.locationList = new System.Windows.Forms.ListBox();
            this.eventList = new System.Windows.Forms.ListBox();
            this.storyBox = new System.Windows.Forms.RichTextBox();
            this.imageView = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 800);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.charactersList);
            this.tabPage1.Controls.Add(this.locationList);
            this.tabPage1.Controls.Add(this.eventList);
            this.tabPage1.Controls.Add(this.storyBox);
            this.tabPage1.Controls.Add(this.imageView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 774);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // charactersList
            // 
            this.charactersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.charactersList.FormattingEnabled = true;
            this.charactersList.Location = new System.Drawing.Point(974, 6);
            this.charactersList.Name = "charactersList";
            this.charactersList.Size = new System.Drawing.Size(236, 212);
            this.charactersList.TabIndex = 9;
            // 
            // locationList
            // 
            this.locationList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.locationList.FormattingEnabled = true;
            this.locationList.Location = new System.Drawing.Point(974, 478);
            this.locationList.Name = "locationList";
            this.locationList.Size = new System.Drawing.Size(236, 290);
            this.locationList.TabIndex = 8;
            // 
            // eventList
            // 
            this.eventList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.eventList.FormattingEnabled = true;
            this.eventList.Location = new System.Drawing.Point(974, 221);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(236, 251);
            this.eventList.TabIndex = 7;
            // 
            // storyBox
            // 
            this.storyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.storyBox.Location = new System.Drawing.Point(8, 612);
            this.storyBox.Name = "storyBox";
            this.storyBox.ReadOnly = true;
            this.storyBox.Size = new System.Drawing.Size(960, 156);
            this.storyBox.TabIndex = 6;
            this.storyBox.Text = "";
            // 
            // imageView
            // 
            this.imageView.BackColor = System.Drawing.Color.MistyRose;
            this.imageView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageView.Location = new System.Drawing.Point(8, 6);
            this.imageView.Name = "imageView";
            this.imageView.Size = new System.Drawing.Size(960, 600);
            this.imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageView.TabIndex = 5;
            this.imageView.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1222, 774);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 824);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LifeGE";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox charactersList;
        private System.Windows.Forms.ListBox locationList;
        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.RichTextBox storyBox;
        private System.Windows.Forms.PictureBox imageView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    }
}

