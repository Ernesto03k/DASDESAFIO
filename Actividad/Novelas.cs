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
    public partial class Novelas : Form
     
    {
        Dictionary<string, string> novelas = new Dictionary<string, string>();
        Dictionary<string, string> novelas2 = new Dictionary<string, string>();
        Dictionary<string, string> novelas3 = new Dictionary<string, string>();
        public Novelas()

        {
            InitializeComponent();
        }

       


        private void Novelas_Load(object sender, EventArgs e)
        {
            //Datos de Harry
novelas.Add("Autor", "J. K. Rowling");
novelas.Add("Genero", "Novela");
novelas.Add("# de paginas", "3407 (ENG),\r\n 3665(ESP)");
novelas.Add("Protagonistas", "Harry Potter,\r\n Ron Weasley,\r\n Hermione Granger,\r\n Ginny Weasley,\r\n Neville Longbottom,\r\n Albus Dumbledore ");
novelas.Add("Antagonistas", "Lord Voldemort,\r\n Mortífagos");
novelas.Add("Argumento", "La historia comienza con la celebración del mundo mágico. \r\nDurante muchos años, había sido aterrorizado por el malvado mago Lord Voldemort. \r\nLa noche del 31 de octubre, mató a Lily y James Potter. Sin embargo, cuando intenta matar a \r\nsu hijo de 1 año, Harry, la \r\nmaldición asesina Avada \r\nKedavra se vuelve sobre sí mismo. El cuerpo de Voldemort resulta destruido, pero él \r\nsobrevive: no está muerto ni \r\nvivo. Por su parte, a Harry solo \r\nle queda una cicatriz con forma de rayo en la frente que es el \r\núnico remanente físico de la \r\nmaldición de Voldemort. Harry \r\nes el único sobreviviente de la maldición asesina, y a raíz de la \r\nmisteriosa derrota de Voldemort, \r\nel mundo mágico empieza a llamarlo como «el niño que sobrevivió».");
            foreach (var item in novelas.Keys)
            {
                novela1.Items.Add(item);

            }

//Datos de Goosebumps

novelas2.Add("Autor", "Robert Lawrence Stine");
novelas2.Add("Genero", "Ciencia Ficción,\r\n Literatura,\r\n Infantil,\r\n Suspenso");
novelas2.Add("Subgenero", "Suspenso,\r\n Terror,\r\n Juvenil");
novelas2.Add("# de paginas", "---");
novelas2.Add("Protagonistas", "El protagonista principal de una \r\nhistoria de Pesadillas / \r\nEscalofríos, es a menudo situado \r\nen una ubicación remota o de \r\nalguna manera aislada en \r\nalgunas situaciones. ");
novelas2.Add("Antagonistas", "---");
novelas2.Add("Argumento", "La serie consta de un total de 60 \r\nlibros para España, el último de \r\nlos cuales (Sangre de monstruo \r\nIV) se publicó en 1999, mientras \r\nque en Hispanoamérica consta \r\nde 45 historias. \r\nEl nombre se tradujo en España \r\ncomo Pesadillas y en \r\nHispanoamérica \r\ncomo Escalofríos.  ");
            foreach (var item in novelas2.Keys)
            {
                lista4.Items.Add(item);

            }
//Datos de Perry Mason

novelas3.Add("Autor", "Erle Stanley Gardner");
novelas3.Add("Genero", "Novela Policiaca");
novelas3.Add("Subgenero", "xx");
novelas3.Add("# de Paginas", "xx");
novelas3.Add("Protagonistas", "Perry Jackson");
novelas3.Add("Antagonistas", "xx");
novelas3.Add("Argumento", "El personaje era un abogado que \r\nllegó a aparecer en 80 novelas e \r\nhistorias cortas, la mayoría de \r\nlas cuales versaban sobre la \r\ndefensa de un cliente que había \r\nsido acusado de asesinato. En \r\ngeneral, Perry Mason era capaz \r\nde demostrar la inocencia de su \r\ncliente mediante la averiguación \r\nde la culpabilidad del verdadero \r\nasesino, otro personaje de la \r\nhistoria. ");
            foreach (var item in novelas.Keys)
            {
                    Listan.Items.Add(item);

            }
        }

        private void juanito_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void juanita_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void BOX2_TextChanged(object sender, EventArgs e)
        {
           
      
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = novela1.Text;
            for (int i = 0; i < novelas.Count; i++)
            {
                var item = novelas.ElementAt(i);
                if (buscar == item.Key)
                {
                    juanito.Text = item.Value;
                    break;
                }
            }
        }

        private void lista4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lista4.Text;
            for (int i = 0; i < novelas3.Count; i++)
            {
                var item = novelas3.ElementAt(i);
                if (buscar == item.Key)
                {
                    juanita.Text = item.Value;
                    break;
                }
            }
        }

        private void Listan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = Listan.Text;
            for (int i = 0; i < novelas3.Count; i++)
            {
                var item = novelas.ElementAt(i);
                if (buscar == item.Key)
                {
                    BOX2.Text = item.Value;
                    break;
                }
            }
        }
    }

    }
    

