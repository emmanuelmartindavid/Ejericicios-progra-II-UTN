using Logic;
using Machine;
using Machine.Properties;

namespace ExpendingBooks
{
    public partial class FrmVending : Form
    {
        private ExpendingMachine machine = new();
        private PictureBoxManager pbManager;
        FrmQueueClients frmQueueClients = new();


        public FrmVending()
        {
            frmQueueClients.ShowDialog();
            InitializeComponent();
            lblClientName_Click(null, null);
            btnFinishBuy_Click(null, null);
            pbManager = new(pb_lays, pb_doritos, pb_pringles, pb_pepsi, pb_coca, pb_water,
                                                  pb_kinder, pb_kat, pb_oreo);
        }

        private void FrmVending_Load(object sender, EventArgs e)
        {

        }
        private void btn_1_Click(object sender, EventArgs e)
        {

            txb_codeInfo.Text += "1";

        }

        private void btn_2_Click(object sender, EventArgs e)
        {

            txb_codeInfo.Text += "2";

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txb_codeInfo.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txb_codeInfo.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txb_codeInfo.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txb_codeInfo.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txb_codeInfo.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txb_codeInfo.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txb_codeInfo.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txb_codeInfo.Text += "0";
        }



        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                ImageHelper.RemoveImagesForEmptyProducts(machine.Products, pbManager.PictureBoxes, int.Parse(txb_codeInfo.Text));
                rtxt_message.Text = Input.ShowProduct(machine.Products, int.Parse(txb_codeInfo.Text));
                Input.RemoveProduct(machine.Products, int.Parse(txb_codeInfo.Text));
            }
            catch (Exception)
            {
                rtxt_message.Text = "No se pudo realizar la operación. Ingrese una opcion valida!";
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            txb_codeInfo.Clear();
        }

        private void lblClientName_Click(object sender, EventArgs e)
        {
            int amountClient = frmQueueClients.clientQueue.Count;

            string clientName = frmQueueClients.clientQueue.Peek();

            lblClientName.Text = $"{clientName}. Cantidad en fila: {amountClient}";
        }

        private void btnFinishBuy_Click(object sender, EventArgs e)
        {
            int amountClient = frmQueueClients.clientQueue.Count;
            if (amountClient > 0)
            {
                string clientName = frmQueueClients.clientQueue.Dequeue();
                amountClient = frmQueueClients.clientQueue.Count;
                lblClientName.Text = $"{clientName}. Cantidad en fila: {amountClient}";
            }
            else
            {
                lblClientName.Text = "No hay mas clientes en la fila";

            }

        }

    }
}