namespace BT_MayTinh
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnTich = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(292, 101);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(54, 22);
            this.txtSoA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Máy tính";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(280, 255);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(77, 40);
            this.btnTong.TabIndex = 2;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết Quả";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(292, 171);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(54, 22);
            this.txtSoB.TabIndex = 0;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(450, 141);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(76, 22);
            this.txtKQ.TabIndex = 0;
            // 
            // btnTich
            // 
            this.btnTich.Location = new System.Drawing.Point(410, 255);
            this.btnTich.Name = "btnTich";
            this.btnTich.Size = new System.Drawing.Size(77, 40);
            this.btnTich.TabIndex = 2;
            this.btnTich.Text = "Tích";
            this.btnTich.UseVisualStyleBackColor = true;
            // 
            // btnHieu
            // 
            this.btnHieu.Location = new System.Drawing.Point(280, 313);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(77, 40);
            this.btnHieu.TabIndex = 2;
            this.btnHieu.Text = "Hiệu";
            this.btnHieu.UseVisualStyleBackColor = true;
            // 
            // btnThuong
            // 
            this.btnThuong.Location = new System.Drawing.Point(410, 313);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(77, 40);
            this.btnThuong.TabIndex = 2;
            this.btnThuong.Text = "Thương";
            this.btnThuong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 503);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTich);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnTich;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnThuong;
    }
}

