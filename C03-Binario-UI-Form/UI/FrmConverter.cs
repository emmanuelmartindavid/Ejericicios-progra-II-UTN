using Logic;

namespace UI
{
    public partial class FrmConverter : Form
    {
        BinaryNumber? BinaryNumber;
        DecimalNumber? DecimalNumber;
        public FrmConverter()
        {
            InitializeComponent();
        }

        private void btnBinaryToDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryNumber = InputNumberValidator.GetValidatedString(txtBinaryInput.Text);
                DecimalNumber = (DecimalNumber)BinaryNumber;
                txtBinaryToDecimal.Text = DecimalNumber.number.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecimalToBinary_Click(object sender, EventArgs e)
        {
            try
            {
                DecimalNumber = InputNumberValidator.GetValidatedDecimal(txtDecimalInput.Text);
                BinaryNumber = (BinaryNumber)DecimalNumber;
                txtDecimalToBinary.Text = BinaryNumber.number;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}