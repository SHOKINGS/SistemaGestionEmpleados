namespace SistemaGestionEmpleados
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.desconectar_btn = new System.Windows.Forms.Button();
            this.salario_btn = new System.Windows.Forms.Button();
            this.agregarEmpleado_btn = new System.Windows.Forms.Button();
            this.panel_btn = new System.Windows.Forms.Button();
            this.greet_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new SistemaGestionEmpleados.Panel();
            this.addEmpleado2 = new SistemaGestionEmpleados.AddEmpleado();
            this.salario2 = new SistemaGestionEmpleados.Salario();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión De Empleados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.desconectar_btn);
            this.panel2.Controls.Add(this.salario_btn);
            this.panel2.Controls.Add(this.agregarEmpleado_btn);
            this.panel2.Controls.Add(this.panel_btn);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 750);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 710);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desconectar";
            // 
            // desconectar_btn
            // 
            this.desconectar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desconectar_btn.FlatAppearance.BorderSize = 0;
            this.desconectar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desconectar_btn.ForeColor = System.Drawing.Color.White;
            this.desconectar_btn.Image = ((System.Drawing.Image)(resources.GetObject("desconectar_btn.Image")));
            this.desconectar_btn.Location = new System.Drawing.Point(12, 698);
            this.desconectar_btn.Name = "desconectar_btn";
            this.desconectar_btn.Size = new System.Drawing.Size(40, 40);
            this.desconectar_btn.TabIndex = 5;
            this.desconectar_btn.UseVisualStyleBackColor = true;
            this.desconectar_btn.Click += new System.EventHandler(this.desconectar_btn_Click);
            // 
            // salario_btn
            // 
            this.salario_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.salario_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salario_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salario_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario_btn.ForeColor = System.Drawing.Color.White;
            this.salario_btn.Image = ((System.Drawing.Image)(resources.GetObject("salario_btn.Image")));
            this.salario_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salario_btn.Location = new System.Drawing.Point(16, 337);
            this.salario_btn.Name = "salario_btn";
            this.salario_btn.Size = new System.Drawing.Size(235, 44);
            this.salario_btn.TabIndex = 4;
            this.salario_btn.Text = "Salario";
            this.salario_btn.UseVisualStyleBackColor = false;
            this.salario_btn.Click += new System.EventHandler(this.salario_btn_Click);
            // 
            // agregarEmpleado_btn
            // 
            this.agregarEmpleado_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.agregarEmpleado_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarEmpleado_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.agregarEmpleado_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.agregarEmpleado_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarEmpleado_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarEmpleado_btn.ForeColor = System.Drawing.Color.White;
            this.agregarEmpleado_btn.Image = ((System.Drawing.Image)(resources.GetObject("agregarEmpleado_btn.Image")));
            this.agregarEmpleado_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarEmpleado_btn.Location = new System.Drawing.Point(16, 273);
            this.agregarEmpleado_btn.Name = "agregarEmpleado_btn";
            this.agregarEmpleado_btn.Size = new System.Drawing.Size(235, 44);
            this.agregarEmpleado_btn.TabIndex = 3;
            this.agregarEmpleado_btn.Text = "   Agregar Empleado";
            this.agregarEmpleado_btn.UseVisualStyleBackColor = false;
            this.agregarEmpleado_btn.Click += new System.EventHandler(this.agregarEmpleado_btn_Click);
            // 
            // panel_btn
            // 
            this.panel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.panel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel_btn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_btn.ForeColor = System.Drawing.Color.White;
            this.panel_btn.Image = ((System.Drawing.Image)(resources.GetObject("panel_btn.Image")));
            this.panel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panel_btn.Location = new System.Drawing.Point(16, 208);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(235, 44);
            this.panel_btn.TabIndex = 2;
            this.panel_btn.Text = "Panel";
            this.panel_btn.UseVisualStyleBackColor = false;
            this.panel_btn.Click += new System.EventHandler(this.panel_btn_Click);
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.Color.White;
            this.greet_user.Location = new System.Drawing.Point(60, 164);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(150, 19);
            this.greet_user.TabIndex = 1;
            this.greet_user.Text = "Bienvenido, Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.addEmpleado2);
            this.panel3.Controls.Add(this.salario2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(270, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1212, 750);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1264, 835);
            this.panel4.TabIndex = 2;
            this.panel4.Load += new System.EventHandler(this.panel4_Load);
            // 
            // addEmpleado2
            // 
            this.addEmpleado2.Location = new System.Drawing.Point(0, 0);
            this.addEmpleado2.Name = "addEmpleado2";
            this.addEmpleado2.Size = new System.Drawing.Size(1264, 835);
            this.addEmpleado2.TabIndex = 1;
            // 
            // salario2
            // 
            this.salario2.Location = new System.Drawing.Point(0, 0);
            this.salario2.Name = "salario2";
            this.salario2.Size = new System.Drawing.Size(1264, 835);
            this.salario2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 796);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.Button panel_btn;
        private System.Windows.Forms.Button salario_btn;
        private System.Windows.Forms.Button agregarEmpleado_btn;
        private System.Windows.Forms.Button desconectar_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private AddEmpleado addEmpleado1;
        private Salario salario1;
        private Salario salario2;
        private AddEmpleado addEmpleado2;
        private Panel panel4;
    }
}