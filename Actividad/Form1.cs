using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            while( this.Opacity > 200)
            {
                this.Opacity -= 15000;
            }
            this.Hide();
            Form2 inicio = new Form2();
            inicio.Show();
            timer1.Stop();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 15000;
            

        }
    }
}
