using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADVICE
{
    
    public partial class Form1 : Form
    {
        
        int x = 255, y = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.SetBounds(x,y,1,1);
            x--;
            if (x <= -10)
            {
                x = 500;
            }

            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            
            String time = "";
            
           label2.Text = hh+":"+mm+":"+ss;


        }

        private void Label2_Click(object sender, EventArgs e)
        {
           
            

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String date = "";
            date = date + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            label3.Text = date;
             



            label1.Text = "ประยุทธ์ จันโอชา";
            label1.Font = new Font("", 25, FontStyle.Bold);
            timer1.Interval = 1;
            timer1.Start();

        }
    }
}
