using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;

                if (credencialesCorrectas())
                {
                    MessageBox.Show("Logueado correctamente", "Listo");
                    Form2 app = new Form2();
                    app.Show();
                    this.Hide();
                app.labelBienvenido.Text = "Bienvenido " + textBoxUsuario.Text;
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error");
                }

        }

        public bool credencialesCorrectas()
        {
            return this.textBoxUsuario.Text.Equals("ignacio") && this.textBoxContrasenia.Text.Equals("ignacio123");
        }

    }
}
