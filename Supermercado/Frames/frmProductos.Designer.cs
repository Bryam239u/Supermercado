namespace Supermercado.Frames
{
    partial class frmProductos
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbStock = new System.Windows.Forms.TextBox();
            this.txtbMarca = new System.Windows.Forms.TextBox();
            this.txtbGrupo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbImg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbTipo = new System.Windows.Forms.TextBox();
            this.txtbPrecio_U = new System.Windows.Forms.TextBox();
            this.txtbPeso = new System.Windows.Forms.TextBox();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cmsOpc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.cmsOpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(489, 364);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(170, 46);
            this.btnCerrar.TabIndex = 124;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(282, 364);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(181, 46);
            this.btnAgregar.TabIndex = 123;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(412, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(408, 31);
            this.txtBuscar.TabIndex = 122;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(181, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 42);
            this.label16.TabIndex = 121;
            this.label16.Text = "Productos";
            // 
            // txtbStock
            // 
            this.txtbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbStock.Location = new System.Drawing.Point(682, 100);
            this.txtbStock.Name = "txtbStock";
            this.txtbStock.Size = new System.Drawing.Size(241, 29);
            this.txtbStock.TabIndex = 3;
            // 
            // txtbMarca
            // 
            this.txtbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMarca.Location = new System.Drawing.Point(368, 167);
            this.txtbMarca.Name = "txtbMarca";
            this.txtbMarca.Size = new System.Drawing.Size(241, 29);
            this.txtbMarca.TabIndex = 5;
            // 
            // txtbGrupo
            // 
            this.txtbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbGrupo.Location = new System.Drawing.Point(368, 236);
            this.txtbGrupo.Name = "txtbGrupo";
            this.txtbGrupo.Size = new System.Drawing.Size(241, 29);
            this.txtbGrupo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 116;
            this.label9.Text = "Marca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(365, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 24);
            this.label11.TabIndex = 115;
            this.label11.Text = "Grupo";
            // 
            // txtbImg
            // 
            this.txtbImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbImg.Location = new System.Drawing.Point(13, 167);
            this.txtbImg.Name = "txtbImg";
            this.txtbImg.Size = new System.Drawing.Size(241, 29);
            this.txtbImg.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 24);
            this.label10.TabIndex = 113;
            this.label10.Text = "Imagen";
            // 
            // txtbTipo
            // 
            this.txtbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTipo.Location = new System.Drawing.Point(13, 236);
            this.txtbTipo.Name = "txtbTipo";
            this.txtbTipo.Size = new System.Drawing.Size(241, 29);
            this.txtbTipo.TabIndex = 7;
            // 
            // txtbPrecio_U
            // 
            this.txtbPrecio_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrecio_U.Location = new System.Drawing.Point(682, 167);
            this.txtbPrecio_U.Name = "txtbPrecio_U";
            this.txtbPrecio_U.Size = new System.Drawing.Size(241, 29);
            this.txtbPrecio_U.TabIndex = 6;
            // 
            // txtbPeso
            // 
            this.txtbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPeso.Location = new System.Drawing.Point(682, 236);
            this.txtbPeso.Name = "txtbPeso";
            this.txtbPeso.Size = new System.Drawing.Size(241, 29);
            this.txtbPeso.TabIndex = 9;
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCodigo.Location = new System.Drawing.Point(368, 100);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(241, 29);
            this.txtbCodigo.TabIndex = 2;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(13, 100);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(241, 29);
            this.txtbNombre.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 111;
            this.label8.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(678, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 110;
            this.label5.Text = "Precio Unidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 108;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(678, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 107;
            this.label4.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 106;
            this.label2.Text = "Nombre";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.ContextMenuStrip = this.cmsOpc;
            this.dgvProductos.Location = new System.Drawing.Point(13, 427);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(931, 282);
            this.dgvProductos.TabIndex = 127;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(678, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 24);
            this.label12.TabIndex = 120;
            this.label12.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 129;
            this.label1.Text = "Proveedor";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(368, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 32);
            this.comboBox1.TabIndex = 130;
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(682, 271);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(241, 150);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 131;
            this.pbImg.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(963, 721);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtbStock);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbMarca);
            this.Controls.Add(this.txtbGrupo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbImg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbTipo);
            this.Controls.Add(this.txtbPrecio_U);
            this.Controls.Add(this.txtbPeso);
            this.Controls.Add(this.txtbCodigo);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.cmsOpc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbStock;
        private System.Windows.Forms.TextBox txtbMarca;
        private System.Windows.Forms.TextBox txtbGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbImg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbTipo;
        private System.Windows.Forms.TextBox txtbPrecio_U;
        private System.Windows.Forms.TextBox txtbPeso;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ContextMenuStrip cmsOpc;
        private System.Windows.Forms.ToolStripMenuItem editarTSM;
        private System.Windows.Forms.ToolStripMenuItem eliminarTSM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbImg;
    }
}