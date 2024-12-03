namespace SistemaGestionEmpleados
{
    partial class Salario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salario_limpiarBtn = new System.Windows.Forms.Button();
            this.salario_actualizarBtn = new System.Windows.Forms.Button();
            this.salario_salario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salario_cargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salario_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salario_empleadoID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.salario_limpiarBtn);
            this.panel1.Controls.Add(this.salario_actualizarBtn);
            this.panel1.Controls.Add(this.salario_salario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.salario_cargo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.salario_nombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.salario_empleadoID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 640);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // salario_limpiarBtn
            // 
            this.salario_limpiarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.salario_limpiarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salario_limpiarBtn.FlatAppearance.BorderSize = 0;
            this.salario_limpiarBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salario_limpiarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salario_limpiarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salario_limpiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salario_limpiarBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario_limpiarBtn.ForeColor = System.Drawing.Color.White;
            this.salario_limpiarBtn.Location = new System.Drawing.Point(196, 392);
            this.salario_limpiarBtn.Name = "salario_limpiarBtn";
            this.salario_limpiarBtn.Size = new System.Drawing.Size(158, 43);
            this.salario_limpiarBtn.TabIndex = 14;
            this.salario_limpiarBtn.Text = "Limpiar";
            this.salario_limpiarBtn.UseVisualStyleBackColor = false;
            this.salario_limpiarBtn.Click += new System.EventHandler(this.salario_limpiarBtn_Click);
            // 
            // salario_actualizarBtn
            // 
            this.salario_actualizarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            this.salario_actualizarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salario_actualizarBtn.FlatAppearance.BorderSize = 0;
            this.salario_actualizarBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salario_actualizarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salario_actualizarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salario_actualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salario_actualizarBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario_actualizarBtn.ForeColor = System.Drawing.Color.White;
            this.salario_actualizarBtn.Location = new System.Drawing.Point(18, 392);
            this.salario_actualizarBtn.Name = "salario_actualizarBtn";
            this.salario_actualizarBtn.Size = new System.Drawing.Size(158, 43);
            this.salario_actualizarBtn.TabIndex = 13;
            this.salario_actualizarBtn.Text = "Actualizar";
            this.salario_actualizarBtn.UseVisualStyleBackColor = false;
            this.salario_actualizarBtn.Click += new System.EventHandler(this.salario_actualizarBtn_Click);
            // 
            // salario_salario
            // 
            this.salario_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario_salario.Location = new System.Drawing.Point(17, 297);
            this.salario_salario.Multiline = true;
            this.salario_salario.Name = "salario_salario";
            this.salario_salario.Size = new System.Drawing.Size(338, 33);
            this.salario_salario.TabIndex = 7;
            this.salario_salario.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salario:";
            // 
            // salario_cargo
            // 
            this.salario_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario_cargo.Location = new System.Drawing.Point(16, 227);
            this.salario_cargo.Multiline = true;
            this.salario_cargo.Name = "salario_cargo";
            this.salario_cargo.Size = new System.Drawing.Size(338, 33);
            this.salario_cargo.TabIndex = 5;
            this.salario_cargo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cargo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // salario_nombre
            // 
            this.salario_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario_nombre.Location = new System.Drawing.Point(16, 155);
            this.salario_nombre.Multiline = true;
            this.salario_nombre.Name = "salario_nombre";
            this.salario_nombre.Size = new System.Drawing.Size(338, 33);
            this.salario_nombre.TabIndex = 3;
            this.salario_nombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // salario_empleadoID
            // 
            this.salario_empleadoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario_empleadoID.Location = new System.Drawing.Point(16, 88);
            this.salario_empleadoID.Multiline = true;
            this.salario_empleadoID.Name = "salario_empleadoID";
            this.salario_empleadoID.Size = new System.Drawing.Size(338, 33);
            this.salario_empleadoID.TabIndex = 1;
            this.salario_empleadoID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleado ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(433, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 640);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(8)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(57, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(685, 547);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Salario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salario";
            this.Size = new System.Drawing.Size(1264, 835);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salario_cargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salario_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salario_empleadoID;
        private System.Windows.Forms.TextBox salario_salario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salario_actualizarBtn;
        private System.Windows.Forms.Button salario_limpiarBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
