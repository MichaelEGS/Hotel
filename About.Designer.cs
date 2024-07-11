namespace Hotel
{
    partial class About
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 418);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Saludos a todo/as,",
            "Mi nombre es Michael Zorrilla, estudiante de Ing. De Software, y he desarrollado " +
                "un sistema de gestión de ",
            "reservaciones de habitaciones para hoteles. ",
            "Este proyecto tiene como objetivo facilitar el manejo de reservas, permitiendo ag" +
                "regar, buscar, editar",
            "y eliminar reservas de manera eficiente.",
            "",
            "Tecnologías Utilizadas",
            "",
            "Lenguaje de Programación",
            "C#: Utilizado para desarrollar toda la lógica de negocio y la interfaz de usuario" +
                ".",
            "",
            "",
            "Frameworks",
            ".NET Framework: Utilizado para desarrollar la aplicación de escritorio.",
            "",
            "",
            "Entity Framework: Utilizado en modo Database First para interactuar con la base d" +
                "e datos de manera más eficiente.",
            "",
            "",
            "ADO.NET: Utilizado para ejecutar consultas SQL directamente y para manejar transa" +
                "cciones.",
            "",
            "",
            "Librerías",
            "System.Data.Entity: Proporciona soporte para Entity Framework.",
            "",
            "System.Data.SqlClient: Utilizada para la interacción directa con la base de datos" +
                " a través de ADO.NET.",
            "",
            "",
            "System.Windows.Forms: Utilizada para crear la interfaz gráfica de la aplicación.",
            "",
            "",
            "Arquitectura del Proyecto",
            "",
            "Patrón de Arquitectura",
            "MVC (Model-View-Controller): Implementado para organizar el código de ",
            "manera modular y mantener una separación clara entre ",
            "la lógica de negocio, la interfaz de usuario y la interacción con la base de dato" +
                "s."});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(944, 418);
            this.listBox1.TabIndex = 0;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 418);
            this.Controls.Add(this.panel1);
            this.Name = "About";
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}