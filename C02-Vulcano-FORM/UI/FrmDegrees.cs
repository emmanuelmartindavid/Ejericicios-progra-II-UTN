using Logic;

namespace UI
{
    public partial class FrmDegrees : Form
    {
        Celsius celsius;
        Fahrenheit fahrenheit;
        Kelvin kelvin;

        public FrmDegrees()
        {
            InitializeComponent();

        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                fahrenheit = decimal.Parse(txtFahrenheitInput.Text);
                celsius = (Celsius)fahrenheit;
                kelvin = (Kelvin)fahrenheit;

                txtFahrenheit.Text = fahrenheit.FahrenheitDegree.ToString();
                txtFahrenheitToCelsius.Text = celsius.CelsiusDegree.ToString("0.000");
                txtFahrenheitToKelvin.Text = kelvin.KelvinDegree.ToString("0.000");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            try
            {
                celsius = InputDegreeValidator.ConvertInputDegreeToDecimal(txtCelsiusInput.Text);
                fahrenheit = (Fahrenheit)celsius;
                kelvin = (Kelvin)celsius;

                txtCelsius.Text = celsius.CelsiusDegree.ToString();
                txtCelsiusToFahrenheit.Text = fahrenheit.FahrenheitDegree.ToString("0.000");
                txtCelsiusToKelvin.Text = kelvin.KelvinDegree.ToString("0.000");


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            try
            {
                kelvin = decimal.Parse(txtKelvinInput.Text);
                celsius = (Celsius)kelvin;
                fahrenheit = (Fahrenheit)kelvin;

                txtKelvin.Text = kelvin.KelvinDegree.ToString();
                txtKelvinToCelsius.Text = celsius.CelsiusDegree.ToString("0.000");
                txtKelvinToFahrenheit.Text = fahrenheit.FahrenheitDegree.ToString("0.000");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}