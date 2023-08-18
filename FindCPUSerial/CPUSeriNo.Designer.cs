namespace FindCPUSerial
{
    partial class CPUSeriNo
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
            this.btn_seribul = new System.Windows.Forms.Button();
            this.tb_serino = new System.Windows.Forms.TextBox();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_seribul
            // 
            this.btn_seribul.Location = new System.Drawing.Point(13, 124);
            this.btn_seribul.Name = "btn_seribul";
            this.btn_seribul.Size = new System.Drawing.Size(99, 23);
            this.btn_seribul.TabIndex = 0;
            this.btn_seribul.Text = "Seri No Bul";
            this.btn_seribul.UseVisualStyleBackColor = true;
            this.btn_seribul.Click += new System.EventHandler(this.btn_seribul_Click);
            // 
            // tb_serino
            // 
            this.tb_serino.Location = new System.Drawing.Point(13, 63);
            this.tb_serino.Name = "tb_serino";
            this.tb_serino.Size = new System.Drawing.Size(265, 20);
            this.tb_serino.TabIndex = 1;
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(179, 124);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(99, 23);
            this.btn_kapat.TabIndex = 2;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // CPUSeriNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.tb_serino);
            this.Controls.Add(this.btn_seribul);
            this.Name = "CPUSeriNo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_seribul;
        private System.Windows.Forms.TextBox tb_serino;
        private System.Windows.Forms.Button btn_kapat;
    }
}

