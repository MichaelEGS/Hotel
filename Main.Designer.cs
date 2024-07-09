namespace Hotel
{
    partial class Main
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.AcercadeBtn = new FontAwesome.Sharp.IconButton();
            this.EliminarBtn = new FontAwesome.Sharp.IconButton();
            this.AboutBtn = new FontAwesome.Sharp.IconButton();
            this.BuscarReservaBtn = new FontAwesome.Sharp.IconButton();
            this.ReservacionBtn = new FontAwesome.Sharp.IconButton();
            this.panelLOGO = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTituloFormularioHijo = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLOGO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.AcercadeBtn);
            this.panelMenu.Controls.Add(this.EliminarBtn);
            this.panelMenu.Controls.Add(this.AboutBtn);
            this.panelMenu.Controls.Add(this.BuscarReservaBtn);
            this.panelMenu.Controls.Add(this.ReservacionBtn);
            this.panelMenu.Controls.Add(this.panelLOGO);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 554);
            this.panelMenu.TabIndex = 0;
            // 
            // AcercadeBtn
            // 
            this.AcercadeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AcercadeBtn.FlatAppearance.BorderSize = 0;
            this.AcercadeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcercadeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.AcercadeBtn.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.AcercadeBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.AcercadeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AcercadeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AcercadeBtn.Location = new System.Drawing.Point(0, 380);
            this.AcercadeBtn.Name = "AcercadeBtn";
            this.AcercadeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AcercadeBtn.Size = new System.Drawing.Size(220, 60);
            this.AcercadeBtn.TabIndex = 5;
            this.AcercadeBtn.Text = "About";
            this.AcercadeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AcercadeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AcercadeBtn.UseVisualStyleBackColor = true;
            this.AcercadeBtn.Click += new System.EventHandler(this.AcercadeBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EliminarBtn.FlatAppearance.BorderSize = 0;
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.EliminarBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.EliminarBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.EliminarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarBtn.Location = new System.Drawing.Point(0, 320);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EliminarBtn.Size = new System.Drawing.Size(220, 60);
            this.EliminarBtn.TabIndex = 4;
            this.EliminarBtn.Text = "Eliminar reserva";
            this.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.AboutBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.AboutBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.AboutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutBtn.Location = new System.Drawing.Point(0, 260);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AboutBtn.Size = new System.Drawing.Size(220, 60);
            this.AboutBtn.TabIndex = 3;
            this.AboutBtn.Text = "Actualizar reserva";
            this.AboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.ActualizarReservaBtn_Click);
            // 
            // BuscarReservaBtn
            // 
            this.BuscarReservaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuscarReservaBtn.FlatAppearance.BorderSize = 0;
            this.BuscarReservaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarReservaBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.BuscarReservaBtn.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.BuscarReservaBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.BuscarReservaBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuscarReservaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarReservaBtn.Location = new System.Drawing.Point(0, 200);
            this.BuscarReservaBtn.Name = "BuscarReservaBtn";
            this.BuscarReservaBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BuscarReservaBtn.Size = new System.Drawing.Size(220, 60);
            this.BuscarReservaBtn.TabIndex = 2;
            this.BuscarReservaBtn.Text = "Buscar reserva";
            this.BuscarReservaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarReservaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarReservaBtn.UseVisualStyleBackColor = true;
            this.BuscarReservaBtn.Click += new System.EventHandler(this.BuscarReservaBtn_Click);
            // 
            // ReservacionBtn
            // 
            this.ReservacionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReservacionBtn.FlatAppearance.BorderSize = 0;
            this.ReservacionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservacionBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ReservacionBtn.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.ReservacionBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.ReservacionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReservacionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservacionBtn.Location = new System.Drawing.Point(0, 140);
            this.ReservacionBtn.Name = "ReservacionBtn";
            this.ReservacionBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ReservacionBtn.Size = new System.Drawing.Size(220, 60);
            this.ReservacionBtn.TabIndex = 1;
            this.ReservacionBtn.Text = "Agregar reservacion";
            this.ReservacionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservacionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReservacionBtn.UseVisualStyleBackColor = true;
            this.ReservacionBtn.Click += new System.EventHandler(this.ReservacionBtn_Click);
            // 
            // panelLOGO
            // 
            this.panelLOGO.Controls.Add(this.BtnHome);
            this.panelLOGO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLOGO.Location = new System.Drawing.Point(0, 0);
            this.panelLOGO.Name = "panelLOGO";
            this.panelLOGO.Size = new System.Drawing.Size(220, 140);
            this.panelLOGO.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Image = global::Hotel.Properties.Resources.Ahora_es;
            this.BtnHome.Location = new System.Drawing.Point(34, 36);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(154, 85);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelBarraTitulo.Controls.Add(this.lblTituloFormularioHijo);
            this.panelBarraTitulo.Controls.Add(this.iconCurrentChildForm);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(962, 80);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // lblTituloFormularioHijo
            // 
            this.lblTituloFormularioHijo.AutoSize = true;
            this.lblTituloFormularioHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloFormularioHijo.Location = new System.Drawing.Point(59, 36);
            this.lblTituloFormularioHijo.Name = "lblTituloFormularioHijo";
            this.lblTituloFormularioHijo.Size = new System.Drawing.Size(44, 16);
            this.lblTituloFormularioHijo.TabIndex = 1;
            this.lblTituloFormularioHijo.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 9);
            this.panel1.TabIndex = 2;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 89);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(962, 465);
            this.panelEscritorio.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 554);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLOGO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ReservacionBtn;
        private System.Windows.Forms.Panel panelLOGO;
        private FontAwesome.Sharp.IconButton AboutBtn;
        private FontAwesome.Sharp.IconButton BuscarReservaBtn;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTituloFormularioHijo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEscritorio;
        private FontAwesome.Sharp.IconButton AcercadeBtn;
        private FontAwesome.Sharp.IconButton EliminarBtn;
    }
}

