using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Classes;

namespace UI
{
    public partial class FrmPersona : Form
    {
        private Person _person;

        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }
        public FrmPersona()
        {
            InitializeComponent();
        }


        private void CerrarFormulario()
        {
            //Close();
            DialogResult = DialogResult.Cancel;
        }
        private void CerrarFormulario(DialogResult dg)
        {
            //Close();
            DialogResult = dg;
        }
        private void btn_cargar_Click(object sender, EventArgs e)
        {
            // instanciamos objeto persona y cerramo formulario

            if (!String.IsNullOrEmpty(txb_name.Text) && int.TryParse(txb_legajo.Text, out int legajo))
            {
                _person = new(txb_name.Text, legajo);
                MessageBox.Show($"Nombre: {_person.FirstName} y legajo: {_person.File}");

                CerrarFormulario(DialogResult.OK);
            }
            else
            {
                MessageBox.Show("Datos mal ingresados");
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // cerramo formulario
            CerrarFormulario(DialogResult.Cancel);
        }


    }
}
