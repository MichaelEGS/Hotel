namespace Hotel
{
    partial class Actualizar__Reserva
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
            this.ActualizarcbHabitacion = new System.Windows.Forms.ComboBox();
            this.ActualizarTimeCheckout = new System.Windows.Forms.DateTimePicker();
            this.ActualizarTimeCheckin = new System.Windows.Forms.DateTimePicker();
            this.ActualizarbtnGuardar = new System.Windows.Forms.Button();
            this.TxtActualizarNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActualizarcbHabitacion
            // 
            this.ActualizarcbHabitacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualizarcbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActualizarcbHabitacion.FormattingEnabled = true;
            this.ActualizarcbHabitacion.Location = new System.Drawing.Point(672, 113);
            this.ActualizarcbHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActualizarcbHabitacion.Name = "ActualizarcbHabitacion";
            this.ActualizarcbHabitacion.Size = new System.Drawing.Size(163, 24);
            this.ActualizarcbHabitacion.TabIndex = 26;
            // 
            // ActualizarTimeCheckout
            // 
            this.ActualizarTimeCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualizarTimeCheckout.Location = new System.Drawing.Point(672, 52);
            this.ActualizarTimeCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActualizarTimeCheckout.MinDate = new System.DateTime(2024, 7, 11, 0, 0, 0, 0);
            this.ActualizarTimeCheckout.Name = "ActualizarTimeCheckout";
            this.ActualizarTimeCheckout.Size = new System.Drawing.Size(275, 22);
            this.ActualizarTimeCheckout.TabIndex = 25;
            // 
            // ActualizarTimeCheckin
            // 
            this.ActualizarTimeCheckin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualizarTimeCheckin.Location = new System.Drawing.Point(231, 110);
            this.ActualizarTimeCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActualizarTimeCheckin.MinDate = new System.DateTime(2024, 7, 11, 0, 0, 0, 0);
            this.ActualizarTimeCheckin.Name = "ActualizarTimeCheckin";
            this.ActualizarTimeCheckin.Size = new System.Drawing.Size(295, 22);
            this.ActualizarTimeCheckin.TabIndex = 24;
            // 
            // ActualizarbtnGuardar
            // 
            this.ActualizarbtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualizarbtnGuardar.Location = new System.Drawing.Point(517, 162);
            this.ActualizarbtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActualizarbtnGuardar.Name = "ActualizarbtnGuardar";
            this.ActualizarbtnGuardar.Size = new System.Drawing.Size(116, 36);
            this.ActualizarbtnGuardar.TabIndex = 23;
            this.ActualizarbtnGuardar.Text = "Guardar";
            this.ActualizarbtnGuardar.UseVisualStyleBackColor = true;
            this.ActualizarbtnGuardar.Click += new System.EventHandler(this.ActualizarbtnGuardar_Click);
            // 
            // TxtActualizarNombre
            // 
            this.TxtActualizarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtActualizarNombre.Location = new System.Drawing.Point(231, 43);
            this.TxtActualizarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtActualizarNombre.Name = "TxtActualizarNombre";
            this.TxtActualizarNombre.Size = new System.Drawing.Size(295, 22);
            this.TxtActualizarNombre.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(572, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "# Habitacion:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(588, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Check-out:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(113, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Check-in:\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(81, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre del huesped:\r\n";
            // 
            // dgvReservas
            // 
            this.dgvReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(116, 220);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.Size = new System.Drawing.Size(798, 185);
            this.dgvReservas.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvReservas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 418);
            this.panel1.TabIndex = 28;
            // 
            // Actualizar__Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(944, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActualizarcbHabitacion);
            this.Controls.Add(this.ActualizarTimeCheckout);
            this.Controls.Add(this.ActualizarTimeCheckin);
            this.Controls.Add(this.ActualizarbtnGuardar);
            this.Controls.Add(this.TxtActualizarNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Actualizar__Reserva";
            this.Text = "Actualizar__Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ActualizarcbHabitacion;
        private System.Windows.Forms.DateTimePicker ActualizarTimeCheckout;
        private System.Windows.Forms.DateTimePicker ActualizarTimeCheckin;
        private System.Windows.Forms.Button ActualizarbtnGuardar;
        private System.Windows.Forms.TextBox TxtActualizarNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Panel panel1;
    }
}