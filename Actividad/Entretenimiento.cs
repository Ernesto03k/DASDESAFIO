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
    public partial class Entretenimiento : Form
    {
      
Dictionary<string, string> Entre = new Dictionary<string, string>();
Dictionary<string, string> Cher = new Dictionary<string, string>();
        Dictionary<string, string> Marvelus = new Dictionary<string, string>();
        public Entretenimiento()
        {
            InitializeComponent();
        }

      

        private void Entretenimiento_Load(object sender, EventArgs e)
        {
             //Datos de Game Of Thrones
Entre.Add("Título en Español", "Juego de Tronos ");
Entre.Add("Creado por", "David Benioff D.B. Weiss");
Entre.Add("Protagonistas", "Sean Bean,\r\n Nicolaj Coster-Waldau,\r\n Peter Dinklage,\r\n Emilia Clark,\r\n Lena Headey,\r\n Ian Glen,\r\n Kit Harintong,\r\n Sophie Turner,\r\n Maisie Williams,\r\n Isaac Hemstead-Wright,\r\n Natalie Dormer");
Entre.Add("País de Origen", "Estados Unidos");
Entre.Add("Temporadas", "8");
Entre.Add("Episodios", "73");
Entre.Add("Sinopsis", "La trama de Game of \r\nThrones está basada en la serie \r\nde novelas Canción de hielo y \r\nfuego, y relata las vivencias de \r\nun grupo de personajes de \r\ndistintas casas nobiliarias en el \r\ncontinente ficticio Poniente para \r\ntener el control del Trono de \r\nHierro y gobernar los siete \r\nreinos que conforman el \r\nterritorio");
            foreach (var item in Entre.Keys)
            {
                Lista1.Items.Add(item);

            }

  //Datos de Chernobyl
Cher.Add("Título en Español", "Chernóbyl");
Cher.Add("Creado por", "Craig Mazin");
Cher.Add("Protagonistas", "Jared Harris\r\n, Stellan Skarsgard\r\n Emily Watson");
Cher.Add("País de Origen", "Estados Unidos\r, Reino Unido");
Cher.Add("Temporadas", "1");
Cher.Add("Episodios", "5");
Cher.Add("Sinopsis", "La serie gira en torno al desastre nuclear de Chernóbil de abril de \r\n1986 y los esfuerzos de limpieza \r\nsin precedentes que siguieron. \r\nCuenta con un reparto \r\nencabezado por Jared Harris, \r\nStellan Skarsgård y Emily \r\nWatson.");
            foreach (var item in Cher.Keys)
            {
                Lista2.Items.Add(item);

            }

//Datos de THE MARVELOUS MRS.MAISEL
Marvelus.Add("Titulo", "La maravillosa Señora Maisel");
Marvelus.Add("Creado por", "Amy Sherman-Paladino");
Marvelus.Add("Protagonistas", "Rachel Brosnaham,\r\n Micheal Zegen,\r\n Alex Borstein,\r\n Tony Shalhoub, Marin Hinkle");
Marvelus.Add("País de Origen", "Estados Unidos");
Marvelus.Add("Temporadas", "3");
Marvelus.Add("Episodios", "26");
Marvelus.Add("Sinopsis", "La serie cuenta la historia de un \r\nama de casa en Nueva York que \r\ndescubre que tiene una habilidad \r\nespecial para la comedia en vivo. \r\nEl primer episodio se estrenó \r\ncomo parte de la temporada de \r\npilotos de primavera de Amazon \r\nStudios el 17 de marzo de 2017, \r\nrecibiendo la aclamación de la \r\ncrítica.");
            foreach (var item in Marvelus .Keys)
            {
                Lista3.Items.Add(item);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = Lista1.Text;
            for (int i = 0; i < Entre.Count; i++)
            {
                var item = Entre.ElementAt(i);
                if (buscar == item.Key)
                {
                    Box1.Text = item.Value;
                    break;
                }
            }
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Lista2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = Lista2.Text;
            for (int i = 0; i < Cher.Count; i++)
            {
                var item = Cher.ElementAt(i);
                if (buscar == item.Key)
                {
                    Cuadro2.Text = item.Value;
                    break;
                }
            }
        }

        private void Lista3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = Lista3.Text;
            for (int i = 0; i < Marvelus.Count; i++)
            {
                var item = Marvelus.ElementAt(i);
                if (buscar == item.Key)
                {
                    Box3.Text = item.Value;
                    break;
                }
            }
        }

        private void Box3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
