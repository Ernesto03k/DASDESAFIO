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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            Entretenimiento entretenimiento = new Entretenimiento();
            entretenimiento.ShowDialog();
            // Form3 enlace = new Form3();
            //enlace.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Novelas novelas = new Novelas();
            novelas.ShowDialog();

            // Form3 enlace = new Form3();
            //enlace.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Programas programas = new Programas();
            programas.ShowDialog();

        }
    }
}
