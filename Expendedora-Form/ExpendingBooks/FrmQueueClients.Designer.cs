namespace Machine
{
    partial class FrmQueueClients
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
            txtClienName = new TextBox();
            lblTitle = new Label();
            btnLoadPeople = new Button();
            btnFinish = new Button();
            lblQueue = new Label();
            lblClientsQueue = new Label();
            lstClientQueue = new ListBox();
            SuspendLayout();
            // 
            // txtClienName
            // 
            txtClienName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienName.Location = new Point(119, 49);
            txtClienName.Multiline = true;
            txtClienName.Name = "txtClienName";
            txtClienName.PlaceholderText = "Nombre de cliente";
            txtClienName.Size = new Size(168, 35);
            txtClienName.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(88, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 28);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Ingrese Cliente a la fila";
            // 
            // btnLoadPeople
            // 
            btnLoadPeople.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadPeople.Location = new Point(12, 299);
            btnLoadPeople.Name = "btnLoadPeople";
            btnLoadPeople.Size = new Size(143, 40);
            btnLoadPeople.TabIndex = 2;
            btnLoadPeople.Text = "AGREGAR";
            btnLoadPeople.UseVisualStyleBackColor = true;
            btnLoadPeople.Click += btnLoadPeople_Click;
            // 
            // btnFinish
            // 
            btnFinish.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinish.Location = new Point(262, 299);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(143, 40);
            btnFinish.TabIndex = 4;
            btnFinish.Text = "FINALIZAR";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(179, 87);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(54, 28);
            lblQueue.TabIndex = 5;
            lblQueue.Text = "FILA:";
            // 
            // lblClientsQueue
            // 
            lblClientsQueue.AutoSize = true;
            lblClientsQueue.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblClientsQueue.Location = new Point(128, 126);
            lblClientsQueue.Name = "lblClientsQueue";
            lblClientsQueue.Size = new Size(0, 25);
            lblClientsQueue.TabIndex = 6;
            // 
            // lstClientQueue
            // 
            lstClientQueue.BackColor = Color.DarkSlateGray;
            lstClientQueue.BorderStyle = BorderStyle.None;
            lstClientQueue.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lstClientQueue.FormattingEnabled = true;
            lstClientQueue.ItemHeight = 23;
            lstClientQueue.Location = new Point(134, 118);
            lstClientQueue.Name = "lstClientQueue";
            lstClientQueue.Size = new Size(142, 161);
            lstClientQueue.TabIndex = 7;
            // 
            // FrmQueueClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(417, 351);
            Controls.Add(lstClientQueue);
            Controls.Add(lblClientsQueue);
            Controls.Add(lblQueue);
            Controls.Add(btnFinish);
            Controls.Add(btnLoadPeople);
            Controls.Add(lblTitle);
            Controls.Add(txtClienName);
            Name = "FrmQueueClients";
            Text = "FrmQueueClients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClienName;
        private Label lblTitle;
        private Button btnLoadPeople;
        private Button btnFinish;
        private Label lblQueue;
        private Label lblClientsQueue;
        private ListBox lstClientQueue;
    }
}