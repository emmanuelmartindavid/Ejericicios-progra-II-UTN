namespace Frm1
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
            gb_user = new GroupBox();
            lb_age = new Label();
            nud_Age = new NumericUpDown();
            txb_adress = new TextBox();
            txb_name = new TextBox();
            gb_gender = new GroupBox();
            rb_nb = new RadioButton();
            rb_femn = new RadioButton();
            rb_masc = new RadioButton();
            gb_courses = new GroupBox();
            checkBox3 = new CheckBox();
            cb_cpp = new CheckBox();
            checkBox1 = new CheckBox();
            lb_country = new ListBox();
            lb_ctr = new Label();
            btn_userData = new Button();
            gb_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Age).BeginInit();
            gb_gender.SuspendLayout();
            gb_courses.SuspendLayout();
            SuspendLayout();
            // 
            // gb_user
            // 
            gb_user.Controls.Add(lb_age);
            gb_user.Controls.Add(nud_Age);
            gb_user.Controls.Add(txb_adress);
            gb_user.Controls.Add(txb_name);
            gb_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_user.Location = new Point(51, 42);
            gb_user.Name = "gb_user";
            gb_user.Size = new Size(254, 244);
            gb_user.TabIndex = 0;
            gb_user.TabStop = false;
            gb_user.Text = "Detalles de Usuario";
            // 
            // lb_age
            // 
            lb_age.AutoSize = true;
            lb_age.Location = new Point(31, 191);
            lb_age.Name = "lb_age";
            lb_age.Size = new Size(44, 21);
            lb_age.TabIndex = 3;
            lb_age.Text = "Edad";
            // 
            // nud_Age
            // 
            nud_Age.Location = new Point(141, 191);
            nud_Age.Name = "nud_Age";
            nud_Age.Size = new Size(83, 29);
            nud_Age.TabIndex = 2;
            nud_Age.Tag = "";
            // 
            // txb_adress
            // 
            txb_adress.Location = new Point(31, 125);
            txb_adress.Name = "txb_adress";
            txb_adress.PlaceholderText = "Ingrese Direccion";
            txb_adress.Size = new Size(193, 29);
            txb_adress.TabIndex = 1;
            // 
            // txb_name
            // 
            txb_name.Location = new Point(31, 47);
            txb_name.Name = "txb_name";
            txb_name.PlaceholderText = "Ingrese Nombre";
            txb_name.Size = new Size(193, 29);
            txb_name.TabIndex = 0;
            // 
            // gb_gender
            // 
            gb_gender.Controls.Add(rb_nb);
            gb_gender.Controls.Add(rb_femn);
            gb_gender.Controls.Add(rb_masc);
            gb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_gender.Location = new Point(403, 42);
            gb_gender.Name = "gb_gender";
            gb_gender.Size = new Size(186, 185);
            gb_gender.TabIndex = 1;
            gb_gender.TabStop = false;
            gb_gender.Text = "Genero";
            // 
            // rb_nb
            // 
            rb_nb.AutoSize = true;
            rb_nb.Location = new Point(36, 126);
            rb_nb.Name = "rb_nb";
            rb_nb.Size = new Size(102, 25);
            rb_nb.TabIndex = 2;
            rb_nb.TabStop = true;
            rb_nb.Text = "No binario";
            rb_nb.TextAlign = ContentAlignment.BottomCenter;
            rb_nb.UseVisualStyleBackColor = true;
            // 
            // rb_femn
            // 
            rb_femn.AutoSize = true;
            rb_femn.Location = new Point(36, 86);
            rb_femn.Name = "rb_femn";
            rb_femn.Size = new Size(97, 25);
            rb_femn.TabIndex = 1;
            rb_femn.TabStop = true;
            rb_femn.Text = "Femenino";
            rb_femn.TextAlign = ContentAlignment.MiddleCenter;
            rb_femn.UseVisualStyleBackColor = true;
            // 
            // rb_masc
            // 
            rb_masc.AutoSize = true;
            rb_masc.Location = new Point(36, 47);
            rb_masc.Name = "rb_masc";
            rb_masc.Size = new Size(99, 25);
            rb_masc.TabIndex = 0;
            rb_masc.TabStop = true;
            rb_masc.Text = "Masculino";
            rb_masc.TextAlign = ContentAlignment.TopCenter;
            rb_masc.UseVisualStyleBackColor = true;
            // 
            // gb_courses
            // 
            gb_courses.Controls.Add(checkBox3);
            gb_courses.Controls.Add(cb_cpp);
            gb_courses.Controls.Add(checkBox1);
            gb_courses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gb_courses.Location = new Point(403, 233);
            gb_courses.Name = "gb_courses";
            gb_courses.Size = new Size(186, 150);
            gb_courses.TabIndex = 2;
            gb_courses.TabStop = false;
            gb_courses.Text = "Cursos";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(39, 104);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(99, 25);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "JavaScript";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // cb_cpp
            // 
            cb_cpp.AutoSize = true;
            cb_cpp.Location = new Point(39, 71);
            cb_cpp.Name = "cb_cpp";
            cb_cpp.Size = new Size(61, 25);
            cb_cpp.TabIndex = 1;
            cb_cpp.Text = "C++";
            cb_cpp.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ImageAlign = ContentAlignment.TopCenter;
            checkBox1.Location = new Point(39, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(48, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "C#";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lb_country
            // 
            lb_country.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lb_country.FormattingEnabled = true;
            lb_country.ItemHeight = 20;
            lb_country.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lb_country.Location = new Point(51, 325);
            lb_country.Name = "lb_country";
            lb_country.Size = new Size(254, 124);
            lb_country.TabIndex = 3;
            // 
            // lb_ctr
            // 
            lb_ctr.AutoSize = true;
            lb_ctr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ctr.Location = new Point(51, 301);
            lb_ctr.Name = "lb_ctr";
            lb_ctr.Size = new Size(37, 21);
            lb_ctr.TabIndex = 4;
            lb_ctr.Text = "Pais";
            // 
            // btn_userData
            // 
            btn_userData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_userData.Location = new Point(468, 415);
            btn_userData.Name = "btn_userData";
            btn_userData.Size = new Size(121, 34);
            btn_userData.TabIndex = 5;
            btn_userData.Text = "Ingresar";
            btn_userData.UseVisualStyleBackColor = true;
            btn_userData.Click += btn_userData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(642, 488);
            Controls.Add(btn_userData);
            Controls.Add(lb_ctr);
            Controls.Add(lb_country);
            Controls.Add(gb_courses);
            Controls.Add(gb_gender);
            Controls.Add(gb_user);
            Name = "Form1";
            Text = "Registro";
            gb_user.ResumeLayout(false);
            gb_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Age).EndInit();
            gb_gender.ResumeLayout(false);
            gb_gender.PerformLayout();
            gb_courses.ResumeLayout(false);
            gb_courses.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_user;
        private Label lb_age;
        private NumericUpDown nud_Age;
        private TextBox txb_adress;
        private TextBox txb_name;
        private GroupBox gb_gender;
        private RadioButton rb_nb;
        private RadioButton rb_femn;
        private RadioButton rb_masc;
        private GroupBox gb_courses;
        private CheckBox checkBox3;
        private CheckBox cb_cpp;
        private CheckBox checkBox1;
        private ListBox lb_country;
        private Label lb_ctr;
        private Button btn_userData;
    }
}