namespace CapaPresentacion.Mantenimiento
{
    partial class ManteInterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManteInterno));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            comboTaller = new ComboBox();
            groupBox2 = new GroupBox();
            comboMante = new ComboBox();
            datetimeFechaInicio = new DateTimePicker();
            dateFechaFin = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnAsignar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(575, 27);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(534, -2);
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
            label1.Location = new Point(174, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 0;
            label1.Text = "Asignacion Mantenimiento";
            label1.MouseDown += label1_MouseDown;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(247, 115, 5);
            panel8.ForeColor = Color.Coral;
            panel8.Location = new Point(28, 114);
            panel8.Name = "panel8";
            panel8.Size = new Size(242, 3);
            panel8.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(293, 59);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 27;
            label3.Text = "Fecha Fin";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 115, 5);
            panel2.ForeColor = Color.Coral;
            panel2.Location = new Point(293, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 3);
            panel2.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(28, 59);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 30;
            label2.Text = "Fecha Inicio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboTaller);
            groupBox1.Location = new Point(293, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 97);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccionar Taller";
            // 
            // comboTaller
            // 
            comboTaller.FormattingEnabled = true;
            comboTaller.Location = new Point(6, 43);
            comboTaller.Name = "comboTaller";
            comboTaller.Size = new Size(238, 23);
            comboTaller.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboMante);
            groupBox2.Location = new Point(28, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 97);
            groupBox2.TabIndex = 40;
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
            // datetimeFechaInicio
            // 
            datetimeFechaInicio.Location = new Point(28, 91);
            datetimeFechaInicio.Name = "datetimeFechaInicio";
            datetimeFechaInicio.Size = new Size(242, 23);
            datetimeFechaInicio.TabIndex = 41;
            // 
            // dateFechaFin
            // 
            dateFechaFin.Location = new Point(293, 91);
            dateFechaFin.Name = "dateFechaFin";
            dateFechaFin.Size = new Size(250, 23);
            dateFechaFin.TabIndex = 42;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(515, 179);
            dataGridView1.TabIndex = 43;
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.FromArgb(36, 32, 40);
            btnAsignar.Cursor = Cursors.Hand;
            btnAsignar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsignar.ForeColor = Color.LightGray;
            btnAsignar.Location = new Point(102, 271);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(104, 31);
            btnAsignar.TabIndex = 44;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(36, 32, 40);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.LightGray;
            btnCancelar.Location = new Point(371, 271);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 31);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Eliminar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // ManteInterno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 525);
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
            Name = "ManteInterno";
            Text = "ManteInterno";
            Load += ManteInterno_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel8;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private GroupBox groupBox1;
        private ComboBox comboTaller;
        private GroupBox groupBox2;
        private ComboBox comboMante;
        private DateTimePicker datetimeFechaInicio;
        private DateTimePicker dateFechaFin;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button btnAsignar;
        private Button btnCancelar;
    }
}