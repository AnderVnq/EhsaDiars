namespace CapaPresentacion.Mantenimiento
{
    partial class ManteExterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManteExterno));
            btnCancelar = new Button();
            btnAsignar = new Button();
            dataGridView1 = new DataGridView();
            dateFechaFin = new DateTimePicker();
            datetimeFechaInicio = new DateTimePicker();
            groupBox2 = new GroupBox();
            comboMante = new ComboBox();
            groupBox1 = new GroupBox();
            comboContratista = new ComboBox();
            panel2 = new Panel();
            label2 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(36, 32, 40);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.LightGray;
            btnCancelar.Location = new Point(611, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 31);
            btnCancelar.TabIndex = 58;
            btnCancelar.Text = "Eliminar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.FromArgb(36, 32, 40);
            btnAsignar.Cursor = Cursors.Hand;
            btnAsignar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsignar.ForeColor = Color.LightGray;
            btnAsignar.Location = new Point(611, 89);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(104, 31);
            btnAsignar.TabIndex = 57;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(621, 248);
            dataGridView1.TabIndex = 56;
            // 
            // dateFechaFin
            // 
            dateFechaFin.Location = new Point(293, 97);
            dateFechaFin.Name = "dateFechaFin";
            dateFechaFin.Size = new Size(250, 23);
            dateFechaFin.TabIndex = 55;
            // 
            // datetimeFechaInicio
            // 
            datetimeFechaInicio.Location = new Point(28, 97);
            datetimeFechaInicio.Name = "datetimeFechaInicio";
            datetimeFechaInicio.Size = new Size(242, 23);
            datetimeFechaInicio.TabIndex = 54;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboMante);
            groupBox2.Location = new Point(28, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 97);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccionar Mantenimientos ";
            // 
            // comboMante
            // 
            comboMante.FormattingEnabled = true;
            comboMante.Location = new Point(6, 43);
            comboMante.Name = "comboMante";
            comboMante.Size = new Size(230, 23);
            comboMante.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboContratista);
            groupBox1.Location = new Point(293, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 97);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccionar Contratista";
            // 
            // comboContratista
            // 
            comboContratista.FormattingEnabled = true;
            comboContratista.Location = new Point(6, 43);
            comboContratista.Name = "comboContratista";
            comboContratista.Size = new Size(238, 23);
            comboContratista.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 115, 5);
            panel2.ForeColor = Color.Coral;
            panel2.Location = new Point(293, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 3);
            panel2.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(28, 65);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 50;
            label2.Text = "Fecha Inicio";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(247, 115, 5);
            panel8.ForeColor = Color.Coral;
            panel8.Location = new Point(28, 120);
            panel8.Name = "panel8";
            panel8.Size = new Size(242, 3);
            panel8.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(293, 65);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 48;
            label3.Text = "Fecha Fin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 115, 5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 27);
            panel1.TabIndex = 47;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(706, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(293, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 0;
            label1.Text = "Asignacion Mantenimiento";
            label1.MouseDown += label1_MouseDown;
            // 
            // ManteExterno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 525);
            Controls.Add(btnCancelar);
            Controls.Add(btnAsignar);
            Controls.Add(dataGridView1);
            Controls.Add(dateFechaFin);
            Controls.Add(datetimeFechaInicio);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel8);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManteExterno";
            Text = "ManteExterno";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAsignar;
        private DataGridView dataGridView1;
        private DateTimePicker dateFechaFin;
        private DateTimePicker datetimeFechaInicio;
        private GroupBox groupBox2;
        private ComboBox comboMante;
        private GroupBox groupBox1;
        private ComboBox comboContratista;
        private Panel panel2;
        private Label label2;
        private Panel panel8;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}