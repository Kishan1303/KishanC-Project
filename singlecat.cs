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
    public partial class singlecat : Form
    {
        public static Panel main;
        public static homepage fn;
        int totcat;
        public static string a;
        int pxloc = 50, pyloc = 80, lxloc = 100, lyloc = 240;
        public singlecat(homepage f, Panel p, string s)
        {
            InitializeComponent();
            main = p;
            fn = f;
            a = s;

        }

        private void singlecat_Load(object sender, EventArgs e)
        {
            string sel = "Select * from catagory ";
            SqlDataAdapter adapter = new SqlDataAdapter(sel, Class1.cn);
            DataTable dts = new DataTable();
            adapter.Fill(dts);
            totcat = dts.Rows.Count;
            for (int i = 0; i < totcat; i++)
            {
                PictureBox p = new PictureBox();
                this.Controls.Add(p);
                p.Name = "P_Item" + i.ToString();
                p.Size = new Size(200, 150);
                p.Location = new System.Drawing.Point(pxloc, pyloc);
                string i_path = Path.Combine(dts.Rows[i]["catimage"].ToString());
                p.Image = Image.FromFile(i_path);
                p.SizeMode = PictureBoxSizeMode.Zoom;


                Label l = new Label();
                this.Controls.Add(l);
                l.Name = dts.Rows[i]["catname"].ToString();
                l.Size = new Size(200, 50);
                l.Location = new System.Drawing.Point(pxloc + 40, pyloc + 180);
                l.Text = dts.Rows[i]["catname"].ToString();
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
        public void l_Click(object sender, System.EventArgs e)
        {
            string nm = sender.ToString();
            string nnm = nm.Substring(34);
            Class1.s_cat = nnm;

            homepage h = new homepage();
            Class1.openChildForm(new rooms(fn, main, nnm), main);

        }
    }
}
