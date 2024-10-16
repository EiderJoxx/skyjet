namespace Presentacion.reserva
{
    partial class CancelacionUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelacionUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCodVuelo = new System.Windows.Forms.Label();
            this.cmbTicketId = new System.Windows.Forms.ComboBox();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.txtCancelacionId = new System.Windows.Forms.TextBox();
            this.lblCancelacionId = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCancelaciones = new System.Windows.Forms.DataGridView();
            this.CancelacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCodVuelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(670, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 49);
            this.btnBack.TabIndex = 24;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(185, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 49);
            this.panel1.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(70, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "SkyJet Airlines";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.Navy;
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(507, 230);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(168, 26);
            this.dtpFecha.TabIndex = 34;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Navy;
            this.lblFecha.Location = new System.Drawing.Point(386, 236);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 20);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCodVuelo
            // 
            this.lblCodVuelo.AutoSize = true;
            this.lblCodVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVuelo.ForeColor = System.Drawing.Color.Navy;
            this.lblCodVuelo.Location = new System.Drawing.Point(37, 236);
            this.lblCodVuelo.Name = "lblCodVuelo";
            this.lblCodVuelo.Size = new System.Drawing.Size(121, 20);
            this.lblCodVuelo.TabIndex = 31;
            this.lblCodVuelo.Text = "Código Vuelo:";
            // 
            // cmbTicketId
            // 
            this.cmbTicketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTicketId.ForeColor = System.Drawing.Color.Navy;
            this.cmbTicketId.FormattingEnabled = true;
            this.cmbTicketId.Location = new System.Drawing.Point(507, 164);
            this.cmbTicketId.Name = "cmbTicketId";
            this.cmbTicketId.Size = new System.Drawing.Size(168, 28);
            this.cmbTicketId.TabIndex = 65;
            this.cmbTicketId.SelectedValueChanged += new System.EventHandler(this.cmbTicketId_SelectedValueChanged);
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketId.ForeColor = System.Drawing.Color.Navy;
            this.lblTicketId.Location = new System.Drawing.Point(386, 172);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(85, 20);
            this.lblTicketId.TabIndex = 64;
            this.lblTicketId.Text = "N° Ticket:";
            // 
            // txtCancelacionId
            // 
            this.txtCancelacionId.BackColor = System.Drawing.SystemColors.Control;
            this.txtCancelacionId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCancelacionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelacionId.ForeColor = System.Drawing.Color.Navy;
            this.txtCancelacionId.Location = new System.Drawing.Point(190, 172);
            this.txtCancelacionId.Name = "txtCancelacionId";
            this.txtCancelacionId.Size = new System.Drawing.Size(142, 19);
            this.txtCancelacionId.TabIndex = 63;
            // 
            // lblCancelacionId
            // 
            this.lblCancelacionId.AutoSize = true;
            this.lblCancelacionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelacionId.ForeColor = System.Drawing.Color.Navy;
            this.lblCancelacionId.Location = new System.Drawing.Point(37, 172);
            this.lblCancelacionId.Name = "lblCancelacionId";
            this.lblCancelacionId.Size = new System.Drawing.Size(135, 20);
            this.lblCancelacionId.TabIndex = 62;
            this.lblCancelacionId.Text = "N° Cancelación:";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Navy;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 188;
            this.lineShape1.X2 = 332;
            this.lineShape1.Y1 = 194;
            this.lineShape1.Y2 = 194;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(720, 568);
            this.shapeContainer1.TabIndex = 66;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Navy;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 185;
            this.lineShape2.X2 = 333;
            this.lineShape2.Y1 = 253;
            this.lineShape2.Y2 = 253;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Red;
            this.lblSubTitle.Location = new System.Drawing.Point(245, 87);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(249, 29);
            this.lblSubTitle.TabIndex = 67;
            this.lblSubTitle.Text = "CANCELAR TICKET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(240, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 24);
            this.label2.TabIndex = 68;
            this.label2.Text = "LISTA CANCELACIONES";
            // 
            // dgvCancelaciones
            // 
            this.dgvCancelaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCancelaciones.BackgroundColor = System.Drawing.Color.Navy;
            this.dgvCancelaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCancelaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancelaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCancelaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CancelacionId,
            this.TicketId,
            this.Cod_vuelo,
            this.Fecha});
            this.dgvCancelaciones.Location = new System.Drawing.Point(132, 380);
            this.dgvCancelaciones.Name = "dgvCancelaciones";
            this.dgvCancelaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancelaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCancelaciones.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            this.dgvCancelaciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCancelaciones.Size = new System.Drawing.Size(448, 166);
            this.dgvCancelaciones.TabIndex = 69;
            // 
            // CancelacionId
            // 
            this.CancelacionId.HeaderText = "N° Cancelacion";
            this.CancelacionId.Name = "CancelacionId";
            this.CancelacionId.Width = 141;
            // 
            // TicketId
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            this.TicketId.DefaultCellStyle = dataGridViewCellStyle2;
            this.TicketId.HeaderText = "N° Ticket";
            this.TicketId.Name = "TicketId";
            this.TicketId.Width = 96;
            // 
            // Cod_vuelo
            // 
            this.Cod_vuelo.HeaderText = "Código Vuelo";
            this.Cod_vuelo.Name = "Cod_vuelo";
            this.Cod_vuelo.Width = 129;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 79;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(372, 283);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 71;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(308, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCodVuelo
            // 
            this.txtCodVuelo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodVuelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodVuelo.Enabled = false;
            this.txtCodVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVuelo.ForeColor = System.Drawing.Color.Navy;
            this.txtCodVuelo.Location = new System.Drawing.Point(185, 231);
            this.txtCodVuelo.Name = "txtCodVuelo";
            this.txtCodVuelo.Size = new System.Drawing.Size(147, 19);
            this.txtCodVuelo.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(190, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 73;
            this.label4.Text = "* Requerido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(510, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 74;
            this.label1.Text = "* Requerido";
            // 
            // CancelacionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodVuelo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCancelaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.cmbTicketId);
            this.Controls.Add(this.lblTicketId);
            this.Controls.Add(this.txtCancelacionId);
            this.Controls.Add(this.lblCancelacionId);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCodVuelo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelacionUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCodVuelo;
        private System.Windows.Forms.ComboBox cmbTicketId;
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtCancelacionId;
        private System.Windows.Forms.Label lblCancelacionId;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCancelaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CancelacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtCodVuelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}