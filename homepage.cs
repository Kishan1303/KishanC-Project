using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class homepage : Form
    {
        public static Panel main;
        public static homepage fn;
        public static string a;
        public homepage()
        {
            InitializeComponent();
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // DC.openChildForm(new FormName(arguments),main)
            Class1.openChildForm(new singlecat(this,p_fm,"0"),p_fm);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Keys.Escape == keyData)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void l_Click(object sender, System.EventArgs e)
        {
            string nm = sender.ToString();
            string nnm = nm.Substring(34);
            Class1.s_cat = nnm;


        }
    }
}
