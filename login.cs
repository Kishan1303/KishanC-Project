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

namespace Hotel_Management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static String accountno;
        public int pass1 = 0;
        private void butlogin_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" || textBox2.Text != "")
            {
                if (textBox1.Text != "")
                {
                    if (pass1 < 3)
                    {
                        if (textBox2.Text != "")
                        {
                            if (textBox1.Text == "Kishan" && textBox2.Text == "kishan123")
                            {
                                    homepage hp = new homepage();
                                    hp.Show();
                                    this.Hide();

                             
                            }
                            else
                           {
                                string s = "Select * from login where name = '" + textBox1.Text + "' and password ='" + textBox2.Text + "' ";
                                SqlDataAdapter adapter = new SqlDataAdapter(s, Class1.cn);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                if (dt.Rows.Count == 1)
                                {

                                    homepage hp = new homepage();
                                    hp.Show();
                                    this.Hide();

                                    
                                }
                                else
                                {
                                    MessageBox.Show("User not found !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    pass1++;

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Password !","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        timer1.Start();
                        butlogin.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Enter User Name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Detail !", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Keys.Escape == keyData)
            {
                Application.Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            butlogin.Enabled = true;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
