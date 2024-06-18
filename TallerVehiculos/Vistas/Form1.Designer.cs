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
            menuStrip1 = new MenuStrip();
            iNFOToolStripMenuItem = new ToolStripMenuItem();
            integrantesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(213, 75);
            label1.Name = "label1";
            label1.Size = new Size(369, 62);
            label1.TabIndex = 0;
            label1.Text = "Taller Mecanico";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_rg_cliente
            // 
            btn_rg_cliente.BackColor = SystemColors.Control;
            btn_rg_cliente.FlatStyle = FlatStyle.Flat;
            btn_rg_cliente.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_rg_cliente.ForeColor = SystemColors.ControlText;
            btn_rg_cliente.Location = new Point(122, 140);
            btn_rg_cliente.Name = "btn_rg_cliente";
            btn_rg_cliente.Size = new Size(535, 115);
            btn_rg_cliente.TabIndex = 1;
            btn_rg_cliente.Text = "Registar Cliente";
            btn_rg_cliente.UseVisualStyleBackColor = false;
            btn_rg_cliente.Click += btn_rg_cliente_Click;
            // 
            // btn_rg_mecanico
            // 
            btn_rg_mecanico.BackColor = SystemColors.Control;
            btn_rg_mecanico.FlatStyle = FlatStyle.Flat;
            btn_rg_mecanico.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_rg_mecanico.ForeColor = SystemColors.ControlText;
            btn_rg_mecanico.Location = new Point(122, 261);
            btn_rg_mecanico.Name = "btn_rg_mecanico";
            btn_rg_mecanico.Size = new Size(535, 115);
            btn_rg_mecanico.TabIndex = 2;
            btn_rg_mecanico.Text = "Registar Mecanico";
            btn_rg_mecanico.UseVisualStyleBackColor = false;
            btn_rg_mecanico.Click += btn_rg_mecanico_Click;
            // 
            // btn_gr_mantenimiento
            // 
            btn_gr_mantenimiento.BackColor = SystemColors.Control;
            btn_gr_mantenimiento.FlatStyle = FlatStyle.Flat;
            btn_gr_mantenimiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gr_mantenimiento.ForeColor = SystemColors.ControlText;
            btn_gr_mantenimiento.Location = new Point(122, 382);
            btn_gr_mantenimiento.Name = "btn_gr_mantenimiento";
            btn_gr_mantenimiento.Size = new Size(535, 115);
            btn_gr_mantenimiento.TabIndex = 3;
            btn_gr_mantenimiento.Text = "Registrar Mantenimiento";
            btn_gr_mantenimiento.UseVisualStyleBackColor = false;
            btn_gr_mantenimiento.Click += btn_gr_mantenimiento_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNFOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNFOToolStripMenuItem
            // 
            iNFOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { integrantesToolStripMenuItem });
            iNFOToolStripMenuItem.Name = "iNFOToolStripMenuItem";
            iNFOToolStripMenuItem.Size = new Size(56, 24);
            iNFOToolStripMenuItem.Text = "INFO";
            // 
            // integrantesToolStripMenuItem
            // 
            integrantesToolStripMenuItem.Name = "integrantesToolStripMenuItem";
            integrantesToolStripMenuItem.Size = new Size(166, 26);
            integrantesToolStripMenuItem.Text = "Integrantes";
            integrantesToolStripMenuItem.Click += integrantesToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(782, 600);
            Controls.Add(btn_gr_mantenimiento);
            Controls.Add(label1);
            Controls.Add(btn_rg_mecanico);
            Controls.Add(btn_rg_cliente);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = " ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_rg_cliente;
        private Button btn_rg_mecanico;
        private Button btn_gr_mantenimiento;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNFOToolStripMenuItem;
        private ToolStripMenuItem integrantesToolStripMenuItem;
    }
}
