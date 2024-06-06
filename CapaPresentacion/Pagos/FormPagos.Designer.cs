namespace CapaPresentacion.Pagos
{
    partial class FormPagos
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            lblfecha = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblprecio = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            Editar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(353, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 25);
            label1.TabIndex = 0;
            label1.Text = " CONTROL DE PAGOS DE MANTENIMIENTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(745, 66);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 1;
            label2.Text = "Fecha Actual:";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblfecha.Location = new Point(857, 69);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(88, 17);
            lblfecha.TabIndex = 2;
            lblfecha.Text = "Fecha Actual:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblprecio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(58, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(933, 156);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area de Pagos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(111, 100);
            label7.Name = "label7";
            label7.Size = new Size(58, 17);
            label7.TabIndex = 13;
            label7.Text = "Vehiculo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(87, 45);
            label6.Name = "label6";
            label6.Size = new Size(107, 17);
            label6.TabIndex = 12;
            label6.Text = "Mantenimientos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(411, 45);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 10;
            label4.Text = "Componente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(504, 44);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 74);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 7;
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblprecio.Location = new Point(813, 90);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(21, 16);
            lblprecio.TabIndex = 6;
            lblprecio.Text = "S/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(744, 43);
            label3.Name = "label3";
            label3.Size = new Size(163, 17);
            label3.TabIndex = 5;
            label3.Text = "Costo Del mantenimiento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(207, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 23);
            comboBox1.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 90);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Externo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 43);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Interno";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(145, 252);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(708, 297);
            dataGridView1.TabIndex = 4;
            // 
            // Editar
            // 
            Editar.BackColor = Color.FromArgb(36, 32, 40);
            Editar.Cursor = Cursors.Hand;
            Editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.ForeColor = Color.LightGray;
            Editar.Location = new Point(889, 274);
            Editar.Name = "Editar";
            Editar.Size = new Size(102, 31);
            Editar.TabIndex = 9;
            Editar.Text = "Factura";
            Editar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 32, 40);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(889, 334);
            button1.Name = "button1";
            button1.Size = new Size(102, 31);
            button1.TabIndex = 10;
            button1.Text = "Boleta";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(36, 32, 40);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.LightGray;
            button2.Location = new Point(889, 399);
            button2.Name = "button2";
            button2.Size = new Size(102, 31);
            button2.TabIndex = 11;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(36, 32, 40);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.LightGray;
            button3.Location = new Point(889, 466);
            button3.Name = "button3";
            button3.Size = new Size(102, 31);
            button3.TabIndex = 12;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 561);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Editar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(lblfecha);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPagos";
            Text = "FormPagos";
            Load += FormPagos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblfecha;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label lblprecio;
        private Label label3;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button Editar;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}