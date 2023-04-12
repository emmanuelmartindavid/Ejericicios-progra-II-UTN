namespace UI
{
    partial class FrmPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_saludo = new Label();
            txb_legajo = new TextBox();
            lbl_Legajo = new Label();
            txb_name = new TextBox();
            lbl_name = new Label();
            btn_cancel = new Button();
            btn_saludo = new Button();
            SuspendLayout();
            // 
            // lbl_saludo
            // 
            lbl_saludo.AutoSize = true;
            lbl_saludo.Location = new Point(321, 80);
            lbl_saludo.Name = "lbl_saludo";
            lbl_saludo.Size = new Size(0, 15);
            lbl_saludo.TabIndex = 1;
            // 
            // txb_legajo
            // 
            txb_legajo.Location = new Point(327, 214);
            txb_legajo.Name = "txb_legajo";
            txb_legajo.PlaceholderText = "Ingrese Legajo";
            txb_legajo.Size = new Size(147, 23);
            txb_legajo.TabIndex = 4;
            // 
            // lbl_Legajo
            // 
            lbl_Legajo.AutoSize = true;
            lbl_Legajo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Legajo.Location = new Point(383, 152);
            lbl_Legajo.Name = "lbl_Legajo";
            lbl_Legajo.Size = new Size(61, 21);
            lbl_Legajo.TabIndex = 5;
            lbl_Legajo.Text = "Legajo";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(105, 214);
            txb_name.Name = "txb_name";
            txb_name.PlaceholderText = "Ingrese Nombre";
            txb_name.Size = new Size(130, 23);
            txb_name.TabIndex = 6;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(143, 138);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(73, 21);
            lbl_name.TabIndex = 7;
            lbl_name.Text = "Nombre";
            // 
            // btn_cancel
            // 
            btn_cancel.ForeColor = SystemColors.ActiveCaptionText;
            btn_cancel.Location = new Point(393, 335);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(103, 30);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_saludo
            // 
            btn_saludo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_saludo.Location = new Point(95, 336);
            btn_saludo.Name = "btn_saludo";
            btn_saludo.Size = new Size(112, 29);
            btn_saludo.TabIndex = 9;
            btn_saludo.Text = "Saludar";
            btn_saludo.UseVisualStyleBackColor = true;
            // 
            // FrmPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_saludo);
            Controls.Add(btn_cancel);
            Controls.Add(lbl_name);
            Controls.Add(txb_name);
            Controls.Add(lbl_Legajo);
            Controls.Add(txb_legajo);
            Controls.Add(lbl_saludo);
            Name = "FrmPersona";
            Text = "Saludo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_saludo;
        private TextBox txb_legajo;
        private Label lbl_Legajo;
        private TextBox txb_name;
        private Label lbl_name;
        private Button btn_cancel;
        private Button btn_saludo;
    }
}