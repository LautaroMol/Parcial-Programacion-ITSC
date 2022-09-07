using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Backend
{

    public class Carga
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }
        public string Dni { get; set; }
        public string ruta = @"./registro.txt";
        public void Cargar(string nombre, string apellido, string puesto, string dni)
        {
            string empleado;
            empleado = "dni: " + dni + ".  " + nombre + "  " + apellido + ".  puesto: " + puesto;
            if (File.Exists(ruta))
            {
                StreamWriter registro = File.AppendText("registro.txt");
                registro.WriteLine(empleado);
                registro.Close();
                empleado = "";
            }
            else
            {
                TextWriter registro;
                registro = new StreamWriter("registro.txt");
                registro.WriteLine(empleado);
                registro.Close();
                empleado = "";
            }

        }

        public void Borrar()
        {
            File.Delete(ruta);
        }


        public static void Guardar(string texto)
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete("registro.txt");
            TextWriter datos;
            datos = new StreamWriter("registro.txt");
            datos.Write(texto);
            datos.Close();
        }

        /// <summary>
        /// Realiza la busqueda
        /// </summary>
        /// <param name="dni"> +  o - o * o /</param>
        /// <returns></returns>
        public static string Mostrar()
        {
            string texto;
            TextReader datos;
            datos = new StreamReader("registro.txt");
            texto = datos.ReadToEnd();
            return texto;
            datos.Close();
        }

        public static string Contar()
        {
            int num = 0;
            StringBuilder cadena = new StringBuilder();
            using (StreamReader sr = new StreamReader("./registro.txt"))
            {
                while (!sr.EndOfStream)
                {
                    cadena.Append(sr.ReadLine());

                    num++;
                }
            }
            return num.ToString();
        }
    }
}