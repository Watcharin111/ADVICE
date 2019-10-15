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
        apd621_60011212106Entities context = new apd621_60011212106Entities();
        Form2 form2;
        int x = 255, y = 1;
        String youtube, str="";
        int cont = 0,ct = 0,c = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void setStr(String str)
        {
            this.str = str;
        }
        public void setURL(String str)
        {
            this.youtube = str;
        }
        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            c++;
            if (c == ct)
            {
                
                var result = from r in context.db_Text
                             select r;
                var rs = result.ToList();
                cont++;
                c = 0;
                //MessageBox.Show(cont+" " + rs.Count);
                if (cont == rs.Count)
                {
                    
                    cont = 0;
                    //MessageBox.Show("OK "+cont);
                }
                //MessageBox.Show(cont + " " + rs.Count);
                label1.Text = rs[cont].Test;
                ct = (int)rs[cont].Time;
               // MessageBox.Show(" " + ct);
            }

            label1.SetBounds(x,y,1,1);
            x--;
            if (x <= -300)
            {
                x = 1500;
            }

            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            
            String time = "";
            if(h < 10)
            {
                time = time + "0" + h;
            }
            else
            {
                time = time + h;
            }
            time = time + ":";
            if(m < 10)
            {
                time = time + "0" + m;
            }
            else
            {
                time = time + m;
            }
            time = time + ":";
            if(s < 10)
            {
                time = time + "0" + s;
            }
            else
            {
                time = time + s;
            }
            
           label2.Text = time;


        }


        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void DemobuttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = from r in context.db_Text
                        select r.Test;

            var rs = result.ToArray();
            var result2 = from r in context.db_Text
                         select r.Time;
            var vs = result2.ToArray(); 
            str = rs[cont];
            ct = (int)vs[cont]; 
           
           //MessageBox.Show("ct"); 
           /*foreach (var r in result){
                MessageBox.Show(r);
           }*/
            
            this.form2 = new Form2(this);
            String date = "";
            date = date + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            label3.Text = date;
            youtube = "https://www.youtube.com/watch?v=vetKTtM7YyU";

            axVLCPlugin21.playlist.add(new Uri(youtube).AbsoluteUri);
            axVLCPlugin21.playlist.play();

            label1.Text = str;
            label1.Font = new Font("", 25, FontStyle.Bold);
            timer1.Interval = 10;
            timer1.Start();

        }

    }
}
