
using UI.Classes;

namespace UI
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {

            lb_saludo.Text = "HOLA";
            var nombre = txb_saluda.Text;
            lb_saludo.Text = "HOLA" + nombre;
        }

     

        private void cargarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formPersona = new FrmPersona();

            if (formPersona.ShowDialog() == DialogResult.OK)
            {
                // tengo que recibir persona
                string nombre = formPersona.Person.ToString();

                MessageBox.Show(Text, nombre);

            }
            else
            {
                MessageBox.Show("sali mal");
            }

        }
    }
}