namespace Practica_1
{
    partial class Inicio
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.archToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcPestañas = new System.Windows.Forms.TabControl();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            this.gbDescripción = new System.Windows.Forms.GroupBox();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.msPrincipal.SuspendLayout();
            this.gbDescripción.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.Color.White;
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(975, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // archToolStripMenuItem
            // 
            this.archToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPestañaToolStripMenuItem,
            this.cargarArchivoToolStripMenuItem,
            this.guardarArchivoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archToolStripMenuItem.Name = "archToolStripMenuItem";
            this.archToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archToolStripMenuItem.Text = "Archivo";
            this.archToolStripMenuItem.Click += new System.EventHandler(this.archToolStripMenuItem_Click);
            // 
            // nuevaPestañaToolStripMenuItem
            // 
            this.nuevaPestañaToolStripMenuItem.Name = "nuevaPestañaToolStripMenuItem";
            this.nuevaPestañaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nuevaPestañaToolStripMenuItem.Text = "Nueva Pestaña";
            this.nuevaPestañaToolStripMenuItem.Click += new System.EventHandler(this.nuevaPestañaToolStripMenuItem_Click);
            // 
            // cargarArchivoToolStripMenuItem
            // 
            this.cargarArchivoToolStripMenuItem.Name = "cargarArchivoToolStripMenuItem";
            this.cargarArchivoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cargarArchivoToolStripMenuItem.Text = "Cargar Archivo";
            this.cargarArchivoToolStripMenuItem.Click += new System.EventHandler(this.cargarArchivoToolStripMenuItem_Click);
            // 
            // guardarArchivoToolStripMenuItem
            // 
            this.guardarArchivoToolStripMenuItem.Name = "guardarArchivoToolStripMenuItem";
            this.guardarArchivoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.guardarArchivoToolStripMenuItem.Text = "Guardar Archivo";
            this.guardarArchivoToolStripMenuItem.Click += new System.EventHandler(this.guardarArchivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualAplicaciónToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualAplicaciónToolStripMenuItem
            // 
            this.manualAplicaciónToolStripMenuItem.Name = "manualAplicaciónToolStripMenuItem";
            this.manualAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualAplicaciónToolStripMenuItem.Text = "Manual Aplicación";
            this.manualAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.manualAplicaciónToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tcPestañas
            // 
            this.tcPestañas.Location = new System.Drawing.Point(12, 37);
            this.tcPestañas.Name = "tcPestañas";
            this.tcPestañas.SelectedIndex = 0;
            this.tcPestañas.Size = new System.Drawing.Size(301, 542);
            this.tcPestañas.TabIndex = 1;
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(751, 37);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.PathSeparator = "/";
            this.tvArbol.Size = new System.Drawing.Size(215, 262);
            this.tvArbol.TabIndex = 4;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.Location = new System.Drawing.Point(344, 37);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(124, 39);
            this.btnAnalizar.TabIndex = 5;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // mcCalendario
            // 
            this.mcCalendario.Location = new System.Drawing.Point(344, 114);
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 6;
            this.mcCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendario_DateChanged);
            // 
            // gbDescripción
            // 
            this.gbDescripción.Controls.Add(this.rtbDescripcion);
            this.gbDescripción.Controls.Add(this.pbImagen);
            this.gbDescripción.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDescripción.ForeColor = System.Drawing.Color.White;
            this.gbDescripción.Location = new System.Drawing.Point(344, 317);
            this.gbDescripción.Name = "gbDescripción";
            this.gbDescripción.Size = new System.Drawing.Size(619, 262);
            this.gbDescripción.TabIndex = 7;
            this.gbDescripción.TabStop = false;
            this.gbDescripción.Text = "Actividad";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Enabled = false;
            this.rtbDescripcion.Location = new System.Drawing.Point(149, 25);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(464, 231);
            this.rtbDescripcion.TabIndex = 1;
            this.rtbDescripcion.Text = "";
            // 
            // pbImagen
            // 
            this.pbImagen.ErrorImage = null;
            this.pbImagen.Location = new System.Drawing.Point(7, 25);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(135, 101);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(975, 591);
            this.Controls.Add(this.gbDescripción);
            this.Controls.Add(this.mcCalendario);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.tcPestañas);
            this.Controls.Add(this.msPrincipal);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planificador";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.gbDescripción.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPestañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TabControl tcPestañas;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.MonthCalendar mcCalendario;
        private System.Windows.Forms.GroupBox gbDescripción;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
    }
}

