namespace TallerVehiculos
{
    partial class Mantenimiento
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
            panel1 = new Panel();
            button1 = new Button();
            groupBox4 = new GroupBox();
            textIVA = new TextBox();
            label10 = new Label();
            checkedListBox1 = new CheckedListBox();
            textDiagnostico = new TextBox();
            richTextTrabajos = new RichTextBox();
            dateTimePickerM = new DateTimePicker();
            cbTipoMantenimiento = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            textColor = new TextBox();
            textModelo = new TextBox();
            textMarca = new TextBox();
            textPlaca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtEspecialidad = new TextBox();
            txtNombreMecanico = new TextBox();
            label16 = new Label();
            label15 = new Label();
            cbCedulaMecanico = new ComboBox();
            label14 = new Label();
            groupBox1 = new GroupBox();
            label13 = new Label();
            txtCorreoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            label12 = new Label();
            label11 = new Label();
            cbCedula = new ComboBox();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 774);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(347, 681);
            button1.Name = "button1";
            button1.Size = new Size(384, 81);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Khaki;
            groupBox4.Controls.Add(textIVA);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(checkedListBox1);
            groupBox4.Controls.Add(textDiagnostico);
            groupBox4.Controls.Add(richTextTrabajos);
            groupBox4.Controls.Add(dateTimePickerM);
            groupBox4.Controls.Add(cbTipoMantenimiento);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 353);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1121, 311);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Mantenimiento";
            // 
            // textIVA
            // 
            textIVA.Location = new Point(764, 41);
            textIVA.Name = "textIVA";
            textIVA.Size = new Size(314, 30);
            textIVA.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(715, 47);
            label10.Name = "label10";
            label10.Size = new Size(42, 23);
            label10.TabIndex = 12;
            label10.Text = " IVA";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(28, 151);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(371, 154);
            checkedListBox1.TabIndex = 11;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // textDiagnostico
            // 
            textDiagnostico.Location = new Point(764, 78);
            textDiagnostico.Name = "textDiagnostico";
            textDiagnostico.Size = new Size(314, 30);
            textDiagnostico.TabIndex = 10;
            // 
            // richTextTrabajos
            // 
            richTextTrabajos.Location = new Point(652, 151);
            richTextTrabajos.Name = "richTextTrabajos";
            richTextTrabajos.Size = new Size(409, 154);
            richTextTrabajos.TabIndex = 9;
            richTextTrabajos.Text = "";
            // 
            // dateTimePickerM
            // 
            dateTimePickerM.Location = new Point(242, 41);
            dateTimePickerM.Name = "dateTimePickerM";
            dateTimePickerM.Size = new Size(346, 30);
            dateTimePickerM.TabIndex = 8;
            // 
            // cbTipoMantenimiento
            // 
            cbTipoMantenimiento.FormattingEnabled = true;
            cbTipoMantenimiento.Location = new Point(242, 77);
            cbTipoMantenimiento.Name = "cbTipoMantenimiento";
            cbTipoMantenimiento.Size = new Size(346, 31);
            cbTipoMantenimiento.TabIndex = 7;
            cbTipoMantenimiento.SelectedIndexChanged += cbTipoMantenimiento_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 128);
            label9.Name = "label9";
            label9.Size = new Size(81, 23);
            label9.TabIndex = 4;
            label9.Text = "Servicios";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(652, 85);
            label8.Name = "label8";
            label8.Size = new Size(105, 23);
            label8.TabIndex = 3;
            label8.Text = "Diagnostico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(30, 85);
            label7.Name = "label7";
            label7.Size = new Size(199, 23);
            label7.TabIndex = 2;
            label7.Text = "Tipo de mantenimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(652, 125);
            label6.Name = "label6";
            label6.Size = new Size(162, 23);
            label6.TabIndex = 1;
            label6.Text = "Trabajos realizados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 50);
            label5.Name = "label5";
            label5.Size = new Size(208, 23);
            label5.TabIndex = 0;
            label5.Text = "Fecha de mantenimiento";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textColor);
            groupBox3.Controls.Add(textModelo);
            groupBox3.Controls.Add(textMarca);
            groupBox3.Controls.Add(textPlaca);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1121, 129);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del vehiculo";
            // 
            // textColor
            // 
            textColor.Location = new Point(491, 75);
            textColor.Name = "textColor";
            textColor.Size = new Size(275, 27);
            textColor.TabIndex = 7;
            // 
            // textModelo
            // 
            textModelo.Location = new Point(96, 75);
            textModelo.Name = "textModelo";
            textModelo.Size = new Size(269, 27);
            textModelo.TabIndex = 6;
            // 
            // textMarca
            // 
            textMarca.Location = new Point(491, 42);
            textMarca.Name = "textMarca";
            textMarca.Size = new Size(275, 27);
            textMarca.TabIndex = 5;
            // 
            // textPlaca
            // 
            textPlaca.Location = new Point(96, 42);
            textPlaca.Name = "textPlaca";
            textPlaca.Size = new Size(269, 27);
            textPlaca.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(425, 79);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 3;
            label4.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 79);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 2;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(419, 46);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 46);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 0;
            label1.Text = "Placa";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEspecialidad);
            groupBox2.Controls.Add(txtNombreMecanico);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(cbCedulaMecanico);
            groupBox2.Controls.Add(label14);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1121, 111);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del mecanico";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(486, 65);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(275, 27);
            txtEspecialidad.TabIndex = 5;
            // 
            // txtNombreMecanico
            // 
            txtNombreMecanico.Location = new Point(486, 32);
            txtNombreMecanico.Name = "txtNombreMecanico";
            txtNombreMecanico.Size = new Size(275, 27);
            txtNombreMecanico.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(369, 69);
            label16.Name = "label16";
            label16.Size = new Size(109, 23);
            label16.TabIndex = 3;
            label16.Text = "Especialidad";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(402, 36);
            label15.Name = "label15";
            label15.Size = new Size(76, 23);
            label15.TabIndex = 2;
            label15.Text = "Nombre";
            // 
            // cbCedulaMecanico
            // 
            cbCedulaMecanico.FormattingEnabled = true;
            cbCedulaMecanico.Location = new Point(108, 34);
            cbCedulaMecanico.Name = "cbCedulaMecanico";
            cbCedulaMecanico.Size = new Size(226, 28);
            cbCedulaMecanico.TabIndex = 1;
            cbCedulaMecanico.SelectedIndexChanged += cbCedulaMecanico_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(30, 39);
            label14.Name = "label14";
            label14.Size = new Size(65, 23);
            label14.TabIndex = 0;
            label14.Text = "Cedula";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtCorreoCliente);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cbCedula);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1121, 113);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(28, 78);
            label13.Name = "label13";
            label13.Size = new Size(157, 23);
            label13.TabIndex = 6;
            label13.Text = "Correo Electronico";
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(196, 74);
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(565, 27);
            txtCorreoCliente.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(486, 41);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(275, 27);
            txtNombreCliente.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(402, 45);
            label12.Name = "label12";
            label12.Size = new Size(76, 23);
            label12.TabIndex = 3;
            label12.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(28, 47);
            label11.Name = "label11";
            label11.Size = new Size(65, 23);
            label11.TabIndex = 2;
            label11.Text = "Cedula";
            // 
            // cbCedula
            // 
            cbCedula.FormattingEnabled = true;
            cbCedula.Location = new Point(108, 40);
            cbCedula.Name = "cbCedula";
            cbCedula.Size = new Size(226, 28);
            cbCedula.TabIndex = 0;
            cbCedula.SelectedIndexChanged += cbCedula_SelectedIndexChanged;
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1121, 774);
            Controls.Add(panel1);
            Name = "Mantenimiento";
            Text = "Mantenimiento";
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textColor;
        private TextBox textModelo;
        private TextBox textMarca;
        private TextBox textPlaca;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label12;
        private Label label11;
        private ComboBox cbCedula;
        private ComboBox cbCedulaMecanico;
        private Label label14;
        private Label label13;
        private TextBox txtCorreoCliente;
        private TextBox txtNombreCliente;
        private Label label16;
        private Label label15;
        private TextBox txtEspecialidad;
        private TextBox txtNombreMecanico;
        private RichTextBox richTextTrabajos;
        private DateTimePicker dateTimePickerM;
        private ComboBox cbTipoMantenimiento;
        private Button button1;
        private TextBox textDiagnostico;
        private CheckedListBox checkedListBox1;
        private TextBox textIVA;
        private Label label10;
    }
}