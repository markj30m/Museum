namespace Museum
{
    partial class Form1
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
            this.uiArtordonsearchtextbox = new System.Windows.Forms.TextBox();
            this.uiSearchlabel = new System.Windows.Forms.Label();
            this.uiSearchbutton = new System.Windows.Forms.Button();
            this.uiArtefactlabel = new System.Windows.Forms.Label();
            this.uiDonatorlabel = new System.Windows.Forms.Label();
            this.uiDonatortextbox = new System.Windows.Forms.TextBox();
            this.uiArtefactnametextbox = new System.Windows.Forms.TextBox();
            this.uiArtefactremovebutton = new System.Windows.Forms.Button();
            this.uiArtefactaddbutton = new System.Windows.Forms.Button();
            this.uiDescriplabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uiShowinfotextbox = new System.Windows.Forms.TextBox();
            this.uiSelectcombobox = new System.Windows.Forms.ComboBox();
            this.uiAdddescrip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiArtordonsearchtextbox
            // 
            this.uiArtordonsearchtextbox.Location = new System.Drawing.Point(51, 16);
            this.uiArtordonsearchtextbox.MaxLength = 40;
            this.uiArtordonsearchtextbox.Name = "uiArtordonsearchtextbox";
            this.uiArtordonsearchtextbox.Size = new System.Drawing.Size(211, 20);
            this.uiArtordonsearchtextbox.TabIndex = 1;
            // 
            // uiSearchlabel
            // 
            this.uiSearchlabel.AutoSize = true;
            this.uiSearchlabel.Location = new System.Drawing.Point(10, 19);
            this.uiSearchlabel.Name = "uiSearchlabel";
            this.uiSearchlabel.Size = new System.Drawing.Size(41, 13);
            this.uiSearchlabel.TabIndex = 2;
            this.uiSearchlabel.Text = "Search";
            // 
            // uiSearchbutton
            // 
            this.uiSearchbutton.Location = new System.Drawing.Point(351, 14);
            this.uiSearchbutton.Name = "uiSearchbutton";
            this.uiSearchbutton.Size = new System.Drawing.Size(75, 23);
            this.uiSearchbutton.TabIndex = 3;
            this.uiSearchbutton.Text = "Search";
            this.uiSearchbutton.UseVisualStyleBackColor = true;
            this.uiSearchbutton.Click += new System.EventHandler(this.uiSearchbutton_Click);
            // 
            // uiArtefactlabel
            // 
            this.uiArtefactlabel.AutoSize = true;
            this.uiArtefactlabel.Location = new System.Drawing.Point(429, 89);
            this.uiArtefactlabel.Name = "uiArtefactlabel";
            this.uiArtefactlabel.Size = new System.Drawing.Size(75, 13);
            this.uiArtefactlabel.TabIndex = 4;
            this.uiArtefactlabel.Text = "Artefact Name";
            // 
            // uiDonatorlabel
            // 
            this.uiDonatorlabel.AutoSize = true;
            this.uiDonatorlabel.Location = new System.Drawing.Point(432, 66);
            this.uiDonatorlabel.Name = "uiDonatorlabel";
            this.uiDonatorlabel.Size = new System.Drawing.Size(45, 13);
            this.uiDonatorlabel.TabIndex = 6;
            this.uiDonatorlabel.Text = "Donator";
            // 
            // uiDonatortextbox
            // 
            this.uiDonatortextbox.Location = new System.Drawing.Point(510, 63);
            this.uiDonatortextbox.MaxLength = 25;
            this.uiDonatortextbox.Name = "uiDonatortextbox";
            this.uiDonatortextbox.Size = new System.Drawing.Size(136, 20);
            this.uiDonatortextbox.TabIndex = 7;
            this.uiDonatortextbox.TextChanged += new System.EventHandler(this.uiDonatortextbox_TextChanged);
            // 
            // uiArtefactnametextbox
            // 
            this.uiArtefactnametextbox.Location = new System.Drawing.Point(510, 86);
            this.uiArtefactnametextbox.MaxLength = 40;
            this.uiArtefactnametextbox.Name = "uiArtefactnametextbox";
            this.uiArtefactnametextbox.Size = new System.Drawing.Size(136, 20);
            this.uiArtefactnametextbox.TabIndex = 8;
            this.uiArtefactnametextbox.TextChanged += new System.EventHandler(this.uiArtefactnametextbox_TextChanged);
            // 
            // uiArtefactremovebutton
            // 
            this.uiArtefactremovebutton.Location = new System.Drawing.Point(570, 183);
            this.uiArtefactremovebutton.Name = "uiArtefactremovebutton";
            this.uiArtefactremovebutton.Size = new System.Drawing.Size(75, 23);
            this.uiArtefactremovebutton.TabIndex = 10;
            this.uiArtefactremovebutton.Text = "Remove";
            this.uiArtefactremovebutton.UseVisualStyleBackColor = true;
            this.uiArtefactremovebutton.Click += new System.EventHandler(this.uiArtefactremovebutton_Click);
            // 
            // uiArtefactaddbutton
            // 
            this.uiArtefactaddbutton.Location = new System.Drawing.Point(507, 183);
            this.uiArtefactaddbutton.Name = "uiArtefactaddbutton";
            this.uiArtefactaddbutton.Size = new System.Drawing.Size(57, 23);
            this.uiArtefactaddbutton.TabIndex = 11;
            this.uiArtefactaddbutton.Text = "Add";
            this.uiArtefactaddbutton.UseVisualStyleBackColor = true;
            this.uiArtefactaddbutton.Click += new System.EventHandler(this.uiArtefactaddbutton_Click);
            // 
            // uiDescriplabel
            // 
            this.uiDescriplabel.AutoSize = true;
            this.uiDescriplabel.Location = new System.Drawing.Point(432, 110);
            this.uiDescriplabel.Name = "uiDescriplabel";
            this.uiDescriplabel.Size = new System.Drawing.Size(60, 13);
            this.uiDescriplabel.TabIndex = 12;
            this.uiDescriplabel.Text = "Description";
            // 
            // uiShowinfotextbox
            // 
            this.uiShowinfotextbox.Location = new System.Drawing.Point(13, 45);
            this.uiShowinfotextbox.Multiline = true;
            this.uiShowinfotextbox.Name = "uiShowinfotextbox";
            this.uiShowinfotextbox.ReadOnly = true;
            this.uiShowinfotextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uiShowinfotextbox.Size = new System.Drawing.Size(413, 270);
            this.uiShowinfotextbox.TabIndex = 14;
            // 
            // uiSelectcombobox
            // 
            this.uiSelectcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiSelectcombobox.FormattingEnabled = true;
            this.uiSelectcombobox.Items.AddRange(new object[] {
            "All",
            "Donator",
            "Artefact"});
            this.uiSelectcombobox.Location = new System.Drawing.Point(265, 14);
            this.uiSelectcombobox.Margin = new System.Windows.Forms.Padding(2);
            this.uiSelectcombobox.Name = "uiSelectcombobox";
            this.uiSelectcombobox.Size = new System.Drawing.Size(82, 21);
            this.uiSelectcombobox.TabIndex = 16;
            // 
            // uiAdddescrip
            // 
            this.uiAdddescrip.Location = new System.Drawing.Point(510, 110);
            this.uiAdddescrip.Margin = new System.Windows.Forms.Padding(2);
            this.uiAdddescrip.MaxLength = 300;
            this.uiAdddescrip.Multiline = true;
            this.uiAdddescrip.Name = "uiAdddescrip";
            this.uiAdddescrip.Size = new System.Drawing.Size(136, 69);
            this.uiAdddescrip.TabIndex = 17;
            this.uiAdddescrip.TextChanged += new System.EventHandler(this.uiAdddescrip_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 327);
            this.Controls.Add(this.uiAdddescrip);
            this.Controls.Add(this.uiSelectcombobox);
            this.Controls.Add(this.uiShowinfotextbox);
            this.Controls.Add(this.uiDescriplabel);
            this.Controls.Add(this.uiArtefactaddbutton);
            this.Controls.Add(this.uiArtefactremovebutton);
            this.Controls.Add(this.uiArtefactnametextbox);
            this.Controls.Add(this.uiDonatortextbox);
            this.Controls.Add(this.uiDonatorlabel);
            this.Controls.Add(this.uiArtefactlabel);
            this.Controls.Add(this.uiSearchbutton);
            this.Controls.Add(this.uiSearchlabel);
            this.Controls.Add(this.uiArtordonsearchtextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uiArtordonsearchtextbox;
        private System.Windows.Forms.Label uiSearchlabel;
        private System.Windows.Forms.Button uiSearchbutton;
        private System.Windows.Forms.Label uiArtefactlabel;
        private System.Windows.Forms.Label uiDonatorlabel;
        private System.Windows.Forms.TextBox uiDonatortextbox;
        private System.Windows.Forms.TextBox uiArtefactnametextbox;
        private System.Windows.Forms.Button uiArtefactremovebutton;
        private System.Windows.Forms.Button uiArtefactaddbutton;
        private System.Windows.Forms.Label uiDescriplabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox uiShowinfotextbox;
        private System.Windows.Forms.ComboBox uiSelectcombobox;
        private System.Windows.Forms.TextBox uiAdddescrip;
    }
}

