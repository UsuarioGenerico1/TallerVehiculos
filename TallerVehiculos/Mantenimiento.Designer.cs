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
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 701);
            panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(0, 488);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1051, 166);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Mantenimiento";
            // 
            // groupBox3
            // 
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 295);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1051, 193);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del vehiculo";
            // 
            // groupBox2
            // 
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1051, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del mecanico";
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1051, 170);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 701);
            Controls.Add(panel1);
            Name = "Mantenimiento";
            Text = "Mantenimiento";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}