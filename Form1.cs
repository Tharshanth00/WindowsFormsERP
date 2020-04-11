using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsERP
{
    public partial class FrmLogin : Form
    {
        int count = 0;
        int found1 = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sris\InvDatabase.mdb");


        private void PasswordHint()
        {
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserID='" + TxtUser.Text.Trim() + "' ", con);
            cmd1.Connection = con;
            rdr = cmd1.ExecuteReader();
            
           // bool temp = false;
            while (rdr.Read())
            {
                lblPH.Text = rdr["PWHint"].ToString();
           //     temp = true;
            }
            con.Close();
            //if (temp == false)
            //{
            //    MessageBox.Show("Please Enter the correct User ID!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtUser.Text = "";
            //    TxtUser.Focus();
            //    return;
            //}
        }

        public FrmLogin()
        {
            InitializeComponent();            
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtUser.Text == "")
                {
                    MessageBox.Show("Please Enter the User ID!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PasswordHint();
                    TxtPW.Focus();   
                }
            }
        }

        private void TxtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtPW.Text == "")
                {
                    MessageBox.Show("Please Enter the Valied Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (TxtPW.Text.Substring(2, 2) == DateTime.Now.ToString("mm"))
                        {
                            linkLabel2.Enabled = true;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("  Error No:Lgnpkwn01 Please rename password in more than 4 digits!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CmdLogin.Focus();
                }
            }            
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {          
            if(TxtUser.Text != "" && TxtPW.Text != "")
            {
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserID='" + TxtUser.Text.Trim() + "' ", con);
                cmd1.Connection = con;
                rdr = cmd1.ExecuteReader();
                bool temp = false;
                while (rdr.Read())
                {
                    lblPW.Text = rdr["Password1"].ToString();
                    lblUser.Text = rdr["UserName"].ToString();
                    lblULevel.Text = rdr["UserLevel"].ToString();
                    lblPWHint.Text = rdr["PWHint"].ToString();
                    lblColor.Text = rdr["BGColor"].ToString();
                    temp = true;
                }
                con.Close();
                if (temp == false)
                {
                    MessageBox.Show("Please Enter the correct User ID, or Sign Up your details!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUser.Text = "";
                    TxtPW.Text = "";
                    TxtUser.Focus();
                    return;
                }
                else
                {
                    if (TxtPW.Text == lblPW.Text)
                    {
                        FrmLoad FLoad = new FrmLoad();

                        Control[] ctrlsID = FLoad.Controls.Find("lblUser", false);
                        Label lbl1 = (Label)ctrlsID[0];
                        lbl1.Text = lblUser.Text;

                        Control[] ctrlsUL = FLoad.Controls.Find("lblULevel", false);
                        Label lbl2 = (Label)ctrlsUL[0];
                        lbl2.Text = lblULevel.Text;

                        Control[] ctrlsIDD = FLoad.Controls.Find("lblID", false);
                        Label lbl3 = (Label)ctrlsIDD[0];
                        lbl3.Text = TxtUser.Text;

                        Control[] ctrlsPW = FLoad.Controls.Find("lblPW", false);
                        Label lbl4 = (Label)ctrlsPW[0];
                        lbl4.Text = TxtPW.Text;

                        Control[] ctrlsPWh = FLoad.Controls.Find("lblPWHint", false);
                        Label lbl5 = (Label)ctrlsPWh[0];
                        lbl5.Text = lblPWHint.Text;

                        Control[] ctrlsClr = FLoad.Controls.Find("lblColor", false);
                        Label lbl6 = (Label)ctrlsClr[0];
                        lbl6.Text = lblColor.Text;

                        this.Visible = false;
                        FLoad.Show();                        
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Valied Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtPW.Text = "";
                        TxtPW.Focus();
                        return;
                    }
                }      
            }
            else
            {
                MessageBox.Show("Please Enter the Valied User ID and Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUser.Text = "";
                TxtPW.Text = "";
                TxtUser.Focus();
                return;
            }
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            TxtUser.Text = "";
            TxtUser.BackColor = Color.White;
            TxtUser.ForeColor = Color.Black;
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if(TxtUser.Text=="")
            {
                TxtUser.Text = "User ID";
                TxtUser.BackColor = Color.MintCream;
                TxtUser.ForeColor = Color.Gray;
            }
        }

        private void TxtPW_Enter(object sender, EventArgs e)
        {
            TxtPW.Text = "";
            TxtPW.UseSystemPasswordChar = true;
            TxtPW.BackColor = Color.White;
            TxtPW.ForeColor = Color.Black;
        }

        private void TxtPW_Leave(object sender, EventArgs e)
        {
            if (TxtPW.Text == "")
            {
                TxtPW.Text = "Password";
                TxtPW.UseSystemPasswordChar = false;
                TxtPW.BackColor = Color.MintCream;
                TxtPW.ForeColor = Color.Gray;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtPW.Text = "Password";
            TxtPW.UseSystemPasswordChar = false;
            TxtPW.BackColor = Color.MintCream;
            TxtPW.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUReg FUReg = new FrmUReg();
            FUReg.Show();
        }

        private void CmdLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                linkLabel2.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(TxtUser.Text=="" || TxtUser.Text == "User ID")
            {
                MessageBox.Show("Enter your User ID then Press Enter Key!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUser.Focus();
            }
            else
            {
                PasswordHint();
            }
            panelHint.Visible = true;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelHint.Visible = false;
            lblPH.Text = "Password Hint";
            TxtPW.Text = "";
            TxtPW.Focus();
        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
