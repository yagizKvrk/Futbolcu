namespace Futbolcu
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtForma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.btnFutbolcuOlustur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(34, 74);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Multiline = true;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(182, 26);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Honeydew;
            this.lblAdSoyad.Location = new System.Drawing.Point(30, 37);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(127, 20);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Adı ve soyadı:";
            // 
            // txtForma
            // 
            this.txtForma.Location = new System.Drawing.Point(34, 175);
            this.txtForma.Margin = new System.Windows.Forms.Padding(4);
            this.txtForma.Multiline = true;
            this.txtForma.Name = "txtForma";
            this.txtForma.Size = new System.Drawing.Size(182, 28);
            this.txtForma.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(30, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forma Numarası:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Seçiniz";
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.BackColor = System.Drawing.Color.Transparent;
            this.lblPozisyon.ForeColor = System.Drawing.Color.Honeydew;
            this.lblPozisyon.Location = new System.Drawing.Point(30, 237);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(85, 20);
            this.lblPozisyon.TabIndex = 3;
            this.lblPozisyon.Text = "Pozisyon";
            // 
            // btnFutbolcuOlustur
            // 
            this.btnFutbolcuOlustur.BackColor = System.Drawing.Color.Transparent;
            this.btnFutbolcuOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFutbolcuOlustur.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnFutbolcuOlustur.Location = new System.Drawing.Point(276, 336);
            this.btnFutbolcuOlustur.Name = "btnFutbolcuOlustur";
            this.btnFutbolcuOlustur.Size = new System.Drawing.Size(87, 35);
            this.btnFutbolcuOlustur.TabIndex = 4;
            this.btnFutbolcuOlustur.Text = "Oluştur";
            this.btnFutbolcuOlustur.UseVisualStyleBackColor = false;
            this.btnFutbolcuOlustur.Click += new System.EventHandler(this.btnFutbolcuOlustur_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(243, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kadroyu Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Futbolcu.Properties.Resources._615630_v2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(644, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFutbolcuOlustur);
            this.Controls.Add(this.lblPozisyon);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtForma);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtAdSoyad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtForma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.Button btnFutbolcuOlustur;
        private System.Windows.Forms.Button button1;
    }
}

