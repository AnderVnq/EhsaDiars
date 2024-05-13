namespace CapaPresentacion.Usuarios
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRegistro = new Button();
            btnVolver = new Button();
            txtNombre = new TextBox();
            panel8 = new Panel();
            txtdni = new TextBox();
            panel2 = new Panel();
            txtApellidopat = new TextBox();
            panel3 = new Panel();
            txtUsername = new TextBox();
            panel4 = new Panel();
            txtApellidomat = new TextBox();
            panel5 = new Panel();
            txtPasword = new TextBox();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 115, 5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 31);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(518, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 18);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO USUARIO";
            label1.MouseDown += label1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(183, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(33, 145);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 13;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(33, 223);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 14;
            label3.Text = "Primer Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(311, 223);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 15;
            label4.Text = "Nombre Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(311, 145);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 16;
            label5.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(33, 310);
            label6.Name = "label6";
            label6.Size = new Size(112, 17);
            label6.TabIndex = 17;
            label6.Text = "Segundo Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(311, 310);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 18;
            label7.Text = "Contraseña";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(36, 32, 40);
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.ForeColor = Color.LightGray;
            btnRegistro.Location = new Point(165, 397);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(210, 30);
            btnRegistro.TabIndex = 19;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(36, 32, 40);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.LightGray;
            btnVolver.Location = new Point(165, 443);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(210, 30);
            btnVolver.TabIndex = 20;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 174);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 23);
            txtNombre.TabIndex = 23;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(247, 115, 5);
            panel8.ForeColor = Color.Coral;
            panel8.Location = new Point(33, 197);
            panel8.Name = "panel8";
            panel8.Size = new Size(226, 3);
            panel8.TabIndex = 22;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(311, 174);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(232, 23);
            txtdni.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 115, 5);
            panel2.ForeColor = Color.Coral;
            panel2.Location = new Point(311, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 3);
            panel2.TabIndex = 24;
            // 
            // txtApellidopat
            // 
            txtApellidopat.Location = new Point(33, 252);
            txtApellidopat.Name = "txtApellidopat";
            txtApellidopat.Size = new Size(226, 23);
            txtApellidopat.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 115, 5);
            panel3.ForeColor = Color.Coral;
            panel3.Location = new Point(33, 275);
            panel3.Name = "panel3";
            panel3.Size = new Size(226, 3);
            panel3.TabIndex = 26;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(311, 252);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(232, 23);
            txtUsername.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(247, 115, 5);
            panel4.ForeColor = Color.Coral;
            panel4.Location = new Point(311, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 3);
            panel4.TabIndex = 28;
            // 
            // txtApellidomat
            // 
            txtApellidomat.Location = new Point(33, 334);
            txtApellidomat.Name = "txtApellidomat";
            txtApellidomat.Size = new Size(226, 23);
            txtApellidomat.TabIndex = 31;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(247, 115, 5);
            panel5.ForeColor = Color.Coral;
            panel5.Location = new Point(33, 357);
            panel5.Name = "panel5";
            panel5.Size = new Size(226, 3);
            panel5.TabIndex = 30;
            // 
            // txtPasword
            // 
            txtPasword.Location = new Point(311, 334);
            txtPasword.Name = "txtPasword";
            txtPasword.Size = new Size(232, 23);
            txtPasword.TabIndex = 33;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(247, 115, 5);
            panel6.ForeColor = Color.Coral;
            panel6.Location = new Point(311, 357);
            panel6.Name = "panel6";
            panel6.Size = new Size(232, 3);
            panel6.TabIndex = 32;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 497);
            Controls.Add(txtPasword);
            Controls.Add(panel6);
            Controls.Add(txtApellidomat);
            Controls.Add(panel5);
            Controls.Add(txtUsername);
            Controls.Add(panel4);
            Controls.Add(txtApellidopat);
            Controls.Add(panel3);
            Controls.Add(txtdni);
            Controls.Add(panel2);
            Controls.Add(txtNombre);
            Controls.Add(panel8);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistro);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "register";
            Text = "Registro Usuario";
            Load += register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnRegistro;
        private Button btnVolver;
        private TextBox txtNombre;
        private Panel panel8;
        private TextBox txtdni;
        private Panel panel2;
        private TextBox txtApellidopat;
        private Panel panel3;
        private TextBox txtUsername;
        private Panel panel4;
        private TextBox txtApellidomat;
        private Panel panel5;
        private TextBox txtPasword;
        private Panel panel6;
        private PictureBox pictureBox2;
    }
}