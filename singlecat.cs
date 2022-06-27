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
    public partial class singlecat : Form
    {
        public static Panel main;
        public static homepage fn;
        public static string a;
        public singlecat(homepage f, Panel p, string s)
        {
            InitializeComponent();
            main = p;
            fn = f;
            a = s;

        }

        private void singlecat_Load(object sender, EventArgs e)
        {

        }
        public void l_Click(object sender, System.EventArgs e)
        {
            string nm = sender.ToString();
            string nnm = nm.Substring(34);
            Class1.s_cat = nnm;

           

        }
    }
}
