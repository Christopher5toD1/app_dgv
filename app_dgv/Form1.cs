using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_dgv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtCorreo.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dgvCuadro.Rows.Add(TxtNombre.Text, TxtCorreo.Text);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvCuadro.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int fila;
                fila = dgvCuadro.CurrentRow.Index;
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dgvCuadro.Rows.RemoveAt(fila);
                    MessageBox.Show("Registro eliminar");

                }
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCorreo.Clear();
            TxtNombre.Clear();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
