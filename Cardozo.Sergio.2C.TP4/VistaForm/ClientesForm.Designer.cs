namespace VistaForm
{
    partial class ClientesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnModificar = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBorrarCliente = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.dataGClientes = new System.Windows.Forms.DataGridView();
            this.gBPanelControl = new System.Windows.Forms.GroupBox();
            this.btnBorrarSeleccion = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.lblIDSocio = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtIDSocio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGClientes)).BeginInit();
            this.gBPanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStrip
            // 
            this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGuardar,
            this.tsBtnModificar,
            this.tsBtnBorrarCliente,
            this.tsBtnCancelar});
            this.tStrip.Location = new System.Drawing.Point(0, 0);
            this.tStrip.Name = "tStrip";
            this.tStrip.Size = new System.Drawing.Size(507, 39);
            this.tStrip.TabIndex = 0;
            this.tStrip.Text = "toolStrip1";
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
            // tsBtnBorrarCliente
            // 
            this.tsBtnBorrarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnBorrarCliente.Image = global::VistaForm.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.tsBtnBorrarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnBorrarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBorrarCliente.Name = "tsBtnBorrarCliente";
            this.tsBtnBorrarCliente.Size = new System.Drawing.Size(79, 36);
            this.tsBtnBorrarCliente.Text = "Borrar";
            this.tsBtnBorrarCliente.Click += new System.EventHandler(this.tsBtnBorrarCliente_Click);
            // 
            // tsBtnCancelar
            // 
            this.tsBtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnCancelar.Image = global::VistaForm.Properties.Resources.restart_back_left_arrow_6022;
            this.tsBtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancelar.Name = "tsBtnCancelar";
            this.tsBtnCancelar.Size = new System.Drawing.Size(72, 36);
            this.tsBtnCancelar.Text = "Atras";
            this.tsBtnCancelar.Click += new System.EventHandler(this.tsBtnCancelar_Click);
            // 
            // dataGClientes
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGClientes.Location = new System.Drawing.Point(0, 165);
            this.dataGClientes.MultiSelect = false;
            this.dataGClientes.Name = "dataGClientes";
            this.dataGClientes.RowHeadersVisible = false;
            this.dataGClientes.Size = new System.Drawing.Size(507, 275);
            this.dataGClientes.TabIndex = 10;
            this.dataGClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGClientes_CellClick);
            // 
            // gBPanelControl
            // 
            this.gBPanelControl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gBPanelControl.Controls.Add(this.btnCancelar);
            this.gBPanelControl.Controls.Add(this.btnBorrarSeleccion);
            this.gBPanelControl.Controls.Add(this.btnModificarCliente);
            this.gBPanelControl.Controls.Add(this.btnBorrarCliente);
            this.gBPanelControl.Controls.Add(this.lblIDSocio);
            this.gBPanelControl.Controls.Add(this.txtApellido);
            this.gBPanelControl.Controls.Add(this.lblNombre);
            this.gBPanelControl.Controls.Add(this.txtNombre);
            this.gBPanelControl.Controls.Add(this.lblApellido);
            this.gBPanelControl.Controls.Add(this.txtIDSocio);
            this.gBPanelControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gBPanelControl.Location = new System.Drawing.Point(5, 42);
            this.gBPanelControl.Name = "gBPanelControl";
            this.gBPanelControl.Size = new System.Drawing.Size(496, 119);
            this.gBPanelControl.TabIndex = 9;
            this.gBPanelControl.TabStop = false;
            this.gBPanelControl.Text = "Panel Control";
            // 
            // btnBorrarSeleccion
            // 
            this.btnBorrarSeleccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrarSeleccion.Location = new System.Drawing.Point(282, 80);
            this.btnBorrarSeleccion.Name = "btnBorrarSeleccion";
            this.btnBorrarSeleccion.Size = new System.Drawing.Size(104, 22);
            this.btnBorrarSeleccion.TabIndex = 10;
            this.btnBorrarSeleccion.Text = "Borrar Seleccion";
            this.btnBorrarSeleccion.UseVisualStyleBackColor = true;
            this.btnBorrarSeleccion.Click += new System.EventHandler(this.btnBorrarSeleccion_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarCliente.Location = new System.Drawing.Point(282, 52);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(104, 22);
            this.btnModificarCliente.TabIndex = 9;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.ModificarCliente_Click);
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrarCliente.Location = new System.Drawing.Point(282, 20);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(104, 26);
            this.btnBorrarCliente.TabIndex = 8;
            this.btnBorrarCliente.Text = "Borrar Cliente";
            this.btnBorrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBorrarCliente.UseVisualStyleBackColor = true;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
            // 
            // lblIDSocio
            // 
            this.lblIDSocio.AutoSize = true;
            this.lblIDSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSocio.Location = new System.Drawing.Point(12, 25);
            this.lblIDSocio.Name = "lblIDSocio";
            this.lblIDSocio.Size = new System.Drawing.Size(78, 20);
            this.lblIDSocio.TabIndex = 1;
            this.lblIDSocio.Text = "ID Socio";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(96, 83);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 26);
            this.txtApellido.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(96, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 89);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 20);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtIDSocio
            // 
            this.txtIDSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSocio.Location = new System.Drawing.Point(96, 19);
            this.txtIDSocio.Name = "txtIDSocio";
            this.txtIDSocio.Size = new System.Drawing.Size(180, 26);
            this.txtIDSocio.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(392, 79);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 22);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(507, 440);
            this.ControlBox = false;
            this.Controls.Add(this.dataGClientes);
            this.Controls.Add(this.gBPanelControl);
            this.Controls.Add(this.tStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.tStrip.ResumeLayout(false);
            this.tStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGClientes)).EndInit();
            this.gBPanelControl.ResumeLayout(false);
            this.gBPanelControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.DataGridView dataGClientes;
        private System.Windows.Forms.GroupBox gBPanelControl;
        private System.Windows.Forms.Label lblIDSocio;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtIDSocio;
        private System.Windows.Forms.ToolStripButton tsBtnGuardar;
        private System.Windows.Forms.ToolStripButton tsBtnCancelar;
        private System.Windows.Forms.ToolStripButton tsBtnModificar;
        private System.Windows.Forms.ToolStripButton tsBtnBorrarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Button btnBorrarSeleccion;
        private System.Windows.Forms.Button btnCancelar;
    }
}