﻿namespace CapaPresentacion.Conductores
{
    partial class ListConductores
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
            btnAgregar = new Button();
            btnEliminar = new Button();
            Editar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            lblCountConductores = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(36, 32, 40);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.LightGray;
            btnAgregar.Location = new Point(894, 185);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 31);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(36, 32, 40);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.LightGray;
            btnEliminar.Location = new Point(894, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 31);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Editar
            // 
            Editar.BackColor = Color.FromArgb(36, 32, 40);
            Editar.Cursor = Cursors.Hand;
            Editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            Editar.FlatStyle = FlatStyle.Flat;
            Editar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.ForeColor = Color.LightGray;
            Editar.Location = new Point(894, 257);
            Editar.Name = "Editar";
            Editar.Size = new Size(102, 31);
            Editar.TabIndex = 4;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = false;
            Editar.Click += Editar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(435, 19);
            label1.Name = "label1";
            label1.Size = new Size(241, 32);
            label1.TabIndex = 5;
            label1.Text = "Gestion Conductores";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 85);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Bucar Por DNI...";
            textBox1.Size = new Size(328, 23);
            textBox1.TabIndex = 6;
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
            dataGridView1.Location = new Point(30, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(838, 414);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(590, 96);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 8;
            label2.Text = "Cantidad Conductores :";
            // 
            // lblCountConductores
            // 
            lblCountConductores.AutoSize = true;
            lblCountConductores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountConductores.Location = new Point(728, 96);
            lblCountConductores.Name = "lblCountConductores";
            lblCountConductores.Size = new Size(0, 15);
            lblCountConductores.TabIndex = 9;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(36, 32, 40);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 115, 5);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.LightGray;
            btnActualizar.Location = new Point(894, 412);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(102, 31);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ListConductores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1040, 540);
            Controls.Add(btnActualizar);
            Controls.Add(lblCountConductores);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Editar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListConductores";
            Text = "ListConductores";
            Load += ListConductores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEliminar;
        private Button Editar;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label lblCountConductores;
        private Button btnActualizar;
    }
}