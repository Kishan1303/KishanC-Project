using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace Hotel_Management
{

    public partial class staffmanagement : Form
    {
        public static Panel main;
        public static homepage fn;
        int sid, i = 0;
        string gen, a;
        string date;
        public static string pwd;
        DataTable dts = new DataTable();
        public staffmanagement(homepage f, Panel p, string s)
        {
            InitializeComponent();
            main = p;
            fn = f;
            a = s;

        }
        private void load()
        {

            txtnm.Enabled = false;
            txtnum.Enabled = false;
            txteid.Enabled = false;
            txtage.Enabled = false;
            txtsal.Enabled = false;
            gridloader();
        }
        private void staffmanagement_Load(object sender, EventArgs e)
        {
            load();
        }
        public void gridloader()
        {
            dts.Clear();
            string sel = "select id , name ,number,gender,age,designation,email,salary,jod ,img,password from staff";
            SqlDataAdapter das = new SqlDataAdapter(sel, Class1.cn);
            das.Fill(dts);
            staffdgv.DataSource = dts;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                tb_enable();
                date = dtp.ToString().Substring(44, 8);
                btn_add.Text = "Save";
                i = 1;
            }
            else if (i == 1)
            {
                try
                {
                    if (txtnm.Text != "" || txtnum.Text != "" || txtage.Text != "" || comboBox1.Text != "" || txtsal.Text != "" || pictureBox1 != null || txteid.Text != "")
                    {
                        string pathf = Application.StartupPath.ToString();
                        if (!(Directory.Exists(@"..\staffimages")))
                        {
                            Directory.CreateDirectory(@"..\staffimages");
                        }
                        string fnm = txtnm.Text + ".jpg";
                        string location = @"..\\staffimages\\";
                        string path = Path.Combine(location, fnm);
                        Image img = pictureBox1.Image;
                        date = dtp.ToString().Substring(44, 8);
                        if (ch_m.Checked == true)
                        {
                            string ins = "insert into staff(name,email,number,age,designation,img,gender,jod,salary,password)values('" + txtnm.Text + "','" + txteid.Text + "','" + txtnum.Text + "','" + txtage.Text + "','" + comboBox1.Text + "','" + path + "','" + "male" + "','" + date + "','" + txtsal.Text + "','" + tpwd.Text + "')";
                            SqlDataAdapter dai = new SqlDataAdapter(ins, Class1.cn);
                            DataTable dti = new DataTable();
                            dai.Fill(dti);
                            if (comboBox1.Text == "Receptionist")
                            {
                                EnterLoginData();
                            }
                        }
                        else if (ch_f.Checked == true)
                        {
                            string ins = "insert into staff(name,email,number,age,designation,img,gender,jod,salary,password)values('" + txtnm.Text + "','" + txteid.Text + "','" + txtnum.Text + "','" + txtage.Text + "','" + comboBox1.Text + "','" + path + "','" + "female" + "','" + date + "','" + txtsal.Text + "','" + tpwd.Text + "')";
                            SqlDataAdapter dai = new SqlDataAdapter(ins, Class1.cn);
                            DataTable dti = new DataTable();
                            dai.Fill(dti);
                            if (comboBox1.Text == "Receptionist")
                            {
                                EnterLoginData();
                            }
                        }

                        img.Save(path);
                        MessageBox.Show("Data Added !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridloader();
                    }
                    else
                    {
                        MessageBox.Show("Please provide all information!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Please upload an image!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                clear();
                btn_add.Text = "Add Info";
                txtnm.Focus();
                tb_disable();
                i = 0;

            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                btn_upld.Enabled = false;
                tb_enable();
                date = dtp.ToString().Substring(44, 8);
                btn_up.Text = "Save";
                i = 1;
            }
            else if (i == 1)
            {
                if (ch_m.Checked == true)
                {
                    gen = "male";
                }
                else
                {
                    gen = "female";
                }
                if (comboBox1.Text == "Receptionist")
                {
                    pwd = tpwd.Text;
                }
                else
                {
                    pwd = null;
                }
                //string up = "update staff set name = '" + txtnm.Text + "',number ='" + txtnum.Text + "',gender = '" + gen + "',age='" + txtage.Text + "', designation = '" + comboBox1.Text + "' ,email='" + txteid.Text + "',salary='" + txtsal.Text + "',jod='" + date + "' , password = '" + pwd + "' where id='" + sid + "' ";
                //  SqlDataAdapter dau = new SqlDataAdapter(up, Class1.cn);
                ///  DataTable dtu = new DataTable();
                //   dau.Fill(dtu);
                btn_up.Text = "Update";
                tb_disable();
                i = 0;
                btn_upld.Enabled = true;
                clear();
                gridloader();
            }

        }

        private void btn_rm_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you want to remove '" + txtnm.Text + "' \n This action won't be undone");
            if (msg == DialogResult.OK)
            {
                string del = "delete from staff where id = '" + sid + "'";
                SqlDataAdapter dad = new SqlDataAdapter(del, Class1.cn);
                DataTable dtd = new DataTable();
                dad.Fill(dtd);
                clear();
                gridloader();
            }
            else
            {
                clear();
            }
        }
        public void clear()
        {
            txtnm.Text = "";
            txtnum.Text = "";
            ch_f.Checked = false;
            ch_m.Checked = false;
            txtage.Text = "";
            txteid.Text = "";
            txtsal.Text = "";
            
            comboBox1.Text = "";
            tpwd.Text = "";
            
            pictureBox1.Dispose();
        }

        private void btn_upld_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            PictureBox p = pictureBox1;
            if (p != null)
            {
                op.Filter = "(.jpg;.jpeg;.png) | *.jpg;.jpeg;*.png ";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(op.FileName);
                }
            }
        }

        private void staffdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = staffdgv.Rows[e.RowIndex];
            txtnm.Text = row.Cells[1].Value.ToString();
            txtnum.Text = row.Cells[2].Value.ToString();
            string gen = row.Cells[3].Value.ToString();
            if (gen == "male")
            {
                ch_m.Checked = true;
            }
            else
            {
                ch_f.Checked = true;
            }
            txtage.Text = row.Cells[4].Value.ToString();
            txteid.Text = row.Cells[6].Value.ToString();
            txtsal.Text = row.Cells[7].Value.ToString();
            tpwd.Text = row.Cells[10].Value.ToString();
            sid = Convert.ToInt32(row.Cells[0].Value.ToString());
            var sn = row.Cells[5].Value.ToString();
            var in1 = comboBox1.Items.IndexOf(sn.ToString());
            comboBox1.SelectedIndex = in1;

            dtp.Text = row.Cells[8].Value.ToString();
            pictureBox1.ImageLocation = row.Cells[9].Value.ToString();
            pictureBox1.Load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Receptionist")
            {
                tpwd.Enabled = true;
            }
            else
            {
                tpwd.Enabled = false;
            }
        }
        public void tb_enable()
        {
            txtnm.Enabled = true;
            txtnum.Enabled = true;
            txtage.Enabled = true;
            txteid.Enabled = true;
            txtsal.Enabled = true;
            dtp.Enabled = true;
            tpwd.Enabled = true;
        }
        public void tb_disable()
        {
            txtnm.Enabled = false;
            txtnum.Enabled = false;
            txtage.Enabled = false;
            txteid.Enabled = false;
            txtsal.Enabled = false;
            dtp.Enabled = false;
            tpwd.Enabled = false;
        }
        protected void EnterLoginData()
        {
            string ins2 = "insert into login(name,email,password) values('" + txtnm.Text + "','" + txteid.Text + "','" + tpwd.Text + "')";
            SqlDataAdapter dai = new SqlDataAdapter(ins2, Class1.cn);
            DataTable dti = new DataTable();
            dai.Fill(dti);
        }
    }
}
