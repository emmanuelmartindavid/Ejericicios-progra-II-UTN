namespace UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (this.tb_user.Text == "Emma" && this.tb_pass.Text == "123")
            {
               // FrmMenu menu = new FrmMenu(this.tb_user.Text);
                FrmMenu menu = new FrmMenu();

                menu.ActualizarMensaje(this.tb_user.Text);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");

                this.tb_user.Text = string.Empty;
                this.tb_pass.Text = string.Empty;
            }         
        }
    }
}