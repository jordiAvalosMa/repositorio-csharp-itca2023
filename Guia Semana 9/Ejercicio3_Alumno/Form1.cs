using System.ComponentModel;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio3_Alumno
{
    public partial class Form1 : Form
    {
        private RegistroAlumno registroAlumno = new RegistroAlumno();
        public Form1()
        {
            InitializeComponent();
            dataGridViewAlumnos.DataSource = registroAlumno.ObtenerListaAlumnos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregarAmlumnp_Click(object sender, EventArgs e)
        {
            int carnet = int.Parse(txtCarnet.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            double nota = Convert.ToDouble(txtNota.Text);
            Alumno objAlumno = new Alumno(carnet, nombre, apellido, edad, nota);
            registroAlumno.RegistrarAlumno(objAlumno);
            LimpiarCampos();
            ActualizarDataGridView();
        }
        private void LimpiarCampos()
        {
            txtCarnet.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtNota.Clear();
        }

        private void ActualizarDataGridView()
        {
            dataGridViewAlumnos.DataSource = null;
            dataGridViewAlumnos.DataSource = registroAlumno.ObtenerListaAlumnos();
        }

        private void bntPromedio_Click(object sender, EventArgs e)
        {
            double promedioGlobal = registroAlumno.CalcularPromedioGlobal();

            if (promedioGlobal > 0)
            {
                MessageBox.Show($"El promedio de calificaciones de todos los alumnos es: {promedioGlobal.ToString("F2")}");
            }
            else
            {
                MessageBox.Show("No hay alumnos registrados para calcular el promedio.");
            }
        }
    }
}