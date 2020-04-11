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
    public partial class FrmPassword : Form
    {
        public static string uname = "";
        public static string ul = "";
        //int count = 0;
        //int found1 = 0;
        string scolour;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sris\InvDatabase.mdb");

        private void Blank()
        {
            txtFullName.Text = "";
            txtNewPW.Text = "";
            txtOldPW.Text = "";
            txtPHint.Text = "";
            txtUserName.Text = "";
            txtConPW.Text = "";
            PicImg.Image = null;
        }

        private void UserIDKW()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserID='" + txtUserID.Text.Trim() + "'", con);
                cmd1.Connection = con;
                rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                {
                    txtUserName.Text = rdr["UserName"].ToString();
                    txtFullName.Text = rdr["FullName"].ToString();
                    lblOPW.Text = rdr["Password1"].ToString();
                    txtPHint.Text = rdr["PWHint"].ToString();
                    if (PicImg.Image == null)
                    {

                    }
                    else
                    {
                        byte[] Photo = (byte[])(rdr["IImg"]);
                        MemoryStream ms = new MemoryStream(Photo);
                        PicImg.Image = Image.FromStream(ms);
                    }
                }
                txtOldPW.Focus();
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                return;
            }            
        }

        public FrmPassword()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            Blank();
            txtUserID.Text = "";
            txtUserID.Focus();
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtUserID.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Blank();
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserID='" + txtUserID.Text.Trim() + "'", con);
                        cmd1.Connection = con;
                        rdr = cmd1.ExecuteReader();
                        bool temp = false;
                        while (rdr.Read())
                        {
                            temp = true;
                            txtUserName.Text = rdr["UserName"].ToString();
                            txtFullName.Text = rdr["FullName"].ToString();
                            lblOPW.Text = rdr["Password1"].ToString();
                            txtPHint.Text = rdr["PWHint"].ToString();

                            byte[] Photo = (byte[])(rdr["IImg"]);
                            MemoryStream ms = new MemoryStream(Photo);
                            PicImg.Image = Image.FromStream(ms);
                        }
                        txtOldPW.Focus();
                        con.Close();
                        if (temp == false)
                        {
                            MessageBox.Show("Record Not Found! Please Enter the Correct User Name.", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUserID.Text = "";
                            txtUserID.Focus();
                        }                        
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Please Fill All Fields and Select Profile Picture!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPW.Focus();
                con.Close();
            }
        }

        private void txtConPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtConPW.Text == txtNewPW.Text)
                {
                    txtPHint.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the Same Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConPW.Focus();
                    txtConPW.Text = "";
                }
            }                
        }

        private void txtOldPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOldPW.Text == lblOPW.Text)
                {
                    groupBox1.Enabled = true;
                    panel5.Enabled = true;
                    panel2.Enabled = true;
                    txtNewPW.Text = txtOldPW.Text;
                    txtNewPW.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the Correct Old Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPW.Focus();
                    txtOldPW.Text = "";
                }
            }                
        }

        private void txtNewPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewPW.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtNewPW.Text.Length < 5)
                    {
                        MessageBox.Show("You should enter more than 4 characters!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtNewPW.Text==txtOldPW.Text)
                        {
                            txtConPW.Text = txtNewPW.Text;
                        }
                        else
                        {
                            txtConPW.Text = "";
                        }
                        txtConPW.Focus();
                    }                    
                }
            }
        }

        private void txtPHint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPHint.Text =="")
                {
                    MessageBox.Show("Please Enter the Word or Remember this Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }

        private void cmdColor_Click(object sender, EventArgs e)
        {

        }

        private void cmdFont_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                PicImg.Image = Image.FromFile(fd.FileName);
            }
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            txtUserID.Text = lblID.Text;
            UserIDKW();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmdSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtConPW.Text == "")
                {
                    MessageBox.Show("Please Enter the Valied Password! and Enter the same new password in comfirm password box!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPW.Focus();
                    txtNewPW.Text = "";
                    txtConPW.Text = "";
                    return;
                }
                if (txtOldPW.Text == lblOPW.Text && txtConPW.Text == txtNewPW.Text)
                {
                    OleDbCommand cmd = new OleDbCommand("Update UserDetails SET Password1='" + txtNewPW.Text + "', PWHint='" + txtPHint.Text
                    + "' WHERE UserID='" + txtUserID.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CmdExit.Focus();

                }
                else if (txtOldPW.Text != lblOPW.Text && txtConPW.Text != txtNewPW.Text)
                {
                    MessageBox.Show("Please Try Again! Please Enter the Correct Old Password! and Enter the same new password in comfirm password box!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPW.Focus();
                    txtNewPW.Text = "";
                    txtConPW.Text = "";
                    txtOldPW.Text = "";
                }
                else if (txtOldPW.Text != lblOPW.Text)
                {
                    MessageBox.Show("Please Enter the Correct Old Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPW.Focus();
                    txtNewPW.Text = "";
                    txtOldPW.Text = "";
                }
                else if (txtConPW.Text != txtNewPW.Text)
                {
                    MessageBox.Show("Please Enter the Same Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConPW.Focus();
                    txtConPW.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-309-PSW" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                PicImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);
                OleDbCommand cmd = new OleDbCommand("Update UserDetails SET BGColor='" + txtCol.Text
                + "', IImg=@photo WHERE UserID='" + txtUserID.Text + "'", con);
                cmd.Parameters.AddWithValue("@photo", Photo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmdExit.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("  Error No:PWCS01 Please Select Valied Profile Photo", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOldPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdColor_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            scolour = colorDialog1.Color.ToArgb().ToString();
            txtCol.Text = colorDialog1.Color.ToArgb().ToString();
        }

        private void CmdExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
