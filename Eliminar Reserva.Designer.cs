namespace Hotel
{
    partial class Eliminar_Reserva
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
            this.dgvDelete = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDelete
            // 
            this.dgvDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDelete.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Location = new System.Drawing.Point(39, 174);
            this.dgvDelete.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.RowHeadersWidth = 51;
            this.dgvDelete.Size = new System.Drawing.Size(671, 230);
            this.dgvDelete.TabIndex = 8;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscar.Location = new System.Drawing.Point(609, 70);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 28);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtBuscarDelete
            // 
            this.txtBuscarDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarDelete.Location = new System.Drawing.Point(312, 92);
            this.txtBuscarDelete.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarDelete.Name = "txtBuscarDelete";
            this.txtBuscarDelete.Size = new System.Drawing.Size(241, 22);
            this.txtBuscarDelete.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(147, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del huesped:";
            // 
            // BtnEliminarR
            // 
            this.BtnEliminarR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminarR.Location = new System.Drawing.Point(609, 138);
            this.BtnEliminarR.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminarR.Name = "BtnEliminarR";
            this.BtnEliminarR.Size = new System.Drawing.Size(100, 28);
            this.BtnEliminarR.TabIndex = 9;
            this.BtnEliminarR.Text = "Eliminar";
            this.BtnEliminarR.UseVisualStyleBackColor = true;
            this.BtnEliminarR.Click += new System.EventHandler(this.BtnEliminarR_Click);
            // 
            // Eliminar_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(944, 418);
            this.Controls.Add(this.BtnEliminarR);
            this.Controls.Add(this.dgvDelete);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtBuscarDelete);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Eliminar_Reserva";
            this.Text = "Eliminar_Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDelete;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtBuscarDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarR;
    }
}