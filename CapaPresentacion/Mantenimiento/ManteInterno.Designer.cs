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
            label1 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            datetimeFechaInicio = new DateTimePicker();
            dateFechaFin = new DateTimePicker();
            comboMante = new ComboBox();
            comboContratista = new ComboBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            groupBox1.Controls.Add(comboContratista);
            groupBox1.Location = new Point(293, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 97);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccionar Contratista Disponible";
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
            // comboMante
            // 
            comboMante.FormattingEnabled = true;
            comboMante.Location = new Point(6, 43);
            comboMante.Name = "comboMante";
            comboMante.Size = new Size(230, 23);
            comboMante.TabIndex = 0;
            // 
            // comboContratista
            // 
            comboContratista.FormattingEnabled = true;
            comboContratista.Location = new Point(6, 43);
            comboContratista.Name = "comboContratista";
            comboContratista.Size = new Size(238, 23);
            comboContratista.TabIndex = 0;
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
            // 
            // ManteInterno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 525);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private ComboBox comboContratista;
        private GroupBox groupBox2;
        private ComboBox comboMante;
        private DateTimePicker datetimeFechaInicio;
        private DateTimePicker dateFechaFin;
        private PictureBox pictureBox2;
    }
}