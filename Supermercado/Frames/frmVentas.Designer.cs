namespace Supermercado.Frames
{
    partial class frmVentas
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.Ventas = new System.Windows.Forms.TabPage();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.VentProd = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEmp = new System.Windows.Forms.ComboBox();
            this.cbFac = new System.Windows.Forms.ComboBox();
            this.cmsOpc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbVenta = new System.Windows.Forms.ComboBox();
            this.dgvVenProd = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbCantidad = new System.Windows.Forms.TextBox();
            this.cmsOpc2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab.SuspendLayout();
            this.Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.VentProd.SuspendLayout();
            this.cmsOpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenProd)).BeginInit();
            this.cmsOpc2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Ventas);
            this.Tab.Controls.Add(this.VentProd);
            this.Tab.Location = new System.Drawing.Point(4, 4);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(951, 591);
            this.Tab.TabIndex = 70;
            this.Tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // Ventas
            // 
            this.Ventas.Controls.Add(this.cbFac);
            this.Ventas.Controls.Add(this.cbEmp);
            this.Ventas.Controls.Add(this.dgvVentas);
            this.Ventas.Controls.Add(this.label1);
            this.Ventas.Controls.Add(this.btnCerrar);
            this.Ventas.Controls.Add(this.btnAgregar);
            this.Ventas.Controls.Add(this.label3);
            this.Ventas.Controls.Add(this.label2);
            this.Ventas.Location = new System.Drawing.Point(4, 22);
            this.Ventas.Name = "Ventas";
            this.Ventas.Padding = new System.Windows.Forms.Padding(3);
            this.Ventas.Size = new System.Drawing.Size(943, 565);
            this.Ventas.TabIndex = 0;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.ContextMenuStrip = this.cmsOpc;
            this.dgvVentas.Location = new System.Drawing.Point(351, 77);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(555, 321);
            this.dgvVentas.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(331, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ventas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(209, 327);
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
            this.btnAgregar.Location = new System.Drawing.Point(29, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 46);
            this.btnAgregar.TabIndex = 67;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Id Empleado";
            // 
            // VentProd
            // 
            this.VentProd.Controls.Add(this.txtbCantidad);
            this.VentProd.Controls.Add(this.cbProducto);
            this.VentProd.Controls.Add(this.cbVenta);
            this.VentProd.Controls.Add(this.dgvVenProd);
            this.VentProd.Controls.Add(this.label4);
            this.VentProd.Controls.Add(this.btnCerrar2);
            this.VentProd.Controls.Add(this.btnAgregar2);
            this.VentProd.Controls.Add(this.label7);
            this.VentProd.Controls.Add(this.label5);
            this.VentProd.Controls.Add(this.label6);
            this.VentProd.Location = new System.Drawing.Point(4, 22);
            this.VentProd.Name = "VentProd";
            this.VentProd.Padding = new System.Windows.Forms.Padding(3);
            this.VentProd.Size = new System.Drawing.Size(943, 565);
            this.VentProd.TabIndex = 1;
            this.VentProd.Text = "Ventas Productos";
            this.VentProd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Id Factura";
            // 
            // cbEmp
            // 
            this.cbEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmp.FormattingEnabled = true;
            this.cbEmp.Location = new System.Drawing.Point(40, 123);
            this.cbEmp.Name = "cbEmp";
            this.cbEmp.Size = new System.Drawing.Size(164, 26);
            this.cbEmp.TabIndex = 69;
            // 
            // cbFac
            // 
            this.cbFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFac.FormattingEnabled = true;
            this.cbFac.Location = new System.Drawing.Point(40, 210);
            this.cbFac.Name = "cbFac";
            this.cbFac.Size = new System.Drawing.Size(164, 26);
            this.cbFac.TabIndex = 69;
            // 
            // cmsOpc
            // 
            this.cmsOpc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarTSM});
            this.cmsOpc.Name = "cmsOpc";
            this.cmsOpc.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarTSM
            // 
            this.eliminarTSM.Name = "eliminarTSM";
            this.eliminarTSM.Size = new System.Drawing.Size(117, 22);
            this.eliminarTSM.Text = "Eliminar";
            this.eliminarTSM.Click += new System.EventHandler(this.eliminarTSM_Click);
            // 
            // cbProducto
            // 
            this.cbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbProducto.Location = new System.Drawing.Point(25, 202);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(164, 26);
            this.cbProducto.TabIndex = 76;
            // 
            // cbVenta
            // 
            this.cbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVenta.FormattingEnabled = true;
            this.cbVenta.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbVenta.Location = new System.Drawing.Point(25, 115);
            this.cbVenta.Name = "cbVenta";
            this.cbVenta.Size = new System.Drawing.Size(164, 26);
            this.cbVenta.TabIndex = 77;
            // 
            // dgvVenProd
            // 
            this.dgvVenProd.AllowUserToAddRows = false;
            this.dgvVenProd.AllowUserToDeleteRows = false;
            this.dgvVenProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenProd.ContextMenuStrip = this.cmsOpc2;
            this.dgvVenProd.Location = new System.Drawing.Point(347, 85);
            this.dgvVenProd.Name = "dgvVenProd";
            this.dgvVenProd.ReadOnly = true;
            this.dgvVenProd.Size = new System.Drawing.Size(555, 321);
            this.dgvVenProd.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(258, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 42);
            this.label4.TabIndex = 70;
            this.label4.Text = "Ventas Productos";
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar2.Location = new System.Drawing.Point(205, 335);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(109, 46);
            this.btnCerrar2.TabIndex = 75;
            this.btnCerrar2.Text = "Cerrar";
            this.btnCerrar2.UseVisualStyleBackColor = true;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnAgregar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar2.Location = new System.Drawing.Point(25, 335);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(116, 46);
            this.btnAgregar2.TabIndex = 74;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = false;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Id Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 72;
            this.label6.Text = "Id Venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 71;
            this.label7.Text = "Cantidad";
            // 
            // txtbCantidad
            // 
            this.txtbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCantidad.Location = new System.Drawing.Point(25, 279);
            this.txtbCantidad.Name = "txtbCantidad";
            this.txtbCantidad.Size = new System.Drawing.Size(164, 24);
            this.txtbCantidad.TabIndex = 78;
            // 
            // cmsOpc2
            // 
            this.cmsOpc2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editarToolStripMenuItem});
            this.cmsOpc2.Name = "cmsOpc";
            this.cmsOpc2.Size = new System.Drawing.Size(118, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Eliminar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 462);
            this.Controls.Add(this.Tab);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.Tab.ResumeLayout(false);
            this.Ventas.ResumeLayout(false);
            this.Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.VentProd.ResumeLayout(false);
            this.VentProd.PerformLayout();
            this.cmsOpc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenProd)).EndInit();
            this.cmsOpc2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Ventas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage VentProd;
        private System.Windows.Forms.ComboBox cbFac;
        private System.Windows.Forms.ComboBox cbEmp;
        private System.Windows.Forms.ContextMenuStrip cmsOpc;
        private System.Windows.Forms.ToolStripMenuItem eliminarTSM;
        private System.Windows.Forms.TextBox txtbCantidad;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbVenta;
        private System.Windows.Forms.DataGridView dgvVenProd;
        private System.Windows.Forms.ContextMenuStrip cmsOpc2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}