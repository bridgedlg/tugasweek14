
namespace TugasWeek14
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
            this.labelmasukal = new System.Windows.Forms.Label();
            this.labelmasukh = new System.Windows.Forms.Label();
            this.labelmenjadi = new System.Windows.Forms.Label();
            this.textkalimat = new System.Windows.Forms.TextBox();
            this.textboxhuruf = new System.Windows.Forms.TextBox();
            this.textboxjadi = new System.Windows.Forms.TextBox();
            this.buttonkonversi = new System.Windows.Forms.Button();
            this.labelh = new System.Windows.Forms.Label();
            this.labelhasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelmasukal
            // 
            this.labelmasukal.AutoSize = true;
            this.labelmasukal.Location = new System.Drawing.Point(44, 36);
            this.labelmasukal.Name = "labelmasukal";
            this.labelmasukal.Size = new System.Drawing.Size(138, 20);
            this.labelmasukal.TabIndex = 0;
            this.labelmasukal.Text = "Masukkan Kalimat";
            // 
            // labelmasukh
            // 
            this.labelmasukh.AutoSize = true;
            this.labelmasukh.Location = new System.Drawing.Point(44, 86);
            this.labelmasukh.Name = "labelmasukh";
            this.labelmasukh.Size = new System.Drawing.Size(115, 20);
            this.labelmasukh.TabIndex = 1;
            this.labelmasukh.Text = "Masukan huruf";
            this.labelmasukh.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelmenjadi
            // 
            this.labelmenjadi.AutoSize = true;
            this.labelmenjadi.Location = new System.Drawing.Point(327, 86);
            this.labelmenjadi.Name = "labelmenjadi";
            this.labelmenjadi.Size = new System.Drawing.Size(64, 20);
            this.labelmenjadi.TabIndex = 2;
            this.labelmenjadi.Text = "Menjadi";
            // 
            // textkalimat
            // 
            this.textkalimat.Location = new System.Drawing.Point(203, 36);
            this.textkalimat.Name = "textkalimat";
            this.textkalimat.Size = new System.Drawing.Size(309, 26);
            this.textkalimat.TabIndex = 3;
            // 
            // textboxhuruf
            // 
            this.textboxhuruf.Location = new System.Drawing.Point(203, 86);
            this.textboxhuruf.Name = "textboxhuruf";
            this.textboxhuruf.Size = new System.Drawing.Size(100, 26);
            this.textboxhuruf.TabIndex = 4;
            // 
            // textboxjadi
            // 
            this.textboxjadi.Location = new System.Drawing.Point(412, 86);
            this.textboxjadi.Name = "textboxjadi";
            this.textboxjadi.Size = new System.Drawing.Size(100, 26);
            this.textboxjadi.TabIndex = 5;
            // 
            // buttonkonversi
            // 
            this.buttonkonversi.Location = new System.Drawing.Point(203, 157);
            this.buttonkonversi.Name = "buttonkonversi";
            this.buttonkonversi.Size = new System.Drawing.Size(309, 38);
            this.buttonkonversi.TabIndex = 6;
            this.buttonkonversi.Text = "Konversi!";
            this.buttonkonversi.UseVisualStyleBackColor = true;
            this.buttonkonversi.Click += new System.EventHandler(this.buttonkonversi_Click);
            // 
            // labelh
            // 
            this.labelh.AutoSize = true;
            this.labelh.Location = new System.Drawing.Point(44, 234);
            this.labelh.Name = "labelh";
            this.labelh.Size = new System.Drawing.Size(48, 20);
            this.labelh.TabIndex = 7;
            this.labelh.Text = "Hasil:";
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Location = new System.Drawing.Point(199, 234);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(0, 20);
            this.labelhasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.labelh);
            this.Controls.Add(this.buttonkonversi);
            this.Controls.Add(this.textboxjadi);
            this.Controls.Add(this.textboxhuruf);
            this.Controls.Add(this.textkalimat);
            this.Controls.Add(this.labelmenjadi);
            this.Controls.Add(this.labelmasukh);
            this.Controls.Add(this.labelmasukal);
            this.Name = "Form1";
            this.Text = "QUIZ PANDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmasukal;
        private System.Windows.Forms.Label labelmasukh;
        private System.Windows.Forms.Label labelmenjadi;
        private System.Windows.Forms.TextBox textkalimat;
        private System.Windows.Forms.TextBox textboxhuruf;
        private System.Windows.Forms.TextBox textboxjadi;
        private System.Windows.Forms.Button buttonkonversi;
        private System.Windows.Forms.Label labelh;
        private System.Windows.Forms.Label labelhasil;
    }
}

