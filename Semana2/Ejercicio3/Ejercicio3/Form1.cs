// Ingresar los datos desde los textBox y mostrarlos en cuadro de dialogo. Usar el botón “Aceptar”.
//Tomar el ejercicio 1, pero los datos deben ser ingresados también en un cuadro de diálogo.
//Usando el botón “Cálculo” solicitar con un cuadro de diálogo el ingreso de dos números
//(es un cuadro de dialogo para cada dato) y mostrar cuál es el número más grande.
//La forma de declaración, lectura de datos numéricos y uso de condicional lo viste en la semana 1
//y lo ejercitaste desde el modo consola. Simplemente debes adaptarlo a este nuevo modo.


using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio3
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void txtDato1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDato2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El DATO 1 es :" + txtDato1.Text + " y el DATO 2 es :"
                + txtDato2.Text, "DATOS DESDE TextBox",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            string datoUno;
            string datoDos;

            datoUno = Convert.ToString
            (Microsoft.VisualBasic.Interaction.InputBox("Ingresar el valor del DATO 1", "PRIMER DATO", "ingrese aqui"));
            datoDos = Convert.ToString
            (Microsoft.VisualBasic.Interaction.InputBox("Ingresar elvalor del DATO 2", "SEGUNDO DATO", "ingrese aqui"));

            MessageBox.Show("El DATO 1 es:-->> " + datoUno + " y el DATO es: -->> " + datoDos,
            "DATOS DESDE CUADRO DE DIALOGO",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
         

            int datoUno = Convert.ToInt32
            (Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero", "PRIMER NUMERO", "Ingrese ->"));
            int datoDos = Convert.ToInt32
            (Microsoft.VisualBasic.Interaction.InputBox("Ingrese el segundo numero", "SEGUNDO NUMERO", "Ingrese ->"));

            if (datoUno>datoDos)
            {
                MessageBox.Show("El PRIMER numero es MAYOR", "NUMERO MAYOR", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El SEGUNDO numero es MAYOR", "NUMERO MAYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
