namespace UI
{
    public partial class Form1 : Form
    {
        public Dictionary<string, int> dictionary = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateWords_Click(object sender, EventArgs e)
        {
            string text = rtbWords.Text;
            dictionary = Logic.HandlerWord.AddWordsToDictionary(text);
            string words = Logic.HandlerWord.ShowTopNWordsByFrequency(dictionary, 3);
            MessageBox.Show(words.ToString(), "Cantidad de Palabras");

        }
    }
}