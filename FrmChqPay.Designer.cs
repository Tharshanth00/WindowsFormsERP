namespace WindowsFormsERP
{
    partial class FrmChqPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChqPay));
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CmdOK = new System.Windows.Forms.Button();
            this.CmdExit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCPDate = new System.Windows.Forms.DateTimePicker();
            this.txyTotAmo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.txtAmo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBnkCrg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OptAcc = new System.Windows.Forms.RadioButton();
            this.txtCrncy = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Exchange Date";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CmdOK);
            this.panel5.Controls.Add(this.CmdExit);
            this.panel5.Location = new System.Drawing.Point(71, 408);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 45);
            this.panel5.TabIndex = 20;
            // 
            // CmdOK
            // 
            this.CmdOK.Location = new System.Drawing.Point(3, 4);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(121, 35);
            this.CmdOK.TabIndex = 22;
            this.CmdOK.Text = "&OK";
            this.CmdOK.UseVisualStyleBackColor = true;
            this.CmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(125, 4);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(120, 35);
            this.CmdExit.TabIndex = 15;
            this.CmdExit.Text = "&Cancel";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 135);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowTemplate.Height = 42;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(684, 122);
            this.dataGridView2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEDate);
            this.groupBox2.Controls.Add(this.dtpCPDate);
            this.groupBox2.Controls.Add(this.txyTotAmo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTot);
            this.groupBox2.Controls.Add(this.txtAmo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBnkCrg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.OptAcc);
            this.groupBox2.Controls.Add(this.txtCrncy);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(41, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 377);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dtpEDate
            // 
            this.dtpEDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDate.Location = new System.Drawing.Point(543, 85);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(168, 20);
            this.dtpEDate.TabIndex = 3;
            // 
            // dtpCPDate
            // 
            this.dtpCPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCPDate.Location = new System.Drawing.Point(113, 45);
            this.dtpCPDate.Name = "dtpCPDate";
            this.dtpCPDate.Size = new System.Drawing.Size(168, 20);
            this.dtpCPDate.TabIndex = 0;
            this.dtpCPDate.ValueChanged += new System.EventHandler(this.dtpCPDate_ValueChanged);
            // 
            // txyTotAmo
            // 
            this.txyTotAmo.Location = new System.Drawing.Point(112, 338);
            this.txyTotAmo.Name = "txyTotAmo";
            this.txyTotAmo.Size = new System.Drawing.Size(168, 20);
            this.txyTotAmo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Total Amount";
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(543, 279);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(168, 20);
            this.txtTot.TabIndex = 7;
            // 
            // txtAmo
            // 
            this.txtAmo.Location = new System.Drawing.Point(113, 278);
            this.txtAmo.Name = "txtAmo";
            this.txtAmo.Size = new System.Drawing.Size(168, 20);
            this.txtAmo.TabIndex = 4;
            this.txtAmo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Amount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBnkCrg
            // 
            this.txtBnkCrg.Location = new System.Drawing.Point(112, 308);
            this.txtBnkCrg.Name = "txtBnkCrg";
            this.txtBnkCrg.Size = new System.Drawing.Size(168, 20);
            this.txtBnkCrg.TabIndex = 5;
            this.txtBnkCrg.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Bank Charges";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // OptAcc
            // 
            this.OptAcc.AutoSize = true;
            this.OptAcc.Location = new System.Drawing.Point(345, 46);
            this.OptAcc.Name = "OptAcc";
            this.OptAcc.Size = new System.Drawing.Size(65, 17);
            this.OptAcc.TabIndex = 1;
            this.OptAcc.TabStop = true;
            this.OptAcc.Text = "Account";
            this.OptAcc.UseVisualStyleBackColor = true;
            // 
            // txtCrncy
            // 
            this.txtCrncy.Location = new System.Drawing.Point(543, 48);
            this.txtCrncy.Name = "txtCrncy";
            this.txtCrncy.Size = new System.Drawing.Size(168, 20);
            this.txtCrncy.TabIndex = 2;
            this.txtCrncy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCrncy_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-18, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 478);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(268, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cheque Payment";
            // 
            // FrmChqPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(794, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmChqPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque Payment";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmChqPay_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCrncy;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.TextBox txtAmo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBnkCrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton OptAcc;
        private System.Windows.Forms.Button CmdOK;
        private System.Windows.Forms.TextBox txyTotAmo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.DateTimePicker dtpCPDate;
    }
}