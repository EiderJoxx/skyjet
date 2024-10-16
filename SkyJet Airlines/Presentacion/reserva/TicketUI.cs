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
    public partial class TicketUI : Form
    {
        Form homeUI;

        public TicketUI(Form home)
        {
            InitializeComponent();
            homeUI = home;
            ResetForm();
            LoadGrid();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            homeUI.Visible = true;

            this.Close();
        }

        public void ResetForm()
        {
            txtTicketId.Text = "";
            cmbCodVuelo.Text = "";
            cmbPasajeroId.Text = "";
            txtNamesPasajero.Text = "";
            txtPasaporte.Text = "";
            txtNacionalidad.Text = "";
            txtCantidad.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregado Exitosamente", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool TextIsNumber(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public string ValidateData(Ticket ticket)
        {
            if (txtTicketId.Text == "")
                return "Completar el campo Ticket Id";
            if (ticket.CodigoVuelo == "")
                return "Completar el campo Codigo Vuelo";
            if (ticket.NumDocumento == "")
                return "Completar el campo N° Documento";
            if (txtCantidad.Text == "")
                return "Completar el campo Cantidad";

            if ( ticket.Id == 0 || ticket.Id < 0 )
                return "El campo Ticket Id es númerico y mayor a cero";

            if ( !ValidateCombo(cmbCodVuelo, ticket.CodigoVuelo) )
                return "El campo Codigo Vuelo no es correcto";
            if (!ValidateCombo(cmbPasajeroId, ticket.NumDocumento))
                return "El campo N° Documento no es correcto";

            if (ticket.Cantidad == 0 || ticket.Cantidad < 0)
                return "El campo Cantidad es númerico y mayor a cero";

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

        private void cmbPasajeroId_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNamesPasajero.Text ="";
            txtPasaporte.Text = "";
            txtNacionalidad.Text = "";
        }

        public void LoadGrid()
        {
            dgvTickets.Rows.Clear();
        }
    }
}
