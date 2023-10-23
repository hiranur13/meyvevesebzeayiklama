namespace meyvesebzeayirma
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstTumu = new System.Windows.Forms.ListBox();
            this.lstMeyve = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbSebze = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tümü";
            // 
            // lstTumu
            // 
            this.lstTumu.FormattingEnabled = true;
            this.lstTumu.ItemHeight = 24;
            this.lstTumu.Items.AddRange(new object[] {
            "Patates",
            "Muz",
            "Soğan",
            "Çilek",
            "Böğürtlen",
            "Kiraz",
            "Ispanak"});
            this.lstTumu.Location = new System.Drawing.Point(12, 95);
            this.lstTumu.Name = "lstTumu";
            this.lstTumu.Size = new System.Drawing.Size(144, 196);
            this.lstTumu.TabIndex = 1;
            // 
            // lstMeyve
            // 
            this.lstMeyve.FormattingEnabled = true;
            this.lstMeyve.ItemHeight = 24;
            this.lstMeyve.Location = new System.Drawing.Point(174, 95);
            this.lstMeyve.Name = "lstMeyve";
            this.lstMeyve.Size = new System.Drawing.Size(144, 196);
            this.lstMeyve.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meyve";
            // 
            // lsbSebze
            // 
            this.lsbSebze.FormattingEnabled = true;
            this.lsbSebze.ItemHeight = 24;
            this.lsbSebze.Location = new System.Drawing.Point(341, 95);
            this.lsbSebze.Name = "lsbSebze";
            this.lsbSebze.Size = new System.Drawing.Size(144, 196);
            this.lsbSebze.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sebze";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(473, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ayıkla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsbSebze);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMeyve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTumu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTumu;
        private System.Windows.Forms.ListBox lstMeyve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbSebze;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

