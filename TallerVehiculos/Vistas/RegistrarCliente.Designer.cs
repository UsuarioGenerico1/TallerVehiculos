﻿namespace TallerVehiculos
{
    partial class RegistrarCliente
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnActualizar = new Button();
            dateTimePicker1 = new DateTimePicker();
            textCorreo = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            textCedula = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Khaki;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textCorreo);
            groupBox1.Controls.Add(textApellido);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(textCedula);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 501);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Del Cliente";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(938, 230);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CelltClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.Enabled = false;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ControlText;
            btnEliminar.Location = new Point(710, 145);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 38);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Control;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(710, 53);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 40);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Control;
            btnActualizar.Enabled = false;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = SystemColors.ControlText;
            btnActualizar.Location = new Point(710, 99);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(144, 40);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(202, 185);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(425, 30);
            dateTimePicker1.TabIndex = 9;
            // 
            // textCorreo
            // 
            textCorreo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textCorreo.Location = new Point(202, 149);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(425, 30);
            textCorreo.TabIndex = 8;
            // 
            // textApellido
            // 
            textApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textApellido.Location = new Point(133, 109);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(494, 30);
            textApellido.TabIndex = 7;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textNombre.Location = new Point(133, 73);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(494, 30);
            textNombre.TabIndex = 6;
            // 
            // textCedula
            // 
            textCedula.BorderStyle = BorderStyle.FixedSingle;
            textCedula.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textCedula.Location = new Point(133, 37);
            textCedula.Name = "textCedula";
            textCedula.Size = new Size(494, 30);
            textCedula.TabIndex = 5;
            textCedula.KeyPress += textCedula_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 191);
            label5.Name = "label5";
            label5.Size = new Size(141, 23);
            label5.TabIndex = 4;
            label5.Text = "Fecha de registro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 152);
            label4.Name = "label4";
            label4.Size = new Size(151, 23);
            label4.TabIndex = 3;
            label4.Text = "Correo Electronico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 116);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 80);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 40);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 0;
            label1.Text = "Cedula";
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 501);
            Controls.Add(groupBox1);
            Name = "RegistrarCliente";
            Text = "RegistrarCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textNombre;
        private TextBox textCedula;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textCorreo;
        private TextBox textApellido;
        private Button btnActualizar;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}