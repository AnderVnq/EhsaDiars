namespace CapaPresentacion.Pagos
{
    partial class Pagos
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
            label10 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnGenerarPlantilla = new Button();
            btnGuardar = new Button();
            txtNumeroCuenta = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnAbrirPlantilla = new Button();
            btnNuevo = new Button();
            label3 = new Label();
            textMontoTotal = new TextBox();
            label6 = new Label();
            txtConceptoPago = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(968, 0);
            label10.Name = "label10";
            label10.Size = new Size(29, 32);
            label10.TabIndex = 1;
            label10.Text = "X";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 115, 5);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 45);
            panel1.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(443, 9);
            label9.Name = "label9";
            label9.Size = new Size(71, 30);
            label9.TabIndex = 0;
            label9.Text = "Pagos";
            label9.Click += label9_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(199, 55);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 27);
            dateTimePicker1.TabIndex = 42;
            // 
            // btnGenerarPlantilla
            // 
            btnGenerarPlantilla.BackColor = Color.FromArgb(36, 32, 40);
            btnGenerarPlantilla.Cursor = Cursors.Hand;
            btnGenerarPlantilla.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnGenerarPlantilla.FlatStyle = FlatStyle.Flat;
            btnGenerarPlantilla.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarPlantilla.ForeColor = Color.LightGray;
            btnGenerarPlantilla.Location = new Point(722, 361);
            btnGenerarPlantilla.Margin = new Padding(3, 4, 3, 4);
            btnGenerarPlantilla.Name = "btnGenerarPlantilla";
            btnGenerarPlantilla.Size = new Size(178, 41);
            btnGenerarPlantilla.TabIndex = 41;
            btnGenerarPlantilla.Text = "Generar Plantilla";
            btnGenerarPlantilla.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(36, 32, 40);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.LightGray;
            btnGuardar.Location = new Point(291, 361);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 41);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(199, 157);
            txtNumeroCuenta.Margin = new Padding(3, 4, 3, 4);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(167, 27);
            txtNumeroCuenta.TabIndex = 38;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(116, 176);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(218, 27);
            txtDni.TabIndex = 37;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(116, 120);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(218, 27);
            txtApellido.TabIndex = 34;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 57);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 27);
            txtNombre.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 62);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 32;
            label8.Text = "Fecha Pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 205);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 29;
            label5.Text = "Monto Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 183);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 28;
            label4.Text = "Dni:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 123);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 26;
            label2.Text = "Apellido:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 60);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 25;
            label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtDni);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(22, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 250);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtConceptoPago);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textMontoTotal);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(txtNumeroCuenta);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(549, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(427, 250);
            groupBox3.TabIndex = 46;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de Pago";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnAbrirPlantilla
            // 
            btnAbrirPlantilla.BackColor = Color.FromArgb(36, 32, 40);
            btnAbrirPlantilla.Cursor = Cursors.Hand;
            btnAbrirPlantilla.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnAbrirPlantilla.FlatStyle = FlatStyle.Flat;
            btnAbrirPlantilla.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrirPlantilla.ForeColor = Color.LightGray;
            btnAbrirPlantilla.Location = new Point(487, 361);
            btnAbrirPlantilla.Margin = new Padding(3, 4, 3, 4);
            btnAbrirPlantilla.Name = "btnAbrirPlantilla";
            btnAbrirPlantilla.Size = new Size(152, 41);
            btnAbrirPlantilla.TabIndex = 47;
            btnAbrirPlantilla.Text = "Abrir Plantilla";
            btnAbrirPlantilla.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(36, 32, 40);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.LightGray;
            btnNuevo.Location = new Point(78, 361);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(117, 41);
            btnNuevo.TabIndex = 48;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 160);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 43;
            label3.Text = "Numero Cuenta:";
            // 
            // textMontoTotal
            // 
            textMontoTotal.Location = new Point(199, 202);
            textMontoTotal.Margin = new Padding(3, 4, 3, 4);
            textMontoTotal.Name = "textMontoTotal";
            textMontoTotal.Size = new Size(167, 27);
            textMontoTotal.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 112);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 45;
            label6.Text = "Concepto Pago:";
            // 
            // txtConceptoPago
            // 
            txtConceptoPago.Location = new Point(199, 109);
            txtConceptoPago.Margin = new Padding(3, 4, 3, 4);
            txtConceptoPago.Name = "txtConceptoPago";
            txtConceptoPago.Size = new Size(167, 27);
            txtConceptoPago.TabIndex = 46;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 422);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(954, 204);
            dataGridView1.TabIndex = 49;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 725);
            Controls.Add(dataGridView1);
            Controls.Add(btnNuevo);
            Controls.Add(btnAbrirPlantilla);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(btnGenerarPlantilla);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pagos";
            Text = "Pagos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label10;
        private Panel panel1;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Button btnGenerarPlantilla;
        private Button btnGuardar;
        private TextBox txtNumeroCuenta;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAbrirPlantilla;
        private Button btnNuevo;
        private Label label3;
        private TextBox textMontoTotal;
        private TextBox txtConceptoPago;
        private Label label6;
        private DataGridView dataGridView1;
    }
}