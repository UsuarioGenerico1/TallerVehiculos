namespace TallerVehiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_rg_cliente = new Button();
            btn_rg_mecanico = new Button();
            btn_gr_mantenimiento = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(369, 62);
            label1.TabIndex = 0;
            label1.Text = "Taller Mecanico";
            // 
            // btn_rg_cliente
            // 
            btn_rg_cliente.Location = new Point(434, 335);
            btn_rg_cliente.Name = "btn_rg_cliente";
            btn_rg_cliente.Size = new Size(437, 66);
            btn_rg_cliente.TabIndex = 1;
            btn_rg_cliente.Text = "Registar Cliente";
            btn_rg_cliente.UseVisualStyleBackColor = true;
            btn_rg_cliente.Click += btn_rg_cliente_Click;
            // 
            // btn_rg_mecanico
            // 
            btn_rg_mecanico.Location = new Point(434, 258);
            btn_rg_mecanico.Name = "btn_rg_mecanico";
            btn_rg_mecanico.Size = new Size(437, 71);
            btn_rg_mecanico.TabIndex = 2;
            btn_rg_mecanico.Text = "Registar Mecanico";
            btn_rg_mecanico.UseVisualStyleBackColor = true;
            btn_rg_mecanico.Click += btn_rg_mecanico_Click;
            // 
            // btn_gr_mantenimiento
            // 
            btn_gr_mantenimiento.Location = new Point(434, 170);
            btn_gr_mantenimiento.Name = "btn_gr_mantenimiento";
            btn_gr_mantenimiento.Size = new Size(437, 82);
            btn_gr_mantenimiento.TabIndex = 3;
            btn_gr_mantenimiento.Text = "Registrar Mantenimiento";
            btn_gr_mantenimiento.UseVisualStyleBackColor = true;
            btn_gr_mantenimiento.Click += btn_gr_mantenimiento_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btn_gr_mantenimiento);
            Controls.Add(btn_rg_mecanico);
            Controls.Add(btn_rg_cliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = " Taller Mecanico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_rg_cliente;
        private Button btn_rg_mecanico;
        private Button btn_gr_mantenimiento;
    }
}
