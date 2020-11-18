namespace VistaForm
{
    partial class HistorialVentasForm
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
            this.dataGHistorialVentas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnGuardarArchivo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAtras = new System.Windows.Forms.ToolStripButton();
            this.lblGananciasVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGHistorialVentas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGHistorialVentas
            // 
            this.dataGHistorialVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGHistorialVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGHistorialVentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGHistorialVentas.EnableHeadersVisualStyles = false;
            this.dataGHistorialVentas.Location = new System.Drawing.Point(0, 42);
            this.dataGHistorialVentas.MultiSelect = false;
            this.dataGHistorialVentas.Name = "dataGHistorialVentas";
            this.dataGHistorialVentas.RowHeadersVisible = false;
            this.dataGHistorialVentas.Size = new System.Drawing.Size(685, 475);
            this.dataGHistorialVentas.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGuardarArchivo,
            this.tsBtnAtras});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnGuardarArchivo
            // 
            this.tsBtnGuardarArchivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnGuardarArchivo.Image = global::VistaForm.Properties.Resources.FileSaveAs_11185;
            this.tsBtnGuardarArchivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnGuardarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnGuardarArchivo.Name = "tsBtnGuardarArchivo";
            this.tsBtnGuardarArchivo.Size = new System.Drawing.Size(134, 36);
            this.tsBtnGuardarArchivo.Text = "Guardar Archivo";
            this.tsBtnGuardarArchivo.Click += new System.EventHandler(this.tsBtnGuardarArchivo_Click);
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
            // lblGananciasVentas
            // 
            this.lblGananciasVentas.AutoSize = true;
            this.lblGananciasVentas.Location = new System.Drawing.Point(581, 9);
            this.lblGananciasVentas.Name = "lblGananciasVentas";
            this.lblGananciasVentas.Size = new System.Drawing.Size(0, 13);
            this.lblGananciasVentas.TabIndex = 4;
            // 
            // HistorialVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 517);
            this.Controls.Add(this.lblGananciasVentas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGHistorialVentas);
            this.Name = "HistorialVentasForm";
            this.Text = "HistorialVentasForm";
            this.Load += new System.EventHandler(this.HistorialVentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGHistorialVentas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGHistorialVentas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnGuardarArchivo;
        private System.Windows.Forms.ToolStripButton tsBtnAtras;
        private System.Windows.Forms.Label lblGananciasVentas;
    }
}