namespace C01_Cotizador_Form
{
    partial class Form1
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
            Lbl_Euro = new Label();
            Lbl_peso = new Label();
            label1 = new Label();
            Lbl_Dolar = new Label();
            label2 = new Label();
            label3 = new Label();
            Txb_EuroAmount = new TextBox();
            Txb_DolarAmount = new TextBox();
            Txb_PesoAmount = new TextBox();
            Txb_EuroShow = new TextBox();
            Txb_DolarToEuroShow = new TextBox();
            Txb_PesoToEuroShow = new TextBox();
            Txb_EuroToDolarShow = new TextBox();
            Txb_DolarShow = new TextBox();
            Txb_PesoToDolarShow = new TextBox();
            Txb_EuroToPesoShow = new TextBox();
            Txb_PesoShow = new TextBox();
            Txb_DolarToPesoShow = new TextBox();
            Lbl_Cotizacion = new Label();
            Txb_EditRatePeso = new TextBox();
            Txb_EditRateDolar = new TextBox();
            Txb_EditRateEuro = new TextBox();
            Btn_DolarConvertion = new Button();
            Btn_PesoConvertion = new Button();
            Btn_EuroConvertion = new Button();
            Btn_Padlock = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.38318F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.61682F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143F));
            tableLayoutPanel1.Controls.Add(Lbl_Euro, 0, 2);
            tableLayoutPanel1.Controls.Add(Lbl_peso, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 3, 1);
            tableLayoutPanel1.Controls.Add(Lbl_Dolar, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 4, 1);
            tableLayoutPanel1.Controls.Add(label3, 5, 1);
            tableLayoutPanel1.Controls.Add(Txb_EuroAmount, 1, 2);
            tableLayoutPanel1.Controls.Add(Txb_DolarAmount, 1, 3);
            tableLayoutPanel1.Controls.Add(Txb_PesoAmount, 1, 4);
            tableLayoutPanel1.Controls.Add(Txb_EuroShow, 3, 2);
            tableLayoutPanel1.Controls.Add(Txb_DolarToEuroShow, 3, 3);
            tableLayoutPanel1.Controls.Add(Txb_PesoToEuroShow, 3, 4);
            tableLayoutPanel1.Controls.Add(Txb_EuroToDolarShow, 4, 2);
            tableLayoutPanel1.Controls.Add(Txb_DolarShow, 4, 3);
            tableLayoutPanel1.Controls.Add(Txb_PesoToDolarShow, 4, 4);
            tableLayoutPanel1.Controls.Add(Txb_EuroToPesoShow, 5, 2);
            tableLayoutPanel1.Controls.Add(Txb_PesoShow, 5, 4);
            tableLayoutPanel1.Controls.Add(Txb_DolarToPesoShow, 5, 3);
            tableLayoutPanel1.Controls.Add(Lbl_Cotizacion, 1, 0);
            tableLayoutPanel1.Controls.Add(Txb_EditRatePeso, 5, 0);
            tableLayoutPanel1.Controls.Add(Txb_EditRateDolar, 4, 0);
            tableLayoutPanel1.Controls.Add(Txb_EditRateEuro, 3, 0);
            tableLayoutPanel1.Controls.Add(Btn_DolarConvertion, 2, 3);
            tableLayoutPanel1.Controls.Add(Btn_PesoConvertion, 2, 4);
            tableLayoutPanel1.Controls.Add(Btn_EuroConvertion, 2, 2);
            tableLayoutPanel1.Controls.Add(Btn_Padlock, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.90625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.09375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(919, 335);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Lbl_Euro
            // 
            Lbl_Euro.AutoSize = true;
            Lbl_Euro.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Euro.Location = new Point(3, 128);
            Lbl_Euro.Name = "Lbl_Euro";
            Lbl_Euro.Size = new Size(55, 28);
            Lbl_Euro.TabIndex = 0;
            Lbl_Euro.Text = "Euro";
            // 
            // Lbl_peso
            // 
            Lbl_peso.AllowDrop = true;
            Lbl_peso.AutoSize = true;
            Lbl_peso.Enabled = false;
            Lbl_peso.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_peso.Location = new Point(3, 257);
            Lbl_peso.Name = "Lbl_peso";
            Lbl_peso.Size = new Size(55, 28);
            Lbl_peso.TabIndex = 2;
            Lbl_peso.Text = "Peso";
            Lbl_peso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(470, 69);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 4;
            label1.Text = "Euro";
            // 
            // Lbl_Dolar
            // 
            Lbl_Dolar.AutoSize = true;
            Lbl_Dolar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Dolar.Location = new Point(3, 192);
            Lbl_Dolar.Name = "Lbl_Dolar";
            Lbl_Dolar.Size = new Size(64, 28);
            Lbl_Dolar.TabIndex = 1;
            Lbl_Dolar.Text = "Dolar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(621, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 5;
            label2.Text = "Dolar";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(778, 69);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 6;
            label3.Text = "Peso";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txb_EuroAmount
            // 
            Txb_EuroAmount.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_EuroAmount.Location = new Point(119, 131);
            Txb_EuroAmount.Multiline = true;
            Txb_EuroAmount.Name = "Txb_EuroAmount";
            Txb_EuroAmount.Size = new Size(189, 25);
            Txb_EuroAmount.TabIndex = 7;
            // 
            // Txb_DolarAmount
            // 
            Txb_DolarAmount.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_DolarAmount.Location = new Point(119, 195);
            Txb_DolarAmount.Multiline = true;
            Txb_DolarAmount.Name = "Txb_DolarAmount";
            Txb_DolarAmount.Size = new Size(189, 25);
            Txb_DolarAmount.TabIndex = 9;
            // 
            // Txb_PesoAmount
            // 
            Txb_PesoAmount.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_PesoAmount.Location = new Point(119, 260);
            Txb_PesoAmount.Multiline = true;
            Txb_PesoAmount.Name = "Txb_PesoAmount";
            Txb_PesoAmount.Size = new Size(189, 25);
            Txb_PesoAmount.TabIndex = 10;
            // 
            // Txb_EuroShow
            // 
            Txb_EuroShow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_EuroShow.Location = new Point(470, 131);
            Txb_EuroShow.Multiline = true;
            Txb_EuroShow.Name = "Txb_EuroShow";
            Txb_EuroShow.ReadOnly = true;
            Txb_EuroShow.Size = new Size(145, 25);
            Txb_EuroShow.TabIndex = 11;
            // 
            // Txb_DolarToEuroShow
            // 
            Txb_DolarToEuroShow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_DolarToEuroShow.Location = new Point(470, 195);
            Txb_DolarToEuroShow.Multiline = true;
            Txb_DolarToEuroShow.Name = "Txb_DolarToEuroShow";
            Txb_DolarToEuroShow.ReadOnly = true;
            Txb_DolarToEuroShow.Size = new Size(145, 25);
            Txb_DolarToEuroShow.TabIndex = 12;
            // 
            // Txb_PesoToEuroShow
            // 
            Txb_PesoToEuroShow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_PesoToEuroShow.Location = new Point(470, 260);
            Txb_PesoToEuroShow.Multiline = true;
            Txb_PesoToEuroShow.Name = "Txb_PesoToEuroShow";
            Txb_PesoToEuroShow.ReadOnly = true;
            Txb_PesoToEuroShow.Size = new Size(145, 25);
            Txb_PesoToEuroShow.TabIndex = 8;
            // 
            // Txb_EuroToDolarShow
            // 
            Txb_EuroToDolarShow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_EuroToDolarShow.Location = new Point(621, 131);
            Txb_EuroToDolarShow.Multiline = true;
            Txb_EuroToDolarShow.Name = "Txb_EuroToDolarShow";
            Txb_EuroToDolarShow.ReadOnly = true;
            Txb_EuroToDolarShow.Size = new Size(151, 25);
            Txb_EuroToDolarShow.TabIndex = 14;
            // 
            // Txb_DolarShow
            // 
            Txb_DolarShow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_DolarShow.Location = new Point(621, 195);
            Txb_DolarShow.Multiline = true;
            Txb_DolarShow.Name = "Txb_DolarShow";
            Txb_DolarShow.ReadOnly = true;
            Txb_DolarShow.Size = new Size(151, 25);
            Txb_DolarShow.TabIndex = 15;
            // 
            // Txb_PesoToDolarShow
            // 
            Txb_PesoToDolarShow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_PesoToDolarShow.Location = new Point(621, 260);
            Txb_PesoToDolarShow.Multiline = true;
            Txb_PesoToDolarShow.Name = "Txb_PesoToDolarShow";
            Txb_PesoToDolarShow.ReadOnly = true;
            Txb_PesoToDolarShow.Size = new Size(151, 25);
            Txb_PesoToDolarShow.TabIndex = 13;
            // 
            // Txb_EuroToPesoShow
            // 
            Txb_EuroToPesoShow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_EuroToPesoShow.Location = new Point(778, 131);
            Txb_EuroToPesoShow.Multiline = true;
            Txb_EuroToPesoShow.Name = "Txb_EuroToPesoShow";
            Txb_EuroToPesoShow.ReadOnly = true;
            Txb_EuroToPesoShow.Size = new Size(138, 25);
            Txb_EuroToPesoShow.TabIndex = 18;
            // 
            // Txb_PesoShow
            // 
            Txb_PesoShow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_PesoShow.Location = new Point(778, 260);
            Txb_PesoShow.Multiline = true;
            Txb_PesoShow.Name = "Txb_PesoShow";
            Txb_PesoShow.ReadOnly = true;
            Txb_PesoShow.Size = new Size(138, 25);
            Txb_PesoShow.TabIndex = 16;
            // 
            // Txb_DolarToPesoShow
            // 
            Txb_DolarToPesoShow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_DolarToPesoShow.Location = new Point(778, 195);
            Txb_DolarToPesoShow.Multiline = true;
            Txb_DolarToPesoShow.Name = "Txb_DolarToPesoShow";
            Txb_DolarToPesoShow.ReadOnly = true;
            Txb_DolarToPesoShow.Size = new Size(138, 25);
            Txb_DolarToPesoShow.TabIndex = 17;
            // 
            // Lbl_Cotizacion
            // 
            Lbl_Cotizacion.AutoSize = true;
            Lbl_Cotizacion.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Cotizacion.Location = new Point(119, 0);
            Lbl_Cotizacion.Name = "Lbl_Cotizacion";
            Lbl_Cotizacion.Size = new Size(111, 28);
            Lbl_Cotizacion.TabIndex = 3;
            Lbl_Cotizacion.Text = "Cotizacion";
            // 
            // Txb_EditRatePeso
            // 
            Txb_EditRatePeso.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_EditRatePeso.Location = new Point(778, 3);
            Txb_EditRatePeso.Multiline = true;
            Txb_EditRatePeso.Name = "Txb_EditRatePeso";
            Txb_EditRatePeso.Size = new Size(138, 25);
            Txb_EditRatePeso.TabIndex = 21;
            Txb_EditRatePeso.TextChanged += Txb_EditRatePeso_TextChanged;
            // 
            // Txb_EditRateDolar
            // 
            Txb_EditRateDolar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_EditRateDolar.Location = new Point(621, 3);
            Txb_EditRateDolar.Multiline = true;
            Txb_EditRateDolar.Name = "Txb_EditRateDolar";
            Txb_EditRateDolar.Size = new Size(151, 25);
            Txb_EditRateDolar.TabIndex = 20;
            Txb_EditRateDolar.TextChanged += Txb_EditRateDolar_TextChanged;
            // 
            // Txb_EditRateEuro
            // 
            Txb_EditRateEuro.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Txb_EditRateEuro.Location = new Point(470, 3);
            Txb_EditRateEuro.Multiline = true;
            Txb_EditRateEuro.Name = "Txb_EditRateEuro";
            Txb_EditRateEuro.Size = new Size(145, 25);
            Txb_EditRateEuro.TabIndex = 19;
            Txb_EditRateEuro.TextChanged += Txb_EditRateEuro_TextChanged;
            // 
            // Btn_DolarConvertion
            // 
            Btn_DolarConvertion.Location = new Point(314, 195);
            Btn_DolarConvertion.Name = "Btn_DolarConvertion";
            Btn_DolarConvertion.Size = new Size(150, 25);
            Btn_DolarConvertion.TabIndex = 23;
            Btn_DolarConvertion.Text = "--->";
            Btn_DolarConvertion.UseVisualStyleBackColor = true;
            Btn_DolarConvertion.Click += Btn_DolarConvertion_Click;
            // 
            // Btn_PesoConvertion
            // 
            Btn_PesoConvertion.Location = new Point(314, 260);
            Btn_PesoConvertion.Name = "Btn_PesoConvertion";
            Btn_PesoConvertion.Size = new Size(150, 25);
            Btn_PesoConvertion.TabIndex = 24;
            Btn_PesoConvertion.Text = "--->";
            Btn_PesoConvertion.UseVisualStyleBackColor = true;
            Btn_PesoConvertion.Click += Btn_PesoConvertion_Click;
            // 
            // Btn_EuroConvertion
            // 
            Btn_EuroConvertion.Location = new Point(314, 131);
            Btn_EuroConvertion.Name = "Btn_EuroConvertion";
            Btn_EuroConvertion.Size = new Size(150, 25);
            Btn_EuroConvertion.TabIndex = 22;
            Btn_EuroConvertion.Text = "--->";
            Btn_EuroConvertion.UseVisualStyleBackColor = true;
            Btn_EuroConvertion.Click += Btn_EuroConvertion_Click;
            // 
            // Btn_Padlock
            // 
            Btn_Padlock.Location = new Point(314, 3);
            Btn_Padlock.Name = "Btn_Padlock";
            Btn_Padlock.Size = new Size(41, 42);
            Btn_Padlock.TabIndex = 25;
            Btn_Padlock.UseVisualStyleBackColor = true;
            Btn_Padlock.Click += Btn_Padlock_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(933, 344);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Lbl_Dolar;
        private Label Lbl_Euro;
        private Label Lbl_peso;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Txb_EuroAmount;
        private TextBox Txb_DolarAmount;
        private TextBox Txb_PesoAmount;
        private TextBox Txb_EuroShow;
        private TextBox Txb_DolarToEuroShow;
        private TextBox Txb_PesoToEuroShow;
        private TextBox Txb_EuroToDolarShow;
        private TextBox Txb_DolarShow;
        private TextBox Txb_PesoToDolarShow;
        private TextBox Txb_EuroToPesoShow;
        private TextBox Txb_PesoShow;
        private TextBox Txb_DolarToPesoShow;
        private Label Lbl_Cotizacion;
        private TextBox Txb_EditRatePeso;
        private TextBox Txb_EditRateDolar;
        private TextBox Txb_EditRateEuro;
        private Button Btn_EuroConvertion;
        private Button Btn_DolarConvertion;
        private Button Btn_PesoConvertion;
        private Button Btn_Padlock;
    }
}