using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionEmpleados
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void desconectar_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Estás seguro que quieres abandonar?", "Mensaje de confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes) 
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void panel_btn_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            addEmpleado2.Visible = false;
            salario2.Visible = false;

            Panel panelForm = panel4 as Panel;

            if(panelForm != null) 
            {
                panelForm.RefreshData();
            }
        }

        private void agregarEmpleado_btn_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            addEmpleado2.Visible = true;
            salario2.Visible = false;
        }

        private void salario_btn_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            addEmpleado2.Visible = false;
            salario2.Visible = true;
        }

        private void addEmpleado2_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Load(object sender, EventArgs e)
        {

        }
    }
}
