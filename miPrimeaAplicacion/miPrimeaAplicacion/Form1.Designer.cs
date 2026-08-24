namespace miPrimeaAplicacion {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.ltsValores = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(225, 59);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(100, 69);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(21, 18);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(34, 13);
            this.lblSerie.TabIndex = 1;
            this.lblSerie.Text = "Serie:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(60, 15);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(265, 20);
            this.txtSerie.TabIndex = 2;
            // 
            // ltsValores
            // 
            this.ltsValores.FormattingEnabled = true;
            this.ltsValores.Location = new System.Drawing.Point(24, 59);
            this.ltsValores.Name = "ltsValores";
            this.ltsValores.Size = new System.Drawing.Size(181, 160);
            this.ltsValores.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(225, 134);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 69);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 250);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.ltsValores);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Conversor de Longitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.ListBox ltsValores;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

