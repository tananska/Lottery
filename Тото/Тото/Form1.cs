using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тото
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        int GetRandomNumber()
        {
            return r.Next() % 49 + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int n1, n2, n3, n4, n5, n6;
             n1 = GetRandomNumber();
             textbox1.Text = n1.ToString();
             do
             ( 
              n2 = GetRandomNumber();
             ) while(n2 == n1);
              textbox2.Text = n2.ToString();
             do
             ( 
              n3 = GetRandomNumber();
             ) while(n3 == n2 || n3 == n5);
             textbox3.Text = n3.ToString();
             do
             ( 
              n4 = GetRandomNumber();
             ) while(n4 == n3|| n4 == n2 ||n4==n1);
             textbox4.Text = n4.ToString();
             do
             ( 
              n5 = GetRandomNumber();
             ) while(n5 == n4 || n5==n3 || n5 == n2 || n5==n1);
             textbox5.Text = n5.ToString();
             do
             ( 
              n6 = GetRandomNumber();
             ) while(n6 == n5 || n6 == n4 ||n6 == n3 ||n6 == n2|| n6 == n1);
             textbox6.Text = n6.ToString();
             ;
             */
            textBox1.Text = GetRandomNumber().ToString();
            textBox2.Text = GetRandomNumber().ToString();
            textBox3.Text = GetRandomNumber().ToString();
            textBox4.Text = GetRandomNumber().ToString();
            textBox5.Text = GetRandomNumber().ToString();
            textBox6.Text = GetRandomNumber().ToString();




        }
    }
}
