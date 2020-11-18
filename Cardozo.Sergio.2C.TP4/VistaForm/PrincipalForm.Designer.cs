namespace VistaForm
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnCliente = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_VideoJuegos = new System.Windows.Forms.ToolStripButton();
            this.tsBtnVentas = new System.Windows.Forms.ToolStripButton();
            this.tsBtnHistorialVentas = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblFechayHora = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnCliente,
            this.tsBtn_VideoJuegos,
            this.tsBtnVentas,
            this.tsBtnHistorialVentas,
            this.tsBtnLogOut,
            this.tsBtnSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(886, 39);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsBtnCliente
            // 
            this.tsBtnCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnCliente.Image = global::VistaForm.Properties.Resources.customer_person_people_man_you_1625__1_;
            this.tsBtnCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCliente.Name = "tsBtnCliente";
            this.tsBtnCliente.Size = new System.Drawing.Size(87, 36);
            this.tsBtnCliente.Text = "Clientes";
            this.tsBtnCliente.Click += new System.EventHandler(this.tsBtnCliente_Click);
            // 
            // tsBtn_VideoJuegos
            // 
            this.tsBtn_VideoJuegos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtn_VideoJuegos.Image = global::VistaForm.Properties.Resources.games_gamepad_juego_12680;
            this.tsBtn_VideoJuegos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtn_VideoJuegos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_VideoJuegos.Name = "tsBtn_VideoJuegos";
            this.tsBtn_VideoJuegos.Size = new System.Drawing.Size(109, 36);
            this.tsBtn_VideoJuegos.Text = "Lista Juegos";
            this.tsBtn_VideoJuegos.Click += new System.EventHandler(this.tsBtn_VideoJuegos_Click);
            // 
            // tsBtnVentas
            // 
            this.tsBtnVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnVentas.Image = global::VistaForm.Properties.Resources._1486146618_propertyagent003_79454;
            this.tsBtnVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnVentas.Name = "tsBtnVentas";
            this.tsBtnVentas.Size = new System.Drawing.Size(79, 36);
            this.tsBtnVentas.Text = "Ventas";
            this.tsBtnVentas.Click += new System.EventHandler(this.tsBtnVentas_Click);
            // 
            // tsBtnHistorialVentas
            // 
            this.tsBtnHistorialVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnHistorialVentas.Image = global::VistaForm.Properties.Resources.calendar_office_day_1474;
            this.tsBtnHistorialVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnHistorialVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHistorialVentas.Name = "tsBtnHistorialVentas";
            this.tsBtnHistorialVentas.Size = new System.Drawing.Size(129, 36);
            this.tsBtnHistorialVentas.Text = "Historial Ventas";
            this.tsBtnHistorialVentas.Click += new System.EventHandler(this.tsBtnHistorialVentas_Click);
            // 
            // tsBtnLogOut
            // 
            this.tsBtnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnLogOut.Image = global::VistaForm.Properties.Resources.off_logout_17916;
            this.tsBtnLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLogOut.Name = "tsBtnLogOut";
            this.tsBtnLogOut.Size = new System.Drawing.Size(87, 36);
            this.tsBtnLogOut.Text = "Log Out";
            this.tsBtnLogOut.Click += new System.EventHandler(this.tsBtnLogOut_Click);
            // 
            // tsBtnSalir
            // 
            this.tsBtnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBtnSalir.Image = global::VistaForm.Properties.Resources.SignOut_icon_icons_com_74704;
            this.tsBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSalir.Name = "tsBtnSalir";
            this.tsBtnSalir.Size = new System.Drawing.Size(67, 36);
            this.tsBtnSalir.Text = "Salir";
            this.tsBtnSalir.Click += new System.EventHandler(this.tsBtnSalir_Click);
            // 
            // lblFechayHora
            // 
            this.lblFechayHora.AutoSize = true;
            this.lblFechayHora.Location = new System.Drawing.Point(874, 9);
            this.lblFechayHora.Name = "lblFechayHora";
            this.lblFechayHora.Size = new System.Drawing.Size(0, 13);
            this.lblFechayHora.TabIndex = 2;
            this.lblFechayHora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VistaForm.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 454);
            this.Controls.Add(this.lblFechayHora);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PrincipalForm";
            this.Text = "PrincipalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsBtn_VideoJuegos;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton tsBtnVentas;
        private System.Windows.Forms.ToolStripButton tsBtnHistorialVentas;
        private System.Windows.Forms.ToolStripButton tsBtnCliente;
        private System.Windows.Forms.ToolStripButton tsBtnLogOut;
        private System.Windows.Forms.ToolStripButton tsBtnSalir;
        private System.Windows.Forms.Label lblFechayHora;
    }
}