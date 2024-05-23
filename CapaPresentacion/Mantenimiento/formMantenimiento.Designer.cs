namespace CapaPresentacion.Mantenimiento
{
    partial class formMantenimiento
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnActualizar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnEliminar = new Button();
            btnAgregar = new Button();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtcomentario = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtcosto = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            txtcomponente = new TextBox();
            txtKilometraje = new TextBox();
            panel1 = new Panel();
            panel8 = new Panel();
            label4 = new Label();
            label3 = new Label();
            btnAsigInterna = new Button();
            btnAsigExterna = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(36, 32, 40);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.LightGray;
            btnActualizar.Location = new Point(872, 452);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(102, 31);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(39, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(779, 234);
            dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(467, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 32);
            label1.TabIndex = 14;
            label1.Text = "Mantenimientos";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(36, 32, 40);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.LightGray;
            btnEliminar.Location = new Point(852, 206);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 31);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(36, 32, 40);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.LightGray;
            btnAgregar.Location = new Point(852, 126);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 31);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtcomentario);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtcosto);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtcomponente);
            groupBox1.Controls.Add(txtKilometraje);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(panel8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(54, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 251);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro Mantenimiento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(351, 226);
            label9.Name = "label9";
            label9.Size = new Size(43, 17);
            label9.TabIndex = 38;
            label9.Text = "Fecha";
            // 
            // txtcomentario
            // 
            txtcomentario.Location = new Point(351, 146);
            txtcomentario.Multiline = true;
            txtcomentario.Name = "txtcomentario";
            txtcomentario.Size = new Size(286, 66);
            txtcomentario.TabIndex = 37;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Preventivo", "Correctivo" });
            comboBox2.Location = new Point(351, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(286, 23);
            comboBox2.TabIndex = 36;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(351, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 23);
            comboBox1.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(420, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(351, 126);
            label8.Name = "label8";
            label8.Size = new Size(77, 17);
            label8.TabIndex = 32;
            label8.Text = "Comentario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(351, 77);
            label7.Name = "label7";
            label7.Size = new Size(129, 17);
            label7.TabIndex = 31;
            label7.Text = "Tipo Mantenimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(351, 31);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 30;
            label6.Text = "Vehiculo";
            // 
            // txtcosto
            // 
            txtcosto.Location = new Point(6, 172);
            txtcosto.Name = "txtcosto";
            txtcosto.Size = new Size(226, 23);
            txtcosto.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 115, 5);
            panel2.ForeColor = Color.Coral;
            panel2.Location = new Point(6, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 3);
            panel2.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(6, 152);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 27;
            label5.Text = "Costo";
            // 
            // txtcomponente
            // 
            txtcomponente.Location = new Point(6, 112);
            txtcomponente.Name = "txtcomponente";
            txtcomponente.Size = new Size(226, 23);
            txtcomponente.TabIndex = 26;
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(6, 51);
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.Size = new Size(226, 23);
            txtKilometraje.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 115, 5);
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(6, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 3);
            panel1.TabIndex = 25;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(247, 115, 5);
            panel8.ForeColor = Color.Coral;
            panel8.Location = new Point(6, 74);
            panel8.Name = "panel8";
            panel8.Size = new Size(226, 3);
            panel8.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(6, 92);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 24;
            label4.Text = "Componente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 24;
            label3.Text = "Kilometraje";
            // 
            // btnAsigInterna
            // 
            btnAsigInterna.BackColor = Color.FromArgb(36, 32, 40);
            btnAsigInterna.Cursor = Cursors.Hand;
            btnAsigInterna.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnAsigInterna.FlatStyle = FlatStyle.Flat;
            btnAsigInterna.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsigInterna.ForeColor = Color.LightGray;
            btnAsigInterna.Location = new Point(852, 334);
            btnAsigInterna.Name = "btnAsigInterna";
            btnAsigInterna.Size = new Size(140, 31);
            btnAsigInterna.TabIndex = 21;
            btnAsigInterna.Text = "Asignacion Interna";
            btnAsigInterna.UseVisualStyleBackColor = false;
            btnAsigInterna.Click += btnAsigInterna_Click;
            // 
            // btnAsigExterna
            // 
            btnAsigExterna.BackColor = Color.FromArgb(36, 32, 40);
            btnAsigExterna.Cursor = Cursors.Hand;
            btnAsigExterna.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnAsigExterna.FlatStyle = FlatStyle.Flat;
            btnAsigExterna.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsigExterna.ForeColor = Color.LightGray;
            btnAsigExterna.Location = new Point(852, 399);
            btnAsigExterna.Name = "btnAsigExterna";
            btnAsigExterna.Size = new Size(140, 31);
            btnAsigExterna.TabIndex = 22;
            btnAsigExterna.Text = "Asignacion Externa";
            btnAsigExterna.UseVisualStyleBackColor = false;
            btnAsigExterna.Click += btnAsigExterna_Click;
            // 
            // formMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 561);
            Controls.Add(btnAsigExterna);
            Controls.Add(btnAsigInterna);
            Controls.Add(groupBox1);
            Controls.Add(btnActualizar);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMantenimiento";
            Text = "formMantenimiento";
            Load += formMantenimiento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnEliminar;
        private Button btnAgregar;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtcosto;
        private Panel panel2;
        private Label label5;
        private TextBox txtcomponente;
        private TextBox txtKilometraje;
        private Panel panel1;
        private Panel panel8;
        private Label label4;
        private Label label3;
        private Label label9;
        private TextBox txtcomentario;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnAsigInterna;
        private Button btnAsigExterna;
    }
}