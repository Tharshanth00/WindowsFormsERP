﻿using System;
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
    public partial class FrmGenLeg : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sris\InvDatabase.mdb");

        private void DGViewSize()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 28;
            dataGridView1.Columns[2].Width = 57;
            if (lblULevel1.Text == "Administrator")
            {
                //dataGridView1.Columns[2].Width = 50;
                //dataGridView1.Columns[24].Width = 29;
                //dataGridView1.Columns[25].Width = 46;
                //dataGridView1.Columns[26].Width = 29;
                //dataGridView1.Columns[27].Width = 70;                
            }
            else
            {
                // dataGridView1.Columns[24].Visible = false;
                // dataGridView1.Columns[25].Visible = false;
                // dataGridView1.Columns[26].Visible = false;
                // dataGridView1.Columns[27].Visible = false;
            }
        }

        public void EPDFReport(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
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

        public FrmGenLeg()
        {
            InitializeComponent();
        }

        private void FrmGenLeg_Load(object sender, EventArgs e)
        {
            lblUser1.Text = FrmMain.uname;
            lblULevel1.Text = FrmMain.ul;
            txtSer_TextChanged(null, null);
        }

        private void txtSer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Item where StNo Like '%" + txtSer.Text + "%' or Des Like '%" + txtSer.Text + "%' or Kw Like '%" + txtSer.Text + "%' or Gr Like '%" + txtSer.Text + "%' or Model Like '%" + txtSer.Text + "%' or Manu Like '%" + txtSer.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                DGViewSize();
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "  Error No:112 Please Inform this error number to Development Team!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
