namespace ThaoTacListBox
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
            ColumnHeader stt;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbHoten = new Label();
            txtHoten = new TextBox();
            lbTrinhdo = new Label();
            cbTrinhdo = new ComboBox();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            btThem = new Button();
            btXoa = new Button();
            listView1 = new ListView();
            hoten = new ColumnHeader();
            trinhdo = new ColumnHeader();
            ngaysinh = new ColumnHeader();
            gioitinh = new ColumnHeader();
            imageList1 = new ImageList(components);
            gbView = new GroupBox();
            rdTilte = new RadioButton();
            rdList = new RadioButton();
            rdDetail = new RadioButton();
            rdSmall = new RadioButton();
            rdLarge = new RadioButton();
            stt = new ColumnHeader();
            gbView.SuspendLayout();
            SuspendLayout();
            // 
            // stt
            // 
            stt.Text = "STT";
            // 
            // lbHoten
            // 
            lbHoten.Location = new Point(87, 57);
            lbHoten.Name = "lbHoten";
            lbHoten.Size = new Size(94, 38);
            lbHoten.TabIndex = 0;
            lbHoten.Text = "Họ tên:";
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(216, 54);
            txtHoten.Multiline = true;
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(300, 41);
            txtHoten.TabIndex = 1;
            // 
            // lbTrinhdo
            // 
            lbTrinhdo.Location = new Point(87, 156);
            lbTrinhdo.Name = "lbTrinhdo";
            lbTrinhdo.Size = new Size(94, 38);
            lbTrinhdo.TabIndex = 2;
            lbTrinhdo.Text = "Trình độ:";
            // 
            // cbTrinhdo
            // 
            cbTrinhdo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTrinhdo.DisplayMember = "(none)";
            cbTrinhdo.FormattingEnabled = true;
            cbTrinhdo.Items.AddRange(new object[] { "Đại học", "Cao đẳng", "Trung cấp", "TNPT" });
            cbTrinhdo.Location = new Point(216, 153);
            cbTrinhdo.Name = "cbTrinhdo";
            cbTrinhdo.Size = new Size(300, 33);
            cbTrinhdo.TabIndex = 3;
            cbTrinhdo.Text = "TNPT";
            // 
            // label1
            // 
            label1.Location = new Point(74, 254);
            label1.Name = "label1";
            label1.Size = new Size(107, 38);
            label1.TabIndex = 4;
            label1.Text = "Ngày sinh: ";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarTrailingForeColor = SystemColors.ActiveBorder;
            dateTimePicker.Checked = false;
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(216, 254);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(300, 33);
            dateTimePicker.TabIndex = 5;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.Location = new Point(87, 354);
            label2.Name = "label2";
            label2.Size = new Size(94, 38);
            label2.TabIndex = 6;
            label2.Text = "GIới tính: ";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(216, 352);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(77, 29);
            rdNam.TabIndex = 7;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(386, 352);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(62, 29);
            rdNu.TabIndex = 8;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            btThem.Location = new Point(216, 457);
            btThem.Name = "btThem";
            btThem.Size = new Size(112, 34);
            btThem.TabIndex = 9;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(404, 457);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(112, 34);
            btXoa.TabIndex = 10;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Default;
            listView1.Columns.AddRange(new ColumnHeader[] { stt, hoten, trinhdo, ngaysinh, gioitinh });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(576, 57);
            listView1.Name = "listView1";
            listView1.Size = new Size(617, 434);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // hoten
            // 
            hoten.Text = "Họ Tên";
            hoten.TextAlign = HorizontalAlignment.Center;
            hoten.Width = 100;
            // 
            // trinhdo
            // 
            trinhdo.Text = "Trình độ";
            trinhdo.TextAlign = HorizontalAlignment.Center;
            trinhdo.Width = 100;
            // 
            // ngaysinh
            // 
            ngaysinh.Text = "Ngày sinh";
            ngaysinh.TextAlign = HorizontalAlignment.Center;
            ngaysinh.Width = 150;
            // 
            // gioitinh
            // 
            gioitinh.Text = "Giới tính";
            gioitinh.TextAlign = HorizontalAlignment.Right;
            gioitinh.Width = 100;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "boy.jpg");
            imageList1.Images.SetKeyName(1, "girl.jpg");
            // 
            // gbView
            // 
            gbView.Controls.Add(rdTilte);
            gbView.Controls.Add(rdList);
            gbView.Controls.Add(rdDetail);
            gbView.Controls.Add(rdSmall);
            gbView.Controls.Add(rdLarge);
            gbView.Location = new Point(1280, 57);
            gbView.Name = "gbView";
            gbView.Size = new Size(134, 434);
            gbView.TabIndex = 12;
            gbView.TabStop = false;
            gbView.Text = "View";
            // 
            // rdTilte
            // 
            rdTilte.AutoSize = true;
            rdTilte.Location = new Point(25, 295);
            rdTilte.Name = "rdTilte";
            rdTilte.Size = new Size(73, 29);
            rdTilte.TabIndex = 12;
            rdTilte.TabStop = true;
            rdTilte.Text = "Tilte";
            rdTilte.UseVisualStyleBackColor = true;
            // 
            // rdList
            // 
            rdList.AutoSize = true;
            rdList.Location = new Point(25, 238);
            rdList.Name = "rdList";
            rdList.Size = new Size(65, 29);
            rdList.TabIndex = 11;
            rdList.TabStop = true;
            rdList.Text = "List";
            rdList.UseVisualStyleBackColor = true;
            // 
            // rdDetail
            // 
            rdDetail.AutoSize = true;
            rdDetail.Checked = true;
            rdDetail.Location = new Point(25, 132);
            rdDetail.Name = "rdDetail";
            rdDetail.Size = new Size(86, 29);
            rdDetail.TabIndex = 10;
            rdDetail.TabStop = true;
            rdDetail.Text = "Detail";
            rdDetail.UseVisualStyleBackColor = true;
            // 
            // rdSmall
            // 
            rdSmall.AutoSize = true;
            rdSmall.Location = new Point(25, 188);
            rdSmall.Name = "rdSmall";
            rdSmall.Size = new Size(83, 29);
            rdSmall.TabIndex = 9;
            rdSmall.TabStop = true;
            rdSmall.Text = "Small";
            rdSmall.UseVisualStyleBackColor = true;
            // 
            // rdLarge
            // 
            rdLarge.AutoSize = true;
            rdLarge.Location = new Point(24, 83);
            rdLarge.Name = "rdLarge";
            rdLarge.Size = new Size(84, 29);
            rdLarge.TabIndex = 8;
            rdLarge.TabStop = true;
            rdLarge.Text = "Large";
            rdLarge.UseVisualStyleBackColor = true;
            rdLarge.CheckedChanged += rdLarge_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 551);
            Controls.Add(gbView);
            Controls.Add(listView1);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(label2);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Controls.Add(cbTrinhdo);
            Controls.Add(lbTrinhdo);
            Controls.Add(txtHoten);
            Controls.Add(lbHoten);
            Name = "Form1";
            Text = "Form1";
            gbView.ResumeLayout(false);
            gbView.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHoten;
        private TextBox txtHoten;
        private Label lbTrinhdo;
        private ComboBox cbTrinhdo;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private Button btThem;
        private Button btXoa;
        private ListView listView1;
        private GroupBox gbView;
        private RadioButton rdTilte;
        private RadioButton rdList;
        private RadioButton rdDetail;
        private RadioButton rdSmall;
        private RadioButton rdLarge;
        private ColumnHeader hoten;
        private ColumnHeader trinhdo;
        private ColumnHeader ngaysinh;
        private ColumnHeader gioitinh;
        private ImageList imageList1;
    }
}
