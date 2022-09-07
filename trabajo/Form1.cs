using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Backend;
using frontend;

namespace trabajo
{
    public partial class Inicio : Form
    {
        Carga carga = new Carga();
        public Inicio()
        {
            InitializeComponent();
        }
        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ruta = @"./registro.txt";
            if (txtnom.Text != "" && txtap.Text != "" && txtpuesto.Text != "" && txtdni.Text != "") 
            {
                if (File.Exists(ruta)) {
                    carga.Cargar(txtnom.Text, txtap.Text, txtpuesto.Text, txtdni.Text);
                    MessageBox.Show("empleado añadido");
                }
                else
                {
                    carga.Cargar(txtnom.Text, txtap.Text, txtpuesto.Text, txtdni.Text);
                    MessageBox.Show("empleado cargado y archivo creado");
                }
                txtnom.Text = "";
                txtdni.Text = "";
                txtap.Text = "";
                txtpuesto.Text = "";
                txtnom.Focus();
            }
            else
            {
                MessageBox.Show("por favor llene todos los campos");
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            string ruta = @"./registro.txt";
            if (File.Exists(ruta))
            {
                try
                {
                    carga.Borrar();
                    MessageBox.Show("el archivo de registro se borro exitosamente");
                }
                catch (Exception a ) {MessageBox.Show("no se pudo borrar el archivo", a.Message); }
            }
            else
            {
                MessageBox.Show("no existe el archivo");
            }
        }

        private void iramod_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Modificar modificar = new Modificar();
            modificar.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contar_Click(object sender, EventArgs e)
        {
            canttxt.Text = Carga.Contar();
        }
    }
}