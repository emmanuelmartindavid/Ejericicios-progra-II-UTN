using C01_Cotizador_Form.Properties;
using Logic;
using System.Runtime.Versioning;

namespace C01_Cotizador_Form
{

    public partial class Form1 : Form
    {
        private bool _controlReadOnly = true;
        public Form1()
        {
            InitializeComponent();
            InitRate();
            SetStatePadLock(_controlReadOnly);
            Btn_Padlock.BackgroundImageLayout = ImageLayout.Stretch;



        }

        private void Btn_EuroConvertion_Click(object sender, EventArgs e)
        {
            int euroAmount = int.Parse(Txb_EuroAmount.Text);

            Euro euro = new(euroAmount, float.Parse(Txb_EditRateEuro.Text));
            _ = new Peso(euroAmount, float.Parse(Txb_EditRatePeso.Text));

            Dolar dolar = (Dolar)euro;

            Peso peso = (Peso)euro;

            Txb_EuroShow.Text = euro.GetAmount().ToString();
            Txb_EuroToDolarShow.Text = dolar.GetAmount().ToString();
            Txb_EuroToPesoShow.Text = peso.GetAmount().ToString();
        }

        private void Btn_DolarConvertion_Click(object sender, EventArgs e)
        {
            int dolarAmount = int.Parse(Txb_DolarAmount.Text);
            Dolar dolar = new(dolarAmount);
            _ = new Peso(dolarAmount, float.Parse(Txb_EditRatePeso.Text));
            _ = new Euro(dolarAmount, float.Parse(Txb_EditRateEuro.Text));

            Euro euro = (Euro)dolar;
            Peso peso = (Peso)euro;

            Txb_DolarShow.Text = dolar.GetAmount().ToString();
            Txb_DolarToEuroShow.Text = euro.GetAmount().ToString();
            Txb_DolarToPesoShow.Text = peso.GetAmount().ToString();

        }

        private void Btn_PesoConvertion_Click(object sender, EventArgs e)
        {
            int pesoAmount = int.Parse(Txb_PesoAmount.Text);

            Peso peso = new(pesoAmount, float.Parse(Txb_EditRatePeso.Text));
            _ = new Dolar(pesoAmount);
            _ = new Euro(pesoAmount, float.Parse(Txb_EditRateEuro.Text));

            Euro euro = (Euro)peso;
            Dolar dolar = (Dolar)euro;

            Txb_PesoToDolarShow.Text = dolar.GetAmount().ToString();
            Txb_PesoToEuroShow.Text = euro.GetAmount().ToString();
            Txb_PesoShow.Text = peso.GetAmount().ToString();


        }
        private void Btn_Padlock_Click(object sender, EventArgs e)
        {
            _controlReadOnly = !_controlReadOnly;
            SetStatePadLock(_controlReadOnly);
        }

        private void SetStatePadLock(bool value)
        {

            Txb_EditRateEuro.ReadOnly = value;
            Txb_EditRateDolar.ReadOnly = value;
            Txb_EditRatePeso.ReadOnly = value;

            var image = (Bitmap)Resources.ResourceManager.GetObject(value ? "padlock" : "padlockOpen")!;
            Btn_Padlock.BackgroundImage = image;
        }

        public void InitRate()
        {
            Txb_EditRateEuro_TextChanged(null, null);
            Txb_EditRateDolar_TextChanged(null, null);
            Txb_EditRatePeso_TextChanged(null, null);

        }

        private void Txb_EditRateEuro_TextChanged(object sender, EventArgs e)
        {
          
            if (_controlReadOnly)
            {
            
                Txb_EditRateEuro.Text = "0.89";

            }
            else
            {
                if (float.TryParse(Txb_EditRateEuro.Text, out float rate))
                {
                    Txb_EditRateEuro.Text = rate.ToString(); 
                }
              
            }


        }

        private void Txb_EditRateDolar_TextChanged(object sender, EventArgs e)
        {
            if (_controlReadOnly)
            {
                Txb_EditRateDolar.Text = "1";
            }
            else
            {
                if (float.TryParse(Txb_EditRateDolar.Text, out float rate))
                {
                    Txb_EditRateDolar.Text = rate.ToString();
                }

            }
        }

        private void Txb_EditRatePeso_TextChanged(object sender, EventArgs e)
        {
            if (_controlReadOnly)
            {
                Txb_EditRatePeso.Text = "0.023";
            }
            else
            {
                if (float.TryParse(Txb_EditRatePeso.Text, out float rate))
                {
                    Txb_EditRatePeso.Text = rate.ToString();
                }

            }

        }
    }
}