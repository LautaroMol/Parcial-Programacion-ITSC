using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using trabajo;


namespace frontend
{
    public partial class Modificar : Form
    {
        string ruta = @"./registro.txt";
        public Modificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(ruta))
            {
                txtdat.Text = Carga.Mostrar();
            }
            else
            {
                MessageBox.Show("no existe el archivo");
            }
       }

        private void btngr_Click(object sender, EventArgs e)
        {
            Carga.Guardar(txtdat.Text);
            MessageBox.Show("archivo sobreescrito");
        }

        private void btnvol_Click(object sender, EventArgs e)
        {
            Inicio form1 = new Inicio();
            form1.Show();
            this.Close();
        }
    }
}
