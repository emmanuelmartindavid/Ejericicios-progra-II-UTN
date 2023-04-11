namespace UI
{
    partial class FrmIngreso
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
            lbl_name = new Label();
            lbl_lastName = new Label();
            tb_name = new TextBox();
            tb_lastName = new TextBox();
            btn_saludo = new Button();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(34, 67);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(73, 21);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Nombre";
            // 
            // lbl_lastName
            // 
            lbl_lastName.AutoSize = true;
            lbl_lastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_lastName.Location = new Point(263, 67);
            lbl_lastName.Name = "lbl_lastName";
            lbl_lastName.Size = new Size(75, 21);
            lbl_lastName.TabIndex = 1;
            lbl_lastName.Text = "Apellido";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(34, 105);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "Ingrese Nombre";
            tb_name.Size = new Size(130, 23);
            tb_name.TabIndex = 2;
            // 
            // tb_lastName
            // 
            tb_lastName.Location = new Point(263, 105);
            tb_lastName.Name = "tb_lastName";
            tb_lastName.PlaceholderText = "Ingrese Apellido";
            tb_lastName.Size = new Size(147, 23);
            tb_lastName.TabIndex = 3;
            // 
            // btn_saludo
            // 
            btn_saludo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_saludo.Location = new Point(263, 184);
            btn_saludo.Name = "btn_saludo";
            btn_saludo.Size = new Size(147, 30);
            btn_saludo.TabIndex = 4;
            btn_saludo.Text = "Saludar";
            btn_saludo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 240);
            Controls.Add(btn_saludo);
            Controls.Add(tb_lastName);
            Controls.Add(tb_name);
            Controls.Add(lbl_lastName);
            Controls.Add(lbl_name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_lastName;
        private TextBox tb_name;
        private TextBox tb_lastName;
        private Button btn_saludo;
    }
}