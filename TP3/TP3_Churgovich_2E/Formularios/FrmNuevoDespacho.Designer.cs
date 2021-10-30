
namespace Formularios
{
    partial class FrmNuevoDespacho
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
            this.lblFechaRecep = new System.Windows.Forms.Label();
            this.txtDiaRecep = new System.Windows.Forms.TextBox();
            this.txtPrefijo = new System.Windows.Forms.TextBox();
            this.lblPrefijo = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.lblGuia = new System.Windows.Forms.Label();
            this.txtDiaEntrega = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cbmOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.txtMesRecep = new System.Windows.Forms.TextBox();
            this.txtAnioRecep = new System.Windows.Forms.TextBox();
            this.txtMesEntrega = new System.Windows.Forms.TextBox();
            this.txtAnioEntrega = new System.Windows.Forms.TextBox();
            this.txtRte = new System.Windows.Forms.TextBox();
            this.lblRte = new System.Windows.Forms.Label();
            this.txtLocalidadRte = new System.Windows.Forms.TextBox();
            this.lblLocalRte = new System.Windows.Forms.Label();
            this.txtLocalDestinatario = new System.Windows.Forms.TextBox();
            this.lblLocalDestinatario = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.txtRto = new System.Windows.Forms.TextBox();
            this.lblRto = new System.Windows.Forms.Label();
            this.cmbTipoBulto = new System.Windows.Forms.ComboBox();
            this.lblTipoBulto = new System.Windows.Forms.Label();
            this.cmbTipoPeso = new System.Windows.Forms.ComboBox();
            this.lblTipoPeso = new System.Windows.Forms.Label();
            this.lblCantBultos = new System.Windows.Forms.Label();
            this.nudCantBultos = new System.Windows.Forms.NumericUpDown();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.lblFlete = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantBultos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaRecep
            // 
            this.lblFechaRecep.AutoSize = true;
            this.lblFechaRecep.Location = new System.Drawing.Point(12, 5);
            this.lblFechaRecep.Name = "lblFechaRecep";
            this.lblFechaRecep.Size = new System.Drawing.Size(112, 15);
            this.lblFechaRecep.TabIndex = 0;
            this.lblFechaRecep.Text = "Fecha Recepción";
            // 
            // txtDiaRecep
            // 
            this.txtDiaRecep.BackColor = System.Drawing.Color.DarkGray;
            this.txtDiaRecep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaRecep.ForeColor = System.Drawing.Color.Black;
            this.txtDiaRecep.Location = new System.Drawing.Point(12, 24);
            this.txtDiaRecep.Name = "txtDiaRecep";
            this.txtDiaRecep.Size = new System.Drawing.Size(25, 23);
            this.txtDiaRecep.TabIndex = 0;
            this.txtDiaRecep.Text = "dd";
            this.txtDiaRecep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrefijo
            // 
            this.txtPrefijo.BackColor = System.Drawing.Color.DarkGray;
            this.txtPrefijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrefijo.ForeColor = System.Drawing.Color.Black;
            this.txtPrefijo.Location = new System.Drawing.Point(153, 74);
            this.txtPrefijo.Name = "txtPrefijo";
            this.txtPrefijo.ReadOnly = true;
            this.txtPrefijo.Size = new System.Drawing.Size(56, 23);
            this.txtPrefijo.TabIndex = 8;
            this.txtPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrefijo
            // 
            this.lblPrefijo.AutoSize = true;
            this.lblPrefijo.Location = new System.Drawing.Point(153, 55);
            this.lblPrefijo.Name = "lblPrefijo";
            this.lblPrefijo.Size = new System.Drawing.Size(56, 15);
            this.lblPrefijo.TabIndex = 2;
            this.lblPrefijo.Text = "Prefijo";
            // 
            // txtGuia
            // 
            this.txtGuia.BackColor = System.Drawing.Color.DarkGray;
            this.txtGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuia.ForeColor = System.Drawing.Color.Black;
            this.txtGuia.Location = new System.Drawing.Point(212, 74);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.ReadOnly = true;
            this.txtGuia.Size = new System.Drawing.Size(94, 23);
            this.txtGuia.TabIndex = 9;
            this.txtGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGuia
            // 
            this.lblGuia.AutoSize = true;
            this.lblGuia.Location = new System.Drawing.Point(212, 55);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(35, 15);
            this.lblGuia.TabIndex = 4;
            this.lblGuia.Text = "Guía";
            // 
            // txtDiaEntrega
            // 
            this.txtDiaEntrega.BackColor = System.Drawing.Color.DarkGray;
            this.txtDiaEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaEntrega.ForeColor = System.Drawing.Color.Black;
            this.txtDiaEntrega.Location = new System.Drawing.Point(146, 24);
            this.txtDiaEntrega.Name = "txtDiaEntrega";
            this.txtDiaEntrega.Size = new System.Drawing.Size(25, 23);
            this.txtDiaEntrega.TabIndex = 3;
            this.txtDiaEntrega.Text = "dd";
            this.txtDiaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(146, 5);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(98, 15);
            this.lblFechaEntrega.TabIndex = 6;
            this.lblFechaEntrega.Text = "Fecha Entrega";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(80, 55);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(56, 15);
            this.lblDestino.TabIndex = 9;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(12, 55);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(49, 15);
            this.lblOrigen.TabIndex = 8;
            this.lblOrigen.Text = "Origen";
            // 
            // cbmOrigen
            // 
            this.cbmOrigen.BackColor = System.Drawing.Color.DarkGray;
            this.cbmOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmOrigen.ForeColor = System.Drawing.Color.Black;
            this.cbmOrigen.FormattingEnabled = true;
            this.cbmOrigen.Location = new System.Drawing.Point(12, 74);
            this.cbmOrigen.Name = "cbmOrigen";
            this.cbmOrigen.Size = new System.Drawing.Size(55, 23);
            this.cbmOrigen.TabIndex = 6;
            // 
            // cmbDestino
            // 
            this.cmbDestino.BackColor = System.Drawing.Color.DarkGray;
            this.cmbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDestino.ForeColor = System.Drawing.Color.Black;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(80, 74);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(55, 23);
            this.cmbDestino.TabIndex = 7;
            // 
            // txtMesRecep
            // 
            this.txtMesRecep.BackColor = System.Drawing.Color.DarkGray;
            this.txtMesRecep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMesRecep.ForeColor = System.Drawing.Color.Black;
            this.txtMesRecep.Location = new System.Drawing.Point(43, 24);
            this.txtMesRecep.Name = "txtMesRecep";
            this.txtMesRecep.Size = new System.Drawing.Size(25, 23);
            this.txtMesRecep.TabIndex = 1;
            this.txtMesRecep.Text = "MM";
            this.txtMesRecep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnioRecep
            // 
            this.txtAnioRecep.BackColor = System.Drawing.Color.DarkGray;
            this.txtAnioRecep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnioRecep.ForeColor = System.Drawing.Color.Black;
            this.txtAnioRecep.Location = new System.Drawing.Point(74, 24);
            this.txtAnioRecep.Name = "txtAnioRecep";
            this.txtAnioRecep.Size = new System.Drawing.Size(46, 23);
            this.txtAnioRecep.TabIndex = 2;
            this.txtAnioRecep.Text = "aaaa";
            this.txtAnioRecep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMesEntrega
            // 
            this.txtMesEntrega.BackColor = System.Drawing.Color.DarkGray;
            this.txtMesEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMesEntrega.ForeColor = System.Drawing.Color.Black;
            this.txtMesEntrega.Location = new System.Drawing.Point(177, 24);
            this.txtMesEntrega.Name = "txtMesEntrega";
            this.txtMesEntrega.Size = new System.Drawing.Size(25, 23);
            this.txtMesEntrega.TabIndex = 4;
            this.txtMesEntrega.Text = "MM";
            this.txtMesEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnioEntrega
            // 
            this.txtAnioEntrega.BackColor = System.Drawing.Color.DarkGray;
            this.txtAnioEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnioEntrega.ForeColor = System.Drawing.Color.Black;
            this.txtAnioEntrega.Location = new System.Drawing.Point(208, 24);
            this.txtAnioEntrega.Name = "txtAnioEntrega";
            this.txtAnioEntrega.Size = new System.Drawing.Size(46, 23);
            this.txtAnioEntrega.TabIndex = 5;
            this.txtAnioEntrega.Text = "aaaa";
            this.txtAnioEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRte
            // 
            this.txtRte.BackColor = System.Drawing.Color.DarkGray;
            this.txtRte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRte.ForeColor = System.Drawing.Color.Black;
            this.txtRte.Location = new System.Drawing.Point(12, 126);
            this.txtRte.Name = "txtRte";
            this.txtRte.ReadOnly = true;
            this.txtRte.Size = new System.Drawing.Size(197, 23);
            this.txtRte.TabIndex = 11;
            // 
            // lblRte
            // 
            this.lblRte.AutoSize = true;
            this.lblRte.Location = new System.Drawing.Point(12, 107);
            this.lblRte.Name = "lblRte";
            this.lblRte.Size = new System.Drawing.Size(35, 15);
            this.lblRte.TabIndex = 16;
            this.lblRte.Text = "Rte.";
            // 
            // txtLocalidadRte
            // 
            this.txtLocalidadRte.BackColor = System.Drawing.Color.DarkGray;
            this.txtLocalidadRte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalidadRte.ForeColor = System.Drawing.Color.Black;
            this.txtLocalidadRte.Location = new System.Drawing.Point(220, 126);
            this.txtLocalidadRte.Name = "txtLocalidadRte";
            this.txtLocalidadRte.Size = new System.Drawing.Size(197, 23);
            this.txtLocalidadRte.TabIndex = 12;
            // 
            // lblLocalRte
            // 
            this.lblLocalRte.AutoSize = true;
            this.lblLocalRte.Location = new System.Drawing.Point(220, 107);
            this.lblLocalRte.Name = "lblLocalRte";
            this.lblLocalRte.Size = new System.Drawing.Size(105, 15);
            this.lblLocalRte.TabIndex = 18;
            this.lblLocalRte.Text = "Localidad Rte.";
            // 
            // txtLocalDestinatario
            // 
            this.txtLocalDestinatario.BackColor = System.Drawing.Color.DarkGray;
            this.txtLocalDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalDestinatario.ForeColor = System.Drawing.Color.Black;
            this.txtLocalDestinatario.Location = new System.Drawing.Point(220, 177);
            this.txtLocalDestinatario.Name = "txtLocalDestinatario";
            this.txtLocalDestinatario.Size = new System.Drawing.Size(197, 23);
            this.txtLocalDestinatario.TabIndex = 14;
            // 
            // lblLocalDestinatario
            // 
            this.lblLocalDestinatario.AutoSize = true;
            this.lblLocalDestinatario.Location = new System.Drawing.Point(220, 158);
            this.lblLocalDestinatario.Name = "lblLocalDestinatario";
            this.lblLocalDestinatario.Size = new System.Drawing.Size(126, 15);
            this.lblLocalDestinatario.TabIndex = 22;
            this.lblLocalDestinatario.Text = "Localidad Destin.";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.BackColor = System.Drawing.Color.DarkGray;
            this.txtDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestinatario.ForeColor = System.Drawing.Color.Black;
            this.txtDestinatario.Location = new System.Drawing.Point(12, 177);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(197, 23);
            this.txtDestinatario.TabIndex = 13;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(12, 158);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(91, 15);
            this.lblDestinatario.TabIndex = 20;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // txtRto
            // 
            this.txtRto.BackColor = System.Drawing.Color.DarkGray;
            this.txtRto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRto.ForeColor = System.Drawing.Color.Black;
            this.txtRto.Location = new System.Drawing.Point(323, 74);
            this.txtRto.Name = "txtRto";
            this.txtRto.Size = new System.Drawing.Size(94, 23);
            this.txtRto.TabIndex = 10;
            this.txtRto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRto
            // 
            this.lblRto.AutoSize = true;
            this.lblRto.Location = new System.Drawing.Point(323, 55);
            this.lblRto.Name = "lblRto";
            this.lblRto.Size = new System.Drawing.Size(35, 15);
            this.lblRto.TabIndex = 24;
            this.lblRto.Text = "Rto.";
            // 
            // cmbTipoBulto
            // 
            this.cmbTipoBulto.BackColor = System.Drawing.Color.DarkGray;
            this.cmbTipoBulto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoBulto.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoBulto.FormattingEnabled = true;
            this.cmbTipoBulto.Location = new System.Drawing.Point(13, 230);
            this.cmbTipoBulto.Name = "cmbTipoBulto";
            this.cmbTipoBulto.Size = new System.Drawing.Size(77, 23);
            this.cmbTipoBulto.TabIndex = 15;
            // 
            // lblTipoBulto
            // 
            this.lblTipoBulto.AutoSize = true;
            this.lblTipoBulto.Location = new System.Drawing.Point(13, 212);
            this.lblTipoBulto.Name = "lblTipoBulto";
            this.lblTipoBulto.Size = new System.Drawing.Size(77, 15);
            this.lblTipoBulto.TabIndex = 26;
            this.lblTipoBulto.Text = "Tipo Bulto";
            // 
            // cmbTipoPeso
            // 
            this.cmbTipoPeso.BackColor = System.Drawing.Color.DarkGray;
            this.cmbTipoPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoPeso.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoPeso.FormattingEnabled = true;
            this.cmbTipoPeso.Location = new System.Drawing.Point(214, 230);
            this.cmbTipoPeso.Name = "cmbTipoPeso";
            this.cmbTipoPeso.Size = new System.Drawing.Size(77, 23);
            this.cmbTipoPeso.TabIndex = 17;
            // 
            // lblTipoPeso
            // 
            this.lblTipoPeso.AutoSize = true;
            this.lblTipoPeso.Location = new System.Drawing.Point(214, 212);
            this.lblTipoPeso.Name = "lblTipoPeso";
            this.lblTipoPeso.Size = new System.Drawing.Size(70, 15);
            this.lblTipoPeso.TabIndex = 28;
            this.lblTipoPeso.Text = "Tipo Peso";
            // 
            // lblCantBultos
            // 
            this.lblCantBultos.AutoSize = true;
            this.lblCantBultos.Location = new System.Drawing.Point(113, 212);
            this.lblCantBultos.Name = "lblCantBultos";
            this.lblCantBultos.Size = new System.Drawing.Size(77, 15);
            this.lblCantBultos.TabIndex = 30;
            this.lblCantBultos.Text = "Cant.Bulto";
            // 
            // nudCantBultos
            // 
            this.nudCantBultos.BackColor = System.Drawing.Color.DarkGray;
            this.nudCantBultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCantBultos.ForeColor = System.Drawing.Color.Black;
            this.nudCantBultos.Location = new System.Drawing.Point(113, 230);
            this.nudCantBultos.Name = "nudCantBultos";
            this.nudCantBultos.Size = new System.Drawing.Size(77, 23);
            this.nudCantBultos.TabIndex = 16;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.DarkGray;
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.ForeColor = System.Drawing.Color.Black;
            this.txtPeso.Location = new System.Drawing.Point(314, 231);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(103, 23);
            this.txtPeso.TabIndex = 18;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(314, 212);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 15);
            this.lblPeso.TabIndex = 32;
            this.lblPeso.Text = "Peso";
            // 
            // txtFlete
            // 
            this.txtFlete.BackColor = System.Drawing.Color.DarkGray;
            this.txtFlete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlete.ForeColor = System.Drawing.Color.Black;
            this.txtFlete.Location = new System.Drawing.Point(12, 286);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.ReadOnly = true;
            this.txtFlete.Size = new System.Drawing.Size(128, 23);
            this.txtFlete.TabIndex = 19;
            // 
            // lblFlete
            // 
            this.lblFlete.AutoSize = true;
            this.lblFlete.Location = new System.Drawing.Point(12, 267);
            this.lblFlete.Name = "lblFlete";
            this.lblFlete.Size = new System.Drawing.Size(42, 15);
            this.lblFlete.TabIndex = 34;
            this.lblFlete.Text = "Flete";
            // 
            // txtIva
            // 
            this.txtIva.BackColor = System.Drawing.Color.DarkGray;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.ForeColor = System.Drawing.Color.Black;
            this.txtIva.Location = new System.Drawing.Point(157, 286);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(108, 23);
            this.txtIva.TabIndex = 20;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(157, 267);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(28, 15);
            this.lblIva.TabIndex = 36;
            this.lblIva.Text = "IVA";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.DarkGray;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(282, 286);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(135, 23);
            this.txtTotal.TabIndex = 21;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(282, 267);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 15);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Total";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = global::Formularios.Properties.Resources.boton2dark;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Cyan;
            this.btnActualizar.Location = new System.Drawing.Point(39, 328);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 47);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.BackgroundImage = global::Formularios.Properties.Resources.boton2dark;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.ForeColor = System.Drawing.Color.Cyan;
            this.btnCargar.Location = new System.Drawing.Point(161, 328);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 47);
            this.btnCargar.TabIndex = 23;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::Formularios.Properties.Resources.boton2dark;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Cyan;
            this.btnSalir.Location = new System.Drawing.Point(282, 328);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 47);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // FrmNuevoDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 407);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.txtFlete);
            this.Controls.Add(this.lblFlete);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.nudCantBultos);
            this.Controls.Add(this.lblCantBultos);
            this.Controls.Add(this.cmbTipoPeso);
            this.Controls.Add(this.lblTipoPeso);
            this.Controls.Add(this.cmbTipoBulto);
            this.Controls.Add(this.lblTipoBulto);
            this.Controls.Add(this.txtRto);
            this.Controls.Add(this.lblRto);
            this.Controls.Add(this.txtLocalDestinatario);
            this.Controls.Add(this.lblLocalDestinatario);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.txtLocalidadRte);
            this.Controls.Add(this.lblLocalRte);
            this.Controls.Add(this.txtRte);
            this.Controls.Add(this.lblRte);
            this.Controls.Add(this.txtAnioEntrega);
            this.Controls.Add(this.txtMesEntrega);
            this.Controls.Add(this.txtAnioRecep);
            this.Controls.Add(this.txtMesRecep);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cbmOrigen);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.txtDiaEntrega);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.lblGuia);
            this.Controls.Add(this.txtPrefijo);
            this.Controls.Add(this.lblPrefijo);
            this.Controls.Add(this.txtDiaRecep);
            this.Controls.Add(this.lblFechaRecep);
            this.Name = "FrmNuevoDespacho";
            this.Text = "Nuevo Despacho";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantBultos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaRecep;
        private System.Windows.Forms.TextBox txtDiaRecep;
        private System.Windows.Forms.TextBox txtPrefijo;
        private System.Windows.Forms.Label lblPrefijo;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.TextBox txtDiaEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cbmOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.TextBox txtMesRecep;
        private System.Windows.Forms.TextBox txtAnioRecep;
        private System.Windows.Forms.TextBox txtMesEntrega;
        private System.Windows.Forms.TextBox txtAnioEntrega;
        private System.Windows.Forms.TextBox txtRte;
        private System.Windows.Forms.Label lblRte;
        private System.Windows.Forms.TextBox txtLocalidadRte;
        private System.Windows.Forms.Label lblLocalRte;
        private System.Windows.Forms.TextBox txtLocalDestinatario;
        private System.Windows.Forms.Label lblLocalDestinatario;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtRto;
        private System.Windows.Forms.Label lblRto;
        private System.Windows.Forms.ComboBox cmbTipoBulto;
        private System.Windows.Forms.Label lblTipoBulto;
        private System.Windows.Forms.ComboBox cmbTipoPeso;
        private System.Windows.Forms.Label lblTipoPeso;
        private System.Windows.Forms.Label lblCantBultos;
        private System.Windows.Forms.NumericUpDown nudCantBultos;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.Label lblFlete;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
    }
}