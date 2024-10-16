using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MostrarVuelos : Form
    {
        Form vuelosUI;

        public MostrarVuelos(Form vuelo)
        {
            InitializeComponent();
            vuelosUI = vuelo;
            ResetForm();
            LoadGrid();
        }   

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualizado Exitosamente", "Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ( txtCodVuelo.Text == "" )
            {
                MessageBox.Show("Debe completar el campo Codigo", "Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Eliminado Exitosamente", "Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ResetForm ()
        {
            txtCodVuelo.Text = "";
            cmbProcedencia.Text = "";
            cmbDestino.Text = "";
            dtpFechaVuelo.Value = DateTime.Now;
            txtNumAsiento.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            vuelosUI.Visible = true;
            this.Close();
        }

        public void LoadGrid()
        {
            dgvVuelos.Rows.Clear();
        }

        private void dgvVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int row = e.RowIndex;
                txtCodVuelo.Text = dgvVuelos.Rows[row].Cells[0].Value.ToString();
                cmbProcedencia.Text = dgvVuelos.Rows[row].Cells[1].Value.ToString();
                cmbDestino.Text = dgvVuelos.Rows[row].Cells[2].Value.ToString();
                dtpFechaVuelo.Value = Convert.ToDateTime(dgvVuelos.Rows[row].Cells[3].Value);
                txtNumAsiento.Text = dgvVuelos.Rows[row].Cells[4].Value.ToString();
            }
            
        }

        public string ValidateData(Vuelo vuelo)
        {

            if (vuelo.Codigo == "")
                return "Completar el campo: Codigo";
            if (vuelo.Procedencia == "")
                return "Completar el campo: Procedencia";
            if (vuelo.Destino == "")
                return "Completar el campo: Destino";
            if (txtNumAsiento.Text == "")
                return "Completar el campo: N° Asiento";

            if (!ValidateCombo(cmbProcedencia, vuelo.Procedencia))
                return "El campo Procedencia no es correcto";
            if (!ValidateCombo(cmbDestino, vuelo.Destino))
                return "El campo Destino no es correcto";
            if (cmbProcedencia.Text == cmbDestino.Text)
                return "La Procedencia y el Destino son iguales";

            if (vuelo.NumAsiento == 0 || vuelo.NumAsiento < 0)
                return "El campo N° Asientos es númerico y mayor a cero";

            return null;
        }

        public bool ValidateCombo(ComboBox comboBox, string value)
        {
            foreach (var item in comboBox.Items)
            {
                if (item.ToString() == value)
                    return true;
            }

            return false;
        }

        private void txtCodVuelo_TextChanged(object sender, EventArgs e)
        {
            txtCodVuelo.Text = txtCodVuelo.Text.ToUpper();
            txtCodVuelo.SelectionStart = txtCodVuelo.Text.Length;
        }
    }
}
