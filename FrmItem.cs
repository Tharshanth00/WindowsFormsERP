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
    public partial class FrmItem : Form
    {
        int count = 0;
        int found1 = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sris\InvDatabase.mdb");

        private void Blank()
        {
            txtDes.Text = "";
            comKW.Text = "";
            comGr.Text = "";
            txtSNum.Text = "";
            txtPNum.Text = "";
            txtCPC.Text = "";
            txtCPMn.Text = "";
            txtMPYs.Text = "";
            txtMPTs.Text = "";
            txtMPEI.Text = "";
            txtPPWt.Text = "";
            txtPPWidth.Text = "";
            txtPPThick.Text = "";
            comUOMes.Text = "";
            comGrade.Text = "";
            comModel.Text = "";
            comManu.Text = "";
            dtpDoMFR.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpDOE.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtMin.Text = "";
            txtMax.Text = "";
            txtROL.Text = "";
            picImg.Image = null;
            TxtSer.Text = "";
            TxtSer_TextChanged(null, null);
        }

        private void fromDGView()
        {          
            txtStNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDes.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comKW.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comGr.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtSNum.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtPNum.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtCPC.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtCPMn.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtMPYs.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtMPTs.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtMPEI.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txtPPWt.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            txtPPWidth.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            txtPPThick.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            comUOMes.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            comGrade.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            comModel.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
            comManu.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
            dtpDoMFR.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[19].Value);
            dtpDOE.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[20].Value);
            txtMin.Text = dataGridView1.SelectedRows[0].Cells[21].Value.ToString();
            txtMax.Text = dataGridView1.SelectedRows[0].Cells[22].Value.ToString();
            txtROL.Text = dataGridView1.SelectedRows[0].Cells[23].Value.ToString();
        }

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 40;
            dataGridView1.Columns[4].Width = 20;
            dataGridView1.Columns[5].Width = 20;
            dataGridView1.Columns[6].Width = 20;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Width = 37;
            dataGridView1.Columns[18].Width = 37;
            dataGridView1.Columns[19].Width = 41;
            dataGridView1.Columns[20].Width = 41;
            dataGridView1.Columns[21].Width = 20;
            dataGridView1.Columns[22].Width = 20;
            dataGridView1.Columns[23].Width = 20;
            dataGridView1.Columns[28].Width = 20;
            dataGridView1.Columns[29].Visible = false;
            if (lblULevel1.Text == "Administrator")
            {
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[22].Visible = false;
                dataGridView1.Columns[21].Visible = false;
                dataGridView1.Columns[20].Width = 35;
                dataGridView1.Columns[24].Width = 35;
                dataGridView1.Columns[25].Width = 45;
                dataGridView1.Columns[26].Width = 35;
                dataGridView1.Columns[27].Width = 45;
                dataGridView1.Columns[28].Width = 25;
            }
            else if (lblULevel1.Text == "USER")
            {
                dataGridView1.Columns[24].Visible = false;
                dataGridView1.Columns[25].Visible = false;
                dataGridView1.Columns[26].Visible = false;
                dataGridView1.Columns[27].Visible = false;
            }
        }

        public FrmItem()
        {
            InitializeComponent();
        }

        private void label26_Click(object sender, EventArgs e)
        {
        }

        private void CmdImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                picImg.Image = Image.FromFile(fd.FileName);
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                 picImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                 byte[] Photo = new byte[ms.Length];

                 ms.Position = 0;
                 ms.Read(Photo, 0, Photo.Length);

                OleDbCommand cmd = new OleDbCommand("Insert into Item(StNo, Des, Kw, Gr, SNum, PNum, CPC, CPMn, MPYs, MPTs, MPEI, PPWt, PPWidth, PPThick, UOMes, Grade, Model, Manu, DoMFR, DOE, Min1, Max1, ROL, AddUser, AddTime, EditUser, EditTime, IImg) values('"
                    + txtStNo.Text + "', '" + txtDes.Text + "', '" + comKW.Text + "', '" + comGr.Text + "', '" + txtSNum.Text + "', '" + txtPNum.Text + "', '" + txtCPC.Text + "', '" + txtCPMn.Text + "', '"
                    + txtMPYs.Text + "', '" + txtMPTs.Text + "', '" + txtMPEI.Text + "', '" + txtPPWt.Text + "', '" + txtPPWidth.Text + "', '" + txtPPThick.Text + "', '" + comUOMes.Text + "', '"
                    + comGrade.Text + "', '" + comModel.Text + "', '" + comManu.Text + "', '" + dtpDoMFR.Value.ToString() + "', '" + dtpDOE.Value.ToString() + "', '" + txtMin.Text.ToString() + "', '" + txtMax.Text.ToString() + "', '" + txtROL.Text.ToString() + "', '" + lblUser1.Text + "', '" + DateTime.Now.ToString("dd/MM/yyyy H:mm:ss") + "', '" + "Not Changed!" + "', '" + DateTime.Now.ToString() + "', @photo)", con);
                cmd.Parameters.AddWithValue("@photo", Photo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Sucessfully!", "MESSAGE BOX",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtStNo.Text = "";
                Blank();
                txtStNo.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-SAV-174-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                picImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];

                ms.Position = 0;
                ms.Read(Photo, 0, Photo.Length);

                OleDbCommand cmd = new OleDbCommand("Update Item SET StNo='" + txtStNo.Text + "', Des='" + txtDes.Text + "', Kw='" + comKW.Text 
                    + "', Gr='" + comGr.Text + "', SNum='" + txtSNum.Text + "', PNum='" + txtPNum.Text + "', CPC='" + txtCPC.Text + "', CPMn='" + txtCPMn.Text
                    + "', MPYs='" + txtMPYs.Text + "', MPTs='" + txtMPTs.Text + "', MPEI='" + txtMPEI.Text + "', PPWt='" + txtPPWt.Text + "', PPWidth='" + txtPPWidth.Text
                    + "', PPThick='" + txtPPThick.Text + "', UOMes='" + comUOMes.Text + "', Grade='" + comGrade.Text + "', Model='" + comModel.Text 
                    + "', Manu='" + comManu.Text + "', DoMFR='" + dtpDoMFR.Value.ToString() + "', DOE='" + dtpDOE.Value.ToString() + "', Min1='" + txtMin.Text.ToString() 
                    + "', Max1='" + txtMax.Text.ToString() + "', ROL='" + txtROL.Text.ToString() + "', EditUser='" + lblUser1.Text + "', EditTime='" + DateTime.Now.ToString("dd/MM/yyyy H:mm:ss") + "', IImg=@photo WHERE ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + " ", con);
                cmd.Parameters.AddWithValue("@photo", Photo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStNo.Text = "";
                Blank();
                txtStNo.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-UPD-207-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null,null);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you confirm to Delete this Record?", "MESSAGE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string txt = "DELETE FROM [Item] Where [id]=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                    OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Record Deleted Sucessfully!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStNo.Text = "";
                    Blank();
                    txtStNo.Focus();
                }
                else
                {
                    txtStNo.Focus();
                }                
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : CMD-DEL-241-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string txt = "SELECT * FROM [Item] Where id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                fromDGView();
                byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                MemoryStream ms = new MemoryStream(Photo);
                picImg.Image = Image.FromStream(ms);
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : DGV-CEL-CLI-260-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.CommandText = "select * from Item where StNo Like '%" + TxtSer.Text + "%' or Des Like '%" + TxtSer.Text + "%' or Kw Like '%" + TxtSer.Text + "%' or Gr Like '%" + TxtSer.Text + "%' or Model Like '%" + TxtSer.Text + "%' or Manu Like '%" + TxtSer.Text + "%'";
                //Multi search
                //cmd.CommandText = "select * from table1 where sname='" + textBox1.Text + "' and city='"+textBox2.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                DGViewSize();

                comKW.Items.Clear();
                comGr.Items.Clear();
                comGrade.Items.Clear();
                comManu.Items.Clear();
                comModel.Items.Clear();
                comUOMes.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comKW.Items.Add(dr["Kw"].ToString());
                    comGr.Items.Add(dr["Gr"].ToString());
                    comGrade.Items.Add(dr["Grade"].ToString());
                    comManu.Items.Add(dr["Manu"].ToString());
                    comModel.Items.Add(dr["Model"].ToString());
                    comUOMes.Items.Add(dr["UOMes"].ToString());
                }

                con.Close();
                if (count == 0)
                {
                   // MessageBox.Show("Record Not Found!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-307-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    
                    if (txtStNo.Text == "")
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
                            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == txtStNo.Text)
                            {                                
                                string txt = "SELECT * FROM [Item] Where id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " ";
                                OleDbDataAdapter da = new OleDbDataAdapter(txt, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds);
                                found1 = 1;
                                fromDGView();
                                byte[] Photo = (byte[])(ds.Tables[0].Rows[0]["IImg"]);
                                MemoryStream ms = new MemoryStream(Photo);
                                picImg.Image = Image.FromStream(ms);
                            }
                        }
                        txtDes.Focus();
                        if (found1 == 0)
                        {
                            Blank();
                         }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERROR CODE : SNO-KDW-351-ITM" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDes.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comKW.Focus();
                }
            }
        }

        private void comGr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comGr.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtSNum.Focus();
                }
            }
        }

        private void comKW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comKW.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comGr.Focus();
                }
            }
        }

        private void txtSNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSNum.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPNum.Focus();
                }
            }
        }

        private void txtPNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPNum.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCPC.Focus();
                }
            }
        }

        private void txtCPC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCPC.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtCPMn.Focus();
                }
            }
        }

        private void txtCPMn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCPMn.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMPYs.Focus();
                }
            }
        }

        private void txtMPYs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMPYs.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMPTs.Focus();
                }
            }
        }

        private void txtMPTs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMPTs.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMPEI.Focus();
                }
            }
        }

        private void txtMPEI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMPEI.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPPWt.Focus();
                }
            }
        }

        private void txtPPWt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPPWt.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPPWidth.Focus();
                }
            }
        }

        private void txtPPWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPPWidth.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtPPThick.Focus();
                }
            }
        }

        private void txtPPThick_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPPThick.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comUOMes.Focus();
                }
            }
        }

        private void comUOMes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comUOMes.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comGrade.Focus();
                }
            }
        }

        private void comGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comGrade.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdImg.Focus();
                }
            }
        }

        private void comModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comModel.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comManu.Focus();
                }
            }
        }

        private void comManu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comManu.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtpDoMFR.Focus();
                }
            }
        }

        private void dtpDoMFR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDOE.Focus();
            }
        }

        private void dtpDOE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMin.Focus();
            }
        }

        private void txtMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMin.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtMax.Focus();
                }
            }
        }

        private void txtMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMax.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtROL.Focus();
                }
            }
        }

        private void txtROL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtROL.Text == "")
                {
                    MessageBox.Show("Please Enter the Data!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CmdSave.Focus();
                }
            }
        }

        private void comKW_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCPC_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdReport_Click(object sender, EventArgs e)
        {
            uname = lblUser1.Text;
            ul = lblULevel1.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Show();
        }
        public static string uname = "";
        public static string ul = "";

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            this.Refresh();
            dtpDOE.Refresh();
            dtpDoMFR.Refresh();
            comGr.Refresh();
            comKW.Refresh();
            comManu.Refresh();
            comModel.Refresh();
            txtDes.Refresh();
            TxtSer.Refresh();
            txtStNo.Refresh();
            dataGridView1.Refresh();
            txtStNo.Text = "";
            Blank();
            txtStNo.Focus();
            this.Refresh();
            Refresh();
        }

        private void CmdImgSer_Click(object sender, EventArgs e)
        {
            FrmStkImg FStkImg = new FrmStkImg();
            FStkImg.Show();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            txtStNo.Text = "";
            Blank();
            txtStNo.Focus();
        }

        private void txtStNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtROL_TextChanged(object sender, EventArgs e)
        {

        }

        private void comGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDoMFR_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CmdImg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comModel.Focus();
            }                
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
