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
    public partial class FrmCus : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sris\InvDatabase.mdb");
        private void Blank()
        {
            comCType.Text = "";
            txtCName.Text = "";
            txtCAdd.Text="";
            txtVatNo.Text = "";
            txtSVatNo.Text = "";
            txtCPer.Text = "";
            txtCTel.Text = "";
            txtCMob.Text = "";
            txtCFax.Text = "";
            txtCEMail.Text = "";
            comPTem.Text = "";
            txtCmnt.Text = "";
            comHAbtUs.Text = "";
            txtFbkAbtUs.Text = "";
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            txtCCode.Text = dataGridView1.SelectedRows[0].Cells["CustomerCode"].Value.ToString();
            comCType.Text = dataGridView1.SelectedRows[0].Cells["CustomerType"].Value.ToString();
            txtCName.Text = dataGridView1.SelectedRows[0].Cells["CustomerName"].Value.ToString();
            txtCAdd.Text = dataGridView1.SelectedRows[0].Cells["customeraddress"].Value.ToString();
            txtVatNo.Text = dataGridView1.SelectedRows[0].Cells["VATNumber"].Value.ToString();
            txtSVatNo.Text = dataGridView1.SelectedRows[0].Cells["SVATNumber"].Value.ToString();
            txtCPer.Text = dataGridView1.SelectedRows[0].Cells["ContactPerson"].Value.ToString();
            txtCTel.Text = dataGridView1.SelectedRows[0].Cells["CustomerLandNo"].Value.ToString();
            txtCMob.Text = dataGridView1.SelectedRows[0].Cells["CustomerMobileNo"].Value.ToString();
            txtCFax.Text = dataGridView1.SelectedRows[0].Cells["CustomerFaxNo"].Value.ToString();
            txtCEMail.Text = dataGridView1.SelectedRows[0].Cells["customeremail"].Value.ToString();
            comPTem.Text = dataGridView1.SelectedRows[0].Cells["PaymentTerms"].Value.ToString();
            txtCmnt.Text = dataGridView1.SelectedRows[0].Cells["Comments"].Value.ToString();
            comHAbtUs.Text = dataGridView1.SelectedRows[0].Cells["IntroducedBy"].Value.ToString();
            txtFbkAbtUs.Text = dataGridView1.SelectedRows[0].Cells["FeedBack"].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 30;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Width = 120;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            //if (lblULevel1.Text == "USER")
            //{
            //    dataGridView1.Columns[24].Visible = false;
            //    dataGridView1.Columns[25].Visible = false;
            //    dataGridView1.Columns[26].Visible = false;
            //    dataGridView1.Columns[27].Visible = false;
            //}
            //else
            //{
            //    dataGridView1.Columns[4].Visible = false;
            //    dataGridView1.Columns[25].Width = 45;
            //    dataGridView1.Columns[26].Width = 35;
            //    dataGridView1.Columns[27].Width = 45;
            //    dataGridView1.Columns[28].Width = 25;
            //}
        }
        public FrmCus()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into customer(CustomerCode, CustomerType, CustomerName, customeraddress, VATNumber, SVATNumber, ContactPerson, CustomerLandNo, CustomerMobileNo, CustomerFaxNo, customeremail, PaymentTerms, Comments, IntroducedBy, FeedBack) values('"
                    + txtCCode.Text + "', '" + comCType.Text + "', '" + txtCName.Text + "', '" + txtCAdd.Text + "', '" 
                    + txtVatNo.Text + "', '" + txtSVatNo.Text + "', '" + txtCPer.Text + "', '" + txtCTel.Text + "', '" 
                    + txtCMob.Text + "', '" + txtCFax.Text + "', '" + txtCEMail.Text + "', '" + comPTem.Text + "', '" 
                    + txtCmnt.Text + "', '" + comHAbtUs.Text + "', '" + txtFbkAbtUs.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCCode.Text = "";
                Blank();
                txtCCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-115-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update customer SET CustomerCode='" + txtCCode.Text.ToString() 
                    + "', CustomerType='" + comCType.Text 
                    + "', CustomerName='" + txtCName.Text 
                    + "', customeraddress='" + txtCAdd.Text
                    + "', VATNumber='" + txtVatNo.Text 
                    + "', SVATNumber='" + txtSVatNo.Text 
                    + "', ContactPerson='" + txtCPer.Text 
                    + "', CustomerLandNo='" + txtCTel.Text 
                    + "', CustomerMobileNo='" + txtCMob.Text
                    + "', CustomerFaxNo='" + txtCFax.Text 
                    + "', customeremail='" + txtCEMail.Text 
                    + "', PaymentTerms='" + comPTem.Text 
                    + "', Comments='" + txtCmnt.Text
                    + "', IntroducedBy='" + comHAbtUs.Text
                    + "', FeedBack='" + txtFbkAbtUs.Text
                    + "' WHERE CustomerCode=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCCode.Text = "";
                Blank();
                txtCCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-149-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCus_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [customer] Where [CustomerCode]=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCCode.Text = "";
                    Blank();
                    txtCCode.Focus();
                }
                else
                {
                    txtCCode.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-183-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [customer] Where CustomerCode=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-199-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from customer where CustomerCode Like '%" + TxtSer.Text + "%' or CustomerType Like '%" + TxtSer.Text + "%' or CustomerName Like '%" + TxtSer.Text + "%' or customeraddress Like '%" + TxtSer.Text + "%' or ContactPerson Like '%" + TxtSer.Text + "%' or CustomerLandNo Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();                
                comCType.Items.Clear();                     //For Combo box List
                comHAbtUs.Items.Clear();
                comPTem.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comCType.Items.Add(dr["CustomerType"].ToString());
                    comHAbtUs.Items.Add(dr["IntroducedBy"].ToString());
                    comPTem.Items.Add(dr["PaymentTerms"].ToString());
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-232-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtCCode.Text == "")
                    {
                        MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        found1 = 0;
                        for (int i = 0; i < count; i++)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == txtCCode.Text)
                            {
                                string txt = "SELECT * FROM [customer] Where CustomerCode=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        comCType.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : CCOD-KDW-277-CUS" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comCType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comCType.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCName.Focus();
                }
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            uname = lblUser1.Text;
            ul = lblULevel1.Text;
            FrmCusRep FCusRep = new FrmCusRep();
            FCusRep.Show();
        }

        private void txtCCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
    }
}
