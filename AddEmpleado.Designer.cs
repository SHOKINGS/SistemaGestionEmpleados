namespace SistemaGestionEmpleados
{
    partial class AddEmpleado
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmpleado_limpiarBtn = new System.Windows.Forms.Button();
            this.addEmpleado_eliminarBtn = new System.Windows.Forms.Button();
            this.addEmpleado_actualizarBtn = new System.Windows.Forms.Button();
            this.addEmpleado_agregarBtn = new System.Windows.Forms.Button();
            this.addEmpleado_importarBtn = new System.Windows.Forms.Button();
            this.addEmpleado_foto = new System.Windows.Forms.PictureBox();
            this.addEmpleado_cargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmpleado_telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmpleado_genero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmpleado_nombreCompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmpleado_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmpleado_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 319);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(21, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(1157, 232);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Empleado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addEmpleado_limpiarBtn);
            this.panel2.Controls.Add(this.addEmpleado_eliminarBtn);
            this.panel2.Controls.Add(this.addEmpleado_actualizarBtn);
            this.panel2.Controls.Add(this.addEmpleado_agregarBtn);
            this.panel2.Controls.Add(this.addEmpleado_importarBtn);
            this.panel2.Controls.Add(this.addEmpleado_foto);
            this.panel2.Controls.Add(this.addEmpleado_cargo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addEmpleado_telefono);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addEmpleado_genero);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addEmpleado_nombreCompleto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addEmpleado_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(24, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 279);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addEmpleado_limpiarBtn
            // 
            this.addEmpleado_limpiarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmpleado_limpiarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpleado_limpiarBtn.FlatAppearance.BorderSize = 0;
            this.addEmpleado_limpiarBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_limpiarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_limpiarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_limpiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpleado_limpiarBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpleado_limpiarBtn.ForeColor = System.Drawing.Color.White;
            this.addEmpleado_limpiarBtn.Location = new System.Drawing.Point(787, 214);
            this.addEmpleado_limpiarBtn.Name = "addEmpleado_limpiarBtn";
            this.addEmpleado_limpiarBtn.Size = new System.Drawing.Size(136, 39);
            this.addEmpleado_limpiarBtn.TabIndex = 15;
            this.addEmpleado_limpiarBtn.Text = "Limpiar";
            this.addEmpleado_limpiarBtn.UseVisualStyleBackColor = false;
            this.addEmpleado_limpiarBtn.Click += new System.EventHandler(this.addEmpleado_limpiarBtn_Click);
            // 
            // addEmpleado_eliminarBtn
            // 
            this.addEmpleado_eliminarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmpleado_eliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpleado_eliminarBtn.FlatAppearance.BorderSize = 0;
            this.addEmpleado_eliminarBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_eliminarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_eliminarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_eliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpleado_eliminarBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpleado_eliminarBtn.ForeColor = System.Drawing.Color.White;
            this.addEmpleado_eliminarBtn.Location = new System.Drawing.Point(617, 214);
            this.addEmpleado_eliminarBtn.Name = "addEmpleado_eliminarBtn";
            this.addEmpleado_eliminarBtn.Size = new System.Drawing.Size(136, 39);
            this.addEmpleado_eliminarBtn.TabIndex = 14;
            this.addEmpleado_eliminarBtn.Text = "Eliminar";
            this.addEmpleado_eliminarBtn.UseVisualStyleBackColor = false;
            this.addEmpleado_eliminarBtn.Click += new System.EventHandler(this.addEmpleado_eliminarBtn_Click);
            // 
            // addEmpleado_actualizarBtn
            // 
            this.addEmpleado_actualizarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmpleado_actualizarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpleado_actualizarBtn.FlatAppearance.BorderSize = 0;
            this.addEmpleado_actualizarBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_actualizarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_actualizarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_actualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpleado_actualizarBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpleado_actualizarBtn.ForeColor = System.Drawing.Color.White;
            this.addEmpleado_actualizarBtn.Location = new System.Drawing.Point(448, 214);
            this.addEmpleado_actualizarBtn.Name = "addEmpleado_actualizarBtn";
            this.addEmpleado_actualizarBtn.Size = new System.Drawing.Size(136, 39);
            this.addEmpleado_actualizarBtn.TabIndex = 13;
            this.addEmpleado_actualizarBtn.Text = "Actualizar";
            this.addEmpleado_actualizarBtn.UseVisualStyleBackColor = false;
            this.addEmpleado_actualizarBtn.Click += new System.EventHandler(this.addEmpleado_actualizarBtn_Click);
            // 
            // addEmpleado_agregarBtn
            // 
            this.addEmpleado_agregarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmpleado_agregarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpleado_agregarBtn.FlatAppearance.BorderSize = 0;
            this.addEmpleado_agregarBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_agregarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_agregarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_agregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpleado_agregarBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpleado_agregarBtn.ForeColor = System.Drawing.Color.White;
            this.addEmpleado_agregarBtn.Location = new System.Drawing.Point(280, 214);
            this.addEmpleado_agregarBtn.Name = "addEmpleado_agregarBtn";
            this.addEmpleado_agregarBtn.Size = new System.Drawing.Size(136, 39);
            this.addEmpleado_agregarBtn.TabIndex = 12;
            this.addEmpleado_agregarBtn.Text = "Agregar";
            this.addEmpleado_agregarBtn.UseVisualStyleBackColor = false;
            this.addEmpleado_agregarBtn.Click += new System.EventHandler(this.addEmpleado_agregarBtn_Click);
            // 
            // addEmpleado_importarBtn
            // 
            this.addEmpleado_importarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.addEmpleado_importarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpleado_importarBtn.FlatAppearance.BorderSize = 0;
            this.addEmpleado_importarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_importarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmpleado_importarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpleado_importarBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpleado_importarBtn.ForeColor = System.Drawing.Color.White;
            this.addEmpleado_importarBtn.Location = new System.Drawing.Point(1044, 174);
            this.addEmpleado_importarBtn.Name = "addEmpleado_importarBtn";
            this.addEmpleado_importarBtn.Size = new System.Drawing.Size(116, 43);
            this.addEmpleado_importarBtn.TabIndex = 11;
            this.addEmpleado_importarBtn.Text = "Importar";
            this.addEmpleado_importarBtn.UseVisualStyleBackColor = false;
            this.addEmpleado_importarBtn.Click += new System.EventHandler(this.addEmpleado_importarBtn_Click);
            // 
            // addEmpleado_foto
            // 
            this.addEmpleado_foto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addEmpleado_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmpleado_foto.Location = new System.Drawing.Point(1044, 23);
            this.addEmpleado_foto.Name = "addEmpleado_foto";
            this.addEmpleado_foto.Size = new System.Drawing.Size(116, 123);
            this.addEmpleado_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmpleado_foto.TabIndex = 10;
            this.addEmpleado_foto.TabStop = false;
            // 
            // addEmpleado_cargo
            // 
            this.addEmpleado_cargo.FormattingEnabled = true;
            this.addEmpleado_cargo.Items.AddRange(new object[] {
            "Desarrollador Frontend",
            "Desarrollador Backend",
            "Desarrollador Full Stack",
            "Desarrollador Móvil",
            "Ingeniero DevOps",
            "Ingeniero de Calidad",
            "Diseñador de Interfaz de Usuario",
            "Diseñador de Experiencia de Usuario",
            "Diseñador de Producto",
            "Diseñador Gráfico",
            "Administrador de Base de Datos",
            "Administrador de Sistemas",
            "Ingeniero de Nube",
            "Analista de Ciberseguridad",
            "Ingeniero de Seguridad",
            "Tester de Penetración (Ethical Hacker)"});
            this.addEmpleado_cargo.Location = new System.Drawing.Point(632, 77);
            this.addEmpleado_cargo.Name = "addEmpleado_cargo";
            this.addEmpleado_cargo.Size = new System.Drawing.Size(267, 21);
            this.addEmpleado_cargo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cargo:";
            // 
            // addEmpleado_telefono
            // 
            this.addEmpleado_telefono.Location = new System.Drawing.Point(632, 24);
            this.addEmpleado_telefono.Multiline = true;
            this.addEmpleado_telefono.Name = "addEmpleado_telefono";
            this.addEmpleado_telefono.Size = new System.Drawing.Size(267, 33);
            this.addEmpleado_telefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número de Teléfono:";
            // 
            // addEmpleado_genero
            // 
            this.addEmpleado_genero.FormattingEnabled = true;
            this.addEmpleado_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.addEmpleado_genero.Location = new System.Drawing.Point(162, 129);
            this.addEmpleado_genero.Name = "addEmpleado_genero";
            this.addEmpleado_genero.Size = new System.Drawing.Size(267, 21);
            this.addEmpleado_genero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Género:";
            // 
            // addEmpleado_nombreCompleto
            // 
            this.addEmpleado_nombreCompleto.Location = new System.Drawing.Point(162, 77);
            this.addEmpleado_nombreCompleto.Multiline = true;
            this.addEmpleado_nombreCompleto.Name = "addEmpleado_nombreCompleto";
            this.addEmpleado_nombreCompleto.Size = new System.Drawing.Size(267, 33);
            this.addEmpleado_nombreCompleto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // addEmpleado_id
            // 
            this.addEmpleado_id.Location = new System.Drawing.Point(162, 23);
            this.addEmpleado_id.Multiline = true;
            this.addEmpleado_id.Name = "addEmpleado_id";
            this.addEmpleado_id.Size = new System.Drawing.Size(267, 34);
            this.addEmpleado_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleado ID:";
            // 
            // AddEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmpleado";
            this.Size = new System.Drawing.Size(1264, 835);
            this.Load += new System.EventHandler(this.AddEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmpleado_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox addEmpleado_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addEmpleado_genero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmpleado_nombreCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addEmpleado_agregarBtn;
        private System.Windows.Forms.Button addEmpleado_importarBtn;
        private System.Windows.Forms.PictureBox addEmpleado_foto;
        private System.Windows.Forms.ComboBox addEmpleado_cargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addEmpleado_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addEmpleado_limpiarBtn;
        private System.Windows.Forms.Button addEmpleado_eliminarBtn;
        private System.Windows.Forms.Button addEmpleado_actualizarBtn;
    }
}
