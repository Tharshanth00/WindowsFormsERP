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
    public partial class FrmUReg : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        int kk = 0;
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sris\InvDatabase.mdb");
        private void Blank()
        {
            txtAge.Text = "";
            txtCPassword.Text = "";
            txtFullName.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            comDes.Text = "";
            comGender.Text = "";
            comPlace.Text = "";
            comUserLevel.Text = "";
         //   PicImg.Image = null;
            grpPD.Visible = false;
            lnklblUD.Visible = false;
            lnklblPD.Visible = true;
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            txtUserID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPassword.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtCPassword.Text = txtPassword.Text;
            comUserLevel.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtFullName.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comPlace.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comDes.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comGender.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtAge.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].HeaderText = " ID";
            dataGridView1.Columns[2].HeaderText = " Name";
            dataGridView1.Columns[4].HeaderText = " U.Level";
            dataGridView1.Columns[6].HeaderText = " Place";
            dataGridView1.Columns[7].HeaderText = " Designation";
            dataGridView1.Columns[8].HeaderText = " Gender";
            dataGridView1.Columns[9].HeaderText = " Age";
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Width = 108;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 70;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Width = 30;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;
            dataGridView1.Columns[26].Visible = false;
            dataGridView1.Columns[27].Visible = false;
            dataGridView1.Columns[28].Visible = false;
            dataGridView1.Columns[29].Visible = false;
            dataGridView1.Columns[30].Visible = false;
            dataGridView1.Columns[31].Visible = false;
            dataGridView1.Columns[32].Visible = false;
            dataGridView1.Columns[33].Visible = false;
            dataGridView1.Columns[34].Visible = false;
        }

        private void ComList()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from UserLevel where UserLevel Like '%" + TxtSer.Text + "%' or Index Like '%" + TxtSer.Text + "%'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.Fill(dt1);
                comUserLevel.Items.Clear();
                foreach (DataRow dr in dt1.Rows)
                {
                    comUserLevel.Items.Add(dr["UserLevel"].ToString());
                }
                con.Close();
                if (comUserLevel.Items.Count<1)
                {
                    comUserLevel.Items.Add("Administrator");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : COM-LST-125-USR-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmUReg()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lnklblPD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpPD.Visible = true;
            lnklblUD.Visible = true;
            lnklblPD.Visible = false;
        }

        private void lnklblUD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grpPD.Visible = false;
            lnklblUD.Visible = false;
            lnklblPD.Visible = true;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPassword.Focus();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtPassword.Text.Length < 5)
                    {
                        MessageBox.Show("You should enter more than 4 characters!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtCPassword.Focus();
                    }                        
                }
            }
        }

        private void txtCPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCPassword.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtCPassword.Text == txtPassword.Text)
                    {
                        comUserLevel.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Same Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Focus();
                        txtCPassword.Text = "";
                    }
                }
            }
        }

        private void comUserLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comUserLevel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand("select * from UserLevel where UserLevel='" + comUserLevel.Text.Trim() + "'", con);
                    cmd1.Connection = con;
                    rdr = cmd1.ExecuteReader();
                    bool temp = false;
                    while (rdr.Read())
                    {
                        temp = true;
                    }
                    grpPD.Visible = true;
                    lnklblUD.Visible = true;
                    lnklblPD.Visible = false;
                    txtFullName.Focus();
                    if (temp == false)
                    {
                        MessageBox.Show("Record Not Found! Please Select from List or Adding User Level after Select!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        grpPD.Visible = false;
                        lnklblUD.Visible = false;
                        lnklblPD.Visible = true;
                        comUserLevel.Text = "";
                        comUserLevel.Focus();
                    }
                    con.Close();                    
                }
            }
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFullName.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comPlace.Focus();
                }
            }
        }

        private void comPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comPlace.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comDes.Focus();
                }
            }
        }

        private void comDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comDes.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comGender.Focus();
                }
            }
        }

        private void comGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comGender.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comGender.Text == "Male" || comGender.Text == "Female" || comGender.Text == "Custom")
                    {
                        txtAge.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please Select from List Male or Female!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comGender.Text = "";
                    }
                }
            }
        }

        private void cmdBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                PicImg.Image = Image.FromFile(fd.FileName);
            }
        }

        private void FrmUReg_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
            ComList();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                //MemoryStream ms = new MemoryStream();
                //PicImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] Photo = new byte[ms.Length];
                //ms.Position = 0;
                //ms.Read(Photo, 0, Photo.Length);

                if (txtCPassword.Text == txtPassword.Text)
                {
                    OleDbCommand cmd = new OleDbCommand("Insert into UserDetails(UserID, UserName, Password1, UserLevel, FullName, Place, Designation, Gender, Age, BGColor, NSystem, NNewUser, NUserLogin, NUserControl, NExit, NInvoice, NPurchase, NJobOrder, NPayments, NCheque, NBank, NAccounts, NStockItem, NCustomer, NVendor, NInventoryItems, NFixedAssets, NMiscellaneous, NReports) values('"
                    //        OleDbCommand cmd = new OleDbCommand("Insert into UserDetails(UserID, UserName, Password1, UserLevel, FullName, Place, Designation, Gender, Age, BGColor) values('"
                    + txtUserID.Text
                    + "', '" + txtUserName.Text
                    + "', '" + txtPassword.Text
                    + "', '" + comUserLevel.Text
                    + "', '" + txtFullName.Text
                    + "', '" + comPlace.Text
                    + "', '" + comDes.Text
                    + "', '" + comGender.Text
                    + "', '" + txtAge.Text.ToString()
                    //+ "', @photo, '" 
                    + "', '" + "-16776961"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "True"
                    + "', '" + "False"
                    + "', '" + "True"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "', '" + "False"
                    + "')", con);
                    //cmd.Parameters.AddWithValue("@photo", Photo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserID.Text = "";
                    Blank();
                    txtUserID.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the Same Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    txtCPassword.Text = "";
                }
            }
            catch (Exception x)
            {
                 MessageBox.Show(x + "  Error No:URS01 Please Select a Profile Picture!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //MemoryStream ms = new MemoryStream();
                //PicImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] Photo = new byte[ms.Length];
                //ms.Position = 0;
                //ms.Read(Photo, 0, Photo.Length);

                if (txtCPassword.Text == txtPassword.Text)
                {
                    if (kk==1)
                    {
                        OleDbCommand cmd = new OleDbCommand("Update UserDetails SET UserID='" + txtUserID.Text + "', UserName='" + txtUserName.Text + "', Password1='" + txtPassword.Text + "', UserLevel='" + comUserLevel.Text + "', FullName='" + txtFullName.Text + "', Place='" + comPlace.Text + "', Designation='" + comDes.Text + "', Gender='" + comGender.Text + "', Age='" + txtAge.Text
                        + "' WHERE UserID='" + txtUserID.Text + "'", con);
                        //+"', IImg=@photo WHERE UserID='" + txtUserID.Text + "'", con);
                        //cmd.Parameters.AddWithValue("@photo", Photo);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        OleDbCommand cmd = new OleDbCommand("Update UserDetails SET UserID='" + txtUserID.Text + "', UserName='" + txtUserName.Text + "', Password1='" + txtPassword.Text + "', UserLevel='" + comUserLevel.Text + "', FullName='" + txtFullName.Text + "', Place='" + comPlace.Text + "', Designation='" + comDes.Text + "', Gender='" + comGender.Text + "', Age='" + txtAge.Text
                         + "' WHERE Index=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                        //cmd.Parameters.AddWithValue("@photo", Photo);

                        //OleDbCommand cmd = new OleDbCommand("Update UserDetails SET UserID='" + txtUserID.Text + "', UserName='" + txtUserName.Text + "', Password1='" + txtPassword.Text + "', UserLevel='" + comUserLevel.Text + "', FullName='" + txtFullName.Text + "', Place='" + comPlace.Text + "', Designation='" + comDes.Text + "', Gender='" + comGender.Text + "', Age='" + txtAge.Text
                        // + "', IImg=@photo WHERE Index=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                        //cmd.Parameters.AddWithValue("@photo", Photo);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    
                    MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserID.Text = "";
                    Blank();
                    txtUserID.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the Same Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    txtCPassword.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-462-USR-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [UserDetails] Where [UserID]='" + txtUserID.Text + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserID.Text = "";
                    Blank();
                    txtUserID.Focus();
                }
                else
                {
                    txtUserID.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-489-USR-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kk = 2;
                string txt = "SELECT * FROM [UserDetails] Where Index=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                //byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                //MemoryStream ms = new MemoryStream(Photo);
                //PicImg.Image = Image.FromStream(ms);
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-509-USR-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "select * from UserDetails where UserID Like '%" + TxtSer.Text + "%' or UserName Like '%" + TxtSer.Text + "%' or UserLevel Like '%" + TxtSer.Text + "%' or Place Like '%" + TxtSer.Text + "%' or Designation Like '%" + TxtSer.Text + "%'";
                cmd6.ExecuteNonQuery();
                DataTable dt6 = new DataTable();
                OleDbDataAdapter da6 = new OleDbDataAdapter(cmd6);
                da6.Fill(dt6);
                count = Convert.ToInt32(dt6.Rows.Count.ToString());
                dataGridView1.DataSource = dt6;
                DGViewSize();
                DGViewSize();
                comDes.Items.Clear();
                comPlace.Items.Clear();
                //comUserLevel.Items.Clear();
                foreach (DataRow dr6 in dt6.Rows)
                {
                    comDes.Items.Add(dr6["Designation"].ToString());
                    comPlace.Items.Add(dr6["Place"].ToString());
                    //comUserLevel.Items.Add(dr6["UserLevel"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
              //  MessageBox.Show(x + "  Error No:URser01 Please Inform this error number to Development Team!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtUserID.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        kk = 1;
                        found1 = 0;
                        for (int i = 0; i < count; i++)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == txtUserID.Text)
                            {
                                string txt = "SELECT * FROM [UserDetails] Where UserID='" + txtUserID.Text.ToString() + "'";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                                //byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                                //MemoryStream ms = new MemoryStream(Photo);
                                //PicImg.Image = Image.FromStream(ms);
                            }
                        }
                        txtUserName.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : UID-KDW-587-USR-REG" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAge.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void comGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)8 || e.KeyChar == (char)13)
            //{

            //}
            //else
            //{
            //    if (comGender.Text != "Male" || comGender.Text != "Female")
            //    {
            //        MessageBox.Show("Please Select Male or Female!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        comGender.Text = "";
            //    }
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUControl FUControl = new FrmUControl();
            FUControl.Show();
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            FrmUsersRep FUsersRep = new FrmUsersRep();
            FUsersRep.Show();
        }
    }
}
