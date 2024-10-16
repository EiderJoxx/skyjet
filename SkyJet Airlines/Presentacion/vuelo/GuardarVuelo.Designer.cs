namespace Presentacion
{
    partial class GuardarVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardarVuelo));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCodVuelo = new System.Windows.Forms.Label();
            this.lblNumAsiento = new System.Windows.Forms.Label();
            this.lblProcedencia = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cmbProcedencia = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.txtCodVuelo = new System.Windows.Forms.TextBox();
            this.txtNumAsiento = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Red;
            this.lblSubTitle.Location = new System.Drawing.Point(110, 92);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(228, 29);
            this.lblSubTitle.TabIndex = 5;
            this.lblSubTitle.Text = "GUARDAR VUELO";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(183, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(110, 386);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCodVuelo
            // 
            this.lblCodVuelo.AutoSize = true;
            this.lblCodVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVuelo.ForeColor = System.Drawing.Color.Navy;
            this.lblCodVuelo.Location = new System.Drawing.Point(26, 149);
            this.lblCodVuelo.Name = "lblCodVuelo";
            this.lblCodVuelo.Size = new System.Drawing.Size(70, 20);
            this.lblCodVuelo.TabIndex = 8;
            this.lblCodVuelo.Text = "Código:";
            // 
            // lblNumAsiento
            // 
            this.lblNumAsiento.AutoSize = true;
            this.lblNumAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAsiento.ForeColor = System.Drawing.Color.Navy;
            this.lblNumAsiento.Location = new System.Drawing.Point(26, 342);
            this.lblNumAsiento.Name = "lblNumAsiento";
            this.lblNumAsiento.Size = new System.Drawing.Size(98, 20);
            this.lblNumAsiento.TabIndex = 9;
            this.lblNumAsiento.Text = "N° Asiento:";
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.AutoSize = true;
            this.lblProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedencia.ForeColor = System.Drawing.Color.Navy;
            this.lblProcedencia.Location = new System.Drawing.Point(26, 199);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(113, 20);
            this.lblProcedencia.TabIndex = 10;
            this.lblProcedencia.Text = "Procedencia:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.Navy;
            this.lblDestino.Location = new System.Drawing.Point(26, 248);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(76, 20);
            this.lblDestino.TabIndex = 11;
            this.lblDestino.Text = "Destino:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Navy;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 174;
            this.lineShape1.X2 = 403;
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
            this.shapeContainer1.Size = new System.Drawing.Size(719, 451);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Navy;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 174;
            this.lineShape2.X2 = 403;
            this.lineShape2.Y1 = 362;
            this.lineShape2.Y2 = 362;
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
            this.cmbProcedencia.Location = new System.Drawing.Point(174, 191);
            this.cmbProcedencia.Name = "cmbProcedencia";
            this.cmbProcedencia.Size = new System.Drawing.Size(233, 28);
            this.cmbProcedencia.TabIndex = 14;
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
            this.cmbDestino.Location = new System.Drawing.Point(174, 240);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(233, 28);
            this.cmbDestino.TabIndex = 15;
            // 
            // txtCodVuelo
            // 
            this.txtCodVuelo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodVuelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVuelo.ForeColor = System.Drawing.Color.Navy;
            this.txtCodVuelo.Location = new System.Drawing.Point(174, 143);
            this.txtCodVuelo.Name = "txtCodVuelo";
            this.txtCodVuelo.Size = new System.Drawing.Size(230, 19);
            this.txtCodVuelo.TabIndex = 16;
            this.txtCodVuelo.TextChanged += new System.EventHandler(this.txtCodVuelo_TextChanged);
            // 
            // txtNumAsiento
            // 
            this.txtNumAsiento.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAsiento.ForeColor = System.Drawing.Color.Navy;
            this.txtNumAsiento.Location = new System.Drawing.Point(174, 340);
            this.txtNumAsiento.Name = "txtNumAsiento";
            this.txtNumAsiento.Size = new System.Drawing.Size(230, 19);
            this.txtNumAsiento.TabIndex = 17;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Navy;
            this.lblFecha.Location = new System.Drawing.Point(26, 296);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 20);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.Navy;
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.Color.Navy;
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(174, 291);
            this.dtpFecha.MinDate = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(233, 26);
            this.dtpFecha.TabIndex = 20;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFechaVuelo_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(184, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 49);
            this.panel1.TabIndex = 21;
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
            this.btnBack.Location = new System.Drawing.Point(669, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 49);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(255, 386);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(40, 40);
            this.btnList.TabIndex = 23;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // GuardarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 451);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNumAsiento);
            this.Controls.Add(this.txtCodVuelo);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbProcedencia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblProcedencia);
            this.Controls.Add(this.lblNumAsiento);
            this.Controls.Add(this.lblCodVuelo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuardarVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Vuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCodVuelo;
        private System.Windows.Forms.Label lblNumAsiento;
        private System.Windows.Forms.Label lblProcedencia;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.ComboBox cmbProcedencia;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.TextBox txtCodVuelo;
        private System.Windows.Forms.TextBox txtNumAsiento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnList;
    }
}