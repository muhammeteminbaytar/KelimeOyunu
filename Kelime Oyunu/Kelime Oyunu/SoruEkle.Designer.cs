
namespace Kelime_Oyunu
{
    partial class SoruEkle
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_add_soru = new System.Windows.Forms.TextBox();
            this.txt_add_cevap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(12, 418);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(1158, 84);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "SORUYU EKLE";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_add_soru
            // 
            this.txt_add_soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_add_soru.Location = new System.Drawing.Point(12, 60);
            this.txt_add_soru.Multiline = true;
            this.txt_add_soru.Name = "txt_add_soru";
            this.txt_add_soru.Size = new System.Drawing.Size(1158, 64);
            this.txt_add_soru.TabIndex = 8;
            // 
            // txt_add_cevap
            // 
            this.txt_add_cevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_add_cevap.Location = new System.Drawing.Point(12, 168);
            this.txt_add_cevap.Multiline = true;
            this.txt_add_cevap.Name = "txt_add_cevap";
            this.txt_add_cevap.Size = new System.Drawing.Size(1158, 64);
            this.txt_add_cevap.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Soru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cevap";
            // 
            // SoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_add_cevap);
            this.Controls.Add(this.txt_add_soru);
            this.Controls.Add(this.btn_add);
            this.Name = "SoruEkle";
            this.Text = "SoruEkle";
            this.Load += new System.EventHandler(this.SoruEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_add_soru;
        private System.Windows.Forms.TextBox txt_add_cevap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}