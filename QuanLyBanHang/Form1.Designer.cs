namespace QuanLyBanHang
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
            this.txtHSA = new System.Windows.Forms.TextBox();
            this.txtHSB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHSC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số a: ";
            // 
            // txtHSA
            // 
            this.txtHSA.Location = new System.Drawing.Point(188, 53);
            this.txtHSA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHSA.MaxLength = 5;
            this.txtHSA.Name = "txtHSA";
            this.txtHSA.Size = new System.Drawing.Size(184, 21);
            this.txtHSA.TabIndex = 1;
            // 
            // txtHSB
            // 
            this.txtHSB.Location = new System.Drawing.Point(188, 114);
            this.txtHSB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHSB.MaxLength = 5;
            this.txtHSB.Name = "txtHSB";
            this.txtHSB.Size = new System.Drawing.Size(184, 21);
            this.txtHSB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập số c:";
            // 
            // txtHSC
            // 
            this.txtHSC.Location = new System.Drawing.Point(188, 181);
            this.txtHSC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHSC.MaxLength = 5;
            this.txtHSC.Name = "txtHSC";
            this.txtHSC.Size = new System.Drawing.Size(184, 21);
            this.txtHSC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nghiệm";
            // 
            // txtNghiem
            // 
            this.txtNghiem.Location = new System.Drawing.Point(188, 303);
            this.txtNghiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNghiem.MaxLength = 5;
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.ReadOnly = true;
            this.txtNghiem.Size = new System.Drawing.Size(184, 21);
            this.txtNghiem.TabIndex = 6;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(188, 246);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 28);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(297, 246);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 28);
            this.btnLamLai.TabIndex = 9;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 352);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNghiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHSC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHSB);
            this.Controls.Add(this.txtHSA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Phương Trình Bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHSA;
        private System.Windows.Forms.TextBox txtHSB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHSC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnLamLai;

    }
}

