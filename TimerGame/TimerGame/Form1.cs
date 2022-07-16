using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hr, sec, min;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = int.Parse(lblsec.Text);
            
            

            if(sec < 10)
            {
                sec++;
                lblsec.Text = sec.ToString();
                
            }
            if (sec == 10)
            {
                sec = 0;
                lblsec.Text = sec.ToString();


            }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();


            if (hr == sec && sec ==min && min ==hr)
            {
                MessageBox.Show("Winner");

            }
            else if(hr == sec || hr == min)
            {
                MessageBox.Show("Winner");

            }
            else if (min == sec || sec == min)
            {
                MessageBox.Show("Winner");

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            min = int.Parse(lblmin.Text);
            if (min < 10)
            {
                min++;
                lblmin.Text = min.ToString();
            }
            if (min == 10)
            {
                min = 0;
                lblmin.Text = min.ToString();


            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            hr = int.Parse(lblhr.Text);
            if (hr < 10)
            {
                hr++;
                lblhr.Text = hr.ToString();
            }
            if (hr == 10)
            {
                hr = 0;
                lblhr.Text = hr.ToString();


            }

        }


    }
}
