namespace Supermercado.Frames
{
    partial class frmEmpleados
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
            this.mtxtbNro_tel_sec = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbNro_tel_princ = new System.Windows.Forms.MaskedTextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.txtbCargo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbSalario_anual = new System.Windows.Forms.TextBox();
            this.txtbFecha_ingreso = new System.Windows.Forms.TextBox();
            this.txtbAntiguedad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.txtbCuil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbFecha_nac = new System.Windows.Forms.TextBox();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbNro_doc = new System.Windows.Forms.TextBox();
            this.txtbTipo_doc = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmsOpc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTSM = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.cmsOpc.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtbNro_tel_sec
            // 
            this.mtxtbNro_tel_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtbNro_tel_sec.Location = new System.Drawing.Point(678, 245);
            this.mtxtbNro_tel_sec.Mask = "000-000-0000";
            this.mtxtbNro_tel_sec.Name = "mtxtbNro_tel_sec";
            this.mtxtbNro_tel_sec.Size = new System.Drawing.Size(151, 29);
            this.mtxtbNro_tel_sec.TabIndex = 86;
            // 
            // mtxtbNro_tel_princ
            // 
            this.mtxtbNro_tel_princ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtbNro_tel_princ.Location = new System.Drawing.Point(678, 176);
            this.mtxtbNro_tel_princ.Mask = "000-000-0000";
            this.mtxtbNro_tel_princ.Name = "mtxtbNro_tel_princ";
            this.mtxtbNro_tel_princ.Size = new System.Drawing.Size(151, 29);
            this.mtxtbNro_tel_princ.TabIndex = 85;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.ContextMenuStrip = this.cmsOpc;
            this.dgvEmpleados.Location = new System.Drawing.Point(18, 509);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(931, 282);
            this.dgvEmpleados.TabIndex = 82;
            // 
            // txtbCargo
            // 
            this.txtbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCargo.Location = new System.Drawing.Point(678, 312);
            this.txtbCargo.Name = "txtbCargo";
            this.txtbCargo.Size = new System.Drawing.Size(241, 29);
            this.txtbCargo.TabIndex = 81;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(674, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 24);
            this.label12.TabIndex = 80;
            this.label12.Text = "Cargo";
            // 
            // txtbSalario_anual
            // 
            this.txtbSalario_anual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSalario_anual.Location = new System.Drawing.Point(678, 381);
            this.txtbSalario_anual.Name = "txtbSalario_anual";
            this.txtbSalario_anual.Size = new System.Drawing.Size(241, 29);
            this.txtbSalario_anual.TabIndex = 79;
            // 
            // txtbFecha_ingreso
            // 
            this.txtbFecha_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFecha_ingreso.Location = new System.Drawing.Point(373, 381);
            this.txtbFecha_ingreso.Name = "txtbFecha_ingreso";
            this.txtbFecha_ingreso.Size = new System.Drawing.Size(241, 29);
            this.txtbFecha_ingreso.TabIndex = 78;
            // 
            // txtbAntiguedad
            // 
            this.txtbAntiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAntiguedad.Location = new System.Drawing.Point(18, 381);
            this.txtbAntiguedad.Name = "txtbAntiguedad";
            this.txtbAntiguedad.Size = new System.Drawing.Size(241, 29);
            this.txtbAntiguedad.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(370, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 24);
            this.label13.TabIndex = 76;
            this.label13.Text = "Fecha de Ingreso";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(674, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 24);
            this.label14.TabIndex = 75;
            this.label14.Text = "Salario Anual";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 354);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 24);
            this.label15.TabIndex = 74;
            this.label15.Text = "Antiguedad";
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDireccion.Location = new System.Drawing.Point(373, 176);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(241, 29);
            this.txtbDireccion.TabIndex = 73;
            // 
            // txtbCuil
            // 
            this.txtbCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCuil.Location = new System.Drawing.Point(373, 245);
            this.txtbCuil.Name = "txtbCuil";
            this.txtbCuil.Size = new System.Drawing.Size(241, 29);
            this.txtbCuil.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(370, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 71;
            this.label9.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(370, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 24);
            this.label11.TabIndex = 70;
            this.label11.Text = "Cuil";
            // 
            // txtbFecha_nac
            // 
            this.txtbFecha_nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFecha_nac.Location = new System.Drawing.Point(18, 176);
            this.txtbFecha_nac.Name = "txtbFecha_nac";
            this.txtbFecha_nac.Size = new System.Drawing.Size(241, 29);
            this.txtbFecha_nac.TabIndex = 69;
            // 
            // txtbEdad
            // 
            this.txtbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEdad.Location = new System.Drawing.Point(678, 109);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(241, 29);
            this.txtbEdad.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Fecha de Nacimiento (YY/MM/DD)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(674, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 24);
            this.label10.TabIndex = 66;
            this.label10.Text = "Edad";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.Location = new System.Drawing.Point(18, 245);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(241, 29);
            this.txtbEmail.TabIndex = 65;
            // 
            // txtbNro_doc
            // 
            this.txtbNro_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNro_doc.Location = new System.Drawing.Point(373, 312);
            this.txtbNro_doc.Name = "txtbNro_doc";
            this.txtbNro_doc.Size = new System.Drawing.Size(241, 29);
            this.txtbNro_doc.TabIndex = 64;
            // 
            // txtbTipo_doc
            // 
            this.txtbTipo_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTipo_doc.Location = new System.Drawing.Point(18, 312);
            this.txtbTipo_doc.Name = "txtbTipo_doc";
            this.txtbTipo_doc.Size = new System.Drawing.Size(241, 29);
            this.txtbTipo_doc.TabIndex = 63;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbApellido.Location = new System.Drawing.Point(373, 109);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(241, 29);
            this.txtbApellido.TabIndex = 62;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(18, 109);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(241, 29);
            this.txtbNombre.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(674, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Numero Telefonico Secundario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 59;
            this.label8.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Numero del Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(674, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Numero Telefonico Principal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nombre";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(417, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(408, 31);
            this.txtBuscar.TabIndex = 88;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(186, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(225, 42);
            this.label16.TabIndex = 87;
            this.label16.Text = "Empleados:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(524, 442);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 46);
            this.btnCerrar.TabIndex = 90;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(344, 442);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 46);
            this.btnAgregar.TabIndex = 89;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
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
            // 
            // eliminarTSM
            // 
            this.eliminarTSM.Name = "eliminarTSM";
            this.eliminarTSM.Size = new System.Drawing.Size(117, 22);
            this.eliminarTSM.Text = "Eliminar";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 803);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mtxtbNro_tel_sec);
            this.Controls.Add(this.mtxtbNro_tel_princ);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.txtbCargo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbSalario_anual);
            this.Controls.Add(this.txtbFecha_ingreso);
            this.Controls.Add(this.txtbAntiguedad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.txtbCuil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbFecha_nac);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbNro_doc);
            this.Controls.Add(this.txtbTipo_doc);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.cmsOpc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtbNro_tel_sec;
        private System.Windows.Forms.MaskedTextBox mtxtbNro_tel_princ;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtbCargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbSalario_anual;
        private System.Windows.Forms.TextBox txtbFecha_ingreso;
        private System.Windows.Forms.TextBox txtbAntiguedad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.TextBox txtbCuil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbFecha_nac;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbNro_doc;
        private System.Windows.Forms.TextBox txtbTipo_doc;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ContextMenuStrip cmsOpc;
        private System.Windows.Forms.ToolStripMenuItem editarTSM;
        private System.Windows.Forms.ToolStripMenuItem eliminarTSM;
    }
}