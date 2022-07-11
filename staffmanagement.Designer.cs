namespace Hotel_Management
{
    partial class staffmanagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_rm = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_f = new System.Windows.Forms.RadioButton();
            this.ch_m = new System.Windows.Forms.RadioButton();
            this.btn_upld = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txteid = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staffdgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(40)))), ((int)(((byte)(91)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 230);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 11);
            this.panel2.TabIndex = 61;
            // 
            // btn_rm
            // 
            this.btn_rm.Location = new System.Drawing.Point(668, 329);
            this.btn_rm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rm.Name = "btn_rm";
            this.btn_rm.Size = new System.Drawing.Size(130, 28);
            this.btn_rm.TabIndex = 60;
            this.btn_rm.Text = "Remove Mem.";
            this.btn_rm.UseVisualStyleBackColor = true;
            this.btn_rm.Click += new System.EventHandler(this.btn_rm_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(668, 297);
            this.btn_up.Margin = new System.Windows.Forms.Padding(2);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(130, 28);
            this.btn_up.TabIndex = 59;
            this.btn_up.Text = "Update Info.";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 327);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Join Date :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(668, 264);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 28);
            this.btn_add.TabIndex = 57;
            this.btn_add.Text = "Add Data";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ch_f);
            this.groupBox1.Controls.Add(this.ch_m);
            this.groupBox1.Location = new System.Drawing.Point(95, 325);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(134, 29);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // ch_f
            // 
            this.ch_f.AutoSize = true;
            this.ch_f.Location = new System.Drawing.Point(59, 2);
            this.ch_f.Margin = new System.Windows.Forms.Padding(2);
            this.ch_f.Name = "ch_f";
            this.ch_f.Size = new System.Drawing.Size(59, 17);
            this.ch_f.TabIndex = 3;
            this.ch_f.TabStop = true;
            this.ch_f.Text = "Female";
            this.ch_f.UseVisualStyleBackColor = true;
            // 
            // ch_m
            // 
            this.ch_m.AutoSize = true;
            this.ch_m.Location = new System.Drawing.Point(0, 2);
            this.ch_m.Margin = new System.Windows.Forms.Padding(2);
            this.ch_m.Name = "ch_m";
            this.ch_m.Size = new System.Drawing.Size(48, 17);
            this.ch_m.TabIndex = 2;
            this.ch_m.TabStop = true;
            this.ch_m.Text = "Male";
            this.ch_m.UseVisualStyleBackColor = true;
            // 
            // btn_upld
            // 
            this.btn_upld.Location = new System.Drawing.Point(542, 392);
            this.btn_upld.Margin = new System.Windows.Forms.Padding(2);
            this.btn_upld.Name = "btn_upld";
            this.btn_upld.Size = new System.Drawing.Size(108, 28);
            this.btn_upld.TabIndex = 55;
            this.btn_upld.Text = "Upload";
            this.btn_upld.UseVisualStyleBackColor = true;
            this.btn_upld.Click += new System.EventHandler(this.btn_upld_Click_1);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(339, 324);
            this.dtp.Margin = new System.Windows.Forms.Padding(2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(148, 20);
            this.dtp.TabIndex = 54;
            // 
            // txtsal
            // 
            this.txtsal.Enabled = false;
            this.txtsal.Location = new System.Drawing.Point(339, 296);
            this.txtsal.Margin = new System.Windows.Forms.Padding(2);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(148, 20);
            this.txtsal.TabIndex = 53;
            // 
            // txteid
            // 
            this.txteid.Enabled = false;
            this.txteid.Location = new System.Drawing.Point(337, 269);
            this.txteid.Margin = new System.Windows.Forms.Padding(2);
            this.txteid.Name = "txteid";
            this.txteid.Size = new System.Drawing.Size(150, 20);
            this.txteid.TabIndex = 52;
            // 
            // txtage
            // 
            this.txtage.Enabled = false;
            this.txtage.Location = new System.Drawing.Point(91, 359);
            this.txtage.Margin = new System.Windows.Forms.Padding(2);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(150, 20);
            this.txtage.TabIndex = 51;
            // 
            // txtnum
            // 
            this.txtnum.Enabled = false;
            this.txtnum.Location = new System.Drawing.Point(94, 297);
            this.txtnum.Margin = new System.Windows.Forms.Padding(2);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(150, 20);
            this.txtnum.TabIndex = 50;
            // 
            // txtnm
            // 
            this.txtnm.Enabled = false;
            this.txtnm.Location = new System.Drawing.Point(94, 269);
            this.txtnm.Margin = new System.Windows.Forms.Padding(2);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(150, 20);
            this.txtnm.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(529, 253);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Gender    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Salary      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Email Id   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "age          :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Number   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Name      :";
            // 
            // staffdgv
            // 
            this.staffdgv.AllowUserToAddRows = false;
            this.staffdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.staffdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.staffdgv.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(40)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(91)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffdgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffdgv.Location = new System.Drawing.Point(0, 0);
            this.staffdgv.Margin = new System.Windows.Forms.Padding(2);
            this.staffdgv.Name = "staffdgv";
            this.staffdgv.ReadOnly = true;
            this.staffdgv.RowHeadersVisible = false;
            this.staffdgv.RowHeadersWidth = 51;
            this.staffdgv.Size = new System.Drawing.Size(825, 230);
            this.staffdgv.TabIndex = 41;
            this.staffdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffdgv_CellClick);
            this.staffdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffdgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 362);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Designation  :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Maintenance & Cleaning",
            "RoomService",
            "Receptionist"});
            this.comboBox1.Location = new System.Drawing.Point(339, 359);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 63;
            //this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // staffmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 431);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_rm);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_upld);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txteid);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffdgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "staffmanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staffmanagement";
            this.Load += new System.EventHandler(this.staffmanagement_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_rm;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ch_f;
        private System.Windows.Forms.RadioButton ch_m;
        private System.Windows.Forms.Button btn_upld;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txteid;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView staffdgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}