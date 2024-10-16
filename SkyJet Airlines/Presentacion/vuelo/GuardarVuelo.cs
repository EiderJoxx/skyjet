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
    public partial class GuardarVuelo : Form
    {
        Form homeUI;

        public GuardarVuelo(Form home)
        {
            InitializeComponent();
            homeUI = home;
            ResetForm();

            dtpFecha.MinDate = DateTime.Now;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardado Exitosamente", "Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpFechaVuelo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Vuelo_Load(object sender, EventArgs e)
        {
            dtpFecha.CalendarTitleForeColor = Color.Navy;    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            homeUI.Visible = true;
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            MostrarVuelos UI = new MostrarVuelos(this);
            UI.Show();

            this.Visible = false;
        }

        public void ResetForm()
        {
            txtCodVuelo.Text = "";
            cmbProcedencia.Text = "";
            cmbDestino.Text = "";
            dtpFecha.Value = DateTime.Now;
            txtNumAsiento.Text = "";
        }

        public string ValidateData(Vuelo vuelo)
        {

            if ( vuelo.Codigo == "" )
                return "Completar el campo: Codigo";
            if ( vuelo.Procedencia == "" )
                return "Completar el campo: Procedencia";
            if ( vuelo.Destino == "" )
                return "Completar el campo: Destino";
            if ( txtNumAsiento.Text == "" )
                return "Completar el campo: N° Asiento";

            if ( !ValidateCombo(cmbProcedencia, vuelo.Procedencia) )
                return "El campo Procedencia no es correcto";
            if ( !ValidateCombo(cmbDestino, vuelo.Destino) )
                return "El campo Destino no es correcto";
            if ( cmbProcedencia.Text == cmbDestino.Text )
                return "La Procedencia y el Destino son iguales";

            if ( vuelo.NumAsiento == 0 || vuelo.NumAsiento < 0 )
                return "El campo N° Asientos es númerico y mayor a cero";

            return null;
        }

        public bool ValidateCombo(ComboBox comboBox, string value)
        {
            foreach (var item in comboBox.Items)
            {
                if ( item.ToString() == value )
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
