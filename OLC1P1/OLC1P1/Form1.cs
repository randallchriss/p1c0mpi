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

            TabPage t = new TabPage();
            tabsArray.Add(t);
            t.Controls.Add(txtContenido);
            tabControl1.TabPages.Add(t);
            pestaniaActiva = tabControl1.SelectedIndex;

            hayPestania = true;
            int cantidadTabs = tabsArray.Count;

            
        }
    }
}
