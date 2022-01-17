namespace Generator_Haseł
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IloscSymboli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.Haslo = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alwaysTop = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxSpecial = new System.Windows.Forms.CheckBox();
            this.checkBoxBig = new System.Windows.Forms.CheckBox();
            this.checkBoxSmall = new System.Windows.Forms.CheckBox();
            this.checkBoxLiczby = new System.Windows.Forms.CheckBox();
            this.StartCopyButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IloscSymboli
            // 
            this.IloscSymboli.Location = new System.Drawing.Point(33, 29);
            this.IloscSymboli.Name = "IloscSymboli";
            this.IloscSymboli.Size = new System.Drawing.Size(49, 20);
            this.IloscSymboli.TabIndex = 0;
            this.IloscSymboli.TabStop = false;
            this.IloscSymboli.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość symboli:";
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Location = new System.Drawing.Point(0, 0);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(167, 35);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Wygeneruj";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Haslo
            // 
            this.Haslo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Haslo.Location = new System.Drawing.Point(0, 0);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(378, 130);
            this.Haslo.TabIndex = 3;
            this.Haslo.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.alwaysTop);
            this.panel1.Controls.Add(this.Haslo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 153);
            this.panel1.TabIndex = 4;
            // 
            // alwaysTop
            // 
            this.alwaysTop.AutoSize = true;
            this.alwaysTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.alwaysTop.Location = new System.Drawing.Point(0, 134);
            this.alwaysTop.Name = "alwaysTop";
            this.alwaysTop.Padding = new System.Windows.Forms.Padding(4, 0, 0, 2);
            this.alwaysTop.Size = new System.Drawing.Size(378, 19);
            this.alwaysTop.TabIndex = 4;
            this.alwaysTop.Text = "zawsze na wierzchu";
            this.alwaysTop.UseVisualStyleBackColor = true;
            this.alwaysTop.CheckedChanged += new System.EventHandler(this.alwaysTop_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.checkBoxSpecial);
            this.panel2.Controls.Add(this.checkBoxBig);
            this.panel2.Controls.Add(this.checkBoxSmall);
            this.panel2.Controls.Add(this.checkBoxLiczby);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.IloscSymboli);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 54);
            this.panel2.TabIndex = 5;
            // 
            // checkBoxSpecial
            // 
            this.checkBoxSpecial.AutoSize = true;
            this.checkBoxSpecial.Checked = true;
            this.checkBoxSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSpecial.Location = new System.Drawing.Point(272, 34);
            this.checkBoxSpecial.Name = "checkBoxSpecial";
            this.checkBoxSpecial.Size = new System.Drawing.Size(103, 17);
            this.checkBoxSpecial.TabIndex = 6;
            this.checkBoxSpecial.Text = "Znaki Specjalne";
            this.checkBoxSpecial.UseVisualStyleBackColor = true;
            // 
            // checkBoxBig
            // 
            this.checkBoxBig.AutoSize = true;
            this.checkBoxBig.Checked = true;
            this.checkBoxBig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBig.Location = new System.Drawing.Point(145, 34);
            this.checkBoxBig.Name = "checkBoxBig";
            this.checkBoxBig.Size = new System.Drawing.Size(79, 17);
            this.checkBoxBig.TabIndex = 5;
            this.checkBoxBig.Text = "Duże Litery";
            this.checkBoxBig.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmall
            // 
            this.checkBoxSmall.AutoSize = true;
            this.checkBoxSmall.Checked = true;
            this.checkBoxSmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSmall.Location = new System.Drawing.Point(272, 8);
            this.checkBoxSmall.Name = "checkBoxSmall";
            this.checkBoxSmall.Size = new System.Drawing.Size(79, 17);
            this.checkBoxSmall.TabIndex = 4;
            this.checkBoxSmall.Text = "Małe Litery";
            this.checkBoxSmall.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiczby
            // 
            this.checkBoxLiczby.AutoSize = true;
            this.checkBoxLiczby.Checked = true;
            this.checkBoxLiczby.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLiczby.Location = new System.Drawing.Point(145, 8);
            this.checkBoxLiczby.Name = "checkBoxLiczby";
            this.checkBoxLiczby.Size = new System.Drawing.Size(56, 17);
            this.checkBoxLiczby.TabIndex = 3;
            this.checkBoxLiczby.Text = "Liczby";
            this.checkBoxLiczby.UseVisualStyleBackColor = true;
            // 
            // StartCopyButton
            // 
            this.StartCopyButton.AutoSize = true;
            this.StartCopyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartCopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartCopyButton.Location = new System.Drawing.Point(0, 0);
            this.StartCopyButton.Name = "StartCopyButton";
            this.StartCopyButton.Size = new System.Drawing.Size(183, 35);
            this.StartCopyButton.TabIndex = 3;
            this.StartCopyButton.Text = "Wygeneruj i skopiuj do schowka";
            this.StartCopyButton.UseVisualStyleBackColor = true;
            this.StartCopyButton.Click += new System.EventHandler(this.StartCopyButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.StartButton);
            this.panel3.Location = new System.Drawing.Point(12, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 35);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.StartCopyButton);
            this.panel4.Location = new System.Drawing.Point(185, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 35);
            this.panel4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(378, 253);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(393, 292);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Generator haseł";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IloscSymboli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RichTextBox Haslo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxSpecial;
        private System.Windows.Forms.CheckBox checkBoxBig;
        private System.Windows.Forms.CheckBox checkBoxLiczby;
        private System.Windows.Forms.Button StartCopyButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox alwaysTop;
        private System.Windows.Forms.CheckBox checkBoxSmall;
    }
}

