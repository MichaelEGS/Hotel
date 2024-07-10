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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // ActualizarcbHabitacion
            // 
            this.ActualizarcbHabitacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualizarcbHabitacion.FormattingEnabled = true;
            this.ActualizarcbHabitacion.Location = new System.Drawing.Point(504, 92);
            this.ActualizarcbHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.ActualizarcbHabitacion.Name = "ActualizarcbHabitacion";
            this.ActualizarcbHabitacion.Size = new System.Drawing.Size(123, 21);
            this.ActualizarcbHabitacion.TabIndex = 26;
            // 
            // ActualizarTimeCheckout
            // 
            this.ActualizarTimeCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualizarTimeCheckout.Location = new System.Drawing.Point(504, 42);
            this.ActualizarTimeCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.ActualizarTimeCheckout.Name = "ActualizarTimeCheckout";
            this.ActualizarTimeCheckout.Size = new System.Drawing.Size(207, 20);
            this.ActualizarTimeCheckout.TabIndex = 25;
            // 
            // ActualizarTimeCheckin
            // 
            this.ActualizarTimeCheckin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualizarTimeCheckin.Location = new System.Drawing.Point(173, 89);
            this.ActualizarTimeCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.ActualizarTimeCheckin.Name = "ActualizarTimeCheckin";
            this.ActualizarTimeCheckin.Size = new System.Drawing.Size(222, 20);
            this.ActualizarTimeCheckin.TabIndex = 24;
            // 
            // ActualizarbtnGuardar
            // 
            this.ActualizarbtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualizarbtnGuardar.Location = new System.Drawing.Point(388, 132);
            this.ActualizarbtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.ActualizarbtnGuardar.Name = "ActualizarbtnGuardar";
            this.ActualizarbtnGuardar.Size = new System.Drawing.Size(87, 29);
            this.ActualizarbtnGuardar.TabIndex = 23;
            this.ActualizarbtnGuardar.Text = "Guardar";
            this.ActualizarbtnGuardar.UseVisualStyleBackColor = true;
            this.ActualizarbtnGuardar.Click += new System.EventHandler(this.ActualizarbtnGuardar_Click);
            // 
            // TxtActualizarNombre
            // 
            this.TxtActualizarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtActualizarNombre.Location = new System.Drawing.Point(173, 35);
            this.TxtActualizarNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtActualizarNombre.Name = "TxtActualizarNombre";
            this.TxtActualizarNombre.Size = new System.Drawing.Size(222, 20);
            this.TxtActualizarNombre.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "# Habitacion:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Check-out:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Check-in:\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre del huesped:\r\n";
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(146, 178);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(531, 150);
            this.dgvReservas.TabIndex = 27;
            // 
            // Actualizar__Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 340);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.ActualizarcbHabitacion);
            this.Controls.Add(this.ActualizarTimeCheckout);
            this.Controls.Add(this.ActualizarTimeCheckin);
            this.Controls.Add(this.ActualizarbtnGuardar);
            this.Controls.Add(this.TxtActualizarNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Actualizar__Reserva";
            this.Text = "Actualizar__Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
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
    }
}