
namespace Kelime_Oyunu
{
    partial class Giris
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_basla = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_soru_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyuna Başlamak İçin\r\n Adınızı Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 91);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.Location = new System.Drawing.Point(12, 109);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(321, 30);
            this.txt_username.TabIndex = 2;
            // 
            // btn_basla
            // 
            this.btn_basla.BackColor = System.Drawing.Color.Maroon;
            this.btn_basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_basla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_basla.Location = new System.Drawing.Point(13, 371);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(321, 46);
            this.btn_basla.TabIndex = 3;
            this.btn_basla.Text = "BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // btn_soru_ekle
            // 
            this.btn_soru_ekle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_soru_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_soru_ekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_soru_ekle.Location = new System.Drawing.Point(13, 423);
            this.btn_soru_ekle.Name = "btn_soru_ekle";
            this.btn_soru_ekle.Size = new System.Drawing.Size(321, 46);
            this.btn_soru_ekle.TabIndex = 4;
            this.btn_soru_ekle.Text = "SORU EKLE";
            this.btn_soru_ekle.UseVisualStyleBackColor = false;
            this.btn_soru_ekle.Click += new System.EventHandler(this.btn_soru_ekle_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(346, 505);
            this.Controls.Add(this.btn_soru_ekle);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_basla;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_soru_ekle;
    }
}