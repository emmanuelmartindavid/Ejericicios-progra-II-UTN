namespace ExpendingBooks
{
    partial class FrmVending
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
            panel1 = new Panel();
            btnFinishBuy = new Button();
            lblClientName = new Label();
            lbl_welcome = new Label();
            txb_codeInfo = new TextBox();
            btn_confirm = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_0 = new Button();
            btn_9 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_delete = new Button();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_codeProduct = new Label();
            pb_kat = new PictureBox();
            pb_oreo = new PictureBox();
            pb_kinder = new PictureBox();
            pb_water = new PictureBox();
            pb_pringles = new PictureBox();
            pb_doritos = new PictureBox();
            pb_pepsi = new PictureBox();
            pb_coca = new PictureBox();
            pb_lays = new PictureBox();
            rtxt_message = new RichTextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_kat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_oreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_kinder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_water).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_pringles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_doritos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_pepsi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_coca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_lays).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnFinishBuy);
            panel1.Controls.Add(lblClientName);
            panel1.Controls.Add(lbl_welcome);
            panel1.Controls.Add(txb_codeInfo);
            panel1.Controls.Add(btn_confirm);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(btn_delete);
            panel1.Location = new Point(580, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 749);
            panel1.TabIndex = 1;
            // 
            // btnFinishBuy
            // 
            btnFinishBuy.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinishBuy.Location = new Point(28, 697);
            btnFinishBuy.Name = "btnFinishBuy";
            btnFinishBuy.Size = new Size(219, 37);
            btnFinishBuy.TabIndex = 16;
            btnFinishBuy.Text = "FINALIZAR";
            btnFinishBuy.UseVisualStyleBackColor = true;
            btnFinishBuy.Click += btnFinishBuy_Click;
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.BackColor = SystemColors.InfoText;
            lblClientName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblClientName.ForeColor = Color.CornflowerBlue;
            lblClientName.Location = new Point(6, 87);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(73, 25);
            lblClientName.TabIndex = 15;
            lblClientName.Text = "Cliente";
            lblClientName.Click += lblClientName_Click;
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.BackColor = Color.LightCyan;
            lbl_welcome.BorderStyle = BorderStyle.Fixed3D;
            lbl_welcome.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_welcome.ForeColor = Color.CornflowerBlue;
            lbl_welcome.Location = new Point(6, 15);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(254, 53);
            lbl_welcome.TabIndex = 14;
            lbl_welcome.Text = "BIENVENIDO";
            // 
            // txb_codeInfo
            // 
            txb_codeInfo.HideSelection = false;
            txb_codeInfo.Location = new Point(80, 162);
            txb_codeInfo.Multiline = true;
            txb_codeInfo.Name = "txb_codeInfo";
            txb_codeInfo.ReadOnly = true;
            txb_codeInfo.Size = new Size(107, 43);
            txb_codeInfo.TabIndex = 13;
            // 
            // btn_confirm
            // 
            btn_confirm.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_confirm.Location = new Point(25, 605);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(222, 57);
            btn_confirm.TabIndex = 12;
            btn_confirm.Text = "INGRESAR";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(btn_7, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_0, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_2, 1, 0);
            tableLayoutPanel1.Location = new Point(25, 233);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.83582F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.8308449F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.Size = new Size(222, 244);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_7.Location = new Point(3, 127);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(67, 56);
            btn_7.TabIndex = 4;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_8.Location = new Point(76, 127);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(68, 56);
            btn_8.TabIndex = 7;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_0.Location = new Point(76, 189);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(68, 52);
            btn_0.TabIndex = 9;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_9.Location = new Point(150, 127);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(69, 56);
            btn_9.TabIndex = 8;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3.Location = new Point(150, 3);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(69, 55);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_4.Location = new Point(3, 64);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(67, 57);
            btn_4.TabIndex = 1;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6.Location = new Point(150, 64);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(69, 55);
            btn_6.TabIndex = 5;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_5.Location = new Point(76, 64);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(68, 57);
            btn_5.TabIndex = 6;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.Location = new Point(3, 3);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(67, 55);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2.Location = new Point(76, 3);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(68, 55);
            btn_2.TabIndex = 3;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(25, 528);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(219, 39);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "BORRAR";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbl_codeProduct);
            panel2.Controls.Add(pb_kat);
            panel2.Controls.Add(pb_oreo);
            panel2.Controls.Add(pb_kinder);
            panel2.Controls.Add(pb_water);
            panel2.Controls.Add(pb_pringles);
            panel2.Controls.Add(pb_doritos);
            panel2.Controls.Add(pb_pepsi);
            panel2.Controls.Add(pb_coca);
            panel2.Controls.Add(pb_lays);
            panel2.Location = new Point(12, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 664);
            panel2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.WindowText;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Cornsilk;
            label8.Location = new Point(128, 624);
            label8.Name = "label8";
            label8.Size = new Size(21, 23);
            label8.TabIndex = 17;
            label8.Text = "7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.WindowText;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Cornsilk;
            label7.Location = new Point(514, 395);
            label7.Name = "label7";
            label7.Size = new Size(21, 23);
            label7.TabIndex = 16;
            label7.Text = "6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.WindowText;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(514, 624);
            label6.Name = "label6";
            label6.Size = new Size(21, 23);
            label6.TabIndex = 15;
            label6.Text = "9";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowText;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Cornsilk;
            label5.Location = new Point(313, 395);
            label5.Name = "label5";
            label5.Size = new Size(21, 23);
            label5.TabIndex = 14;
            label5.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowText;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(313, 167);
            label4.Name = "label4";
            label4.Size = new Size(21, 23);
            label4.TabIndex = 13;
            label4.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowText;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(514, 167);
            label3.Name = "label3";
            label3.Size = new Size(21, 23);
            label3.TabIndex = 12;
            label3.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowText;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(128, 395);
            label2.Name = "label2";
            label2.Size = new Size(21, 23);
            label2.TabIndex = 11;
            label2.Text = "4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowText;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(313, 624);
            label1.Name = "label1";
            label1.Size = new Size(21, 23);
            label1.TabIndex = 10;
            label1.Text = "8";
            // 
            // lbl_codeProduct
            // 
            lbl_codeProduct.AutoSize = true;
            lbl_codeProduct.BackColor = SystemColors.WindowText;
            lbl_codeProduct.BorderStyle = BorderStyle.Fixed3D;
            lbl_codeProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_codeProduct.ForeColor = Color.Cornsilk;
            lbl_codeProduct.Location = new Point(128, 167);
            lbl_codeProduct.Name = "lbl_codeProduct";
            lbl_codeProduct.Size = new Size(21, 23);
            lbl_codeProduct.TabIndex = 9;
            lbl_codeProduct.Text = "1";
            // 
            // pb_kat
            // 
            pb_kat.BackColor = SystemColors.WindowText;
            pb_kat.BorderStyle = BorderStyle.Fixed3D;
            pb_kat.Image = Machine.Properties.Resources.pngegg__8_;
            pb_kat.Location = new Point(199, 483);
            pb_kat.Name = "pb_kat";
            pb_kat.Size = new Size(108, 162);
            pb_kat.SizeMode = PictureBoxSizeMode.Zoom;
            pb_kat.TabIndex = 8;
            pb_kat.TabStop = false;
            // 
            // pb_oreo
            // 
            pb_oreo.BackColor = SystemColors.WindowText;
            pb_oreo.BorderStyle = BorderStyle.Fixed3D;
            pb_oreo.Image = Machine.Properties.Resources.pngegg__9_;
            pb_oreo.Location = new Point(394, 483);
            pb_oreo.Name = "pb_oreo";
            pb_oreo.Size = new Size(114, 162);
            pb_oreo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_oreo.TabIndex = 7;
            pb_oreo.TabStop = false;
            // 
            // pb_kinder
            // 
            pb_kinder.BackColor = SystemColors.WindowText;
            pb_kinder.BorderStyle = BorderStyle.Fixed3D;
            pb_kinder.Image = Machine.Properties.Resources.pngegg__7_;
            pb_kinder.Location = new Point(17, 483);
            pb_kinder.Name = "pb_kinder";
            pb_kinder.Size = new Size(105, 162);
            pb_kinder.SizeMode = PictureBoxSizeMode.Zoom;
            pb_kinder.TabIndex = 6;
            pb_kinder.TabStop = false;
            // 
            // pb_water
            // 
            pb_water.BackColor = SystemColors.WindowText;
            pb_water.BorderStyle = BorderStyle.Fixed3D;
            pb_water.Image = Machine.Properties.Resources.pngegg__6_;
            pb_water.Location = new Point(394, 252);
            pb_water.Name = "pb_water";
            pb_water.Size = new Size(114, 164);
            pb_water.SizeMode = PictureBoxSizeMode.Zoom;
            pb_water.TabIndex = 5;
            pb_water.TabStop = false;
            // 
            // pb_pringles
            // 
            pb_pringles.BackColor = SystemColors.WindowText;
            pb_pringles.BorderStyle = BorderStyle.Fixed3D;
            pb_pringles.Image = Machine.Properties.Resources.pngegg__5_;
            pb_pringles.Location = new Point(394, 31);
            pb_pringles.Name = "pb_pringles";
            pb_pringles.Size = new Size(114, 157);
            pb_pringles.SizeMode = PictureBoxSizeMode.Zoom;
            pb_pringles.TabIndex = 4;
            pb_pringles.TabStop = false;
            // 
            // pb_doritos
            // 
            pb_doritos.BackColor = SystemColors.WindowText;
            pb_doritos.BorderStyle = BorderStyle.Fixed3D;
            pb_doritos.Image = Machine.Properties.Resources.pngegg__4_;
            pb_doritos.Location = new Point(207, 31);
            pb_doritos.Name = "pb_doritos";
            pb_doritos.Size = new Size(100, 157);
            pb_doritos.SizeMode = PictureBoxSizeMode.Zoom;
            pb_doritos.TabIndex = 3;
            pb_doritos.TabStop = false;
            // 
            // pb_pepsi
            // 
            pb_pepsi.BackColor = SystemColors.WindowText;
            pb_pepsi.Image = Machine.Properties.Resources.pngegg__3_;
            pb_pepsi.Location = new Point(22, 252);
            pb_pepsi.Name = "pb_pepsi";
            pb_pepsi.Size = new Size(100, 164);
            pb_pepsi.SizeMode = PictureBoxSizeMode.Zoom;
            pb_pepsi.TabIndex = 2;
            pb_pepsi.TabStop = false;
            // 
            // pb_coca
            // 
            pb_coca.BackColor = SystemColors.WindowText;
            pb_coca.Image = Machine.Properties.Resources.pngegg__1_;
            pb_coca.Location = new Point(199, 252);
            pb_coca.Name = "pb_coca";
            pb_coca.Size = new Size(108, 164);
            pb_coca.SizeMode = PictureBoxSizeMode.Zoom;
            pb_coca.TabIndex = 1;
            pb_coca.TabStop = false;
            // 
            // pb_lays
            // 
            pb_lays.AccessibleRole = AccessibleRole.TitleBar;
            pb_lays.BackColor = SystemColors.WindowText;
            pb_lays.BorderStyle = BorderStyle.Fixed3D;
            pb_lays.Image = Machine.Properties.Resources.pngegg;
            pb_lays.Location = new Point(17, 31);
            pb_lays.Name = "pb_lays";
            pb_lays.Size = new Size(105, 157);
            pb_lays.SizeMode = PictureBoxSizeMode.Zoom;
            pb_lays.TabIndex = 0;
            pb_lays.TabStop = false;
            // 
            // rtxt_message
            // 
            rtxt_message.BackColor = Color.YellowGreen;
            rtxt_message.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rtxt_message.Location = new Point(9, 699);
            rtxt_message.Name = "rtxt_message";
            rtxt_message.Size = new Size(565, 49);
            rtxt_message.TabIndex = 18;
            rtxt_message.Text = "";
            // 
            // FrmVending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(854, 760);
            Controls.Add(rtxt_message);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmVending";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_kat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_oreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_kinder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_water).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_pringles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_doritos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_pepsi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_coca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_lays).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button btn_0;
        private Button btn_9;
        private Button btn_8;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_confirm;
        private Button btn_delete;
        private TextBox txb_codeInfo;
        private Label lbl_welcome;
        private PictureBox pb_doritos;
        private PictureBox pb_pepsi;
        private PictureBox pb_coca;
        private PictureBox pb_lays;
        private PictureBox pb_water;
        private PictureBox pb_pringles;
        private PictureBox pb_kat;
        private PictureBox pb_oreo;
        private PictureBox pb_kinder;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_codeProduct;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private RichTextBox rtxt_message;
        private Label lblClientName;
        private Button btnFinishBuy;
    }
}