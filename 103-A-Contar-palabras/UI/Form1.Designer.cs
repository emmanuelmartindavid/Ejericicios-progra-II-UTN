namespace UI
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
            rtbWords = new RichTextBox();
            btnCalculateWords = new Button();
            SuspendLayout();
            // 
            // rtbWords
            // 
            rtbWords.Location = new Point(-2, -1);
            rtbWords.Name = "rtbWords";
            rtbWords.Size = new Size(696, 430);
            rtbWords.TabIndex = 0;
            rtbWords.Text = "";
            // 
            // btnCalculateWords
            // 
            btnCalculateWords.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculateWords.Location = new Point(209, 445);
            btnCalculateWords.Name = "btnCalculateWords";
            btnCalculateWords.Size = new Size(248, 30);
            btnCalculateWords.TabIndex = 1;
            btnCalculateWords.Text = "Calcular";
            btnCalculateWords.UseVisualStyleBackColor = true;
            btnCalculateWords.Click += btnCalculateWords_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 487);
            Controls.Add(btnCalculateWords);
            Controls.Add(rtbWords);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbWords;
        private Button btnCalculateWords;
    }
}