namespace Supermercado.Frames
{
    partial class frmFacturas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.cmsOpc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbImporte_total = new System.Windows.Forms.TextBox();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Facturas = new System.Windows.Forms.TabPage();
            this.FacDet = new System.Windows.Forms.TabPage();
            this.btnRegresar2 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.txtbDescPago = new System.Windows.Forms.TextBox();
            this.txtbCosto = new System.Windows.Forms.TextBox();
            this.txtbDescF = new System.Windows.Forms.TextBox();
            this.txtbIva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvFacDet = new System.Windows.Forms.DataGridView();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMetodoP = new System.Windows.Forms.ComboBox();
            this.cbIdF = new System.Windows.Forms.ComboBox();
            this.cmsOpc2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.cmsOpc.SuspendLayout();
            this.Tab.SuspendLayout();
            this.Facturas.SuspendLayout();
            this.FacDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacDet)).BeginInit();
            this.cmsOpc2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(348, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(408, 31);
            this.txtBuscar.TabIndex = 34;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 33;
            this.label1.Text = "Facturas:";
            // 
            // dtpHora
            // 
            this.dtpHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHora.CustomFormat = "HH:mm:ss";
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(33, 289);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(683, 24);
            this.dtpHora.TabIndex = 66;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy/MM/dd";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(33, 226);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(139, 24);
            this.dtpFecha.TabIndex = 65;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.ContextMenuStrip = this.cmsOpc;
            this.dgvFacturas.Location = new System.Drawing.Point(312, 69);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.Size = new System.Drawing.Size(555, 321);
            this.dgvFacturas.TabIndex = 62;
            // 
            // cmsOpc
            // 
            this.cmsOpc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarTSM,
            this.eliminarTSM});
            this.cmsOpc.Name = "cmsOpc";
            this.cmsOpc.Size = new System.Drawing.Size(118, 48);
            // 
            // editarTSM
            // 
            this.editarTSM.Name = "editarTSM";
            this.editarTSM.Size = new System.Drawing.Size(117, 22);
            this.editarTSM.Text = "Editar";
            this.editarTSM.Click += new System.EventHandler(this.editarTSM_Click);
            // 
            // eliminarTSM
            // 
            this.eliminarTSM.Name = "eliminarTSM";
            this.eliminarTSM.Size = new System.Drawing.Size(117, 22);
            this.eliminarTSM.Text = "Eliminar";
            this.eliminarTSM.Click += new System.EventHandler(this.eliminarTSM_Click);
            // 
            // txtbImporte_total
            // 
            this.txtbImporte_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbImporte_total.Location = new System.Drawing.Point(33, 355);
            this.txtbImporte_total.Name = "txtbImporte_total";
            this.txtbImporte_total.Size = new System.Drawing.Size(241, 24);
            this.txtbImporte_total.TabIndex = 3;
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCodigo.Location = new System.Drawing.Point(33, 162);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(241, 24);
            this.txtbCodigo.TabIndex = 2;
            // 
            // txtbNumero
            // 
            this.txtbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNumero.Location = new System.Drawing.Point(33, 96);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(241, 24);
            this.txtbNumero.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Importe Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "Fecha (YY/MM/DD)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Numero";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(612, 417);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 46);
            this.btnCerrar.TabIndex = 68;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(432, 417);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 46);
            this.btnAgregar.TabIndex = 67;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Facturas);
            this.Tab.Controls.Add(this.FacDet);
            this.Tab.Location = new System.Drawing.Point(1, 1);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(951, 591);
            this.Tab.TabIndex = 69;
            this.Tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // Facturas
            // 
            this.Facturas.Controls.Add(this.dgvFacturas);
            this.Facturas.Controls.Add(this.label1);
            this.Facturas.Controls.Add(this.btnCerrar);
            this.Facturas.Controls.Add(this.txtBuscar);
            this.Facturas.Controls.Add(this.btnAgregar);
            this.Facturas.Controls.Add(this.label2);
            this.Facturas.Controls.Add(this.dtpHora);
            this.Facturas.Controls.Add(this.label4);
            this.Facturas.Controls.Add(this.dtpFecha);
            this.Facturas.Controls.Add(this.label3);
            this.Facturas.Controls.Add(this.label6);
            this.Facturas.Controls.Add(this.txtbImporte_total);
            this.Facturas.Controls.Add(this.label5);
            this.Facturas.Controls.Add(this.txtbCodigo);
            this.Facturas.Controls.Add(this.txtbNumero);
            this.Facturas.Location = new System.Drawing.Point(4, 22);
            this.Facturas.Name = "Facturas";
            this.Facturas.Padding = new System.Windows.Forms.Padding(3);
            this.Facturas.Size = new System.Drawing.Size(943, 565);
            this.Facturas.TabIndex = 0;
            this.Facturas.Text = "Facturas";
            this.Facturas.UseVisualStyleBackColor = true;
            // 
            // FacDet
            // 
            this.FacDet.Controls.Add(this.cbMetodoP);
            this.FacDet.Controls.Add(this.cbIdF);
            this.FacDet.Controls.Add(this.cbTipo);
            this.FacDet.Controls.Add(this.txtBuscar2);
            this.FacDet.Controls.Add(this.label7);
            this.FacDet.Controls.Add(this.btnRegresar2);
            this.FacDet.Controls.Add(this.btnAgregar2);
            this.FacDet.Controls.Add(this.txtbDescPago);
            this.FacDet.Controls.Add(this.txtbCosto);
            this.FacDet.Controls.Add(this.txtbDescF);
            this.FacDet.Controls.Add(this.txtbIva);
            this.FacDet.Controls.Add(this.label8);
            this.FacDet.Controls.Add(this.label9);
            this.FacDet.Controls.Add(this.label10);
            this.FacDet.Controls.Add(this.label11);
            this.FacDet.Controls.Add(this.label12);
            this.FacDet.Controls.Add(this.label13);
            this.FacDet.Controls.Add(this.label14);
            this.FacDet.Controls.Add(this.dgvFacDet);
            this.FacDet.Location = new System.Drawing.Point(4, 22);
            this.FacDet.Name = "FacDet";
            this.FacDet.Padding = new System.Windows.Forms.Padding(3);
            this.FacDet.Size = new System.Drawing.Size(943, 565);
            this.FacDet.TabIndex = 1;
            this.FacDet.Text = "Facturas Detalles";
            this.FacDet.UseVisualStyleBackColor = true;
            this.FacDet.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnRegresar2
            // 
            this.btnRegresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar2.Location = new System.Drawing.Point(639, 448);
            this.btnRegresar2.Name = "btnRegresar2";
            this.btnRegresar2.Size = new System.Drawing.Size(140, 46);
            this.btnRegresar2.TabIndex = 49;
            this.btnRegresar2.Text = "Cerrar";
            this.btnRegresar2.UseVisualStyleBackColor = true;
            this.btnRegresar2.Click += new System.EventHandler(this.btnRegresar2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnAgregar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar2.Location = new System.Drawing.Point(459, 448);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(147, 46);
            this.btnAgregar2.TabIndex = 41;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = false;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // txtbDescPago
            // 
            this.txtbDescPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDescPago.Location = new System.Drawing.Point(12, 488);
            this.txtbDescPago.Name = "txtbDescPago";
            this.txtbDescPago.Size = new System.Drawing.Size(272, 24);
            this.txtbDescPago.TabIndex = 7;
            // 
            // txtbCosto
            // 
            this.txtbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCosto.Location = new System.Drawing.Point(11, 274);
            this.txtbCosto.Name = "txtbCosto";
            this.txtbCosto.Size = new System.Drawing.Size(272, 24);
            this.txtbCosto.TabIndex = 4;
            // 
            // txtbDescF
            // 
            this.txtbDescF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDescF.Location = new System.Drawing.Point(11, 211);
            this.txtbDescF.Name = "txtbDescF";
            this.txtbDescF.Size = new System.Drawing.Size(272, 24);
            this.txtbDescF.TabIndex = 3;
            // 
            // txtbIva
            // 
            this.txtbIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbIva.Location = new System.Drawing.Point(11, 343);
            this.txtbIva.Name = "txtbIva";
            this.txtbIva.Size = new System.Drawing.Size(272, 24);
            this.txtbIva.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "Medio de pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Desc Pago";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "Costo Asoc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "Iva";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 24);
            this.label12.TabIndex = 44;
            this.label12.Text = "Tipo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 24);
            this.label13.TabIndex = 43;
            this.label13.Text = "Desc Factura";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(8, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 24);
            this.label14.TabIndex = 42;
            this.label14.Text = "Id Factura";
            // 
            // dgvFacDet
            // 
            this.dgvFacDet.AllowUserToAddRows = false;
            this.dgvFacDet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacDet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacDet.ContextMenuStrip = this.cmsOpc2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacDet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacDet.Location = new System.Drawing.Point(320, 103);
            this.dgvFacDet.Name = "dgvFacDet";
            this.dgvFacDet.ReadOnly = true;
            this.dgvFacDet.Size = new System.Drawing.Size(604, 328);
            this.dgvFacDet.TabIndex = 33;
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbTipo.Location = new System.Drawing.Point(11, 144);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(164, 26);
            this.cbTipo.TabIndex = 2;
            // 
            // cbMetodoP
            // 
            this.cbMetodoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodoP.FormattingEnabled = true;
            this.cbMetodoP.Items.AddRange(new object[] {
            "EFECTIVO",
            "CHEQUE",
            "TARJETA CREDITO",
            "TARJETA DEBITO"});
            this.cbMetodoP.Location = new System.Drawing.Point(7, 419);
            this.cbMetodoP.Name = "cbMetodoP";
            this.cbMetodoP.Size = new System.Drawing.Size(276, 26);
            this.cbMetodoP.TabIndex = 6;
            // 
            // cbIdF
            // 
            this.cbIdF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdF.FormattingEnabled = true;
            this.cbIdF.Location = new System.Drawing.Point(11, 79);
            this.cbIdF.Name = "cbIdF";
            this.cbIdF.Size = new System.Drawing.Size(164, 26);
            this.cbIdF.TabIndex = 1;
            // 
            // cmsOpc2
            // 
            this.cmsOpc2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cmsOpc2.Name = "cmsOpc";
            this.cmsOpc2.Size = new System.Drawing.Size(118, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Editar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "Eliminar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(90, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 42);
            this.label7.TabIndex = 50;
            this.label7.Text = "Facturas detalles:";
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar2.Location = new System.Drawing.Point(427, 10);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(439, 31);
            this.txtBuscar2.TabIndex = 51;
            this.txtBuscar2.TextChanged += new System.EventHandler(this.txtBuscar2_TextChanged);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 572);
            this.Controls.Add(this.Tab);
            this.Name = "frmFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.cmsOpc.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.Facturas.ResumeLayout(false);
            this.Facturas.PerformLayout();
            this.FacDet.ResumeLayout(false);
            this.FacDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacDet)).EndInit();
            this.cmsOpc2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.TextBox txtbImporte_total;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ContextMenuStrip cmsOpc;
        private System.Windows.Forms.ToolStripMenuItem editarTSM;
        private System.Windows.Forms.ToolStripMenuItem eliminarTSM;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Facturas;
        private System.Windows.Forms.TabPage FacDet;
        private System.Windows.Forms.Button btnRegresar2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.TextBox txtbDescPago;
        private System.Windows.Forms.TextBox txtbCosto;
        private System.Windows.Forms.TextBox txtbDescF;
        private System.Windows.Forms.TextBox txtbIva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvFacDet;
        private System.Windows.Forms.ComboBox cbMetodoP;
        private System.Windows.Forms.ComboBox cbIdF;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ContextMenuStrip cmsOpc2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox txtBuscar2;
        private System.Windows.Forms.Label label7;
    }
}