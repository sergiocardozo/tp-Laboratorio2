namespace VistaForm
{
    partial class ListaVideoJuegoForm
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAtras = new System.Windows.Forms.ToolStripButton();
            this.gbPanelControl = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarJuego = new System.Windows.Forms.Button();
            this.btnBorrarJuego = new System.Windows.Forms.Button();
            this.btnBorrarSeleccion = new System.Windows.Forms.Button();
            this.cmbTipoJuegos = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblVideoJuego = new System.Windows.Forms.Label();
            this.txtVideoJuego = new System.Windows.Forms.TextBox();
            this.lblTipoVideoJuego = new System.Windows.Forms.Label();
            this.dataGListaJuegos = new System.Windows.Forms.DataGridView();
            this.toolStrip.SuspendLayout();
            this.gbPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGListaJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGuardar,
            this.tsBtnModificar,
            this.tsBtnBorrar,
            this.tsBtnAtras});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(709, 39);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsBtnGuardar
            // 
            this.tsBtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnGuardar.Image = global::VistaForm.Properties.Resources.diskette_save_saveas_1514;
            this.tsBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGuardar.Name = "tsBtnGuardar";
            this.tsBtnGuardar.Size = new System.Drawing.Size(88, 36);
            this.tsBtnGuardar.Text = "Agregar";
            this.tsBtnGuardar.Click += new System.EventHandler(this.tsBtnGuardar_Click);
            // 
            // tsBtnModificar
            // 
            this.tsBtnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnModificar.Image = global::VistaForm.Properties.Resources.edit_pencil_paper_modify_write_icon_141958;
            this.tsBtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnModificar.Name = "tsBtnModificar";
            this.tsBtnModificar.Size = new System.Drawing.Size(96, 36);
            this.tsBtnModificar.Text = "Modificar";
            this.tsBtnModificar.Click += new System.EventHandler(this.tsBtnModificar_Click);
            // 
            // tsBtnBorrar
            // 
            this.tsBtnBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnBorrar.Image = global::VistaForm.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.tsBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBorrar.Name = "tsBtnBorrar";
            this.tsBtnBorrar.Size = new System.Drawing.Size(79, 36);
            this.tsBtnBorrar.Text = "Borrar";
            this.tsBtnBorrar.Click += new System.EventHandler(this.tsBtnBorrar_Click);
            // 
            // tsBtnAtras
            // 
            this.tsBtnAtras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnAtras.Image = global::VistaForm.Properties.Resources.restart_back_left_arrow_6022;
            this.tsBtnAtras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAtras.Name = "tsBtnAtras";
            this.tsBtnAtras.Size = new System.Drawing.Size(72, 36);
            this.tsBtnAtras.Text = "Atras";
            this.tsBtnAtras.Click += new System.EventHandler(this.tsBtnAtras_Click);
            // 
            // gbPanelControl
            // 
            this.gbPanelControl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbPanelControl.Controls.Add(this.btnCancelar);
            this.gbPanelControl.Controls.Add(this.btnModificarJuego);
            this.gbPanelControl.Controls.Add(this.btnBorrarJuego);
            this.gbPanelControl.Controls.Add(this.btnBorrarSeleccion);
            this.gbPanelControl.Controls.Add(this.cmbTipoJuegos);
            this.gbPanelControl.Controls.Add(this.lblStock);
            this.gbPanelControl.Controls.Add(this.txtStock);
            this.gbPanelControl.Controls.Add(this.lblPrecio);
            this.gbPanelControl.Controls.Add(this.txtPrecio);
            this.gbPanelControl.Controls.Add(this.lblVideoJuego);
            this.gbPanelControl.Controls.Add(this.txtVideoJuego);
            this.gbPanelControl.Controls.Add(this.lblTipoVideoJuego);
            this.gbPanelControl.ForeColor = System.Drawing.Color.White;
            this.gbPanelControl.Location = new System.Drawing.Point(12, 42);
            this.gbPanelControl.Name = "gbPanelControl";
            this.gbPanelControl.Size = new System.Drawing.Size(685, 98);
            this.gbPanelControl.TabIndex = 1;
            this.gbPanelControl.TabStop = false;
            this.gbPanelControl.Text = "Panel Control";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(420, 67);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 23);
            this.btnCancelar.TabIndex = 135;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificarJuego
            // 
            this.btnModificarJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarJuego.ForeColor = System.Drawing.Color.Black;
            this.btnModificarJuego.Location = new System.Drawing.Point(194, 67);
            this.btnModificarJuego.Name = "btnModificarJuego";
            this.btnModificarJuego.Size = new System.Drawing.Size(107, 23);
            this.btnModificarJuego.TabIndex = 134;
            this.btnModificarJuego.Text = "Modificar Juego";
            this.btnModificarJuego.UseVisualStyleBackColor = true;
            this.btnModificarJuego.Click += new System.EventHandler(this.btnModificarJuego_Click);
            // 
            // btnBorrarJuego
            // 
            this.btnBorrarJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarJuego.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarJuego.Location = new System.Drawing.Point(307, 67);
            this.btnBorrarJuego.Name = "btnBorrarJuego";
            this.btnBorrarJuego.Size = new System.Drawing.Size(107, 23);
            this.btnBorrarJuego.TabIndex = 133;
            this.btnBorrarJuego.Text = "Borrar Juego";
            this.btnBorrarJuego.UseVisualStyleBackColor = true;
            this.btnBorrarJuego.Click += new System.EventHandler(this.btnBorrarJuego_Click);
            // 
            // btnBorrarSeleccion
            // 
            this.btnBorrarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarSeleccion.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarSeleccion.Location = new System.Drawing.Point(533, 67);
            this.btnBorrarSeleccion.Name = "btnBorrarSeleccion";
            this.btnBorrarSeleccion.Size = new System.Drawing.Size(114, 23);
            this.btnBorrarSeleccion.TabIndex = 132;
            this.btnBorrarSeleccion.Text = "Borrar Seleccion";
            this.btnBorrarSeleccion.UseVisualStyleBackColor = true;
            this.btnBorrarSeleccion.Click += new System.EventHandler(this.btnBorrarSeleccion_Click);
            // 
            // cmbTipoJuegos
            // 
            this.cmbTipoJuegos.FormattingEnabled = true;
            this.cmbTipoJuegos.Location = new System.Drawing.Point(112, 40);
            this.cmbTipoJuegos.Name = "cmbTipoJuegos";
            this.cmbTipoJuegos.Size = new System.Drawing.Size(171, 21);
            this.cmbTipoJuegos.TabIndex = 131;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(307, 48);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(40, 13);
            this.lblStock.TabIndex = 130;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(353, 41);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(171, 20);
            this.txtStock.TabIndex = 129;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(304, 20);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 128;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(353, 16);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(171, 20);
            this.txtPrecio.TabIndex = 127;
            // 
            // lblVideoJuego
            // 
            this.lblVideoJuego.AutoSize = true;
            this.lblVideoJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoJuego.Location = new System.Drawing.Point(6, 24);
            this.lblVideoJuego.Name = "lblVideoJuego";
            this.lblVideoJuego.Size = new System.Drawing.Size(74, 13);
            this.lblVideoJuego.TabIndex = 126;
            this.lblVideoJuego.Text = "Video juego";
            // 
            // txtVideoJuego
            // 
            this.txtVideoJuego.Location = new System.Drawing.Point(112, 17);
            this.txtVideoJuego.Name = "txtVideoJuego";
            this.txtVideoJuego.Size = new System.Drawing.Size(171, 20);
            this.txtVideoJuego.TabIndex = 125;
            // 
            // lblTipoVideoJuego
            // 
            this.lblTipoVideoJuego.AutoSize = true;
            this.lblTipoVideoJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVideoJuego.Location = new System.Drawing.Point(4, 48);
            this.lblTipoVideoJuego.Name = "lblTipoVideoJuego";
            this.lblTipoVideoJuego.Size = new System.Drawing.Size(102, 13);
            this.lblTipoVideoJuego.TabIndex = 124;
            this.lblTipoVideoJuego.Text = "Tipo video juego";
            // 
            // dataGListaJuegos
            // 
            this.dataGListaJuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGListaJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGListaJuegos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGListaJuegos.Location = new System.Drawing.Point(0, 146);
            this.dataGListaJuegos.MultiSelect = false;
            this.dataGListaJuegos.Name = "dataGListaJuegos";
            this.dataGListaJuegos.Size = new System.Drawing.Size(709, 288);
            this.dataGListaJuegos.TabIndex = 2;
            this.dataGListaJuegos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGListaJuegos_CellClick);
            // 
            // ListaVideoJuegoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(709, 434);
            this.ControlBox = false;
            this.Controls.Add(this.dataGListaJuegos);
            this.Controls.Add(this.gbPanelControl);
            this.Controls.Add(this.toolStrip);
            this.Name = "ListaVideoJuegoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoJuegos";
            this.Load += new System.EventHandler(this.ListaVideoJuegoForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gbPanelControl.ResumeLayout(false);
            this.gbPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGListaJuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripButton tsBtnAtras;
        private System.Windows.Forms.GroupBox gbPanelControl;
        private System.Windows.Forms.DataGridView dataGListaJuegos;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblVideoJuego;
        private System.Windows.Forms.TextBox txtVideoJuego;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipoVideoJuego;
        private System.Windows.Forms.ComboBox cmbTipoJuegos;
        private System.Windows.Forms.ToolStripButton tsBtnModificar;
        private System.Windows.Forms.ToolStripButton tsBtnBorrar;
        private System.Windows.Forms.Button btnBorrarSeleccion;
        private System.Windows.Forms.Button btnModificarJuego;
        private System.Windows.Forms.Button btnBorrarJuego;
        private System.Windows.Forms.Button btnCancelar;
    }
}