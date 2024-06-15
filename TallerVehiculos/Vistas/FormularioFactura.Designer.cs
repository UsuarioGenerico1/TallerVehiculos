namespace TallerVehiculos.Vistas
{
    partial class FormularioFactura
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            label7 = new Label();
            textCorreo = new TextBox();
            label6 = new Label();
            textApellido = new TextBox();
            textNombre = new TextBox();
            textCedula = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            textTotal = new TextBox();
            textIVA = new TextBox();
            textSubTotal = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            textTotalM = new TextBox();
            label16 = new Label();
            textDiagnostico = new TextBox();
            label15 = new Label();
            label11 = new Label();
            rtbTrabajos = new RichTextBox();
            dgvServicio = new DataGridView();
            dgvTipoMantenimiento = new DataGridView();
            textTipoMantenimiento = new TextBox();
            dateTimePickerF = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label17 = new Label();
            label18 = new Label();
            textTotalServicios = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTipoMantenimiento).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1178, 950);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(315, 54);
            label1.TabIndex = 0;
            label1.Text = "Taller Mecanico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(34, 54);
            label2.TabIndex = 2;
            label2.Text = " ";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(groupBox1);
            flowLayoutPanel2.Controls.Add(groupBox3);
            flowLayoutPanel2.Location = new Point(3, 111);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1175, 270);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textCorreo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textApellido);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(textCedula);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(438, 114);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 8;
            // 
            // textCorreo
            // 
            textCorreo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textCorreo.Location = new Point(203, 172);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(333, 30);
            textCorreo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 178);
            label6.Name = "label6";
            label6.Size = new Size(157, 23);
            label6.TabIndex = 6;
            label6.Text = "Correo Electronico";
            // 
            // textApellido
            // 
            textApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textApellido.Location = new Point(115, 132);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(421, 30);
            textApellido.TabIndex = 5;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textNombre.Location = new Point(118, 92);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(420, 30);
            textNombre.TabIndex = 4;
            // 
            // textCedula
            // 
            textCedula.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textCedula.Location = new Point(118, 52);
            textCedula.Name = "textCedula";
            textCedula.Size = new Size(420, 30);
            textCedula.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 142);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 2;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 100);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 1;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 58);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 0;
            label3.Text = "Cedula";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textTotal);
            groupBox3.Controls.Add(textIVA);
            groupBox3.Controls.Add(textSubTotal);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(598, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(565, 245);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Total a pagar";
            // 
            // textTotal
            // 
            textTotal.Location = new Point(159, 137);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(194, 30);
            textTotal.TabIndex = 5;
            // 
            // textIVA
            // 
            textIVA.Location = new Point(159, 88);
            textIVA.Name = "textIVA";
            textIVA.Size = new Size(194, 30);
            textIVA.TabIndex = 4;
            // 
            // textSubTotal
            // 
            textSubTotal.Location = new Point(159, 45);
            textSubTotal.Name = "textSubTotal";
            textSubTotal.Size = new Size(194, 30);
            textSubTotal.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(32, 135);
            label14.Name = "label14";
            label14.Size = new Size(115, 23);
            label14.TabIndex = 2;
            label14.Text = "Total a pagar";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(32, 95);
            label13.Name = "label13";
            label13.Size = new Size(57, 23);
            label13.TabIndex = 1;
            label13.Text = "IVA %";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(32, 52);
            label12.Name = "label12";
            label12.Size = new Size(79, 23);
            label12.TabIndex = 0;
            label12.Text = "Subtotal";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textTotalServicios);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(textTotalM);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(textDiagnostico);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(rtbTrabajos);
            groupBox2.Controls.Add(dgvServicio);
            groupBox2.Controls.Add(dgvTipoMantenimiento);
            groupBox2.Controls.Add(textTipoMantenimiento);
            groupBox2.Controls.Add(dateTimePickerF);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(3, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1175, 381);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Mantenimiento";
            // 
            // textTotalM
            // 
            textTotalM.Location = new Point(58, 343);
            textTotalM.Name = "textTotalM";
            textTotalM.Size = new Size(125, 34);
            textTotalM.TabIndex = 12;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(12, 354);
            label16.Name = "label16";
            label16.Size = new Size(49, 23);
            label16.TabIndex = 11;
            label16.Text = "Total";
            // 
            // textDiagnostico
            // 
            textDiagnostico.Location = new Point(685, 34);
            textDiagnostico.Name = "textDiagnostico";
            textDiagnostico.Size = new Size(457, 34);
            textDiagnostico.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(574, 42);
            label15.Name = "label15";
            label15.Size = new Size(105, 23);
            label15.TabIndex = 9;
            label15.Text = "Diagnostico";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(419, 120);
            label11.Name = "label11";
            label11.Size = new Size(81, 23);
            label11.TabIndex = 8;
            label11.Text = "Servicios";
            // 
            // rtbTrabajos
            // 
            rtbTrabajos.Location = new Point(822, 152);
            rtbTrabajos.Name = "rtbTrabajos";
            rtbTrabajos.Size = new Size(315, 188);
            rtbTrabajos.TabIndex = 7;
            rtbTrabajos.Text = "";
            // 
            // dgvServicio
            // 
            dgvServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicio.Location = new Point(419, 152);
            dgvServicio.Name = "dgvServicio";
            dgvServicio.RowHeadersWidth = 51;
            dgvServicio.RowTemplate.Height = 29;
            dgvServicio.Size = new Size(375, 188);
            dgvServicio.TabIndex = 6;
            dgvServicio.CellContentClick += dgvServicio_CellContentClick;
            // 
            // dgvTipoMantenimiento
            // 
            dgvTipoMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoMantenimiento.Location = new Point(12, 152);
            dgvTipoMantenimiento.Name = "dgvTipoMantenimiento";
            dgvTipoMantenimiento.RowHeadersWidth = 51;
            dgvTipoMantenimiento.RowTemplate.Height = 29;
            dgvTipoMantenimiento.Size = new Size(385, 188);
            dgvTipoMantenimiento.TabIndex = 5;
            // 
            // textTipoMantenimiento
            // 
            textTipoMantenimiento.Location = new Point(227, 73);
            textTipoMantenimiento.Name = "textTipoMantenimiento";
            textTipoMantenimiento.Size = new Size(309, 34);
            textTipoMantenimiento.TabIndex = 4;
            // 
            // dateTimePickerF
            // 
            dateTimePickerF.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerF.Location = new Point(227, 36);
            dateTimePickerF.Name = "dateTimePickerF";
            dateTimePickerF.Size = new Size(309, 30);
            dateTimePickerF.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(822, 120);
            label10.Name = "label10";
            label10.Size = new Size(162, 23);
            label10.TabIndex = 2;
            label10.Text = "Trabajos realizados";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 81);
            label9.Name = "label9";
            label9.Size = new Size(199, 23);
            label9.TabIndex = 1;
            label9.Text = "Tipo de Mantenimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 43);
            label8.Name = "label8";
            label8.Size = new Size(208, 23);
            label8.TabIndex = 0;
            label8.Text = "Fecha de Mantenimiento";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(12, 120);
            label17.Name = "label17";
            label17.Size = new Size(150, 23);
            label17.TabIndex = 13;
            label17.Text = "Repuestos usados";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(419, 343);
            label18.Name = "label18";
            label18.Size = new Size(49, 23);
            label18.TabIndex = 14;
            label18.Text = "Total";
            // 
            // textTotalServicios
            // 
            textTotalServicios.Location = new Point(474, 343);
            textTotalServicios.Name = "textTotalServicios";
            textTotalServicios.Size = new Size(125, 34);
            textTotalServicios.TabIndex = 15;
            // 
            // FormularioFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1178, 950);
            Controls.Add(flowLayoutPanel1);
            Name = "FormularioFactura";
            Text = "FormularioFactura";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTipoMantenimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textApellido;
        private TextBox textNombre;
        private TextBox textCedula;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox textCorreo;
        private Label label6;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label10;
        private DateTimePicker dateTimePickerF;
        private TextBox textTipoMantenimiento;
        private DataGridView dgvServicio;
        private DataGridView dgvTipoMantenimiento;
        private RichTextBox rtbTrabajos;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox groupBox3;
        private Label label13;
        private Label label12;
        private TextBox textTotal;
        private TextBox textIVA;
        private TextBox textSubTotal;
        private Label label14;
        private TextBox textDiagnostico;
        private Label label15;
        private TextBox textTotalM;
        private Label label16;
        private Label label17;
        private TextBox textTotalServicios;
        private Label label18;
    }
}