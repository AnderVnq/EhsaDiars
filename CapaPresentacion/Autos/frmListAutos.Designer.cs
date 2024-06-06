namespace CapaPresentacion.Autos
{
    partial class frmListAutos
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
            lblCountAutos = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            txtfiltrar = new TextBox();
            label1 = new Label();
            Editar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnDetalle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnActualizar.Location = new Point(901, 397);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(102, 31);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblCountAutos
            // 
            lblCountAutos.AutoSize = true;
            lblCountAutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountAutos.Location = new Point(735, 93);
            lblCountAutos.Name = "lblCountAutos";
            lblCountAutos.Size = new Size(0, 15);
            lblCountAutos.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(597, 93);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 17;
            label2.Text = "Cantidad Vehiculos :";
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
            dataGridView1.Location = new Point(37, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(838, 414);
            dataGridView1.TabIndex = 16;
            // 
            // txtfiltrar
            // 
            txtfiltrar.Location = new Point(37, 82);
            txtfiltrar.Name = "txtfiltrar";
            txtfiltrar.PlaceholderText = "Bucar Por Placa...";
            txtfiltrar.Size = new Size(328, 23);
            txtfiltrar.TabIndex = 15;
            txtfiltrar.TextChanged += txtfiltrar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(454, 20);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 14;
            label1.Text = "Gestion Autos";
            // 
            // Editar
            // 
            Editar.BackColor = Color.FromArgb(36, 32, 40);
            Editar.Cursor = Cursors.Hand;
            Editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.ForeColor = Color.LightGray;
            Editar.Location = new Point(901, 291);
            Editar.Name = "Editar";
            Editar.Size = new Size(102, 31);
            Editar.TabIndex = 13;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = false;
            Editar.Click += Editar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(36, 32, 40);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.LightGray;
            btnEliminar.Location = new Point(901, 343);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 31);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(36, 32, 40);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.LightGray;
            btnAgregar.Location = new Point(901, 236);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 31);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDetalle
            // 
            btnDetalle.BackColor = Color.FromArgb(36, 32, 40);
            btnDetalle.Cursor = Cursors.Hand;
            btnDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnDetalle.FlatStyle = FlatStyle.Flat;
            btnDetalle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetalle.ForeColor = Color.LightGray;
            btnDetalle.Location = new Point(901, 188);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(102, 31);
            btnDetalle.TabIndex = 20;
            btnDetalle.Text = "Ver detalle";
            btnDetalle.UseVisualStyleBackColor = false;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // frmListAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 540);
            Controls.Add(btnDetalle);
            Controls.Add(btnActualizar);
            Controls.Add(lblCountAutos);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtfiltrar);
            Controls.Add(label1);
            Controls.Add(Editar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListAutos";
            Text = "frmListAutos";
            Load += frmListAutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Label lblCountAutos;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtfiltrar;
        private Label label1;
        private Button Editar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnDetalle;
    }
}