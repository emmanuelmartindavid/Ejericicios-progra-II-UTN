using Logic;

namespace Frm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_userData_Click(object sender, EventArgs e)
        {
            string name = txb_name.Text;
            string address = txb_adress.Text;
            string? gender = gb_gender.Controls.OfType<RadioButton>()
          .FirstOrDefault(rb => rb.Checked)?.Text;
            string country = lb_country.Text;
            int age = int.Parse(nud_Age.Text);
            string[] selectedCourses = gb_courses.Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text).ToArray();


            if (Validator.ValidateEntrantData(name, address, gender, country, selectedCourses, age))
            {
                // Entrant entrant = new(name, address, gender, country, selectedCourses, age);
                // MessageBox.Show(entrant.ShowDataEntrant());
                MessageBox.Show("LLENE TODOS LOS DATOS, POR FAVOR!");

            }
            else
            {
               // MessageBox.Show("LLENE TODOS LOS DATOS, POR FAVOR!");
                Entrant entrant = new(name, address, gender, country, selectedCourses, age);
                MessageBox.Show(entrant.ShowDataEntrant());
            }


        }
    }
}