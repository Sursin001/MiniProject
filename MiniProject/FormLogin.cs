using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                guna2MessageDialog1.Show("Enter the UserName.");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                guna2MessageDialog1.Show("Enter the PassWord.");
            }
            else
            {
                try
                {
                    SqlConnection con = MainClass.con;
                    string qry = "SELECT COUNT(*) FROM Login WHERE username = @Username AND password = @Password";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@username", txtUser.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();

                    if (count > 0)
                    {
                        this.Hide();
                        FormMain frm = new FormMain();
                        frm.Show();
                    }
                    else
                    {
                        guna2MessageDialog1.Show("Invalid username or password");
                    }
                }
                catch (Exception ex)
                {
                    guna2MessageDialog1.Show("Error: " + ex.Message);
                }
            }

            //Let create database and user table

            /*if (MainClass.IsValidUser(txtUser.Text, txtPassword.Text) == true)
            {
                this.Hide();
                FormMain frm = new FormMain();
                frm.Show();
            }
            else
            {
                guna2MessageDialog1.Show("invalid username or password");
                return;
            }*/

        }
    }
}
