namespace Lagerverwaltung
{
    partial class LagerbeständeForm
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
            this.kölnLagerGroupBox = new System.Windows.Forms.GroupBox();
            this.kölnPaletteAbziehenButton = new System.Windows.Forms.Button();
            this.kölnPaletteVerkaufenButton = new System.Windows.Forms.Button();
            this.kölnPaletteEinkaufenButton = new System.Windows.Forms.Button();
            this.kölnBestandLabel = new System.Windows.Forms.Label();
            this.kölnKapazitätLabel = new System.Windows.Forms.Label();
            this.kölnKapazitätTextLabel = new System.Windows.Forms.Label();
            this.kölnBestandTextLabel = new System.Windows.Forms.Label();
            this.bonnLagerGroupBox = new System.Windows.Forms.GroupBox();
            this.bonnPaletteAbziehenButton = new System.Windows.Forms.Button();
            this.bonnPaletteVerkaufenButton = new System.Windows.Forms.Button();
            this.bonnPaletteEinkaufenButton = new System.Windows.Forms.Button();
            this.bonnBestandLabel = new System.Windows.Forms.Label();
            this.bonnKapazitätLabel = new System.Windows.Forms.Label();
            this.bonnKapazitätTextLabel = new System.Windows.Forms.Label();
            this.bonnBestandTextLabel = new System.Windows.Forms.Label();
            this.leverkusenLagerGroupBox = new System.Windows.Forms.GroupBox();
            this.leverkusenPaletteAbziehenButton = new System.Windows.Forms.Button();
            this.leverkusenPaletteVerkaufenButton = new System.Windows.Forms.Button();
            this.leverkusenPaletteEinkaufenButton = new System.Windows.Forms.Button();
            this.leverkusenBestandLabel = new System.Windows.Forms.Label();
            this.leverkusenKapazitätLabel = new System.Windows.Forms.Label();
            this.leverkusenKapazitätTextLabel = new System.Windows.Forms.Label();
            this.leverkusenBestandTextLabel = new System.Windows.Forms.Label();
            this.kölnAnzahlTextBox = new System.Windows.Forms.TextBox();
            this.kölnAnzahlLabel = new System.Windows.Forms.Label();
            this.bonnAnzahllabel = new System.Windows.Forms.Label();
            this.bonnAnzahlTextBox = new System.Windows.Forms.TextBox();
            this.leverkusenAnzahllabel = new System.Windows.Forms.Label();
            this.leverkusenAnzahlTextBox = new System.Windows.Forms.TextBox();
            this.kölnLagerGroupBox.SuspendLayout();
            this.bonnLagerGroupBox.SuspendLayout();
            this.leverkusenLagerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // kölnLagerGroupBox
            // 
            this.kölnLagerGroupBox.Controls.Add(this.kölnAnzahlLabel);
            this.kölnLagerGroupBox.Controls.Add(this.kölnAnzahlTextBox);
            this.kölnLagerGroupBox.Controls.Add(this.kölnPaletteAbziehenButton);
            this.kölnLagerGroupBox.Controls.Add(this.kölnPaletteVerkaufenButton);
            this.kölnLagerGroupBox.Controls.Add(this.kölnPaletteEinkaufenButton);
            this.kölnLagerGroupBox.Controls.Add(this.kölnBestandLabel);
            this.kölnLagerGroupBox.Controls.Add(this.kölnKapazitätLabel);
            this.kölnLagerGroupBox.Controls.Add(this.kölnKapazitätTextLabel);
            this.kölnLagerGroupBox.Controls.Add(this.kölnBestandTextLabel);
            this.kölnLagerGroupBox.Location = new System.Drawing.Point(13, 13);
            this.kölnLagerGroupBox.Name = "kölnLagerGroupBox";
            this.kölnLagerGroupBox.Size = new System.Drawing.Size(200, 181);
            this.kölnLagerGroupBox.TabIndex = 0;
            this.kölnLagerGroupBox.TabStop = false;
            this.kölnLagerGroupBox.Text = "Lager Köln";
            // 
            // kölnPaletteAbziehenButton
            // 
            this.kölnPaletteAbziehenButton.Location = new System.Drawing.Point(6, 151);
            this.kölnPaletteAbziehenButton.Name = "kölnPaletteAbziehenButton";
            this.kölnPaletteAbziehenButton.Size = new System.Drawing.Size(185, 23);
            this.kölnPaletteAbziehenButton.TabIndex = 6;
            this.kölnPaletteAbziehenButton.Text = "Palette abziehen";
            this.kölnPaletteAbziehenButton.UseVisualStyleBackColor = true;
            this.kölnPaletteAbziehenButton.Click += new System.EventHandler(this.kölnPaletteAbziehenButton_Click);
            // 
            // kölnPaletteVerkaufenButton
            // 
            this.kölnPaletteVerkaufenButton.Location = new System.Drawing.Point(6, 121);
            this.kölnPaletteVerkaufenButton.Name = "kölnPaletteVerkaufenButton";
            this.kölnPaletteVerkaufenButton.Size = new System.Drawing.Size(185, 23);
            this.kölnPaletteVerkaufenButton.TabIndex = 5;
            this.kölnPaletteVerkaufenButton.Text = "Palette verkaufen";
            this.kölnPaletteVerkaufenButton.UseVisualStyleBackColor = true;
            this.kölnPaletteVerkaufenButton.Click += new System.EventHandler(this.kölnPaletteVerkaufenButton_Click);
            // 
            // kölnPaletteEinkaufenButton
            // 
            this.kölnPaletteEinkaufenButton.Location = new System.Drawing.Point(6, 92);
            this.kölnPaletteEinkaufenButton.Name = "kölnPaletteEinkaufenButton";
            this.kölnPaletteEinkaufenButton.Size = new System.Drawing.Size(185, 23);
            this.kölnPaletteEinkaufenButton.TabIndex = 4;
            this.kölnPaletteEinkaufenButton.Text = "Palette einkaufen";
            this.kölnPaletteEinkaufenButton.UseVisualStyleBackColor = true;
            this.kölnPaletteEinkaufenButton.Click += new System.EventHandler(this.kölnPaletteEinkaufenButton_Click);
            // 
            // kölnBestandLabel
            // 
            this.kölnBestandLabel.AutoSize = true;
            this.kölnBestandLabel.Location = new System.Drawing.Point(181, 29);
            this.kölnBestandLabel.Name = "kölnBestandLabel";
            this.kölnBestandLabel.Size = new System.Drawing.Size(13, 13);
            this.kölnBestandLabel.TabIndex = 3;
            this.kölnBestandLabel.Text = "0";
            this.kölnBestandLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // kölnKapazitätLabel
            // 
            this.kölnKapazitätLabel.AutoSize = true;
            this.kölnKapazitätLabel.Location = new System.Drawing.Point(181, 16);
            this.kölnKapazitätLabel.Name = "kölnKapazitätLabel";
            this.kölnKapazitätLabel.Size = new System.Drawing.Size(13, 13);
            this.kölnKapazitätLabel.TabIndex = 2;
            this.kölnKapazitätLabel.Text = "0";
            this.kölnKapazitätLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // kölnKapazitätTextLabel
            // 
            this.kölnKapazitätTextLabel.AutoSize = true;
            this.kölnKapazitätTextLabel.Location = new System.Drawing.Point(6, 16);
            this.kölnKapazitätTextLabel.Name = "kölnKapazitätTextLabel";
            this.kölnKapazitätTextLabel.Size = new System.Drawing.Size(80, 13);
            this.kölnKapazitätTextLabel.TabIndex = 1;
            this.kölnKapazitätTextLabel.Text = "Max. Kapazität:";
            // 
            // kölnBestandTextLabel
            // 
            this.kölnBestandTextLabel.AutoSize = true;
            this.kölnBestandTextLabel.Location = new System.Drawing.Point(6, 29);
            this.kölnBestandTextLabel.Name = "kölnBestandTextLabel";
            this.kölnBestandTextLabel.Size = new System.Drawing.Size(93, 13);
            this.kölnBestandTextLabel.TabIndex = 0;
            this.kölnBestandTextLabel.Text = "Aktueller Bestand:";
            // 
            // bonnLagerGroupBox
            // 
            this.bonnLagerGroupBox.Controls.Add(this.bonnAnzahllabel);
            this.bonnLagerGroupBox.Controls.Add(this.bonnPaletteAbziehenButton);
            this.bonnLagerGroupBox.Controls.Add(this.bonnAnzahlTextBox);
            this.bonnLagerGroupBox.Controls.Add(this.bonnPaletteVerkaufenButton);
            this.bonnLagerGroupBox.Controls.Add(this.bonnPaletteEinkaufenButton);
            this.bonnLagerGroupBox.Controls.Add(this.bonnBestandLabel);
            this.bonnLagerGroupBox.Controls.Add(this.bonnKapazitätLabel);
            this.bonnLagerGroupBox.Controls.Add(this.bonnKapazitätTextLabel);
            this.bonnLagerGroupBox.Controls.Add(this.bonnBestandTextLabel);
            this.bonnLagerGroupBox.Location = new System.Drawing.Point(219, 13);
            this.bonnLagerGroupBox.Name = "bonnLagerGroupBox";
            this.bonnLagerGroupBox.Size = new System.Drawing.Size(200, 181);
            this.bonnLagerGroupBox.TabIndex = 7;
            this.bonnLagerGroupBox.TabStop = false;
            this.bonnLagerGroupBox.Text = "Lager Bonn";
            // 
            // bonnPaletteAbziehenButton
            // 
            this.bonnPaletteAbziehenButton.Location = new System.Drawing.Point(9, 151);
            this.bonnPaletteAbziehenButton.Name = "bonnPaletteAbziehenButton";
            this.bonnPaletteAbziehenButton.Size = new System.Drawing.Size(185, 23);
            this.bonnPaletteAbziehenButton.TabIndex = 6;
            this.bonnPaletteAbziehenButton.Text = "Palette abziehen";
            this.bonnPaletteAbziehenButton.UseVisualStyleBackColor = true;
            this.bonnPaletteAbziehenButton.Click += new System.EventHandler(this.bonnPaletteAbziehenButton_Click);
            // 
            // bonnPaletteVerkaufenButton
            // 
            this.bonnPaletteVerkaufenButton.Location = new System.Drawing.Point(9, 121);
            this.bonnPaletteVerkaufenButton.Name = "bonnPaletteVerkaufenButton";
            this.bonnPaletteVerkaufenButton.Size = new System.Drawing.Size(185, 23);
            this.bonnPaletteVerkaufenButton.TabIndex = 5;
            this.bonnPaletteVerkaufenButton.Text = "Palette verkaufen";
            this.bonnPaletteVerkaufenButton.UseVisualStyleBackColor = true;
            this.bonnPaletteVerkaufenButton.Click += new System.EventHandler(this.bonnPaletteVerkaufenButton_Click);
            // 
            // bonnPaletteEinkaufenButton
            // 
            this.bonnPaletteEinkaufenButton.Location = new System.Drawing.Point(9, 92);
            this.bonnPaletteEinkaufenButton.Name = "bonnPaletteEinkaufenButton";
            this.bonnPaletteEinkaufenButton.Size = new System.Drawing.Size(185, 23);
            this.bonnPaletteEinkaufenButton.TabIndex = 4;
            this.bonnPaletteEinkaufenButton.Text = "Palette einkaufen";
            this.bonnPaletteEinkaufenButton.UseVisualStyleBackColor = true;
            this.bonnPaletteEinkaufenButton.Click += new System.EventHandler(this.bonnPaletteEinkaufenButton_Click);
            // 
            // bonnBestandLabel
            // 
            this.bonnBestandLabel.AutoSize = true;
            this.bonnBestandLabel.Location = new System.Drawing.Point(181, 29);
            this.bonnBestandLabel.Name = "bonnBestandLabel";
            this.bonnBestandLabel.Size = new System.Drawing.Size(13, 13);
            this.bonnBestandLabel.TabIndex = 3;
            this.bonnBestandLabel.Text = "0";
            this.bonnBestandLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bonnKapazitätLabel
            // 
            this.bonnKapazitätLabel.AutoSize = true;
            this.bonnKapazitätLabel.Location = new System.Drawing.Point(181, 16);
            this.bonnKapazitätLabel.Name = "bonnKapazitätLabel";
            this.bonnKapazitätLabel.Size = new System.Drawing.Size(13, 13);
            this.bonnKapazitätLabel.TabIndex = 2;
            this.bonnKapazitätLabel.Text = "0";
            this.bonnKapazitätLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bonnKapazitätTextLabel
            // 
            this.bonnKapazitätTextLabel.AutoSize = true;
            this.bonnKapazitätTextLabel.Location = new System.Drawing.Point(6, 16);
            this.bonnKapazitätTextLabel.Name = "bonnKapazitätTextLabel";
            this.bonnKapazitätTextLabel.Size = new System.Drawing.Size(80, 13);
            this.bonnKapazitätTextLabel.TabIndex = 1;
            this.bonnKapazitätTextLabel.Text = "Max. Kapazität:";
            // 
            // bonnBestandTextLabel
            // 
            this.bonnBestandTextLabel.AutoSize = true;
            this.bonnBestandTextLabel.Location = new System.Drawing.Point(6, 29);
            this.bonnBestandTextLabel.Name = "bonnBestandTextLabel";
            this.bonnBestandTextLabel.Size = new System.Drawing.Size(93, 13);
            this.bonnBestandTextLabel.TabIndex = 0;
            this.bonnBestandTextLabel.Text = "Aktueller Bestand:";
            // 
            // leverkusenLagerGroupBox
            // 
            this.leverkusenLagerGroupBox.Controls.Add(this.leverkusenAnzahllabel);
            this.leverkusenLagerGroupBox.Controls.Add(this.leverkusenPaletteAbziehenButton);
            this.leverkusenLagerGroupBox.Controls.Add(this.leverkusenAnzahlTextBox);
            this.leverkusenLagerGroupBox.Controls.Add(this.leverkusenPaletteVerkaufenButton);
            this.leverkusenLagerGroupBox.Controls.Add(this.leverkusenPaletteEinkaufenButton);
            this.leverkusenLagerGroupBox.Controls.Add(this.leverkusenBestandLabel);
            this.leverkusenLagerGroupBox.Controls.Add(this.leverkusenKapazitätLabel);
            this.leverkusenLagerGroupBox.Controls.Add(this.leverkusenKapazitätTextLabel);
            this.leverkusenLagerGroupBox.Controls.Add(this.leverkusenBestandTextLabel);
            this.leverkusenLagerGroupBox.Location = new System.Drawing.Point(425, 13);
            this.leverkusenLagerGroupBox.Name = "leverkusenLagerGroupBox";
            this.leverkusenLagerGroupBox.Size = new System.Drawing.Size(200, 181);
            this.leverkusenLagerGroupBox.TabIndex = 8;
            this.leverkusenLagerGroupBox.TabStop = false;
            this.leverkusenLagerGroupBox.Text = "Lager Leverkusen";
            // 
            // leverkusenPaletteAbziehenButton
            // 
            this.leverkusenPaletteAbziehenButton.Location = new System.Drawing.Point(9, 151);
            this.leverkusenPaletteAbziehenButton.Name = "leverkusenPaletteAbziehenButton";
            this.leverkusenPaletteAbziehenButton.Size = new System.Drawing.Size(185, 23);
            this.leverkusenPaletteAbziehenButton.TabIndex = 6;
            this.leverkusenPaletteAbziehenButton.Text = "Palette abziehen";
            this.leverkusenPaletteAbziehenButton.UseVisualStyleBackColor = true;
            this.leverkusenPaletteAbziehenButton.Click += new System.EventHandler(this.leverkusenPaletteAbziehenButton_Click);
            // 
            // leverkusenPaletteVerkaufenButton
            // 
            this.leverkusenPaletteVerkaufenButton.Location = new System.Drawing.Point(9, 121);
            this.leverkusenPaletteVerkaufenButton.Name = "leverkusenPaletteVerkaufenButton";
            this.leverkusenPaletteVerkaufenButton.Size = new System.Drawing.Size(185, 23);
            this.leverkusenPaletteVerkaufenButton.TabIndex = 5;
            this.leverkusenPaletteVerkaufenButton.Text = "Palette verkaufen";
            this.leverkusenPaletteVerkaufenButton.UseVisualStyleBackColor = true;
            this.leverkusenPaletteVerkaufenButton.Click += new System.EventHandler(this.leverkusenPaletteVerkaufenButton_Click);
            // 
            // leverkusenPaletteEinkaufenButton
            // 
            this.leverkusenPaletteEinkaufenButton.Location = new System.Drawing.Point(9, 92);
            this.leverkusenPaletteEinkaufenButton.Name = "leverkusenPaletteEinkaufenButton";
            this.leverkusenPaletteEinkaufenButton.Size = new System.Drawing.Size(185, 23);
            this.leverkusenPaletteEinkaufenButton.TabIndex = 4;
            this.leverkusenPaletteEinkaufenButton.Text = "Palette einkaufen";
            this.leverkusenPaletteEinkaufenButton.UseVisualStyleBackColor = true;
            this.leverkusenPaletteEinkaufenButton.Click += new System.EventHandler(this.leverkusenPaletteEinkaufenButton_Click);
            // 
            // leverkusenBestandLabel
            // 
            this.leverkusenBestandLabel.AutoSize = true;
            this.leverkusenBestandLabel.Location = new System.Drawing.Point(181, 29);
            this.leverkusenBestandLabel.Name = "leverkusenBestandLabel";
            this.leverkusenBestandLabel.Size = new System.Drawing.Size(13, 13);
            this.leverkusenBestandLabel.TabIndex = 3;
            this.leverkusenBestandLabel.Text = "0";
            this.leverkusenBestandLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // leverkusenKapazitätLabel
            // 
            this.leverkusenKapazitätLabel.AutoSize = true;
            this.leverkusenKapazitätLabel.Location = new System.Drawing.Point(181, 16);
            this.leverkusenKapazitätLabel.Name = "leverkusenKapazitätLabel";
            this.leverkusenKapazitätLabel.Size = new System.Drawing.Size(13, 13);
            this.leverkusenKapazitätLabel.TabIndex = 2;
            this.leverkusenKapazitätLabel.Text = "0";
            this.leverkusenKapazitätLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // leverkusenKapazitätTextLabel
            // 
            this.leverkusenKapazitätTextLabel.AutoSize = true;
            this.leverkusenKapazitätTextLabel.Location = new System.Drawing.Point(6, 16);
            this.leverkusenKapazitätTextLabel.Name = "leverkusenKapazitätTextLabel";
            this.leverkusenKapazitätTextLabel.Size = new System.Drawing.Size(80, 13);
            this.leverkusenKapazitätTextLabel.TabIndex = 1;
            this.leverkusenKapazitätTextLabel.Text = "Max. Kapazität:";
            // 
            // leverkusenBestandTextLabel
            // 
            this.leverkusenBestandTextLabel.AutoSize = true;
            this.leverkusenBestandTextLabel.Location = new System.Drawing.Point(6, 29);
            this.leverkusenBestandTextLabel.Name = "leverkusenBestandTextLabel";
            this.leverkusenBestandTextLabel.Size = new System.Drawing.Size(93, 13);
            this.leverkusenBestandTextLabel.TabIndex = 0;
            this.leverkusenBestandTextLabel.Text = "Aktueller Bestand:";
            // 
            // kölnAnzahlTextBox
            // 
            this.kölnAnzahlTextBox.Location = new System.Drawing.Point(54, 66);
            this.kölnAnzahlTextBox.Name = "kölnAnzahlTextBox";
            this.kölnAnzahlTextBox.Size = new System.Drawing.Size(137, 20);
            this.kölnAnzahlTextBox.TabIndex = 7;
            // 
            // kölnAnzahlLabel
            // 
            this.kölnAnzahlLabel.AutoSize = true;
            this.kölnAnzahlLabel.Location = new System.Drawing.Point(6, 69);
            this.kölnAnzahlLabel.Name = "kölnAnzahlLabel";
            this.kölnAnzahlLabel.Size = new System.Drawing.Size(42, 13);
            this.kölnAnzahlLabel.TabIndex = 8;
            this.kölnAnzahlLabel.Text = "Anzahl:";
            // 
            // bonnAnzahllabel
            // 
            this.bonnAnzahllabel.AutoSize = true;
            this.bonnAnzahllabel.Location = new System.Drawing.Point(9, 69);
            this.bonnAnzahllabel.Name = "bonnAnzahllabel";
            this.bonnAnzahllabel.Size = new System.Drawing.Size(42, 13);
            this.bonnAnzahllabel.TabIndex = 10;
            this.bonnAnzahllabel.Text = "Anzahl:";
            // 
            // bonnAnzahlTextBox
            // 
            this.bonnAnzahlTextBox.Location = new System.Drawing.Point(57, 66);
            this.bonnAnzahlTextBox.Name = "bonnAnzahlTextBox";
            this.bonnAnzahlTextBox.Size = new System.Drawing.Size(137, 20);
            this.bonnAnzahlTextBox.TabIndex = 9;
            // 
            // leverkusenAnzahllabel
            // 
            this.leverkusenAnzahllabel.AutoSize = true;
            this.leverkusenAnzahllabel.Location = new System.Drawing.Point(9, 69);
            this.leverkusenAnzahllabel.Name = "leverkusenAnzahllabel";
            this.leverkusenAnzahllabel.Size = new System.Drawing.Size(42, 13);
            this.leverkusenAnzahllabel.TabIndex = 12;
            this.leverkusenAnzahllabel.Text = "Anzahl:";
            // 
            // leverkusenAnzahlTextBox
            // 
            this.leverkusenAnzahlTextBox.Location = new System.Drawing.Point(57, 66);
            this.leverkusenAnzahlTextBox.Name = "leverkusenAnzahlTextBox";
            this.leverkusenAnzahlTextBox.Size = new System.Drawing.Size(137, 20);
            this.leverkusenAnzahlTextBox.TabIndex = 11;
            // 
            // LagerbeständeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 206);
            this.Controls.Add(this.leverkusenLagerGroupBox);
            this.Controls.Add(this.bonnLagerGroupBox);
            this.Controls.Add(this.kölnLagerGroupBox);
            this.Name = "LagerbeständeForm";
            this.Text = "Lagerbestände";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.kölnLagerGroupBox.ResumeLayout(false);
            this.kölnLagerGroupBox.PerformLayout();
            this.bonnLagerGroupBox.ResumeLayout(false);
            this.bonnLagerGroupBox.PerformLayout();
            this.leverkusenLagerGroupBox.ResumeLayout(false);
            this.leverkusenLagerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox kölnLagerGroupBox;
        private System.Windows.Forms.Label kölnKapazitätTextLabel;
        private System.Windows.Forms.Label kölnBestandTextLabel;
        private System.Windows.Forms.Button kölnPaletteAbziehenButton;
        private System.Windows.Forms.Button kölnPaletteVerkaufenButton;
        private System.Windows.Forms.Button kölnPaletteEinkaufenButton;
        private System.Windows.Forms.Label kölnBestandLabel;
        private System.Windows.Forms.Label kölnKapazitätLabel;
        private System.Windows.Forms.GroupBox bonnLagerGroupBox;
        private System.Windows.Forms.Button bonnPaletteAbziehenButton;
        private System.Windows.Forms.Button bonnPaletteVerkaufenButton;
        private System.Windows.Forms.Button bonnPaletteEinkaufenButton;
        private System.Windows.Forms.Label bonnBestandLabel;
        private System.Windows.Forms.Label bonnKapazitätLabel;
        private System.Windows.Forms.Label bonnKapazitätTextLabel;
        private System.Windows.Forms.Label bonnBestandTextLabel;
        private System.Windows.Forms.GroupBox leverkusenLagerGroupBox;
        private System.Windows.Forms.Button leverkusenPaletteAbziehenButton;
        private System.Windows.Forms.Button leverkusenPaletteVerkaufenButton;
        private System.Windows.Forms.Button leverkusenPaletteEinkaufenButton;
        private System.Windows.Forms.Label leverkusenBestandLabel;
        private System.Windows.Forms.Label leverkusenKapazitätLabel;
        private System.Windows.Forms.Label leverkusenKapazitätTextLabel;
        private System.Windows.Forms.Label leverkusenBestandTextLabel;
        private System.Windows.Forms.Label kölnAnzahlLabel;
        private System.Windows.Forms.TextBox kölnAnzahlTextBox;
        private System.Windows.Forms.Label bonnAnzahllabel;
        private System.Windows.Forms.TextBox bonnAnzahlTextBox;
        private System.Windows.Forms.Label leverkusenAnzahllabel;
        private System.Windows.Forms.TextBox leverkusenAnzahlTextBox;
    }
}

