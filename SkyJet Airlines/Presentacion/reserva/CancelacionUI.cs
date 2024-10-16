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

namespace Presentacion.reserva
{
    public partial class CancelacionUI : Form
    {
        Form homeUI;

        public CancelacionUI(Form home)
        {
            InitializeComponent();
            homeUI = home;
            ResetForm();
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.MaxDate = DateTime.Today;
            LoadGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            homeUI.Visible = true;

            this.Close();
        }

        public void ResetForm()
        {
            txtCancelacionId.Text = "";
            cmbTicketId.Text = "";
            txtCodVuelo.Text = "";
            dtpFecha.Value = DateTime.Today;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado Exitosamente", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string ValidateData(Cancelacion cancelacion)
        {
            if (txtCancelacionId.Text == "")
                return "Completar el campo Cancelacion Id";
            if (cmbTicketId.Text == "")
                return "Completar el campo Ticket Id";
            if (cancelacion.CodVuelo == "")
                return "Completar el campo Codigo Vuelo";

            if (cancelacion.Id == 0 || cancelacion.Id < 0)
                return "El campo Cancelacion Id es númerico y mayor a cero";

            if (cancelacion.IdTicket == 0 || cancelacion.IdTicket < 0)
                return "El campo Tikcet Id es númerico y mayor a cero";

            if (!ValidateCombo(cmbTicketId, cancelacion.IdTicket.ToString()))
                return "El campo Ticket Id no es correcto";

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

        public void LoadCombo<T>(ComboBox combo, List<T> lista)
        {
            combo.Items.Clear();

            foreach (T item in lista)
            {
                combo.Items.Add(item);
            }

            if (combo.Items.Count > 0)
                combo.SelectedIndex = 0;
        }

        public void LoadGrid()
        {
            dgvCancelaciones.Rows.Clear();
           
        }

        private void cmbTicketId_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCodVuelo.Text = "";
        }
    }
}
