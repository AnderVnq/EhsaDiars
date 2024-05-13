namespace CapaPresentacion.Autos
{
    partial class frmInsertVehiculo
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
            panel1 = new Panel();
            label7 = new Label();
            lblTitulo = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtCapacidad = new TextBox();
            txtKilometraje = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            radioMantenimiento = new RadioButton();
            radioDisponible = new RadioButton();
            txtPlaca = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 115, 5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 37);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(560, 2);
            label7.Name = "label7";
            label7.Size = new Size(27, 30);
            label7.TabIndex = 1;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(228, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(142, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Vehiculo";
            lblTitulo.MouseDown += lblTitulo_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 70);
            label1.Name = "label1";
            label1.Size = new Size(139, 19);
            label1.TabIndex = 1;
            label1.Text = "Selecionar Conductor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 23);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 154);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 3;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 222);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 4;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(376, 70);
            label4.Name = "label4";
            label4.Size = new Size(106, 19);
            label4.TabIndex = 5;
            label4.Text = "Año Fabricacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(317, 154);
            label5.Name = "label5";
            label5.Size = new Size(133, 19);
            label5.TabIndex = 6;
            label5.Text = "Capacidad Pasajeros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(317, 222);
            label6.Name = "label6";
            label6.Size = new Size(77, 19);
            label6.TabIndex = 7;
            label6.Text = "Kilometraje";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(317, 103);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(36, 244);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(227, 23);
            txtModelo.TabIndex = 9;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(36, 176);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(227, 23);
            txtMarca.TabIndex = 10;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(317, 176);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(214, 23);
            txtCapacidad.TabIndex = 11;
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(317, 244);
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.Size = new Size(214, 23);
            txtKilometraje.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(36, 32, 40);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.LightGray;
            btnCancelar.Location = new Point(352, 494);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 31);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(36, 32, 40);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.LightGray;
            btnGuardar.Location = new Point(111, 494);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 31);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioMantenimiento);
            groupBox1.Controls.Add(radioDisponible);
            groupBox1.Location = new Point(148, 381);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 64);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado Vehiculo";
            groupBox1.Visible = false;
            // 
            // radioMantenimiento
            // 
            radioMantenimiento.AutoSize = true;
            radioMantenimiento.Location = new Point(133, 39);
            radioMantenimiento.Name = "radioMantenimiento";
            radioMantenimiento.Size = new Size(123, 19);
            radioMantenimiento.TabIndex = 1;
            radioMantenimiento.TabStop = true;
            radioMantenimiento.Text = "En mantenimiento";
            radioMantenimiento.UseVisualStyleBackColor = true;
            // 
            // radioDisponible
            // 
            radioDisponible.AutoSize = true;
            radioDisponible.Location = new Point(20, 39);
            radioDisponible.Name = "radioDisponible";
            radioDisponible.Size = new Size(81, 19);
            radioDisponible.TabIndex = 0;
            radioDisponible.TabStop = true;
            radioDisponible.Text = "Disponible";
            radioDisponible.UseVisualStyleBackColor = true;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(36, 305);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(227, 23);
            txtPlaca.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(36, 283);
            label8.Name = "label8";
            label8.Size = new Size(74, 19);
            label8.TabIndex = 17;
            label8.Text = "Placa Auto";
            // 
            // frmInsertVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 560);
            Controls.Add(txtPlaca);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtKilometraje);
            Controls.Add(txtCapacidad);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInsertVehiculo";
            Text = "frmInsertVehiculo";
            Load += frmInsertVehiculo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtCapacidad;
        private TextBox txtKilometraje;
        private Button btnCancelar;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private RadioButton radioMantenimiento;
        private RadioButton radioDisponible;
        private Label label7;
        private TextBox txtPlaca;
        private Label label8;
    }
}