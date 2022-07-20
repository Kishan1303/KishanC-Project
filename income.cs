using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hotel_Management
{
    public partial class income : Form
    {
        public income()
        {
            InitializeComponent();
        }
        int a = 0;
        Bitmap bitmap;

        private void button2_Click(object sender, EventArgs e)
        {

            int height = staffdgv.Height;
            staffdgv.Height = staffdgv.RowCount * staffdgv.RowTemplate.Height + 100;
            bitmap = new Bitmap(staffdgv.Width, staffdgv.Height);
            staffdgv.DrawToBitmap(bitmap, new Rectangle(0, 0, staffdgv.Width, staffdgv.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printDocument1.PrinterSettings.Copies = 1;
            printPreviewDialog1.ShowDialog();
            staffdgv.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hotel Name", new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold), Brushes.Black, 375, 10);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 0, 40);
            e.Graphics.DrawImage(bitmap, 250, 60);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 0, 60 + staffdgv.Height + 70);
            //e.Graphics.DrawImage(bitmap, 0, 60);
            e.Graphics.DrawString("Total Income  : " + a, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold), Brushes.Black, 375, 60 + staffdgv.Height + 40);
        }

        private void income_Load(object sender, EventArgs e)
        {
            string sel = "select * from income ";
            SqlDataAdapter das = new SqlDataAdapter(sel, Class1.cn);
            DataTable dts = new DataTable();
            das.Fill(dts);
            staffdgv.DataSource = dts;
            foreach (DataGridViewRow r in staffdgv.Rows)
            {
                a += Convert.ToInt32(r.Cells["amount"].Value.ToString());
            }
        }
    }
}
