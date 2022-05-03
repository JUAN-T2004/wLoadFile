namespace wLoadFile
{
    partial class frmCargarArchivo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCargarArchivo = new System.Windows.Forms.GroupBox();
            this.txtLineaLinea = new System.Windows.Forms.TextBox();
            this.dtgCSV = new System.Windows.Forms.DataGridView();
            this.btnLineaLinea = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.grpCargarArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCargarArchivo
            // 
            this.grpCargarArchivo.Controls.Add(this.btnCSV);
            this.grpCargarArchivo.Controls.Add(this.btnLineaLinea);
            this.grpCargarArchivo.Controls.Add(this.dtgCSV);
            this.grpCargarArchivo.Controls.Add(this.txtLineaLinea);
            this.grpCargarArchivo.Location = new System.Drawing.Point(31, 35);
            this.grpCargarArchivo.Name = "grpCargarArchivo";
            this.grpCargarArchivo.Size = new System.Drawing.Size(733, 379);
            this.grpCargarArchivo.TabIndex = 0;
            this.grpCargarArchivo.TabStop = false;
            this.grpCargarArchivo.Text = "Cargar Archivo";
            // 
            // txtLineaLinea
            // 
            this.txtLineaLinea.Location = new System.Drawing.Point(27, 51);
            this.txtLineaLinea.Multiline = true;
            this.txtLineaLinea.Name = "txtLineaLinea";
            this.txtLineaLinea.Size = new System.Drawing.Size(263, 234);
            this.txtLineaLinea.TabIndex = 0;
            // 
            // dtgCSV
            // 
            this.dtgCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCSV.Location = new System.Drawing.Point(334, 51);
            this.dtgCSV.Name = "dtgCSV";
            this.dtgCSV.Size = new System.Drawing.Size(294, 234);
            this.dtgCSV.TabIndex = 1;
            // 
            // btnLineaLinea
            // 
            this.btnLineaLinea.Location = new System.Drawing.Point(95, 316);
            this.btnLineaLinea.Name = "btnLineaLinea";
            this.btnLineaLinea.Size = new System.Drawing.Size(117, 34);
            this.btnLineaLinea.TabIndex = 2;
            this.btnLineaLinea.Text = "Linea a Linea";
            this.btnLineaLinea.UseVisualStyleBackColor = true;
            this.btnLineaLinea.Click += new System.EventHandler(this.btnLineaLinea_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(454, 316);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(99, 34);
            this.btnCSV.TabIndex = 3;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // frmCargarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpCargarArchivo);
            this.Name = "frmCargarArchivo";
            this.Text = "Cargar Archivo";
            this.grpCargarArchivo.ResumeLayout(false);
            this.grpCargarArchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCargarArchivo;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnLineaLinea;
        private System.Windows.Forms.DataGridView dtgCSV;
        private System.Windows.Forms.TextBox txtLineaLinea;
    }
}

