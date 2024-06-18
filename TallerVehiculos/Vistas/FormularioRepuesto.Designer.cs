namespace TallerVehiculos.Vistas
{
    partial class FormularioRepuesto
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
            btnEliminar = new Button();
            btnGuardar = new Button();
            dataGridViewR = new DataGridView();
            textPrecio = new TextBox();
            textRepuesto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewR).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(dataGridViewR);
            groupBox1.Controls.Add(textPrecio);
            groupBox1.Controls.Add(textRepuesto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Repuestos";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(635, 64);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 52);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Control;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(509, 64);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 52);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridViewR
            // 
            dataGridViewR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewR.Location = new Point(23, 139);
            dataGridViewR.Name = "dataGridViewR";
            dataGridViewR.RowHeadersWidth = 51;
            dataGridViewR.RowTemplate.Height = 29;
            dataGridViewR.Size = new Size(714, 188);
            dataGridViewR.TabIndex = 4;
            dataGridViewR.CellClick += dataGridViewR_CellClick;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(180, 94);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(277, 27);
            textPrecio.TabIndex = 3;
            textPrecio.KeyPress += textPrecio_KeyPress;
            // 
            // textRepuesto
            // 
            textRepuesto.Location = new Point(180, 61);
            textRepuesto.Name = "textRepuesto";
            textRepuesto.Size = new Size(275, 27);
            textRepuesto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(115, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 64);
            label1.Name = "label1";
            label1.Size = new Size(155, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre Repuesto";
            // 
            // FormularioRepuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 377);
            Controls.Add(groupBox1);
            Name = "FormularioRepuesto";
            Text = "FormularioRepuesto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dataGridViewR;
        private TextBox textPrecio;
        private TextBox textRepuesto;
        private Label label2;
        private Label label1;
    }
}