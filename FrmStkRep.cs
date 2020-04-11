using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Data.OleDb;


namespace WindowsFormsERP
{
    public partial class FrmStkRep : Form
    {
        int count = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sris\InvDatabase.mdb");

        private void DGViewSize(String userLevel)
        {
            // dataGridView1.Font = new Font("Arial", 11);
            //  dataGridView1.Columns[29].DefaultCellStyle.Format = "D2";
            // HI Tharshanth, How are you??
            // OMG
            if (userLevel == "Administrator") {

                //SET ALIGNMENT RIGHT
                int[] columns = { 6, 7, 8, 9 };
                foreach (int column in columns)
                {
                    dataGridView1.Columns[column].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }


                //SET HEADERTEXT
                //dataGridView1.Columns[2].HeaderText = " Full Details";

                //SET WIDTH
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[2].Width = 358;
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].Width = 50;
                dataGridView1.Columns[7].Width = 50;
                dataGridView1.Columns[8].Width = 50;
                dataGridView1.Columns[9].Width = 70;

            } else {

                //SET ALIGNMENT RIGHT
                int[] columns = { 6, 7, 8, 9 };
                foreach (int column in columns)
                {
                    dataGridView1.Columns[column].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                //SET WIDTH
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[2].Width = 358;
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].Width = 50;
                dataGridView1.Columns[7].Width = 50;
                dataGridView1.Columns[8].Width = 50;
                dataGridView1.Columns[9].Width = 70;
     
                //SET HEADERTEXT
                //dataGridView1.Columns[4].HeaderText = " Other Details";

            }
        }


        private void MultiSearch()
        {
            //try
            //{
            //    con.Open();
            //    //"SELECT ID, StNo, Des, Kwl, Gr, SNum , PNum, CPC, CPMn, MPYs, MPTs, MPEI, PPWt,"
            //    //    + "PPWidth, PPThick, UOMes, Grade, Model, Manu, DoMFR, DOE, Min1, Max1, ROL, AddUser, AddTime, EditUser, EditTime, IImg, CashPrice"
            //    //    + "FROM Item WHERE"

            //    String admin_sql = "SELECT StNo, CONCAT(Des, Kwl, Gr, SNum , PNum, CPC, CPMn, MPYs, MPTs, MPEI, PPWt, PPWidth, PPThick, UOMes, Grade, Model, Manu) AS Full Details "
            //        + " DoMFR, DOE, Min1, Max1, ROL, AddUser, AddTime, EditUser, EditTime, IImg, CashPrice"
            //        + "FROM Item WHERE";

            //    OleDbCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = admin_sql + " StNo Like '%" + TxtSer.Text + "%' or Des Like '%" + TxtSer.Text + "%' or Kw Like '%" + TxtSer.Text + "%' or Gr Like '%" + TxtSer.Text + "%' or Model Like '%" + TxtSer.Text + "%' or Manu Like '%" + TxtSer.Text + "%'";
            //    //Multi search
            //    if (chkDes.Checked && chkKw.Checked && chkManu.Checked && chkMod.Checked)
            //    {
            //        cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Kw='" + txtKw.Text + "' and Model='" + txtMod.Text + "' and Manu='" + txtManu.Text + "'";
            //    }
            //    else
            //    {
            //        if (chkDes.Checked && chkKw.Checked && chkManu.Checked)
            //        {
            //            cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Kw='" + txtKw.Text + "' and Manu='" + txtManu.Text + "'";
            //        }
            //        else if (chkDes.Checked && chkKw.Checked && chkMod.Checked)
            //        {
            //            cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Kw='" + txtKw.Text + "' and Model='" + txtMod.Text + "'";
            //        }
            //        else if (chkDes.Checked && chkManu.Checked && chkMod.Checked)
            //        {
            //            cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Model='" + txtMod.Text + "' and Manu='" + txtManu.Text + "'";
            //        }
            //        else if (chkKw.Checked && chkManu.Checked && chkMod.Checked)
            //        {
            //            cmd.CommandText = "select * from Item where Kw='" + txtKw.Text + "' and Model='" + txtMod.Text + "' and Manu='" + txtManu.Text + "'";
            //        }
            //        else
            //        {
            //            if (chkDes.Checked && chkKw.Checked)
            //            {
            //                cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Kw='" + txtKw.Text + "'";
            //            }
            //            else if (chkDes.Checked && chkMod.Checked)
            //            {
            //                cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Model='" + txtMod.Text + "'";
            //            }
            //            else if (chkDes.Checked && chkManu.Checked)
            //            {
            //                cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "' and Manu='" + txtManu.Text + "'";
            //            }
            //            else if (chkKw.Checked && chkMod.Checked)
            //            {
            //                cmd.CommandText = "select * from Item where Kw='" + txtKw.Text + "' and Model='" + txtMod.Text + "'";
            //            }
            //            else if (chkKw.Checked && chkManu.Checked)
            //            {
            //                cmd.CommandText = "select * from Item where Kw='" + txtKw.Text + "' and Manu='" + txtManu.Text + "'";
            //            }
            //            else if (chkManu.Checked && chkMod.Checked)
            //            {
            //                cmd.CommandText = "select * from Item where Model='" + txtMod.Text + "' and Manu='" + txtManu.Text + "'";
            //            }
            //            else
            //            {
            //                if (chkDes.Checked)
            //                {
            //                    cmd.CommandText = "select * from Item where Des='" + txtDes.Text + "'";
            //                }
            //                else if (chkKw.Checked)
            //                {
            //                    cmd.CommandText = "select * from Item where Kw='" + txtKw.Text + "'";
            //                }
            //                else if (chkMod.Checked)
            //                {
            //                    cmd.CommandText = "select * from Item where Model='" + txtMod.Text + "'";
            //                }
            //                else if (chkManu.Checked)
            //                {
            //                    cmd.CommandText = "select * from Item where Manu='" + txtManu.Text + "'";
            //                }
            //            }
            //        }
            //    }
            //    //cmd.CommandText = "select * from Item where sname='" + textBox1.Text + "' and city='"+textBox2.Text+"'";
            //    cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    DGViewSize();
            //    con.Close();
            //}
            //catch (Exception x)
            //{
            //    MessageBox.Show("ERROR CODE : MLTY-SER-223-STK-REP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public void EPDFReport(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 1;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add Header            
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);//
                pdftable.AddCell(cell);
            }

            //Add Data Row            
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    Paragraph para = new Paragraph("Stock Report ");
                    Paragraph para0 = new Paragraph(DateTime.Now.ToString("dd.MM.yyyy"));
                    Paragraph para1 = new Paragraph(" ");
                    para.Alignment = Element.ALIGN_CENTER;
                    para0.Alignment = Element.ALIGN_CENTER;
                    pdfdoc.Add(para);
                    pdfdoc.Add(para0);
                    pdfdoc.Add(para1);
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        public FrmStkRep()
        {
            InitializeComponent();
        }

        private void FrmStkRep_Load(object sender, EventArgs e)
        {
            count = 0;
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            TxtSer_TextChanged(null, null);
        }

        private void TxtSer_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                String userLevel = lblULevel1.Text;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                

                if (userLevel == "Administrator") {

                    String admin_query = "SELECT StNo, Des AS Description, Des & ', ' & Kw & ', '&Gr& ', ' &SNum& ', ' &PNum& ', ' &CPC& ', ' &CPMn& ', ' &MPYs& ', ' &MPTs& ', ' &MPEI& ', ' &PPWt& ', ' &PPWidth& ', ' &PPThick& ', ' &UOMes& ', ' &Grade& ', ' &Model& ', ' &Manu AS Full_Details, Model, Manu , DOE AS Expire, Min1 AS Minn, Max1 AS Maxx, ROL, CashPrice AS Price FROM Item";
                    cmd.CommandText = admin_query;

                } else {

                    String guest_query = "SELECT StNo, Des AS Description, Gr & ', ' & SNum & ', ' & PNum & ', ' & CPC & ', ' & CPMn & ', ' & MPYs & ', ' & MPTs & ', ' & MPEI & ', ' & PPWt & ', ' & PPWidth & ', ' & PPThick & ', ' & UOMes & ', ' & Grade AS Other_Details, Model, Manu, DOE AS Expire, Min1 AS Minn, Max1 AS Maxx, ROL, CashPrice AS Price FROM Item";
                    cmd.CommandText = guest_query;
                }
                    
     
                cmd.ExecuteNonQuery();

                DataTable data = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(data);
                count = Convert.ToInt32(data.Rows.Count.ToString());
                dataGridView1.DataSource = data;
                DGViewSize(userLevel);
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR CODE : SER-CNG-316-STK-REP" + "\n" + "\n" + "[Please Note this Error Code and Take a Photo in this More Details." + "\n" + "\n" + "Inform the Error Code and Send this Error Details (Mail or WhatsUP) to Development Team (SRIS)!]" + "\n" + "\n" + "\n" + "MORE DETAILS :- " + "\n" + "\n" + x, "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkDes_CheckedChanged(object sender, EventArgs e)
        {
            txtDes.Text = "";
            txtDes.Focus();
        }

        private void chkKw_CheckedChanged(object sender, EventArgs e)
        {
            txtKw.Text = "";
            txtKw.Focus();
        }

        private void chkMod_CheckedChanged(object sender, EventArgs e)
        {
            txtMod.Text = "";
            txtMod.Focus();
        }

        private void chkManu_CheckedChanged(object sender, EventArgs e)
        {
            txtManu.Text = "";
            txtManu.Focus();
        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {
            MultiSearch();
        }

        private void txtKw_TextChanged(object sender, EventArgs e)
        {
            MultiSearch();
        }

        private void txtMod_TextChanged(object sender, EventArgs e)
        {
            MultiSearch();
        }

        private void txtManu_TextChanged(object sender, EventArgs e)
        {
            MultiSearch();
        }

        private void CmdPDF_Click(object sender, EventArgs e)
        {
            EPDFReport(dataGridView1, "Stock Report-" + DateTime.Now.ToString("dd.MM.yyyy"));
            OpenFileDialog dlg = new OpenFileDialog();
            // set file filter of dialog   
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.FileName= ("Stock Report-" + DateTime.Now.ToString("dd.MM.yyyy")+".pdf");
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                // use the LoadFile(ByVal fileName As String) function for open the pdf in control  
                axAcroPDF1.LoadFile(dlg.FileName);
                axAcroPDF1.Visible = true;
                CmdPDFExit.BackColor = Color.Red;
                CmdPDFExit.ForeColor = Color.White;
               // CmdPDFExit.UseVisualStyleBackColor = true;
            }
        }

        private void CmdPDFExit_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Visible = false;
            CmdPDFExit.BackColor = Color.Gainsboro;
            CmdPDFExit.ForeColor = Color.Black;
            CmdPDFExit.UseVisualStyleBackColor = true;
        }

        private void CmdImage_Click(object sender, EventArgs e)
        {
            FrmStkImg FStkImg = new FrmStkImg();
            FStkImg.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblUser1_Click(object sender, EventArgs e)
        {

        }
    }
}
