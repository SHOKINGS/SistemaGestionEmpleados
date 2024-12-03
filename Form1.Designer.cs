namespace SistemaGestionEmpleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.entrar_btn = new System.Windows.Forms.Button();
            this.inicio_mostrarcontraseña = new System.Windows.Forms.CheckBox();
            this.inicio_contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inicio_nombreusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.registrarse_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.entrar_btn);
            this.panel1.Controls.Add(this.inicio_mostrarcontraseña);
            this.panel1.Controls.Add(this.inicio_contraseña);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inicio_nombreusuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 499);
            this.panel1.TabIndex = 0;
            // 
            // entrar_btn
            // 
            this.entrar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.entrar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrar_btn.FlatAppearance.BorderSize = 0;
            this.entrar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.entrar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.entrar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar_btn.ForeColor = System.Drawing.Color.White;
            this.entrar_btn.Location = new System.Drawing.Point(351, 299);
            this.entrar_btn.Name = "entrar_btn";
            this.entrar_btn.Size = new System.Drawing.Size(114, 36);
            this.entrar_btn.TabIndex = 7;
            this.entrar_btn.Text = "Entrar";
            this.entrar_btn.UseVisualStyleBackColor = false;
            this.entrar_btn.Click += new System.EventHandler(this.entrar_btn_Click);
            // 
            // inicio_mostrarcontraseña
            // 
            this.inicio_mostrarcontraseña.AutoSize = true;
            this.inicio_mostrarcontraseña.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio_mostrarcontraseña.Location = new System.Drawing.Point(503, 282);
            this.inicio_mostrarcontraseña.Name = "inicio_mostrarcontraseña";
            this.inicio_mostrarcontraseña.Size = new System.Drawing.Size(139, 20);
            this.inicio_mostrarcontraseña.TabIndex = 6;
            this.inicio_mostrarcontraseña.Text = "Mostrar Contraseña";
            this.inicio_mostrarcontraseña.UseVisualStyleBackColor = true;
            this.inicio_mostrarcontraseña.CheckedChanged += new System.EventHandler(this.inicio_mostrarcontraseña_CheckedChanged);
            // 
            // inicio_contraseña
            // 
            this.inicio_contraseña.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio_contraseña.Location = new System.Drawing.Point(351, 233);
            this.inicio_contraseña.Multiline = true;
            this.inicio_contraseña.Name = "inicio_contraseña";
            this.inicio_contraseña.PasswordChar = '*';
            this.inicio_contraseña.Size = new System.Drawing.Size(291, 43);
            this.inicio_contraseña.TabIndex = 5;
            this.inicio_contraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inicio_nombreusuario
            // 
            this.inicio_nombreusuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio_nombreusuario.Location = new System.Drawing.Point(351, 156);
            this.inicio_nombreusuario.Multiline = true;
            this.inicio_nombreusuario.Name = "inicio_nombreusuario";
            this.inicio_nombreusuario.Size = new System.Drawing.Size(291, 43);
            this.inicio_nombreusuario.TabIndex = 3;
            this.inicio_nombreusuario.TextChanged += new System.EventHandler(this.inicio_nombreusuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar Sesión";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.registrarse_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 499);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gestión de Empleados";
            // 
            // registrarse_btn
            // 
            this.registrarse_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.registrarse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarse_btn.FlatAppearance.BorderSize = 0;
            this.registrarse_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.registrarse_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.registrarse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarse_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarse_btn.ForeColor = System.Drawing.Color.White;
            this.registrarse_btn.Location = new System.Drawing.Point(26, 436);
            this.registrarse_btn.Name = "registrarse_btn";
            this.registrarse_btn.Size = new System.Drawing.Size(271, 31);
            this.registrarse_btn.TabIndex = 9;
            this.registrarse_btn.Text = "Registrarse";
            this.registrarse_btn.UseVisualStyleBackColor = false;
            this.registrarse_btn.Click += new System.EventHandler(this.registrarse_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(94, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registra tu Cuenta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaGestionEmpleados.Properties.Resources.empleado;
            this.pictureBox1.Location = new System.Drawing.Point(98, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 131);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 497);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inicio_contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inicio_nombreusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button entrar_btn;
        private System.Windows.Forms.CheckBox inicio_mostrarcontraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registrarse_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

