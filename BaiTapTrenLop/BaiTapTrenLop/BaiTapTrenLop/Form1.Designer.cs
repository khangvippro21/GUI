namespace BaiTapTrenLop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtBanKinh = new TextBox();
            txtHtronY = new TextBox();
            txtHtronX = new TextBox();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtTamY = new TextBox();
            txtTamX = new TextBox();
            label12 = new Label();
            label13 = new Label();
            rdDienTich = new RadioButton();
            rdChuVi = new RadioButton();
            rdKiemTra = new RadioButton();
            btThucHien = new Button();
            label8 = new Label();
            lbKetQua = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBanKinh);
            groupBox1.Controls.Add(txtHtronY);
            groupBox1.Controls.Add(txtHtronX);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(252, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(668, 157);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hình tròn";
            // 
            // txtBanKinh
            // 
            txtBanKinh.Location = new Point(249, 104);
            txtBanKinh.Name = "txtBanKinh";
            txtBanKinh.Size = new Size(150, 31);
            txtBanKinh.TabIndex = 5;
            // 
            // txtHtronY
            // 
            txtHtronY.Location = new Point(482, 56);
            txtHtronY.Name = "txtHtronY";
            txtHtronY.Size = new Size(150, 31);
            txtHtronY.TabIndex = 4;
            // 
            // txtHtronX
            // 
            txtHtronX.Location = new Point(249, 53);
            txtHtronX.Name = "txtHtronX";
            txtHtronX.Size = new Size(150, 31);
            txtHtronX.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(142, 104);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 1;
            label7.Text = "Bán kính = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 56);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "Y = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 53);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "X = ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 56);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Tâm: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTamY);
            groupBox2.Controls.Add(txtTamX);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(252, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(668, 157);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Điểm";
            // 
            // txtTamY
            // 
            txtTamY.Location = new Point(410, 63);
            txtTamY.Name = "txtTamY";
            txtTamY.Size = new Size(150, 31);
            txtTamY.TabIndex = 5;
            // 
            // txtTamX
            // 
            txtTamX.Location = new Point(159, 63);
            txtTamX.Name = "txtTamX";
            txtTamX.Size = new Size(150, 31);
            txtTamX.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(360, 69);
            label12.Name = "label12";
            label12.Size = new Size(44, 25);
            label12.TabIndex = 2;
            label12.Text = "Y = ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(108, 66);
            label13.Name = "label13";
            label13.Size = new Size(45, 25);
            label13.TabIndex = 1;
            label13.Text = "X = ";
            // 
            // rdDienTich
            // 
            rdDienTich.Checked = true;
            rdDienTich.Font = new Font("Segoe UI", 10F);
            rdDienTich.Location = new Point(252, 435);
            rdDienTich.Name = "rdDienTich";
            rdDienTich.Size = new Size(212, 44);
            rdDienTich.TabIndex = 2;
            rdDienTich.TabStop = true;
            rdDienTich.Text = "Tính diện tích";
            rdDienTich.TextAlign = ContentAlignment.TopLeft;
            rdDienTich.UseVisualStyleBackColor = true;
            // 
            // rdChuVi
            // 
            rdChuVi.Font = new Font("Segoe UI", 10F);
            rdChuVi.Location = new Point(252, 535);
            rdChuVi.Name = "rdChuVi";
            rdChuVi.Size = new Size(212, 44);
            rdChuVi.TabIndex = 3;
            rdChuVi.Text = "Tính chu vi";
            rdChuVi.UseVisualStyleBackColor = true;
            // 
            // rdKiemTra
            // 
            rdKiemTra.Font = new Font("Segoe UI", 10F);
            rdKiemTra.Location = new Point(252, 485);
            rdKiemTra.Name = "rdKiemTra";
            rdKiemTra.Size = new Size(493, 44);
            rdKiemTra.TabIndex = 4;
            rdKiemTra.Text = "Kiểm tra điểm có nằm trong đường tròn hay không";
            rdKiemTra.TextAlign = ContentAlignment.TopLeft;
            rdKiemTra.UseVisualStyleBackColor = true;
            // 
            // btThucHien
            // 
            btThucHien.Location = new Point(252, 596);
            btThucHien.Name = "btThucHien";
            btThucHien.Size = new Size(152, 81);
            btThucHien.TabIndex = 5;
            btThucHien.Text = "Thực hiện";
            btThucHien.UseVisualStyleBackColor = true;
            btThucHien.Click += btThucHien_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(501, 595);
            label8.Name = "label8";
            label8.Size = new Size(135, 81);
            label8.TabIndex = 6;
            label8.Text = "Kết  quả: ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbKetQua
            // 
            lbKetQua.BackColor = SystemColors.ActiveBorder;
            lbKetQua.Font = new Font("Segoe UI", 10F);
            lbKetQua.Location = new Point(654, 595);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(266, 81);
            lbKetQua.TabIndex = 7;
            lbKetQua.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 716);
            Controls.Add(lbKetQua);
            Controls.Add(label8);
            Controls.Add(btThucHien);
            Controls.Add(rdKiemTra);
            Controls.Add(rdChuVi);
            Controls.Add(rdDienTich);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label7;
        private GroupBox groupBox2;
        private Label label12;
        private Label label13;
        private RadioButton rdDienTich;
        private RadioButton rdChuVi;
        private RadioButton rdKiemTra;
        private Button btThucHien;
        private Label label8;
        private Label lbKetQua;
        private TextBox txtHtronY;
        private TextBox txtHtronX;
        private TextBox txtTamY;
        private TextBox txtTamX;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtBanKinh;
    }
}
