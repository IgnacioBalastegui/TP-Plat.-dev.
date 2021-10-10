using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Form2 : Form
    {

        String archivo;
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabControlPrincipal.SelectedTab = tabPageCambiarFormato;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TabControlPrincipal.SelectedTab = tabPageExtraerAudio;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabControlPrincipal.SelectedTab = tabPageRemoverAudio;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TabControlPrincipal.SelectedTab = tabPageCambiarResolucion;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TabControlPrincipal.SelectedTab = tabPageExtraerImagen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                textBoxArchivo1.Text = archivo;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string r;
                 if (textBoxArchivo1.Text.Equals(""))
                 {
                MessageBox.Show("Ingrese un archivo", "Error");
                 }else if (textBoxNuevoArchivo1.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre para el nuevo archivo", "Error");
            }

                if (comboBoxFormatos.SelectedItem.Equals("mp4"))
                {
                    r = ruta();
                    convertir(textBoxArchivo1.Text, comboBoxFormatos.SelectedItem.ToString(), r, textBoxNuevoArchivo1.Text);
                }
                else if (comboBoxFormatos.SelectedItem.Equals("avi"))
                {
                    r = ruta();
                    convertir(textBoxArchivo1.Text, comboBoxFormatos.SelectedItem.ToString(), r, textBoxNuevoArchivo1.Text);
                }
                else if (comboBoxFormatos.SelectedItem.Equals("mpeg"))
                {
                    r = ruta();
                    convertir(textBoxArchivo1.Text, comboBoxFormatos.SelectedItem.ToString(), r, textBoxNuevoArchivo1.Text);
                }
                else if (comboBoxFormatos.SelectedItem.Equals("flv"))
                {
                    r = ruta();
                    convertir(textBoxArchivo1.Text, comboBoxFormatos.SelectedItem.ToString(), r, textBoxNuevoArchivo1.Text);
                }
               /* else
                {
                    MessageBox.Show("Debe seleccionar un formato para convertir", "Error");
                }*/

        }

        public String ruta()
        {
            string rutas = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == DialogResult.OK)
            {
                folder.Description = "Guardar en";
                rutas = folder.SelectedPath;
            }
            return rutas;
        }

        public void convertir(string archivo, string formato, string ruta, string nombre)
        {
            string comando = $"/c ffmpeg -i {archivo} {ruta}\\{nombre}.{formato}";
            
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Minimized,
                Arguments = comando
            };
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }

                MessageBox.Show("Archivo convertido con exito", "Listo");
                textBoxArchivo1.Text = "";
                textBoxNuevoArchivo1.Text = "";

           
        }

        private void button8_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                textBoxArchivo2.Text = archivo;
            }
        }

        public void extraerAudio(string archivo, string formato, string ruta, string nombre)
        {
            string comando = $"/c ffmpeg -i {archivo} {ruta}\\{nombre}.{formato}";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Minimized,
                Arguments = comando
            };
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }

                MessageBox.Show("Audio extraido con exito", "Listo");
                textBoxArchivo2.Text = "";
                textBoxNuevoArchivo2.Text = "";

        }

        private void button10_Click(object sender, EventArgs e)
        {

            string r;
            if (textBoxArchivo2.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un archivo", "Error");
            }
            else if (textBoxNuevoArchivo2.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre para el nuevo archivo", "Error");
            }else
            {
                r = ruta();
                extraerAudio(textBoxArchivo2.Text, "mp3", r, textBoxNuevoArchivo2.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                textBoxArchivo3.Text = archivo;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string r;
            if (textBoxArchivo3.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un archivo", "Error");
            }
            else if (textBoxNuevoArchivo3.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre para el nuevo archivo", "Error");
            }else
            {
                r = ruta();
                remover(textBoxArchivo3.Text, "mp4", r, textBoxNuevoArchivo3.Text);
            }
        }

        public void remover(string archivo, string formato, string ruta, string nombre)
        {
            
            string comando = $"/c ffmpeg -i {archivo} -vcodec copy -an {ruta}\\{nombre}.{formato}";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Minimized,
                Arguments = comando
            };
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }

                MessageBox.Show("Audio removido con exito", "Listo");
                textBoxArchivo3.Text = "";
                textBoxNuevoArchivo3.Text = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                textBoxArchivo4.Text = archivo;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string r;
            if (textBoxArchivo4.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un archivo", "Error");
            }
            else if (textBoxAncho.Text.Equals("") || textBoxAlto.Text.Equals(""))
            {
                MessageBox.Show("Faltan parámetros para realizar el cambio", "Error");
            }
            else if (textBoxNuevoArchivo4.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre para el nuevo archivo", "Error");
            }else
            {
                r = ruta();
                cambiar(textBoxArchivo4.Text, "mp4", r, textBoxNuevoArchivo4.Text, textBoxAncho.Text, textBoxAlto.Text);
            }
        }

        public void cambiar(string archivo, string formato, string ruta, string nombre, 
            string ancho, string alto)
        {
            string comando = $"/c ffmpeg -i {archivo} -vf scale={ancho}:{alto} {ruta}\\{nombre}.{formato}";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Minimized,
                Arguments = comando
            };
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }

                MessageBox.Show("Resolucion modificada con exito", "Listo");
                textBoxArchivo4.Text = "";
                textBoxNuevoArchivo4.Text = "";
                textBoxAlto.Text = "";
                textBoxAncho.Text = "";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                textBoxArchivo5.Text = archivo;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string r;
            if (textBoxArchivo5.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un archivo", "Error");
            }
            else if (textBoxFps.Text.Equals(""))
            {
                MessageBox.Show("Faltan parametros para realizar la extracción", "Error");
            }
            else if (textBoxNuevoArchivo5.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre para el nuevo archivo", "Error");
            }else
            {
                r = ruta();
                extraerImagen(textBoxArchivo5.Text, "png", r, textBoxNuevoArchivo5.Text, textBoxFps.Text);
            }
        }

        public void extraerImagen(string archivo, string formato, string ruta, string nombre, string fps)
        {

            string comando = $"/c ffmpeg -i {archivo} -vf fps=fps={fps} {ruta}\\{nombre}-%d.{formato}";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Minimized,
                Arguments = comando
            };
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }

                MessageBox.Show("Imagenes extraidas con exito", "Listo");
                textBoxNuevoArchivo5.Text = "";
                textBoxArchivo5.Text = "";
                textBoxFps.Text = "";

        }
    }
}
