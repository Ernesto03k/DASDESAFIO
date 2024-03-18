using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Actividad
{
    public partial class Form2 : Form
    {
      
   public string[] usuarios =

    {

            "pablo", "Wilber", "Rocky", "Kike", "Elva"
        };

    public Dictionary<string, string>

     password = new Dictionary<string, string>

     {
            {"pablo", "pablo123" },
            {"Wilber", "Wilber123" },
            {"Rocky", "Rocky123" },
            {"Kike", "Kike123" },
            {"Elva", "Elva123" },
      };
        public Form2()
        {
            InitializeComponent();
        }
        private void btningresar_Click(object sender, EventArgs e)
        {
            {
               
               string usuario  = txtusuario.Text;
               string contraseña = txtcontraseña.Text;

                // if (usuario == "pablo" && contraseña == "1234") ;
                if (Array.IndexOf(usuarios, usuario) > -1 &&
                     password.ContainsKey(usuario) &&
                     password[usuario] == contraseña)
                {
                    Form3 enlace = new Form3();
                    enlace.Show();
                    this.Close();

                }
                else {
                    MessageBox.Show("contraseña Erronea");
                    txtusuario.Clear();
                    txtcontraseña.Clear();
                }

            } 
        } 
    }
}
