using System;
using System.Collections;
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
    public partial class Programas : Form
    {
        Dictionary<string, string> progra1 = new Dictionary<string, string>();
        Dictionary<string, string> progra2 = new Dictionary<string, string>();
        Dictionary<string, string> progra3 = new Dictionary<string, string>();
        public Programas()
        {
            InitializeComponent();
        }

        private void Programas_Load(object sender, EventArgs e)
        {
            //Datos de Python

progra1.Add("Desarrollador(es):", "Python Software Foundation");
progra1.Add("Extensiones:", ".py,\r\n .pyc,\r\n .pyd,\r\n .pyo,\r\n .pyw\r\n, .pyz");
progra1.Add("Apareció en:", "1991");
progra1.Add("Sistema Operativo:", "Multiplataforma");
progra1.Add("Paradigma:", "Multiparadigma: orientado a objetos, imperativo, funcional, \r\nreflexivo");
progra1.Add("Ultima Versión:", "3.8.3");
progra1.Add("Licencia:", "Python Software Foundation License");
            foreach (var item in progra1.Keys)
            {
                lista11.Items.Add(item);

            }

//Datos de JAVA
progra2.Add("Desarrollador(es):", "James Gosling y Sun Microsystem");
progra2.Add("Extensiones:", "java,\r\n class,\r\n jar,\r\n jad,\r\n jmod ");
progra2.Add("Apareció en:", "1996");
progra2.Add("Sistema Operativo:", "Multiplataforma");
progra2.Add("Paradigma:", "Orientado a objetos,\r\n imperativo");
progra2.Add("Ultima Versión:", "14.01");
progra2.Add("Licencia:", "GNU GPL,\r\n Java Community Process");
            foreach (var item in progra2.Keys)
            {
                lista12.Items.Add(item);

            }

 //Datos de JavaScript
 progra3.Add("Desarrollador(es):", "xx ");
 progra3.Add("Extensiones:", "js ");
 progra3.Add("Apareció en:", "1995");
 progra3.Add("Sistema Operativo:", "xx");
 progra3.Add("Paradigma:", "Multiparadigma, programación \r\nfuncional,1 programación basada \r\nen \r\nprototipos, imperativo, interpreta\r\n do (scripting) ");
 progra3.Add("Ultima Versión Estable:", "ECMAScript2016 ");
 progra3.Add("Licencia:", "xx");
            foreach (var item in progra3.Keys)
            {
                lista13.Items.Add(item);

            }
        }

        private void lista11_SelectedIndexChanged(object sender, EventArgs e)
        {
              string buscar;
            buscar = lista11.Text;
            for (int i = 0; i < progra1.Count; i++)
            {
                var item = progra1.ElementAt(i);
                if (buscar == item.Key)
                {
                    box11.Text = item.Value;
                    break;
                }
            }
        }

        private void lista12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lista12.Text;
            for (int i = 0; i < progra2.Count; i++)
            {
                var item = progra2.ElementAt(i);
                if (buscar == item.Key)
                {
                    box12.Text = item.Value;
                    break;
                }
            }
        }

        private void lista13_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lista13.Text;
            for (int i = 0; i < progra3.Count; i++)
            {
                var item = progra3.ElementAt(i);
                if (buscar == item.Key)
                {
                   box13.Text = item.Value;
                    break;
                }
            }
        }
    }
}
