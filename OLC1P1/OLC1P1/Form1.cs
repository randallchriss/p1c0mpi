using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLC1P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // variables globales
        int contador = 0;
        Boolean hayPestania = false;
        int pActiva = 0;
        public ArrayList tabsArray = new ArrayList();
        public ArrayList txtArray = new ArrayList();
        public ArrayList listaTitulos = new ArrayList();
        public ArrayList rutas = new ArrayList();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {// agregar nueva pestania en blanco
            contador++;
            int nombreTab = contador;
            int pestaniaActiva = 0;
            TextBox txtContenido = new TextBox();
            txtContenido.Multiline = true;
            txtContenido.SetBounds(0, 10, 500, 320);
            txtArray.Add(txtContenido);
            //MessageBox.Show("Cantidad en txtArray " + txtArray.Count);
            TabPage t = new TabPage();
            tabsArray.Add(t);
            t.Controls.Add(txtContenido);
            tabControl1.TabPages.Add(t);
            pestaniaActiva = tabControl1.SelectedIndex;

            hayPestania = true;
            int cantidadTabs = tabsArray.Count;


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //si hay pestania activa se abre el archivo en esa pestania
            if (hayPestania == true)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String ruta = openFileDialog1.FileName;
                    rutas.Add(ruta);
                    System.IO.StreamReader sr = new System.IO.StreamReader(ruta, System.Text.Encoding.Default);
                    string texto;
                    texto = sr.ReadToEnd();
                    sr.Close();

                    pActiva = tabControl1.SelectedIndex;
                    int infoTxtNumero = txtArray.Count;
                    MessageBox.Show("txtss: " + infoTxtNumero + " pestañas: " + pActiva);
                    TextBox txtConArchivo = (TextBox)txtArray[pActiva];
                    txtConArchivo.Text = texto;
                    txtArray[pActiva] = txtConArchivo;
                    TabPage tabActual = (TabPage)tabsArray[pActiva];

                    tabActual.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    String nombreArchivo = tabActual.Text;
                    listaTitulos.Add(nombreArchivo);

                    openFileDialog1.Dispose();

                }
                else if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    openFileDialog1.Dispose();
                }
            }
            else {
                MessageBox.Show("No hay pestañas activas, abra una nueva pestaña", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ver que pestania esta activa
        }
    }
}
