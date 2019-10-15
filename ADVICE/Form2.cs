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
    public partial class Form2 : Form
    {
        apd621_60011212106Entities context = new apd621_60011212106Entities(); 
        Form1 form1;
        public Form2(Form1 from1)
        {
            this.form1 = from1;
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form1.setStr("B");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            bindingText.DataSource = context.db_Text.ToList();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(label2.Text);
            
            //MessageBox.Show(" " + num);
            /*var rssult = from r in context.db_Text
                         where r.id == 3
                         select r;
            rssult.ToList().First(s => s.Test == textBox1.Text);*/
            context.db_Text.Where(s => s.id == num)
                .First().Test = textBox1.Text;
            int c = context.SaveChanges();
            MessageBox.Show("Changes :"+c);
        }
    }
}
