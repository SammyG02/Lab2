namespace GroupBox
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtInitBal = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Account_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Controls.Add(this.txtLast);
            this.groupBox1.Controls.Add(this.txtInitBal);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Detail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.createBtn);
            this.groupBox2.Location = new System.Drawing.Point(4, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intial Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Account";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(156, 39);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(100, 26);
            this.txtAccountNo.TabIndex = 5;
            // 
            // txtInitBal
            // 
            this.txtInitBal.Location = new System.Drawing.Point(156, 125);
            this.txtInitBal.Name = "txtInitBal";
            this.txtInitBal.Size = new System.Drawing.Size(100, 26);
            this.txtInitBal.TabIndex = 6;
            this.txtInitBal.Text = "0.00";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(156, 97);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 26);
            this.txtLast.TabIndex = 7;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(156, 68);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 26);
            this.txtFirst.TabIndex = 8;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(156, 155);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 26);
            this.txtBalance.TabIndex = 9;
            this.txtBalance.Text = "0.00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(609, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.createBtn.Location = new System.Drawing.Point(36, 24);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(141, 41);
            this.createBtn.TabIndex = 14;
            this.createBtn.Text = "Create Account";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(215, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Deposit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(405, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "Withdrawl";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(594, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 41);
            this.button4.TabIndex = 17;
            this.button4.Text = "Transfer";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account_num,
            this.fName,
            this.lName,
            this.cBalance});
            this.dataGridView1.Location = new System.Drawing.Point(4, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(762, 268);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Account_num
            // 
            this.Account_num.HeaderText = "Account Number";
            this.Account_num.MinimumWidth = 8;
            this.Account_num.Name = "Account_num";
            // 
            // fName
            // 
            this.fName.HeaderText = "First Name";
            this.fName.MinimumWidth = 8;
            this.fName.Name = "fName";
            // 
            // lName
            // 
            this.lName.HeaderText = "Last Name";
            this.lName.MinimumWidth = 8;
            this.lName.Name = "lName";
            // 
            // cBalance
            // 
            this.cBalance.HeaderText = "Current Balance";
            this.cBalance.MinimumWidth = 8;
            this.cBalance.Name = "cBalance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(769, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtInitBal;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBalance;
    }
}

