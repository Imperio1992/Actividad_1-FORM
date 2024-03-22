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

namespace Actividad_1
{
    public partial class Expediente_Alumno : Form
    {
        private string nombreCompleto;
        private DateTime fechaNacimiento;
        private string direccion;
        private string[] estados = { "Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "CDMX", "Coahuila",
            "Colima", "Chiapas", "Chihuahua", "Durango", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "México", "Michoacán",
            "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa",
            "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas" };
        private bool esMatutino;

        public Expediente_Alumno()
        {
            InitializeComponent();
        }

        private void Nombre_Completo_TextChanged(object sender, EventArgs e)
        {
            nombreCompleto = Nombre_Completo.Text;
        }

        private void Fecha_Nacimiento_TextChanged(object sender, EventArgs e)
        {
            // No es necesario implementar lógica aquí, ya que se captura el valor en el evento ValueChanged del DateTimePicker
        }

        private void Direccion_TextChanged(object sender, EventArgs e)
        {
            direccion = Direccion.Text;
        }

        private void Estados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Estados.SelectedIndex;
            if (index >= 0 && index < estados.Length)
            {
                string estadoSeleccionado = estados[index];
                MessageBox.Show("Has seleccionado: " + estadoSeleccionado);
            }
        }

        private void Matutino_CheckedChanged(object sender, EventArgs e)
        {
            esMatutino = Matutino.Checked;
        }

        private void Vespertino_CheckedChanged(object sender, EventArgs e)
        {
            esMatutino = !Vespertino.Checked;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string horario = esMatutino ? "Matutino" : "Vespertino";

            MessageBox.Show("GRACIAS POR INGRESAR LOS DATOS, BIENVENIDO A UMI");

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar datos, cargar configuraciones, etc. si es necesario.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        // Especifica la URL que deseas abrir en el navegador
        string url = "https://umi.edu.mx/coppel/IDS/login/index.php";

        // Abre la URL en el navegador predeterminado del sistema
        Process.Start(url);
        }

    }
}