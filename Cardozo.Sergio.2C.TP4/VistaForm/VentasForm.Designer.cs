namespace VistaForm
{
    partial class VentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltraPorCodigo = new System.Windows.Forms.TextBox();
            this.dataGClientes = new System.Windows.Forms.DataGridView();
            this.lvClienteSeleccionado = new System.Windows.Forms.ListView();
            this.lvVideoJuegos = new System.Windows.Forms.ListView();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAtras = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGClientes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Cliente";
            // 
            // txtFiltraPorCodigo
            // 
            this.txtFiltraPorCodigo.Location = new System.Drawing.Point(124, 39);
            this.txtFiltraPorCodigo.Name = "txtFiltraPorCodigo";
            this.txtFiltraPorCodigo.Size = new System.Drawing.Size(157, 20);
            this.txtFiltraPorCodigo.TabIndex = 1;
            this.txtFiltraPorCodigo.TextChanged += new System.EventHandler(this.txtFiltraPorCodigo_TextChanged);
            // 
            // dataGClientes
            // 
            this.dataGClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGClientes.Location = new System.Drawing.Point(40, 65);
            this.dataGClientes.MultiSelect = false;
            this.dataGClientes.Name = "dataGClientes";
            this.dataGClientes.Size = new System.Drawing.Size(569, 183);
            this.dataGClientes.TabIndex = 2;
            // 
            // lvClienteSeleccionado
            // 
            this.lvClienteSeleccionado.CheckBoxes = true;
            this.lvClienteSeleccionado.FullRowSelect = true;
            this.lvClienteSeleccionado.GridLines = true;
            this.lvClienteSeleccionado.HideSelection = false;
            this.lvClienteSeleccionado.Location = new System.Drawing.Point(40, 259);
            this.lvClienteSeleccionado.Name = "lvClienteSeleccionado";
            this.lvClienteSeleccionado.Size = new System.Drawing.Size(569, 61);
            this.lvClienteSeleccionado.TabIndex = 3;
            this.lvClienteSeleccionado.UseCompatibleStateImageBehavior = false;
            // 
            // lvVideoJuegos
            // 
            this.lvVideoJuegos.CheckBoxes = true;
            this.lvVideoJuegos.GridLines = true;
            this.lvVideoJuegos.HideSelection = false;
            this.lvVideoJuegos.Location = new System.Drawing.Point(40, 326);
            this.lvVideoJuegos.MultiSelect = false;
            this.lvVideoJuegos.Name = "lvVideoJuegos";
            this.lvVideoJuegos.Size = new System.Drawing.Size(569, 149);
            this.lvVideoJuegos.TabIndex = 4;
            this.lvVideoJuegos.UseCompatibleStateImageBehavior = false;
            this.lvVideoJuegos.View = System.Windows.Forms.View.Details;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(40, 481);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(118, 42);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::VistaForm.Properties.Resources.Cancel_icon_icons_com_73703;
            this.btnCancelar.Location = new System.Drawing.Point(615, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 57);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Eliminar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::VistaForm.Properties.Resources.add_icon_icons_com_74429;
            this.btnAgregar.Location = new System.Drawing.Point(615, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 59);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAtras});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 39);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
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
            // VentasForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(712, 541);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lvVideoJuegos);
            this.Controls.Add(this.lvClienteSeleccionado);
            this.Controls.Add(this.dataGClientes);
            this.Controls.Add(this.txtFiltraPorCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-10, 63);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VentasForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGClientes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltraPorCodigo;
        private System.Windows.Forms.DataGridView dataGClientes;
        private System.Windows.Forms.ListView lvClienteSeleccionado;
        private System.Windows.Forms.ListView lvVideoJuegos;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnAtras;
    }
}