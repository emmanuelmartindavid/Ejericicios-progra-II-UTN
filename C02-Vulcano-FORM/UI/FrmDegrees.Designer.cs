namespace UI
{
    partial class FrmDegrees
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblKelvinDescription = new Label();
            txtFahrenheit = new TextBox();
            txtCelsiusToFahrenheit = new TextBox();
            txtKelvinToFahrenheit = new TextBox();
            txtFahrenheitToCelsius = new TextBox();
            txtCelsius = new TextBox();
            txtKelvinToCelsius = new TextBox();
            txtFahrenheitToKelvin = new TextBox();
            txtCelsiusToKelvin = new TextBox();
            txtKelvin = new TextBox();
            lblCelsius = new Label();
            txtCelsiusInput = new TextBox();
            lblFahrenheit = new Label();
            lblKelvin = new Label();
            lblFahrenheitDescription = new Label();
            lblCelsiusDescription = new Label();
            txtFahrenheitInput = new TextBox();
            txtKelvinInput = new TextBox();
            btnFahrenheit = new Button();
            btnCelsius = new Button();
            btnKelvin = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.3846169F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6153831F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 236F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 237F));
            tableLayoutPanel1.Controls.Add(lblKelvinDescription, 5, 0);
            tableLayoutPanel1.Controls.Add(txtFahrenheit, 3, 1);
            tableLayoutPanel1.Controls.Add(txtCelsiusToFahrenheit, 3, 2);
            tableLayoutPanel1.Controls.Add(txtKelvinToFahrenheit, 3, 3);
            tableLayoutPanel1.Controls.Add(txtFahrenheitToCelsius, 4, 1);
            tableLayoutPanel1.Controls.Add(txtCelsius, 4, 2);
            tableLayoutPanel1.Controls.Add(txtKelvinToCelsius, 4, 3);
            tableLayoutPanel1.Controls.Add(txtFahrenheitToKelvin, 5, 1);
            tableLayoutPanel1.Controls.Add(txtCelsiusToKelvin, 5, 2);
            tableLayoutPanel1.Controls.Add(txtKelvin, 5, 3);
            tableLayoutPanel1.Controls.Add(lblCelsius, 0, 2);
            tableLayoutPanel1.Controls.Add(txtCelsiusInput, 1, 2);
            tableLayoutPanel1.Controls.Add(lblFahrenheit, 0, 1);
            tableLayoutPanel1.Controls.Add(lblKelvin, 0, 3);
            tableLayoutPanel1.Controls.Add(lblFahrenheitDescription, 3, 0);
            tableLayoutPanel1.Controls.Add(lblCelsiusDescription, 4, 0);
            tableLayoutPanel1.Controls.Add(txtFahrenheitInput, 1, 1);
            tableLayoutPanel1.Controls.Add(txtKelvinInput, 1, 3);
            tableLayoutPanel1.Controls.Add(btnFahrenheit, 2, 1);
            tableLayoutPanel1.Controls.Add(btnCelsius, 2, 2);
            tableLayoutPanel1.Controls.Add(btnKelvin, 2, 3);
            tableLayoutPanel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2163734F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7836266F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(1315, 299);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblKelvinDescription
            // 
            lblKelvinDescription.Anchor = AnchorStyles.None;
            lblKelvinDescription.AutoSize = true;
            lblKelvinDescription.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblKelvinDescription.Location = new Point(1167, 30);
            lblKelvinDescription.Name = "lblKelvinDescription";
            lblKelvinDescription.Size = new Size(58, 25);
            lblKelvinDescription.TabIndex = 3;
            lblKelvinDescription.Text = "Kelvin";
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Anchor = AnchorStyles.None;
            txtFahrenheit.Location = new Point(619, 106);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.ReadOnly = true;
            txtFahrenheit.Size = new Size(230, 31);
            txtFahrenheit.TabIndex = 7;
            // 
            // txtCelsiusToFahrenheit
            // 
            txtCelsiusToFahrenheit.Anchor = AnchorStyles.None;
            txtCelsiusToFahrenheit.Location = new Point(619, 178);
            txtCelsiusToFahrenheit.Name = "txtCelsiusToFahrenheit";
            txtCelsiusToFahrenheit.ReadOnly = true;
            txtCelsiusToFahrenheit.Size = new Size(230, 31);
            txtCelsiusToFahrenheit.TabIndex = 10;
            // 
            // txtKelvinToFahrenheit
            // 
            txtKelvinToFahrenheit.Anchor = AnchorStyles.None;
            txtKelvinToFahrenheit.Location = new Point(619, 248);
            txtKelvinToFahrenheit.Name = "txtKelvinToFahrenheit";
            txtKelvinToFahrenheit.ReadOnly = true;
            txtKelvinToFahrenheit.Size = new Size(230, 31);
            txtKelvinToFahrenheit.TabIndex = 11;
            // 
            // txtFahrenheitToCelsius
            // 
            txtFahrenheitToCelsius.Anchor = AnchorStyles.None;
            txtFahrenheitToCelsius.Location = new Point(855, 106);
            txtFahrenheitToCelsius.Name = "txtFahrenheitToCelsius";
            txtFahrenheitToCelsius.ReadOnly = true;
            txtFahrenheitToCelsius.Size = new Size(219, 31);
            txtFahrenheitToCelsius.TabIndex = 12;
            // 
            // txtCelsius
            // 
            txtCelsius.Anchor = AnchorStyles.None;
            txtCelsius.Location = new Point(855, 178);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.ReadOnly = true;
            txtCelsius.Size = new Size(219, 31);
            txtCelsius.TabIndex = 13;
            // 
            // txtKelvinToCelsius
            // 
            txtKelvinToCelsius.Anchor = AnchorStyles.None;
            txtKelvinToCelsius.Location = new Point(855, 248);
            txtKelvinToCelsius.Name = "txtKelvinToCelsius";
            txtKelvinToCelsius.ReadOnly = true;
            txtKelvinToCelsius.Size = new Size(219, 31);
            txtKelvinToCelsius.TabIndex = 14;
            // 
            // txtFahrenheitToKelvin
            // 
            txtFahrenheitToKelvin.Anchor = AnchorStyles.None;
            txtFahrenheitToKelvin.Location = new Point(1080, 106);
            txtFahrenheitToKelvin.Name = "txtFahrenheitToKelvin";
            txtFahrenheitToKelvin.ReadOnly = true;
            txtFahrenheitToKelvin.Size = new Size(232, 31);
            txtFahrenheitToKelvin.TabIndex = 15;
            // 
            // txtCelsiusToKelvin
            // 
            txtCelsiusToKelvin.Anchor = AnchorStyles.None;
            txtCelsiusToKelvin.Location = new Point(1080, 178);
            txtCelsiusToKelvin.Name = "txtCelsiusToKelvin";
            txtCelsiusToKelvin.ReadOnly = true;
            txtCelsiusToKelvin.Size = new Size(232, 31);
            txtCelsiusToKelvin.TabIndex = 16;
            // 
            // txtKelvin
            // 
            txtKelvin.Anchor = AnchorStyles.None;
            txtKelvin.Location = new Point(1080, 248);
            txtKelvin.Name = "txtKelvin";
            txtKelvin.ReadOnly = true;
            txtKelvin.Size = new Size(232, 31);
            txtKelvin.TabIndex = 17;
            // 
            // lblCelsius
            // 
            lblCelsius.Anchor = AnchorStyles.None;
            lblCelsius.AutoSize = true;
            lblCelsius.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblCelsius.Location = new Point(62, 181);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.Size = new Size(66, 25);
            lblCelsius.TabIndex = 1;
            lblCelsius.Text = "Celsius";
            // 
            // txtCelsiusInput
            // 
            txtCelsiusInput.Anchor = AnchorStyles.None;
            txtCelsiusInput.Location = new Point(194, 178);
            txtCelsiusInput.Name = "txtCelsiusInput";
            txtCelsiusInput.Size = new Size(223, 31);
            txtCelsiusInput.TabIndex = 6;
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.Anchor = AnchorStyles.None;
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFahrenheit.Location = new Point(49, 109);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(93, 25);
            lblFahrenheit.TabIndex = 0;
            lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblKelvin
            // 
            lblKelvin.Anchor = AnchorStyles.None;
            lblKelvin.AutoSize = true;
            lblKelvin.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblKelvin.Location = new Point(66, 251);
            lblKelvin.Name = "lblKelvin";
            lblKelvin.Size = new Size(58, 25);
            lblKelvin.TabIndex = 2;
            lblKelvin.Text = "Kelvin";
            // 
            // lblFahrenheitDescription
            // 
            lblFahrenheitDescription.Anchor = AnchorStyles.None;
            lblFahrenheitDescription.AutoSize = true;
            lblFahrenheitDescription.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFahrenheitDescription.Location = new Point(687, 30);
            lblFahrenheitDescription.Name = "lblFahrenheitDescription";
            lblFahrenheitDescription.Size = new Size(93, 25);
            lblFahrenheitDescription.TabIndex = 5;
            lblFahrenheitDescription.Text = "Fahrenheit";
            // 
            // lblCelsiusDescription
            // 
            lblCelsiusDescription.Anchor = AnchorStyles.None;
            lblCelsiusDescription.AutoSize = true;
            lblCelsiusDescription.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblCelsiusDescription.Location = new Point(931, 30);
            lblCelsiusDescription.Name = "lblCelsiusDescription";
            lblCelsiusDescription.Size = new Size(66, 25);
            lblCelsiusDescription.TabIndex = 4;
            lblCelsiusDescription.Text = "Celsius";
            // 
            // txtFahrenheitInput
            // 
            txtFahrenheitInput.Anchor = AnchorStyles.None;
            txtFahrenheitInput.Location = new Point(194, 106);
            txtFahrenheitInput.Name = "txtFahrenheitInput";
            txtFahrenheitInput.Size = new Size(223, 31);
            txtFahrenheitInput.TabIndex = 8;
            // 
            // txtKelvinInput
            // 
            txtKelvinInput.Anchor = AnchorStyles.None;
            txtKelvinInput.Location = new Point(194, 248);
            txtKelvinInput.Name = "txtKelvinInput";
            txtKelvinInput.Size = new Size(223, 31);
            txtKelvinInput.TabIndex = 9;
            // 
            // btnFahrenheit
            // 
            btnFahrenheit.Anchor = AnchorStyles.None;
            btnFahrenheit.Location = new Point(423, 108);
            btnFahrenheit.Name = "btnFahrenheit";
            btnFahrenheit.Size = new Size(190, 28);
            btnFahrenheit.TabIndex = 18;
            btnFahrenheit.Text = "-->";
            btnFahrenheit.UseVisualStyleBackColor = true;
            btnFahrenheit.Click += btnFahrenheit_Click;
            // 
            // btnCelsius
            // 
            btnCelsius.Anchor = AnchorStyles.None;
            btnCelsius.Location = new Point(423, 180);
            btnCelsius.Name = "btnCelsius";
            btnCelsius.Size = new Size(190, 27);
            btnCelsius.TabIndex = 20;
            btnCelsius.Text = "-->";
            btnCelsius.UseVisualStyleBackColor = true;
            btnCelsius.Click += btnCelsius_Click;
            // 
            // btnKelvin
            // 
            btnKelvin.Anchor = AnchorStyles.None;
            btnKelvin.Location = new Point(424, 250);
            btnKelvin.Name = "btnKelvin";
            btnKelvin.Size = new Size(188, 27);
            btnKelvin.TabIndex = 19;
            btnKelvin.Text = "-->";
            btnKelvin.UseVisualStyleBackColor = true;
            btnKelvin.Click += btnKelvin_Click;
            // 
            // FrmDegrees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 298);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmDegrees";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblFahrenheit;
        private Label lblCelsius;
        private Label lblKelvin;
        private Label lblFahrenheitDescription;
        private Label lblCelsiusDescription;
        private Label lblKelvinDescription;
        private TextBox txtCelsiusInput;
        private TextBox txtFahrenheitInput;
        private TextBox txtKelvinInput;
        private TextBox txtFahrenheit;
        private TextBox txtCelsiusToFahrenheit;
        private TextBox txtKelvinToFahrenheit;
        private TextBox txtFahrenheitToCelsius;
        private TextBox txtCelsius;
        private TextBox txtKelvinToCelsius;
        private TextBox txtFahrenheitToKelvin;
        private TextBox txtCelsiusToKelvin;
        private TextBox txtKelvin;
        private Button btnFahrenheit;
        private Button btnCelsius;
        private Button btnKelvin;
    }
}