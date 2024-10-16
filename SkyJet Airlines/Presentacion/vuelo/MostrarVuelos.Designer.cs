namespace Presentacion
{
    partial class MostrarVuelos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarVuelos));
            this.dtpFechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNumAsiento = new System.Windows.Forms.TextBox();
            this.txtCodVuelo = new System.Windows.Forms.TextBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbProcedencia = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblProcedencia = new System.Windows.Forms.Label();
            this.lblNumAsiento = new System.Windows.Forms.Label();
            this.lblCodVuelo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procedencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaVuelo
            // 
            this.dtpFechaVuelo.CalendarForeColor = System.Drawing.Color.Navy;
            this.dtpFechaVuelo.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.dtpFechaVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVuelo.Location = new System.Drawing.Point(464, 205);
            this.dtpFechaVuelo.Name = "dtpFechaVuelo";
            this.dtpFechaVuelo.Size = new System.Drawing.Size(143, 26);
            this.dtpFechaVuelo.TabIndex = 30;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Navy;
            this.lblFecha.Location = new System.Drawing.Point(324, 210);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 20);
            this.lblFecha.TabIndex = 29;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtNumAsiento
            // 
            this.txtNumAsiento.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAsiento.ForeColor = System.Drawing.Color.Navy;
            this.txtNumAsiento.Location = new System.Drawing.Point(150, 259);
            this.txtNumAsiento.Name = "txtNumAsiento";
            this.txtNumAsiento.Size = new System.Drawing.Size(141, 19);
            this.txtNumAsiento.TabIndex = 28;
            // 
            // txtCodVuelo
            // 
            this.txtCodVuelo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodVuelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVuelo.ForeColor = System.Drawing.Color.Navy;
            this.txtCodVuelo.Location = new System.Drawing.Point(150, 143);
            this.txtCodVuelo.Name = "txtCodVuelo";
            this.txtCodVuelo.Size = new System.Drawing.Size(142, 19);
            this.txtCodVuelo.TabIndex = 27;
            this.txtCodVuelo.TextChanged += new System.EventHandler(this.txtCodVuelo_TextChanged);
            // 
            // cmbDestino
            // 
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.ForeColor = System.Drawing.Color.Navy;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "Bogotá",
            "Medellín",
            "Cali",
            "Barranquilla",
            "Cartagena",
            "Bucaramanga",
            "Pereira",
            "Santa Marta",
            "Cúcuta",
            "Armenia",
            "Manizales",
            "Neiva",
            "Ibagué",
            "Villavicencio",
            "Montería",
            "Valledupar",
            "Pasto",
            "San Andrés",
            "Leticia",
            "Riohacha",
            "Popayán",
            "Quibdó",
            "Yopal",
            "Tumaco",
            "Florencia",
            "Mitú",
            "Puerto Inírida",
            "Puerto Carreño",
            "Arauca"});
            this.cmbDestino.Location = new System.Drawing.Point(149, 202);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(142, 28);
            this.cmbDestino.TabIndex = 26;
            // 
            // cmbProcedencia
            // 
            this.cmbProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcedencia.ForeColor = System.Drawing.Color.Navy;
            this.cmbProcedencia.FormattingEnabled = true;
            this.cmbProcedencia.Items.AddRange(new object[] {
            "Bogotá",
            "Medellín",
            "Cali",
            "Barranquilla",
            "Cartagena",
            "Bucaramanga",
            "Pereira",
            "Santa Marta",
            "Cúcuta",
            "Armenia",
            "Manizales",
            "Neiva",
            "Ibagué",
            "Villavicencio",
            "Montería",
            "Valledupar",
            "Pasto",
            "San Andrés",
            "Leticia",
            "Riohacha",
            "Popayán",
            "Quibdó",
            "Yopal",
            "Tumaco",
            "Florencia",
            "Mitú",
            "Puerto Inírida",
            "Puerto Carreño",
            "Arauca"});
            this.cmbProcedencia.Location = new System.Drawing.Point(464, 139);
            this.cmbProcedencia.Name = "cmbProcedencia";
            this.cmbProcedencia.Size = new System.Drawing.Size(143, 28);
            this.cmbProcedencia.TabIndex = 25;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.Navy;
            this.lblDestino.Location = new System.Drawing.Point(33, 211);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(76, 20);
            this.lblDestino.TabIndex = 24;
            this.lblDestino.Text = "Destino:";
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.AutoSize = true;
            this.lblProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedencia.ForeColor = System.Drawing.Color.Navy;
            this.lblProcedencia.Location = new System.Drawing.Point(324, 147);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(113, 20);
            this.lblProcedencia.TabIndex = 23;
            this.lblProcedencia.Text = "Procedencia:";
            // 
            // lblNumAsiento
            // 
            this.lblNumAsiento.AutoSize = true;
            this.lblNumAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAsiento.ForeColor = System.Drawing.Color.Navy;
            this.lblNumAsiento.Location = new System.Drawing.Point(32, 265);
            this.lblNumAsiento.Name = "lblNumAsiento";
            this.lblNumAsiento.Size = new System.Drawing.Size(98, 20);
            this.lblNumAsiento.TabIndex = 22;
            this.lblNumAsiento.Text = "N° Asiento:";
            // 
            // lblCodVuelo
            // 
            this.lblCodVuelo.AutoSize = true;
            this.lblCodVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVuelo.ForeColor = System.Drawing.Color.Navy;
            this.lblCodVuelo.Location = new System.Drawing.Point(33, 148);
            this.lblCodVuelo.Name = "lblCodVuelo";
            this.lblCodVuelo.Size = new System.Drawing.Size(70, 20);
            this.lblCodVuelo.TabIndex = 21;
            this.lblCodVuelo.Text = "Código:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(156, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 49);
            this.panel1.TabIndex = 32;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(66, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "SkyJet Airlines";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Red;
            this.lblSubTitle.Location = new System.Drawing.Point(188, 80);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(272, 29);
            this.lblSubTitle.TabIndex = 33;
            this.lblSubTitle.Text = "GESTIONAR VUELOS";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Navy;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 149;
            this.lineShape1.X2 = 290;
            this.lineShape1.Y1 = 165;
            this.lineShape1.Y2 = 165;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(650, 500);
            this.shapeContainer1.TabIndex = 34;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Navy;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 149;
            this.lineShape2.X2 = 290;
            this.lineShape2.Y1 = 281;
            this.lineShape2.Y2 = 281;
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.BackgroundColor = System.Drawing.Color.Navy;
            this.dgvVuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVuelos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVuelos.ColumnHeadersHeight = 50;
            this.dgvVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Procedencia,
            this.Destino,
            this.Fecha,
            this.NoAsiento});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVuelos.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvVuelos.GridColor = System.Drawing.Color.Navy;
            this.dgvVuelos.Location = new System.Drawing.Point(81, 316);
            this.dgvVuelos.Name = "dgvVuelos";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvVuelos.RowHeadersVisible = false;
            this.dgvVuelos.RowHeadersWidth = 45;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Window;
            this.dgvVuelos.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvVuelos.Size = new System.Drawing.Size(501, 170);
            this.dgvVuelos.TabIndex = 35;
            this.dgvVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVuelos_CellContentClick);
            // 
            // Codigo
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Window;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle12;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Procedencia
            // 
            this.Procedencia.HeaderText = "Procedencia";
            this.Procedencia.Name = "Procedencia";
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // NoAsiento
            // 
            this.NoAsiento.HeaderText = "N° Asiento";
            this.NoAsiento.Name = "NoAsiento";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(483, 255);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 37;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(353, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 40);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(419, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnBack.Location = new System.Drawing.Point(600, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 49);
            this.btnBack.TabIndex = 39;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MostrarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvVuelos);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFechaVuelo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNumAsiento);
            this.Controls.Add(this.txtCodVuelo);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbProcedencia);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblProcedencia);
            this.Controls.Add(this.lblNumAsiento);
            this.Controls.Add(this.lblCodVuelo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaVuelo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNumAsiento;
        private System.Windows.Forms.TextBox txtCodVuelo;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbProcedencia;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblProcedencia;
        private System.Windows.Forms.Label lblNumAsiento;
        private System.Windows.Forms.Label lblCodVuelo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procedencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoAsiento;
    }
}