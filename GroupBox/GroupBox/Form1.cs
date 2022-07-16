using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        Bank bk;
        private void createBtn_Click(object sender, EventArgs e)
        {
            bk = new Bank();
            bk.accountNo = int.Parse(txtAccountNo.Text);
            bk.amount = int.Parse(txtInitBal.Text);
            bk.firstName = txtFirst.Text;
            bk.lastName = txtLast.Text;
            bk.currentBalance = int.Parse(txtBalance.Text);
            dataGridView1.Rows.Add(1);
            // add the values to the row





        }
    }
}
