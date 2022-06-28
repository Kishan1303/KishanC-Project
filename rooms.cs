using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Hotel_Management
{
    public partial class rooms : Form
    {
        public static Panel main;
        public static homepage fn;
        public static string a;


        int totcat, oid;
        int pxloc = 50, pyloc = 80, lxloc = 50, lyloc = 80;
        public rooms(homepage f, Panel p, string s)
        {
            InitializeComponent();
            main = p;
            fn = f;
            a = s;

        }

        private void rooms_Load(object sender, EventArgs e)
        {
            string a = "select Distinct rtype from rooms ";
            SqlDataAdapter da = new SqlDataAdapter(a, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "rtype";


            string sel = "Select * from rooms where catagory='" + Class1.s_cat + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sel, Class1.cn);
            DataTable dts = new DataTable();
            adapter.Fill(dts);
            totcat = dts.Rows.Count;
            for (int i = 0; i < totcat; i++)
            {
              /*  PictureBox p = new PictureBox();
                panel2.Controls.Add(p);
                p.Name = "P_Item" + i.ToString();
                p.Size = new Size(200, 150);
                p.Location = new System.Drawing.Point(pxloc, pyloc);
                string i_path = Path.Combine(dts.Rows[i]["image"].ToString());
                p.Image = Image.FromFile(i_path);
                p.SizeMode = PictureBoxSizeMode.Zoom;*/

                PictureBox p = new PictureBox();
                this.Controls.Add(p);
                p.Name = "P_Item" + i.ToString();
                p.Size = new Size(200, 150);
                p.Location = new System.Drawing.Point(pxloc, pyloc);
                string i_path = Path.Combine(dts.Rows[i]["image"].ToString());
                p.Image = Image.FromFile(i_path);
                p.SizeMode = PictureBoxSizeMode.Zoom;

                Label l = new Label();
                panel2.Controls.Add(l);
                l.Name = dts.Rows[i]["rno"].ToString();
                l.Size = new Size(200, 50);
                l.Location = new System.Drawing.Point(pxloc + 40, pyloc + 180);
                l.Text = dts.Rows[i]["rno"].ToString();
                l.Cursor = Cursors.Hand;
                l.Click += new System.EventHandler(this.l_Click);

                pxloc += 250;


                if (p.Location.X > 500)
                {
                    pyloc += 250;
                    pxloc = 50;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            string a = "select * from rooms where status='Available' and rtype='" + comboBox1.Text + "' and catagory='" + Class1.s_cat + "' ";
            SqlDataAdapter das = new SqlDataAdapter(a, Class1.cn);
            DataTable dt = new DataTable();
            das.Fill(dt);
            totcat = dt.Rows.Count;
            for (int i = 0; i < totcat; i++)
            {
                PictureBox p = new PictureBox();
                panel2.Controls.Add(p);
                p.Name = "P_Item" + i.ToString();
                p.Size = new Size(200, 150);
                p.Location = new System.Drawing.Point(lxloc, lyloc);
                string i_path = Path.Combine(dt.Rows[i]["image"].ToString());
                p.Image = Image.FromFile(i_path);
                p.SizeMode = PictureBoxSizeMode.Zoom;


                Label l = new Label();
                panel2.Controls.Add(l);
                l.Name = dt.Rows[i]["rno"].ToString();
                l.Size = new Size(200, 50);
                l.Location = new System.Drawing.Point(lxloc + 40, lyloc + 180);
                l.Text = dt.Rows[i]["rno"].ToString();
                l.Cursor = Cursors.Hand;
                l.Click += new System.EventHandler(this.l_Click);

                lxloc += 250;


                if (p.Location.X > 500)
                {
                    lyloc += 250;
                    lxloc = 50;
                }
            }
            lxloc = 50;
            lyloc = 80;
        }
        public void l_Click(object sender, System.EventArgs e)
        {
            string nm = sender.ToString();
            string nnm = nm.Substring(34);

            homepage h = new homepage();
            Class1.openChildForm(new rooms(fn, main, nnm), main);

        }
    }
}
