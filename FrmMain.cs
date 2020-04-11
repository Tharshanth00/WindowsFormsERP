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
    public partial class FrmMain : Form
    {
        OleDbDataReader rdr;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Sris\InvDatabase.mdb");
        private void UserIDKW()
        {
            try
            {
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("select * from UserDetails where UserID='" + lblID.Text.Trim() + "'", con);
                cmd1.Connection = con;
                rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["NNewUser"].ToString() == "False")
                    {
                        newUserToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NUserLogin"].ToString() == "False")
                    {
                        loginToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NUserControl"].ToString() == "False")
                    {
                        exitToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NExit"].ToString() == "False")
                    {
                        exitToolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NInvoice"].ToString() == "False")
                    {
                        invoiveToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NPurchase"].ToString() == "False")
                    {
                        toolStripMenuItem1.Enabled = false;
                    }
                    if (rdr["NJobOrder"].ToString() == "False")
                    {
                        jobOrderToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NPayments"].ToString() == "False")
                    {
                        paymentsToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NCheque"].ToString() == "False")
                    {
                        chequeToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NBank"].ToString() == "False")
                    {
                        bankToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NAccounts"].ToString() == "False")
                    {
                        accountsToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NStockItem"].ToString() == "False")
                    {
                        stockItemToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NCustomer"].ToString() == "False")
                    {
                        customerToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NVendor"].ToString() == "False")
                    {
                        vendorToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NInventoryItems"].ToString() == "False")
                    {
                        inventoryItemsToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NFixedAssets"].ToString() == "False")
                    {
                        fixedAssetsToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NMiscellaneous"].ToString() == "False")
                    {
                        miscellaneousToolStripMenuItem.Enabled = false;
                    }
                    if (rdr["NReports"].ToString() == "False")
                    {
                        reportsToolStripMenuItem.Enabled = false;
                    }
                    if (PicImg.Image != null)
                    {
                        byte[] Photo = (byte[])(rdr["IImg"]);
                        MemoryStream ms = new MemoryStream(Photo);
                        PicImg.Image = Image.FromStream(ms);                                        
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                return;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {            
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
            //newUserToolStripMenuItem.Enabled = false;
            //exitToolStripMenuItem.Enabled = false;

            
             FrmLoad FLoad = new FrmLoad();
            FLoad.Close();
            FrmLogin FLogin = new FrmLogin();
            FLogin.Close();
            
            if (lblULevel.Text == "Administrator")
            {
                exitToolStripMenuItem.Enabled = true;
            }
            lblUL.Text = lblULevel.Text;
            lblUID.Text = lblUser.Text;
            lblID.Refresh();
            Refresh();
            this.Refresh();
            panel2.Left = Convert.ToInt32((this.Width)) / 2 - Convert.ToInt32(panel2.Width)/2;
            panel2.Top = Convert.ToInt32((this.Height)) / 2 - Convert.ToInt32(panel2.Height)*2/3;
            try
            {
                this.BackColor = Color.FromArgb(Convert.ToInt32(lblColor.Text));
            }
            catch (Exception)
            {
                return;
            }
            UserIDKW();
            monthCalendar1.SetDate(DateTime.Now);
            if (invoiveToolStripMenuItem.Enabled==false)
            {
                aaaToolStripMenuItem.Enabled = false;
                taxInvoiceToolStripMenuItem1.Enabled = false;                
                suspendedTaxInvoiceToolStripMenuItem1.Enabled = false;
                manufactureInvoiceToolStripMenuItem1.Enabled = false;
            }
            if (jobOrderToolStripMenuItem.Enabled == false)
            {
                jobOrderToolStripMenuItem3.Enabled = false;                
            }
            if (toolStripMenuItem1.Enabled == false)
            {
                purchaseOrderToolStripMenuItem1.Enabled = false;
                purchaseGRNToolStripMenuItem.Enabled = false;
            }
            if (chequeToolStripMenuItem.Enabled == false)
            {
                chequePaymentToolStripMenuItem2.Enabled = false;
            }
            if (accountsToolStripMenuItem.Enabled == false)
            {
                currencyExchangeToolStripMenuItem.Enabled = false;
                cashBookToolStripMenuItem1.Enabled = false;
                generalLedgerSumarryToolStripMenuItem.Enabled = false;
                iOUToolStripMenuItem1.Enabled = false;
                pettyCashToolStripMenuItem1.Enabled = false;
            }
            if (stockItemToolStripMenuItem.Enabled == false)
            {
                stockReportToolStripMenuItem1.Enabled = false;
                stockImageToolStripMenuItem1.Enabled = false;
            }
            lblUID.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width)) / 2 - Convert.ToInt32(lblUID.Width)/2;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmItem FItem = new FrmItem();            
            FItem.Show();
        }
        public static string uname = "";
        public static string ul = "";

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Show();            
        }

        private void newVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSup FSup = new FrmSup();
            FSup.Show();
        }

        private void supplierSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupRep FSupRep = new FrmSupRep();
            FSupRep.Show();
        }

        private void stockImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStkImg FStkImg = new FrmStkImg();
            FStkImg.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin FLogin = new FrmLogin();
            FLogin.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUReg FUReg = new FrmUReg();
            FUReg.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUControl FUControl = new FrmUControl();
            FUControl.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvoice FInvoice = new FrmInvoice();
            FInvoice.Show();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurOrder FmPurOrder = new FrmPurOrder();
            FmPurOrder.Show();
        }

        private void gRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurGRN FPurGRN = new FrmPurGRN();
            FPurGRN.Show();
        }

        private void newJobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobOdr FJobOdr = new FrmJobOdr();
            FJobOdr.Show();
        }

        private void orderWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Show();
        }

        private void receivedEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheque FCheque = new FrmCheque();
            FCheque.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBank FBank = new FrmBank();
            FBank.Show();
        }

        private void bankDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankDtl FBankDtl = new FrmBankDtl();
            FBankDtl.Show();
        }

        private void entryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBankRecn FBankRecn = new FrmBankRecn();
            FBankRecn.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankRecnRep FBankRecnRep = new FrmBankRecnRep();
            FBankRecnRep.Show();
        }

        private void newCustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCus FCus = new FrmCus();
            FCus.Show();
        }

        private void customerSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCusRep FCusRep = new FrmCusRep();
            FCusRep.Show();
        }

        private void accountReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmARInv FAccRec = new FrmARInv();
            FAccRec.Show();
        }

        private void accountPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPInv FAccPay = new FrmAPInv();
            FAccPay.Show();
        }

        private void fixedAssetSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFxdAst FFxdAst = new FrmFxdAst();
            FFxdAst.Show();
        }

        private void fixedAssetSummaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFxdAstRep FFxdAstRep = new FrmFxdAstRep();
            FFxdAstRep.Show();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMislns FMislns = new FrmMislns();
            FMislns.Show();
        }

        private void accountTypeCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGLAccount FGLAccount = new FrmGLAccount();
            FGLAccount.Show();
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaOAcc FChaOAcc = new FrmChaOAcc();
            FChaOAcc.Show();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCrncy FCrncy = new FrmCrncy();
            FCrncy.Show();
        }

        private void exchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrncyExc FCrncyExc = new FrmCrncyExc();
            FCrncyExc.Show();
        }

        private void cashBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCshBok FCshBok = new FrmCshBok();
            FCshBok.Show();
        }

        private void registrationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTaxReg FTaxReg = new FrmTaxReg();
            FTaxReg.Show();
        }

        private void entryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPtyCsh FPtyCsh = new FrmPtyCsh();
            FPtyCsh.Show();
        }

        private void profitAndLossStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProLos FProLos = new FrmProLos();
            FProLos.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBalSht FBalSht = new FrmBalSht();
            FBalSht.Show();
        }

        private void incomeStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncome FIncome = new FrmIncome();
            FIncome.Show();
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriBal FTriBal = new FrmTriBal();
            FTriBal.Show();
        }

        private void transportationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransport FTransport = new FrmTransport();
            FTransport.Show();
        }

        private void iOUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIOU FIOU = new FrmIOU();
            FIOU.Show();
        }

        private void chequePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChqPay FChqPay = new FrmChqPay();
            FChqPay.Show();
        }

        private void chequeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmChqPay FChqPay = new FrmChqPay();
            FChqPay.Show();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenLeg FGenLeg = new FrmGenLeg();
            FGenLeg.Show();
        }

        private void taxInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTxtInv1 FTxtInv1 = new FrmTxtInv1();
            FTxtInv1.Show();
        }

        private void suspendedTaxInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSTaxInv FSTaxInv = new FrmSTaxInv();
            FSTaxInv.Show();
        }

        private void manufactureInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMnuInv FMnuInv = new FrmMnuInv();
            FMnuInv.Show();
        }

        private void totalsByCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Show();
        }

        private void salesInvoiceTotalsByItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Show();
        }

        private void bankWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChqRep FChqRep = new FrmChqRep();
            FChqRep.Show();
        }

        private void customerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChqRep FChqRep = new FrmChqRep();
            FChqRep.Show();
        }

        private void branchWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChqRep FChqRep = new FrmChqRep();
            FChqRep.Show();
        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPtyCshRep FPtyCshRep = new FrmPtyCshRep();
            FPtyCshRep.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurRep FPurRep = new FrmPurRep();
            FPurRep.Show();
        }

        private void numberWiseReportRevenueExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Show();
        }

        private void customerWiseJobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Show();
        }

        private void aPInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPInv FAPInv = new FrmAPInv();
            FAPInv.Show();
        }

        private void cashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAPInv FAPInv = new FrmAPInv();
            FAPInv.Show();
        }

        private void aRInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmARInv FARInv = new FrmARInv();
            FARInv.Show();
        }

        private void cashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmARInv FARInv = new FrmARInv();
            FARInv.Show();
        }

        private void receiptsAndPaymentsSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creditMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmARCMemo FARCMemo = new FrmARCMemo();
            FARCMemo.Show();
        }

        private void debitMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPCMemo FAPCMemo = new FrmAPCMemo();
            FAPCMemo.Show();
        }

        private void outgoingPayment1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgPay1 FOgPay1 = new FrmOgPay1();
            FOgPay1.Show();
        }

        private void outgoingPayment2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgPay2 FOgPay2 = new FrmOgPay2();
            FOgPay2.Show();
        }

        private void tTPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTTPay FTTPay = new FrmTTPay();
            FTTPay.Show();
        }

        private void taxInvoice2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cashToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmARInv FARInv = new FrmARInv();
            FARInv.Show();
        }

        private void cashToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmAPInv FAPInv = new FrmAPInv();
            FAPInv.Show();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBill FBill = new FrmBill();
            FBill.Show();
        }

        private void paymentReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayRec FPayRec = new FrmPayRec();
            FPayRec.Show();
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmJOPay FJOPay = new FrmJOPay();
            FJOPay.Show();
        }

        private void salesStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSStaff FSStaff = new FrmSStaff();
            FSStaff.Show();
        }

        private void locationEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocation FLocation = new FrmLocation();
            FLocation.Show();
        }

        private void FrmMain_Click(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_DoubleClick(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_DragLeave(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_DragOver(object sender, DragEventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_Enter(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_Leave(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_MaximumSizeChanged(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_ResizeEnd(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void FrmMain_RightToLeftChanged(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Rectangle workArea = Screen.GetWorkingArea(this);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
            int intX = Screen.PrimaryScreen.Bounds.Width;
            int intY = Screen.PrimaryScreen.Bounds.Height;
            if (intX < this.Width)
                this.Width = intX;
            if (intY < this.Height)
                this.Height = intY;
            Rectangle r = Screen.GetBounds(this);
            this.Location = new Point(0, 0);
            this.Size = r.Size;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPassword FPassword = new FrmPassword();

            Control[] ctrlsIDD = FPassword.Controls.Find("lblID", false);
            Label lbl3 = (Label)ctrlsIDD[0];
            lbl3.Text = lblID.Text;

            FPassword.Show();
        }

        private void businessMasterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBMaster FBMaster = new FrmBMaster();
            FBMaster.Show();
        }

        private void stockItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stockReportToolStripMenuItem_Click(null, null);
        }

        private void customerSumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerSummaryToolStripMenuItem_Click(null, null);
        }

        private void supplierSummaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supplierSummaryToolStripMenuItem_Click(null, null);
        }

        private void jobOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmJobORep FJobORep = new FrmJobORep();
            FJobORep.Show();
        }

        private void pettyCashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void bankReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankRep FBankRep = new FrmBankRep();
            FBankRep.Show();
        }

        private void bankToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void accountTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bankDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void chartOfAccountsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void currencyExchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void currencyRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void iOUToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salesStaffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void taxRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void tTPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void userLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bankEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankRep FBankRep = new FrmBankRep();
            FBankRep.Show();
        }

        private void bankDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBankDetailsRep FBankDetailsRep = new FrmBankDetailsRep();
            FBankDetailsRep.Show();
        }

        private void tTPaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTTPaymentRep FTTPaymentRep = new FrmTTPaymentRep();
            FTTPaymentRep.Show();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsersRep FUsersRep = new FrmUsersRep();
            FUsersRep.Show();
        }

        private void userLevelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUserLevelRep FUserLevelRep = new FrmUserLevelRep();
            FUserLevelRep.Show();
        }

        private void invoiceItemWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taxRegistrationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmTaxRegRep FTaxRegRep = new FrmTaxRegRep();
            FTaxRegRep.Show();
        }

        private void accountTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAccountTypeRep FAccountTypeRep = new FrmAccountTypeRep();
            FAccountTypeRep.Show();
        }

        private void chartOfAccountsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCOAccountRep FCOAccountRep = new FrmCOAccountRep();
            FCOAccountRep.Show();
        }

        private void currencyRegistrationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCurrencyRegRep FCurrencyRegRep = new FrmCurrencyRegRep();
            FCurrencyRegRep.Show();
        }

        private void currencyExchangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCurrencyExcRep FCurrencyExcRep = new FrmCurrencyExcRep();
            FCurrencyExcRep.Show();
        }

        private void pettyCashToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            reportToolStripMenuItem1_Click(null, null);
        }

        private void iOUToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmIOURep FIOURep = new FrmIOURep();
            FIOURep.Show();
        }

        private void locationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLocationRep FLocationRep = new FrmLocationRep();
            FLocationRep.Show();
        }

        private void salesStaffToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmSalesStaffRep FSalesStaffRep = new FrmSalesStaffRep();
            FSalesStaffRep.Show();
        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInvRep FInvRep = new FrmInvRep();
            FInvRep.Show();
        }

        private void taxInvoiceItemWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTaxInvRep FTaxInvRep = new FrmTaxInvRep();
            FTaxInvRep.Show();
        }

        private void manufactureInvoiceItemWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMInvRep FMInvRep = new FrmMInvRep();
            FMInvRep.Show();
        }

        private void suspendedTaxInvoiceItemWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSTaxInvRep FSTaxInvRep = new FrmSTaxInvRep();
            FSTaxInvRep.Show();
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserLoginRep FUserLoginRep = new FrmUserLoginRep();
            FUserLoginRep.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            FrmLogin FLogin = new FrmLogin();
            FLogin.Show();
            this.Enabled = false;
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invoiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void lblUID_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void aaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvoice FInvoice = new FrmInvoice();
            FInvoice.Show();
        }

        private void taxInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTxtInv1 FTxtInv1 = new FrmTxtInv1();
            FTxtInv1.Show();
        }

        private void suspendedTaxInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSTaxInv FSTaxInv = new FrmSTaxInv();
            FSTaxInv.Show();
        }

        private void manufactureInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMnuInv FMnuInv = new FrmMnuInv();
            FMnuInv.Show();
        }

        private void jobOrderToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmJobOdr FJobOdr = new FrmJobOdr();
            FJobOdr.Show();
        }

        private void purchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPurOrder FmPurOrder = new FrmPurOrder();
            FmPurOrder.Show();
        }

        private void currencyExchangeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCrncyExc FCrncyExc = new FrmCrncyExc();
            FCrncyExc.Show();
        }

        private void purchaseGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurGRN FPurGRN = new FrmPurGRN();
            FPurGRN.Show();
        }

        private void chequePaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmChqPay FChqPay = new FrmChqPay();
            FChqPay.Show();
        }

        private void cashBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCshBok FCshBok = new FrmCshBok();
            FCshBok.Show();
        }

        private void generalLedgerSumarryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenLeg FGenLeg = new FrmGenLeg();
            FGenLeg.Show();
        }

        private void iOUToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmIOU FIOU = new FrmIOU();
            FIOU.Show();
        }

        private void pettyCashToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmPtyCsh FPtyCsh = new FrmPtyCsh();
            FPtyCsh.Show();
        }

        private void stockReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uname = lblUser.Text;
            ul = lblULevel.Text;
            FrmStkRep FStkRep = new FrmStkRep();
            FStkRep.Show();
        }

        private void stockImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmStkImg FStkImg = new FrmStkImg();
            FStkImg.Show();
        }

        private void userLevelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUserLevel FUserLevel = new FrmUserLevel();
            FUserLevel.Show();
        }
    }
}
