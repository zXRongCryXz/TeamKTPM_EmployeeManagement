﻿namespace EmployeeManagerment_UI.User
{
    partial class EventForm
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
            this.btn_addevent = new System.Windows.Forms.Button();
            this.btn_deleteevent = new System.Windows.Forms.Button();
            this.btn_editevent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_dateend = new System.Windows.Forms.DateTimePicker();
            this.dtp_datestart = new System.Windows.Forms.DateTimePicker();
            this.txt_moneystaffpay = new System.Windows.Forms.TextBox();
            this.txt_travelby = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_scale = new System.Windows.Forms.TextBox();
            this.txt_actualcost = new System.Windows.Forms.TextBox();
            this.txt_costawarded = new System.Windows.Forms.TextBox();
            this.txt_expectedcost = new System.Windows.Forms.TextBox();
            this.txt_eventname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_eventcontent = new System.Windows.Forms.TabPage();
            this.rtxt_eventcontent = new System.Windows.Forms.RichTextBox();
            this.grid_listevent = new System.Windows.Forms.DataGridView();
            this.btn_reloadevent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_eventcontent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listevent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addevent
            // 
            this.btn_addevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addevent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addevent.Location = new System.Drawing.Point(0, 398);
            this.btn_addevent.Name = "btn_addevent";
            this.btn_addevent.Size = new System.Drawing.Size(286, 77);
            this.btn_addevent.TabIndex = 12;
            this.btn_addevent.Text = "Thêm";
            this.btn_addevent.UseVisualStyleBackColor = true;
            // 
            // btn_deleteevent
            // 
            this.btn_deleteevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteevent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deleteevent.Location = new System.Drawing.Point(0, 470);
            this.btn_deleteevent.Name = "btn_deleteevent";
            this.btn_deleteevent.Size = new System.Drawing.Size(286, 77);
            this.btn_deleteevent.TabIndex = 13;
            this.btn_deleteevent.Text = "Xóa";
            this.btn_deleteevent.UseVisualStyleBackColor = true;
            // 
            // btn_editevent
            // 
            this.btn_editevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editevent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editevent.Location = new System.Drawing.Point(0, 543);
            this.btn_editevent.Name = "btn_editevent";
            this.btn_editevent.Size = new System.Drawing.Size(286, 77);
            this.btn_editevent.TabIndex = 14;
            this.btn_editevent.Text = "Sửa";
            this.btn_editevent.UseVisualStyleBackColor = true;
            this.btn_editevent.Click += new System.EventHandler(this.btn_editevent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_dateend);
            this.panel1.Controls.Add(this.dtp_datestart);
            this.panel1.Controls.Add(this.txt_moneystaffpay);
            this.panel1.Controls.Add(this.txt_travelby);
            this.panel1.Controls.Add(this.txt_location);
            this.panel1.Controls.Add(this.txt_scale);
            this.panel1.Controls.Add(this.txt_actualcost);
            this.panel1.Controls.Add(this.txt_costawarded);
            this.panel1.Controls.Add(this.txt_expectedcost);
            this.panel1.Controls.Add(this.txt_eventname);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(279, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 588);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtp_dateend
            // 
            this.dtp_dateend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateend.Location = new System.Drawing.Point(783, 117);
            this.dtp_dateend.Name = "dtp_dateend";
            this.dtp_dateend.Size = new System.Drawing.Size(181, 39);
            this.dtp_dateend.TabIndex = 8;
            // 
            // dtp_datestart
            // 
            this.dtp_datestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datestart.Location = new System.Drawing.Point(783, 67);
            this.dtp_datestart.Name = "dtp_datestart";
            this.dtp_datestart.Size = new System.Drawing.Size(181, 39);
            this.dtp_datestart.TabIndex = 7;
            // 
            // txt_moneystaffpay
            // 
            this.txt_moneystaffpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moneystaffpay.Location = new System.Drawing.Point(783, 217);
            this.txt_moneystaffpay.Name = "txt_moneystaffpay";
            this.txt_moneystaffpay.Size = new System.Drawing.Size(181, 39);
            this.txt_moneystaffpay.TabIndex = 10;
            // 
            // txt_travelby
            // 
            this.txt_travelby.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_travelby.Location = new System.Drawing.Point(783, 167);
            this.txt_travelby.Name = "txt_travelby";
            this.txt_travelby.Size = new System.Drawing.Size(181, 39);
            this.txt_travelby.TabIndex = 9;
            // 
            // txt_location
            // 
            this.txt_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.Location = new System.Drawing.Point(783, 17);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(181, 39);
            this.txt_location.TabIndex = 6;
            // 
            // txt_scale
            // 
            this.txt_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_scale.Location = new System.Drawing.Point(290, 217);
            this.txt_scale.Name = "txt_scale";
            this.txt_scale.Size = new System.Drawing.Size(181, 39);
            this.txt_scale.TabIndex = 5;
            this.txt_scale.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_actualcost
            // 
            this.txt_actualcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_actualcost.Location = new System.Drawing.Point(290, 167);
            this.txt_actualcost.Name = "txt_actualcost";
            this.txt_actualcost.Size = new System.Drawing.Size(181, 39);
            this.txt_actualcost.TabIndex = 4;
            this.txt_actualcost.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_costawarded
            // 
            this.txt_costawarded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costawarded.Location = new System.Drawing.Point(290, 117);
            this.txt_costawarded.Name = "txt_costawarded";
            this.txt_costawarded.Size = new System.Drawing.Size(181, 39);
            this.txt_costawarded.TabIndex = 3;
            this.txt_costawarded.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_expectedcost
            // 
            this.txt_expectedcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expectedcost.Location = new System.Drawing.Point(290, 67);
            this.txt_expectedcost.Name = "txt_expectedcost";
            this.txt_expectedcost.Size = new System.Drawing.Size(181, 39);
            this.txt_expectedcost.TabIndex = 2;
            this.txt_expectedcost.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_eventname
            // 
            this.txt_eventname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eventname.Location = new System.Drawing.Point(290, 17);
            this.txt_eventname.Name = "txt_eventname";
            this.txt_eventname.Size = new System.Drawing.Size(181, 39);
            this.txt_eventname.TabIndex = 1;
            this.txt_eventname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(63, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 32);
            this.label12.TabIndex = 5;
            this.label12.Text = "Quy mô:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(63, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 32);
            this.label10.TabIndex = 5;
            this.label10.Text = "Chi phí thực tế:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(63, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Có thể chi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(63, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chi phí dự kiến:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(552, 224);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(233, 32);
            this.label20.TabIndex = 3;
            this.label20.Text = "Lệ phí tham gia:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(552, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 32);
            this.label18.TabIndex = 3;
            this.label18.Text = "Phương tiện:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(552, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 32);
            this.label16.TabIndex = 3;
            this.label16.Text = "Ngày kết thúc:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(552, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 32);
            this.label14.TabIndex = 3;
            this.label14.Text = "Ngày bắt đầu:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(552, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa điểm:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(63, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sự kiện:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_eventcontent);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 413);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 175);
            this.tabControl1.TabIndex = 22;
            // 
            // tab_eventcontent
            // 
            this.tab_eventcontent.Controls.Add(this.rtxt_eventcontent);
            this.tab_eventcontent.Location = new System.Drawing.Point(4, 41);
            this.tab_eventcontent.Name = "tab_eventcontent";
            this.tab_eventcontent.Size = new System.Drawing.Size(973, 130);
            this.tab_eventcontent.TabIndex = 0;
            this.tab_eventcontent.Text = "Nội dung";
            this.tab_eventcontent.UseVisualStyleBackColor = true;
            // 
            // rtxt_eventcontent
            // 
            this.rtxt_eventcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_eventcontent.Location = new System.Drawing.Point(0, 0);
            this.rtxt_eventcontent.Name = "rtxt_eventcontent";
            this.rtxt_eventcontent.Size = new System.Drawing.Size(973, 130);
            this.rtxt_eventcontent.TabIndex = 11;
            this.rtxt_eventcontent.Text = "";
            // 
            // grid_listevent
            // 
            this.grid_listevent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_listevent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_listevent.Location = new System.Drawing.Point(0, 200);
            this.grid_listevent.Name = "grid_listevent";
            this.grid_listevent.RowTemplate.Height = 28;
            this.grid_listevent.Size = new System.Drawing.Size(279, 200);
            this.grid_listevent.TabIndex = 0;
            // 
            // btn_reloadevent
            // 
            this.btn_reloadevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reloadevent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_reloadevent.Location = new System.Drawing.Point(0, 613);
            this.btn_reloadevent.Name = "btn_reloadevent";
            this.btn_reloadevent.Size = new System.Drawing.Size(286, 77);
            this.btn_reloadevent.TabIndex = 15;
            this.btn_reloadevent.Text = "Tải lại";
            this.btn_reloadevent.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1260, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 788);
            this.Controls.Add(this.btn_reloadevent);
            this.Controls.Add(this.grid_listevent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_editevent);
            this.Controls.Add(this.btn_deleteevent);
            this.Controls.Add(this.btn_addevent);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_eventcontent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_listevent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addevent;
        private System.Windows.Forms.Button btn_deleteevent;
        private System.Windows.Forms.Button btn_editevent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_listevent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_eventcontent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_eventname;
        private System.Windows.Forms.TextBox txt_scale;
        private System.Windows.Forms.TextBox txt_actualcost;
        private System.Windows.Forms.TextBox txt_costawarded;
        private System.Windows.Forms.TextBox txt_expectedcost;
        private System.Windows.Forms.RichTextBox rtxt_eventcontent;
        private System.Windows.Forms.Button btn_reloadevent;
        private System.Windows.Forms.TextBox txt_moneystaffpay;
        private System.Windows.Forms.TextBox txt_travelby;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.DateTimePicker dtp_dateend;
        private System.Windows.Forms.DateTimePicker dtp_datestart;
    }
}