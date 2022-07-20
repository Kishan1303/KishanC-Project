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

namespace Hotel_Management
{
    public partial class bookinginfo : Form
    {
        public static Panel main;
        public static homepage fn;
        public static string a;
        public static int oram;

        public bookinginfo(homepage f, Panel p, string s)
        {
            InitializeComponent();
            main = p;
            fn = f;
            a = s;

        }
        private void clear()
        {
            tname.Text = "";
            tacno.Text = "";
            tta.Text = "0";
            tad.Text = "0";
            tage.Text = "";
            tr.Text = "";
            tgst.Text = "";
            tmo.Text = "";
            tcat.Text = "";
            trn.Text = "";
            ttp.Text = "";
            tdate.Text = "";
        }
        private void bookingpage_Load(object sender, EventArgs e)
        {
            tcat.Text = Class1.s_cat;
            trn.Text = a;
            string sel = "select amount from rooms where category='" + tcat.Text + "' and rno='" + trn.Text + "'";
            SqlDataAdapter das = new SqlDataAdapter(sel, Class1.cn);
            DataTable dt1 = new DataTable();
            das.Fill(dt1);
            tta.Text = dt1.Rows[0]["amount"].ToString();
            oram = Convert.ToInt32(tta.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ins = "Insert  Into bookinginfo ( C_name, C_num, C_age, C_TotalMember, C_AdharCardNumber, C_Paid,C_Remaining,gst, C_TotalBill, C_DateOfArrival, C_DateOfCheckOut,roomno, catagory) VALUES ('" + tname.Text + "','" + tmo.Text + "','" + tage.Text + "','" + ttp.Text + "','" + tacno.Text + "','" + tad.Text + "','" + tr.Text + "','" + tgst.Text + "','" + tta.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "','" + trn.Text + "','" + tcat.Text + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(ins, Class1.cn);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);


            string up = "update rooms set doa='" + dateTimePicker1.Value.ToShortDateString() + "' , doc='" + dateTimePicker2.Value.ToShortDateString() + "', status ='Unavailable' where rno='" + trn.Text + "' ";
            SqlDataAdapter dau = new SqlDataAdapter(up, Class1.cn);
            DataTable dataTable = new DataTable();
            dau.Fill(dataTable);
            clear();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Keys.Escape == keyData)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tdate_TextChanged(object sender, EventArgs e)
        {
            tgst.Text = "0";
            tta.Text = oram.ToString();

            try
            {
                int amt = Convert.ToInt32(tdate.Text);
                int rc = Convert.ToInt32(tta.Text);
                double charge = amt * rc;
                double gst = charge * 0.12;
                tgst.Text = gst.ToString();
                charge += gst;
                tta.Text = charge.ToString();
            }

            catch (Exception)
            {
                tta.Text = oram.ToString();
                tdate.Text = "";
                tgst.Text = "";
            }
        }

        private void tad_TextChanged(object sender, EventArgs e)
        {
            tr.Text = "0";
            int ad = Convert.ToInt32(tad.Text);
            int ta = Convert.ToInt32(tta.Text);
            int re = ta - ad;
            tr.Text = re.ToString();
        }

    }
}
