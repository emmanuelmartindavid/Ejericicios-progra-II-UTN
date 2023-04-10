namespace UI
{
    partial class FrmMenu
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
            lb_mensaje = new Label();
            SuspendLayout();
            // 
            // lb_mensaje
            // 
            lb_mensaje.AutoSize = true;
            lb_mensaje.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lb_mensaje.ForeColor = Color.Crimson;
            lb_mensaje.Location = new Point(151, 61);
            lb_mensaje.Name = "lb_mensaje";
            lb_mensaje.Size = new Size(478, 89);
            lb_mensaje.TabIndex = 0;
            lb_mensaje.Text = "Menu Principal";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_mensaje);
            Name = "FrmMenu";
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_mensaje;
    }
}