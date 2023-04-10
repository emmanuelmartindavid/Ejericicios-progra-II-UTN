namespace UI
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Login = new Button();
            tb_user = new TextBox();
            tb_pass = new TextBox();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(289, 264);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(158, 42);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // tb_user
            // 
            tb_user.Location = new Point(289, 107);
            tb_user.Name = "tb_user";
            tb_user.PlaceholderText = "Ingrese usuario";
            tb_user.Size = new Size(158, 23);
            tb_user.TabIndex = 1;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(289, 186);
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.PlaceholderText = "Ingrese password";
            tb_pass.Size = new Size(158, 23);
            tb_pass.TabIndex = 2;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_pass);
            Controls.Add(tb_user);
            Controls.Add(btn_Login);
            Name = "FrmLogin";
            Text = "Formulario Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private TextBox tb_user;
        private TextBox tb_pass;
    }
}