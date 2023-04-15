namespace UI
{
    partial class FrmConverter
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
            btnDecimalToBinary = new Button();
            lblBinaryToDecimal = new Label();
            lblDecimalToBinary = new Label();
            txtDecimalInput = new TextBox();
            txtBinaryInput = new TextBox();
            txtBinaryToDecimal = new TextBox();
            txtDecimalToBinary = new TextBox();
            btnBinaryToDecimal = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.31933F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.68067F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 193F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 247F));
            tableLayoutPanel1.Controls.Add(btnDecimalToBinary, 2, 1);
            tableLayoutPanel1.Controls.Add(lblBinaryToDecimal, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDecimalToBinary, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDecimalInput, 1, 1);
            tableLayoutPanel1.Controls.Add(txtBinaryInput, 1, 0);
            tableLayoutPanel1.Controls.Add(txtBinaryToDecimal, 3, 0);
            tableLayoutPanel1.Controls.Add(txtDecimalToBinary, 3, 1);
            tableLayoutPanel1.Controls.Add(btnBinaryToDecimal, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.94366F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.05634F));
            tableLayoutPanel1.Size = new Size(917, 284);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDecimalToBinary
            // 
            btnDecimalToBinary.Anchor = AnchorStyles.None;
            btnDecimalToBinary.Location = new Point(479, 196);
            btnDecimalToBinary.Name = "btnDecimalToBinary";
            btnDecimalToBinary.Size = new Size(187, 31);
            btnDecimalToBinary.TabIndex = 8;
            btnDecimalToBinary.Text = "-->";
            btnDecimalToBinary.UseVisualStyleBackColor = true;
            btnDecimalToBinary.Click += btnDecimalToBinary_Click;
            // 
            // lblBinaryToDecimal
            // 
            lblBinaryToDecimal.Anchor = AnchorStyles.None;
            lblBinaryToDecimal.AutoSize = true;
            lblBinaryToDecimal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblBinaryToDecimal.Location = new Point(41, 57);
            lblBinaryToDecimal.Name = "lblBinaryToDecimal";
            lblBinaryToDecimal.Size = new Size(148, 25);
            lblBinaryToDecimal.TabIndex = 0;
            lblBinaryToDecimal.Text = "Binario a Decimal";
            // 
            // lblDecimalToBinary
            // 
            lblDecimalToBinary.Anchor = AnchorStyles.None;
            lblDecimalToBinary.AutoSize = true;
            lblDecimalToBinary.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDecimalToBinary.Location = new Point(41, 199);
            lblDecimalToBinary.Name = "lblDecimalToBinary";
            lblDecimalToBinary.Size = new Size(148, 25);
            lblDecimalToBinary.TabIndex = 1;
            lblDecimalToBinary.Text = "Decimal a Binario";
            // 
            // txtDecimalInput
            // 
            txtDecimalInput.Anchor = AnchorStyles.None;
            txtDecimalInput.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDecimalInput.Location = new Point(233, 195);
            txtDecimalInput.Multiline = true;
            txtDecimalInput.Name = "txtDecimalInput";
            txtDecimalInput.PlaceholderText = "Ingrese Numero Decimal";
            txtDecimalInput.Size = new Size(240, 32);
            txtDecimalInput.TabIndex = 4;
            // 
            // txtBinaryInput
            // 
            txtBinaryInput.Anchor = AnchorStyles.None;
            txtBinaryInput.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBinaryInput.Location = new Point(233, 53);
            txtBinaryInput.Multiline = true;
            txtBinaryInput.Name = "txtBinaryInput";
            txtBinaryInput.PlaceholderText = "Ingrese Numero Binario";
            txtBinaryInput.Size = new Size(240, 32);
            txtBinaryInput.TabIndex = 2;
            // 
            // txtBinaryToDecimal
            // 
            txtBinaryToDecimal.Anchor = AnchorStyles.None;
            txtBinaryToDecimal.Location = new Point(672, 52);
            txtBinaryToDecimal.Multiline = true;
            txtBinaryToDecimal.Name = "txtBinaryToDecimal";
            txtBinaryToDecimal.ReadOnly = true;
            txtBinaryToDecimal.Size = new Size(242, 35);
            txtBinaryToDecimal.TabIndex = 5;
            // 
            // txtDecimalToBinary
            // 
            txtDecimalToBinary.Anchor = AnchorStyles.None;
            txtDecimalToBinary.Location = new Point(672, 194);
            txtDecimalToBinary.Multiline = true;
            txtDecimalToBinary.Name = "txtDecimalToBinary";
            txtDecimalToBinary.ReadOnly = true;
            txtDecimalToBinary.Size = new Size(242, 35);
            txtDecimalToBinary.TabIndex = 6;
            // 
            // btnBinaryToDecimal
            // 
            btnBinaryToDecimal.Anchor = AnchorStyles.None;
            btnBinaryToDecimal.Location = new Point(479, 54);
            btnBinaryToDecimal.Name = "btnBinaryToDecimal";
            btnBinaryToDecimal.Size = new Size(187, 31);
            btnBinaryToDecimal.TabIndex = 7;
            btnBinaryToDecimal.Text = "-->";
            btnBinaryToDecimal.UseVisualStyleBackColor = true;
            btnBinaryToDecimal.Click += btnBinaryToDecimal_Click;
            // 
            // FrmConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 289);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmConverter";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDecimalToBinary;
        private Label lblBinaryToDecimal;
        private Label lblDecimalToBinary;
        private TextBox txtDecimalInput;
        private TextBox txtBinaryInput;
        private TextBox txtBinaryToDecimal;
        private TextBox txtDecimalToBinary;
        private Button btnBinaryToDecimal;
    }
}