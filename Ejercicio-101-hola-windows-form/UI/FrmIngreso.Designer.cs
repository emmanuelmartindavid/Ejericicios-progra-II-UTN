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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            cargarToolStripMenuItem = new ToolStripMenuItem();
            lb_saludo = new Label();
            txb_saluda = new TextBox();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cargarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(445, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cargarToolStripMenuItem
            // 
            cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            cargarToolStripMenuItem.Size = new Size(54, 20);
            cargarToolStripMenuItem.Text = "Cargar";
            cargarToolStripMenuItem.Click += cargarToolStripMenuItem_Click_1;
            // 
            // lb_saludo
            // 
            lb_saludo.AutoSize = true;
            lb_saludo.Location = new Point(201, 69);
            lb_saludo.Name = "lb_saludo";
            lb_saludo.Size = new Size(38, 15);
            lb_saludo.TabIndex = 2;
            lb_saludo.Text = "label1";
            // 
            // txb_saluda
            // 
            txb_saluda.Location = new Point(153, 114);
            txb_saluda.Name = "txb_saluda";
            txb_saluda.Size = new Size(128, 23);
            txb_saluda.TabIndex = 3;
            // 
            // FrmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(445, 240);
            Controls.Add(txb_saluda);
            Controls.Add(lb_saludo);
            Controls.Add(menuStrip1);
            Name = "FrmIngreso";
            Text = "Form Ingreso";
 
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cargarToolStripMenuItem;
        private Label lb_saludo;
        private TextBox txb_saluda;
    }
}