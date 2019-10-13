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
            if (hh > 10 && mm > 10 && ss <10)
            {
                label2.Text = "" + hh + ":" + mm + ":0" + ss;
            }
            else if (hh > 10 && mm < 10 && ss < 10)
            {
                label2.Text = "" + hh + ":0" + mm + ":0" + ss;
            }



            else if (hh < 10 && mm <10 && ss < 10)
            {
                label2.Text = "0" + hh + ":0" + mm + ":0" + ss;
            }
            else
            {
                label2.Text = "" + hh + ":" + mm + ":" + ss;
            }
           // label2.Text = hh+":"+mm+":"+ss;


        }

        private void Label2_Click(object sender, EventArgs e)
        {
           
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            label1.Text = "ประยุทธ์ จันโอชา";
            label1.Font = new Font("", 25, FontStyle.Bold);
            timer1.Interval = 1;
            timer1.Start();

        }
    }
}
