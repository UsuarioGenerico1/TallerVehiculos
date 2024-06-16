namespace TallerVehiculos
{
    partial class RegistroMecanico
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
            textDireccion = new TextBox();
            textExp = new TextBox();
            textEspecialidad = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            textCedula = new TextBox();
            label6 = new Label();
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
            groupBox1.Controls.Add(textDireccion);
            groupBox1.Controls.Add(textExp);
            groupBox1.Controls.Add(textEspecialidad);
            groupBox1.Controls.Add(textApellido);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(textCedula);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1128, 507);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Mecanico";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1082, 218);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.Enabled = false;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(703, 174);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 51);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Control;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(703, 64);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 51);
            btnGuardar.TabIndex = 13;
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
            btnActualizar.Location = new Point(703, 119);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(128, 51);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(137, 232);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(458, 30);
            textDireccion.TabIndex = 11;
            // 
            // textExp
            // 
            textExp.Location = new Point(137, 196);
            textExp.Name = "textExp";
            textExp.Size = new Size(458, 30);
            textExp.TabIndex = 10;
            // 
            // textEspecialidad
            // 
            textEspecialidad.Location = new Point(137, 158);
            textEspecialidad.Name = "textEspecialidad";
            textEspecialidad.Size = new Size(458, 30);
            textEspecialidad.TabIndex = 9;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(137, 121);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(458, 30);
            textApellido.TabIndex = 8;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(137, 85);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(458, 30);
            textNombre.TabIndex = 7;
            // 
            // textCedula
            // 
            textCedula.Location = new Point(137, 49);
            textCedula.Name = "textCedula";
            textCedula.Size = new Size(458, 30);
            textCedula.TabIndex = 6;
            textCedula.KeyPress += textCedula_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 239);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 5;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 203);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 4;
            label5.Text = "Experiencia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 167);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 3;
            label4.Text = "Especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 131);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 92);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 56);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 0;
            label1.Text = "Cedula";
            // 
            // RegistroMecanico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 507);
            Controls.Add(groupBox1);
            Name = "RegistroMecanico";
            Text = "RegistroMecanico";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textDireccion;
        private TextBox textExp;
        private TextBox textEspecialidad;
        private TextBox textApellido;
        private TextBox textNombre;
        private TextBox textCedula;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnActualizar;
    }
}