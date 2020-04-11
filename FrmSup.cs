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
    public partial class FrmSup : Form
    {
        public static string uname = "";
        public static string ul = "";
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sris\InvDatabase.mdb");

        private void Blank()
        {
            txtSAdd.Text = "";
            txtCmnt.Text = "";
            txtCPer.Text = "";
            txtSEMail.Text = "";
            txtSFax.Text = "";
            txtSMob.Text = "";
           // txtSCode.Text = "";
            txtSupN.Text = "";
            txtSTel.Text = "";
            comPTem.Text = "";
            comSType.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {
            txtSCode.Text = dataGridView1.SelectedRows[0].Cells["SupplierCode"].Value.ToString();
            comSType.Text = dataGridView1.SelectedRows[0].Cells["SupplierType"].Value.ToString();
            txtSupN.Text = dataGridView1.SelectedRows[0].Cells["SupplierName"].Value.ToString();
            txtSAdd.Text = dataGridView1.SelectedRows[0].Cells["SupplierAddress"].Value.ToString();
            txtCPer.Text = dataGridView1.SelectedRows[0].Cells["ContactPerson"].Value.ToString();
            txtSTel.Text = dataGridView1.SelectedRows[0].Cells["SupplierLandNo"].Value.ToString();
            txtSMob.Text = dataGridView1.SelectedRows[0].Cells["SupplierMobileNO"].Value.ToString();
            txtSFax.Text = dataGridView1.SelectedRows[0].Cells["SupplierFaxNo"].Value.ToString();
            txtSEMail.Text = dataGridView1.SelectedRows[0].Cells["SupplierEmail"].Value.ToString();
            comPTem.Text = dataGridView1.SelectedRows[0].Cells["PaymentTerms"].Value.ToString();
            txtCmnt.Text = dataGridView1.SelectedRows[0].Cells["Comments"].Value.ToString();
        }

        private void DGViewSize()
        {
           // dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Width = 30;
            //dataGridView1.Columns[2].Width = 70;
            //dataGridView1.Columns[3].Width = 40;
            //dataGridView1.Columns[4].Width = 20;
            //dataGridView1.Columns[5].Width = 20;
            //dataGridView1.Columns[6].Width = 20;
            //dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns[11].Visible = false;
            //dataGridView1.Columns[12].Visible = false;
            //dataGridView1.Columns[13].Visible = false;
            //dataGridView1.Columns[14].Visible = false;
            //dataGridView1.Columns[15].Visible = false;
            //dataGridView1.Columns[16].Visible = false;
            //dataGridView1.Columns[17].Width = 37;
            //dataGridView1.Columns[18].Width = 37;
            //dataGridView1.Columns[19].Width = 41;
            //dataGridView1.Columns[20].Width = 41;
            //dataGridView1.Columns[21].Width = 20;
            //dataGridView1.Columns[22].Width = 20;
            //dataGridView1.Columns[23].Width = 20;
            //dataGridView1.Columns[28].Width = 20;
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
            //    dataGridView1.Columns[5].Visible = false;
            //    dataGridView1.Columns[6].Visible = false;
            //    dataGridView1.Columns[19].Visible = false;
            //    dataGridView1.Columns[22].Visible = false;
            //    dataGridView1.Columns[21].Visible = false;
            //    dataGridView1.Columns[20].Width = 35;
            //    dataGridView1.Columns[24].Width = 35;
            //    dataGridView1.Columns[25].Width = 45;
            //    dataGridView1.Columns[26].Width = 35;
            //    dataGridView1.Columns[27].Width = 45;
            //    dataGridView1.Columns[28].Width = 25;
            //}
        }

        public FrmSup()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Insert into Supplier (SupplierCode, SupplierType, SupplierName, SupplierAddress, ContactPerson, SupplierLandNo, SupplierMobileNO, SupplierFaxNo, SupplierEmail, PaymentTerms, Comments) values('"
                    + txtSCode.Text + "', '" 
                    + comSType.Text + "', '" 
                    + txtSupN.Text + "', '" 
                    + txtSAdd.Text + "', '" 
                    + txtCPer.Text + "', '" 
                    + txtSTel.Text + "', '" 
                    + txtSMob.Text + "', '" 
                    + txtSFax.Text + "', '"
                    + txtSEMail.Text + "', '"
                    + comPTem.Text + "', '" 
                    + txtCmnt.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSCode.Text = "";
                Blank();
                txtSCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-137-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("Update Supplier SET SupplierCode='" + txtSCode.Text 
                    + "', SupplierType='" + comSType.Text 
                    + "', SupplierName='" + txtSupN.Text
                    + "', SupplierAddress='" + txtSAdd.Text 
                    + "', ContactPerson='" + txtCPer.Text 
                    + "', SupplierLandNo='" + txtSTel.Text 
                    + "', SupplierMobileNO='" + txtSMob.Text 
                    + "', SupplierFaxNo='" + txtSFax.Text
                    + "', SupplierEmail='" + txtSEMail.Text 
                    + "', PaymentTerms='" + comPTem.Text 
                    + "', Comments='" + txtCmnt.Text 
                    + "' WHERE SupplierCode=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSCode.Text = "";
                Blank();
                txtSCode.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-167-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSup_Load(object sender, EventArgs e)
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
                    string txt = "DELETE FROM [Supplier] Where [SupplierCode]=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSCode.Text = "";
                Blank();
                txtSCode.Focus();
                }
                else
                {
                    txtSCode.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-206-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Supplier] Where SupplierCode=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-222-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = "select * from Supplier where SupplierCode Like '%" + TxtSer.Text + "%' or ContactPerson Like '%" + TxtSer.Text + "%' or SupplierName Like '%" + TxtSer.Text + "%' or SupplierAddress Like '%" + TxtSer.Text + "%' or SupplierType Like '%" + TxtSer.Text + "%' or SupplierLandNo Like '%" + TxtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();
                comPTem.Items.Clear();                     //For Combo box List
                comSType.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comPTem.Items.Add(dr["PaymentTerms"].ToString());
                    comSType.Items.Add(dr["SupplierType"].ToString());
                }
                con.Close();
                if (count == 0)
                {
                  //  MessageBox.Show("Record Not Found!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-257-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            FrmSupRep FSupRep = new FrmSupRep();
            FSupRep.Show();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtSCode.Text == "")
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
                            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == txtSCode.Text)
                            {
                                string txt = "SELECT * FROM [Supplier] Where SupplierCode=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                            }
                        }
                        comSType.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : SCOD-KDW-313-SUP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
    }
}
