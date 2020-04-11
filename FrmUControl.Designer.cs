namespace WindowsFormsERP
{
    partial class FrmUControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("New User", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("User Login", 3, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("User Control", 4, 4);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("User Level", 1, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Exit", 5, 5);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("System", 41, 41, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Invoice", 48, 48);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Purchase", 7, 7);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Job Order", 50, 50);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Payments", 10, 10);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Cheque", 22, 22);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Bank", 14, 14);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Accounts", 34, 34);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Stock Item", 18, 18);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Customer", 15, 15);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Vendor", 19, 19);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Inventory Items", 32, 32);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Fixed Assets", 35, 35);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode(" Miscellaneous", 23, 23);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Reports", 37, 37);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUControl));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtULevel = new System.Windows.Forms.TextBox();
            this.comUID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdDefolt = new System.Windows.Forms.Button();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.CmdReport = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.lblULevel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(573, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Control";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(-18, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 748);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.TxtSer);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(540, 386);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(672, 282);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(3, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(666, 29);
            this.panel6.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "User Details";
            // 
            // TxtSer
            // 
            this.TxtSer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSer.Location = new System.Drawing.Point(105, 53);
            this.TxtSer.Name = "TxtSer";
            this.TxtSer.Size = new System.Drawing.Size(525, 22);
            this.TxtSer.TabIndex = 11;
            this.TxtSer.TextChanged += new System.EventHandler(this.TxtSer_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(49, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(582, 177);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtULevel);
            this.groupBox2.Controls.Add(this.comUID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtGen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(540, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 258);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "User Level";
            // 
            // txtULevel
            // 
            this.txtULevel.Enabled = false;
            this.txtULevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtULevel.Location = new System.Drawing.Point(113, 201);
            this.txtULevel.Name = "txtULevel";
            this.txtULevel.Size = new System.Drawing.Size(343, 22);
            this.txtULevel.TabIndex = 6;
            // 
            // comUID
            // 
            this.comUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comUID.FormattingEnabled = true;
            this.comUID.Location = new System.Drawing.Point(113, 72);
            this.comUID.Name = "comUID";
            this.comUID.Size = new System.Drawing.Size(126, 24);
            this.comUID.TabIndex = 1;
            this.comUID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comUID_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(534, 199);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(90, 22);
            this.txtAge.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Gender";
            // 
            // txtGen
            // 
            this.txtGen.Enabled = false;
            this.txtGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGen.Location = new System.Drawing.Point(534, 159);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(90, 22);
            this.txtGen.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Designation";
            // 
            // txtDes
            // 
            this.txtDes.Enabled = false;
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(113, 158);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(343, 22);
            this.txtDes.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Full Name";
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(113, 117);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(511, 22);
            this.txtFName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(319, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 22);
            this.txtName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "User ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 29);
            this.panel2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Information";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(95, 39);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "NNewUser";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "New User";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "NUserLogin";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "User Login";
            treeNode3.ImageIndex = 4;
            treeNode3.Name = "NUserControl";
            treeNode3.SelectedImageIndex = 4;
            treeNode3.Text = "User Control";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "NUserLevel";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "User Level";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "NExit";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Text = "Exit";
            treeNode6.ImageIndex = 41;
            treeNode6.Name = "NSystem";
            treeNode6.SelectedImageIndex = 41;
            treeNode6.Text = "System";
            treeNode7.ImageIndex = 48;
            treeNode7.Name = "NInvoice";
            treeNode7.SelectedImageIndex = 48;
            treeNode7.Text = "Invoice";
            treeNode8.ImageIndex = 7;
            treeNode8.Name = "NPurchase";
            treeNode8.SelectedImageIndex = 7;
            treeNode8.Text = "Purchase";
            treeNode9.ImageIndex = 50;
            treeNode9.Name = "NJobOrder";
            treeNode9.SelectedImageIndex = 50;
            treeNode9.Text = "Job Order";
            treeNode10.ImageIndex = 10;
            treeNode10.Name = "NPayments";
            treeNode10.SelectedImageIndex = 10;
            treeNode10.Text = "Payments";
            treeNode11.ImageIndex = 22;
            treeNode11.Name = "NCheque";
            treeNode11.SelectedImageIndex = 22;
            treeNode11.Text = "Cheque";
            treeNode12.ImageIndex = 14;
            treeNode12.Name = "NBank";
            treeNode12.SelectedImageIndex = 14;
            treeNode12.Text = "Bank";
            treeNode13.ImageIndex = 34;
            treeNode13.Name = "NAccounts";
            treeNode13.SelectedImageIndex = 34;
            treeNode13.Text = "Accounts";
            treeNode14.ImageIndex = 18;
            treeNode14.Name = "NStockItem";
            treeNode14.SelectedImageIndex = 18;
            treeNode14.Text = "Stock Item";
            treeNode15.ImageIndex = 15;
            treeNode15.Name = "NCustomer";
            treeNode15.SelectedImageIndex = 15;
            treeNode15.Text = "Customer";
            treeNode16.ImageIndex = 19;
            treeNode16.Name = "NVendor";
            treeNode16.SelectedImageIndex = 19;
            treeNode16.Text = "Vendor";
            treeNode17.ImageIndex = 32;
            treeNode17.Name = "NInventoryItems";
            treeNode17.SelectedImageIndex = 32;
            treeNode17.Text = "Inventory Items";
            treeNode18.ImageIndex = 35;
            treeNode18.Name = "NFixedAssets";
            treeNode18.SelectedImageIndex = 35;
            treeNode18.Text = "Fixed Assets";
            treeNode19.ImageIndex = 23;
            treeNode19.Name = "NMiscellaneous";
            treeNode19.SelectedImageIndex = 23;
            treeNode19.Text = " Miscellaneous";
            treeNode20.ImageIndex = 37;
            treeNode20.Name = "NReports";
            treeNode20.SelectedImageIndex = 37;
            treeNode20.Text = "Reports";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(361, 614);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
            this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "19.png");
            this.imageList1.Images.SetKeyName(1, "xxx033-512.png");
            this.imageList1.Images.SetKeyName(2, "1024px-Crystal_Clear_app_Login_Manager.svg.png");
            this.imageList1.Images.SetKeyName(3, "login-icon-39414.png");
            this.imageList1.Images.SetKeyName(4, "images (2).jpg");
            this.imageList1.Images.SetKeyName(5, "exit-1806557-1533018.png");
            this.imageList1.Images.SetKeyName(6, "110438192-invoice-icon-payment-and-billing-invoices-vector-icon.jpg");
            this.imageList1.Images.SetKeyName(7, "download (1).png");
            this.imageList1.Images.SetKeyName(8, "images.jpg");
            this.imageList1.Images.SetKeyName(9, "resolutions-23-512.png");
            this.imageList1.Images.SetKeyName(10, "download (2).png");
            this.imageList1.Images.SetKeyName(11, "download (4).png");
            this.imageList1.Images.SetKeyName(12, "vector-cheque-icon.jpg");
            this.imageList1.Images.SetKeyName(13, "1.png");
            this.imageList1.Images.SetKeyName(14, "bank-icon-vector-1770678.jpg");
            this.imageList1.Images.SetKeyName(15, "21-214875_key-achievements-icons-blue-community-transparent-background-customer.p" +
        "ng");
            this.imageList1.Images.SetKeyName(16, "Budget-Accounting-512.png");
            this.imageList1.Images.SetKeyName(17, "Package-add.png");
            this.imageList1.Images.SetKeyName(18, "add-item-icon.png");
            this.imageList1.Images.SetKeyName(19, "supplier-icon-67.png");
            this.imageList1.Images.SetKeyName(20, "1254276.png");
            this.imageList1.Images.SetKeyName(21, "sage-fas-illustration-depreciation.png");
            this.imageList1.Images.SetKeyName(22, "money-cheque-icon-yellow-circle-frame-background-v-vector-20757851.jpg");
            this.imageList1.Images.SetKeyName(23, "DD-Colorful-Icon-Set-43201-Preview.jpg");
            this.imageList1.Images.SetKeyName(24, "87902178-business-report-paper-on-isolated-white-background-with-simple-vector-il" +
        "lustration-design.jpg");
            this.imageList1.Images.SetKeyName(25, "1.png");
            this.imageList1.Images.SetKeyName(26, "69718118-invoice-icon-in-the-flat-style-isolated-from-the-background-payment-and-" +
        "billing-invoices-business-or.jpg");
            this.imageList1.Images.SetKeyName(27, "images (3).png");
            this.imageList1.Images.SetKeyName(28, "images.png");
            this.imageList1.Images.SetKeyName(29, "dashboard_report_reports_kpi_3_pie_document_bar-512.png");
            this.imageList1.Images.SetKeyName(30, "Package-add.png");
            this.imageList1.Images.SetKeyName(31, "dashboard_report_reports_kpi_3_pie_document_bar-512.png");
            this.imageList1.Images.SetKeyName(32, "6449592_preview.png");
            this.imageList1.Images.SetKeyName(33, "303-3032157_accounting-bookkeeping-accounting-and-bookkeeping-icon.png");
            this.imageList1.Images.SetKeyName(34, "images (4).png");
            this.imageList1.Images.SetKeyName(35, "Fixed-Assets-Icon.png");
            this.imageList1.Images.SetKeyName(36, "fixed-assets-e1540477277327.jpg");
            this.imageList1.Images.SetKeyName(37, "chart-grawth-blue-monitoring-report-screen-statistics-icon-31.png");
            this.imageList1.Images.SetKeyName(38, "download.png");
            this.imageList1.Images.SetKeyName(39, "images.png");
            this.imageList1.Images.SetKeyName(40, "System-Optimization-and-Innovation-CRME-Icon.png");
            this.imageList1.Images.SetKeyName(41, "unnamed (1).png");
            this.imageList1.Images.SetKeyName(42, "4-512.png");
            this.imageList1.Images.SetKeyName(43, "images (1).jpg");
            this.imageList1.Images.SetKeyName(44, "unnamed.jpg");
            this.imageList1.Images.SetKeyName(45, "INVOICE.png");
            this.imageList1.Images.SetKeyName(46, "INVOICE.png");
            this.imageList1.Images.SetKeyName(47, "9-512.png");
            this.imageList1.Images.SetKeyName(48, "paper-receipt-bank-document-payment-and-bill-invoice-icon-retail-and-sales-concep" +
        "t-vector-illustration-WAN2YA.jpg");
            this.imageList1.Images.SetKeyName(49, "images (2).jpg");
            this.imageList1.Images.SetKeyName(50, "job-icon-png-1.png");
            this.imageList1.Images.SetKeyName(51, "job-order-icon-1.jpg");
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cmdDefolt);
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Controls.Add(this.CmdUpdate);
            this.panel5.Controls.Add(this.CmdReport);
            this.panel5.Location = new System.Drawing.Point(651, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(561, 47);
            this.panel5.TabIndex = 20;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cmdDefolt
            // 
            this.cmdDefolt.Location = new System.Drawing.Point(4, 4);
            this.cmdDefolt.Name = "cmdDefolt";
            this.cmdDefolt.Size = new System.Drawing.Size(138, 37);
            this.cmdDefolt.TabIndex = 11;
            this.cmdDefolt.Text = "&Defolt Selection";
            this.cmdDefolt.UseVisualStyleBackColor = true;
            this.cmdDefolt.Click += new System.EventHandler(this.cmdDefolt_Click);
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(421, 4);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(134, 37);
            this.CmdExit.TabIndex = 10;
            this.CmdExit.Text = "&Exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Location = new System.Drawing.Point(145, 4);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(135, 37);
            this.CmdUpdate.TabIndex = 8;
            this.CmdUpdate.Text = "&Save";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // CmdReport
            // 
            this.CmdReport.Location = new System.Drawing.Point(283, 4);
            this.CmdReport.Name = "CmdReport";
            this.CmdReport.Size = new System.Drawing.Size(135, 37);
            this.CmdReport.TabIndex = 9;
            this.CmdReport.Text = "&Report";
            this.CmdReport.UseVisualStyleBackColor = true;
            this.CmdReport.Click += new System.EventHandler(this.CmdReport_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(851, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 64;
            this.label12.Text = "User Level  :";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(851, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 63;
            this.label13.Text = "User ID       :";
            this.label13.Visible = false;
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser1.Location = new System.Drawing.Point(949, 9);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(53, 16);
            this.lblUser1.TabIndex = 61;
            this.lblUser1.Text = "User ID";
            this.lblUser1.Visible = false;
            // 
            // lblULevel1
            // 
            this.lblULevel1.AutoSize = true;
            this.lblULevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULevel1.Location = new System.Drawing.Point(949, 36);
            this.lblULevel1.Name = "lblULevel1";
            this.lblULevel1.Size = new System.Drawing.Size(73, 16);
            this.lblULevel1.TabIndex = 62;
            this.lblULevel1.Text = "User Level";
            this.lblULevel1.Visible = false;
            // 
            // FrmUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1276, 774);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.lblULevel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUControl";
            this.ShowInTaskbar = false;
            this.Text = "User Control";
            this.Load += new System.EventHandler(this.FrmUControl_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Button CmdReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSer;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comUID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtULevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label lblULevel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button cmdDefolt;
    }
}