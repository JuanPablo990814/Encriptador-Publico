namespace D_Encriptador_Proto
{
    partial class Archivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archivos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbArchivo = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.pcResult = new System.Windows.Forms.PictureBox();
            this.pcArchivo = new System.Windows.Forms.PictureBox();
            this.encriptarTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSubir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.btnLimComentario = new System.Windows.Forms.Button();
            this.btnLimllave = new System.Windows.Forms.Button();
            this.btnLimContenido = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbArchivo.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcArchivo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.encriptarTextoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.archivosToolStripMenuItem.Text = "Encriptar Texto";
            this.archivosToolStripMenuItem.Click += new System.EventHandler(this.archivosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "D-Encriptador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "16 Bits - 16 Caracteres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 91);
            this.label7.TabIndex = 20;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(128, 82);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(125, 20);
            this.txtKey.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Llave";
            // 
            // cmbAccion
            // 
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Items.AddRange(new object[] {
            "Encriptar",
            "Desencriptar"});
            this.cmbAccion.Location = new System.Drawing.Point(528, 82);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(121, 21);
            this.cmbAccion.TabIndex = 17;
            this.cmbAccion.SelectedIndexChanged += new System.EventHandler(this.cmbAccion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Accion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Contenido";
            // 
            // gbArchivo
            // 
            this.gbArchivo.BackColor = System.Drawing.Color.White;
            this.gbArchivo.Controls.Add(this.lblNombre);
            this.gbArchivo.Controls.Add(this.pcArchivo);
            this.gbArchivo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArchivo.Location = new System.Drawing.Point(128, 229);
            this.gbArchivo.Name = "gbArchivo";
            this.gbArchivo.Size = new System.Drawing.Size(111, 142);
            this.gbArchivo.TabIndex = 24;
            this.gbArchivo.TabStop = false;
            this.gbArchivo.Text = "Subir";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 15);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "nombre del archivo";
            // 
            // btnAccion
            // 
            this.btnAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAccion.Location = new System.Drawing.Point(128, 418);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(521, 42);
            this.btnAccion.TabIndex = 25;
            this.btnAccion.Text = "Encriptar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(256, 281);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(266, 23);
            this.progressBar.TabIndex = 26;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(6, 124);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(97, 15);
            this.lblResult.TabIndex = 24;
            this.lblResult.Text = "nombre del archivo";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // gbResult
            // 
            this.gbResult.BackColor = System.Drawing.Color.White;
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Controls.Add(this.pcResult);
            this.gbResult.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(538, 229);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(111, 142);
            this.gbResult.TabIndex = 27;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Archivo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(538, 377);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 23);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(12, 551);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(28, 15);
            this.lblRuta.TabIndex = 29;
            this.lblRuta.Text = "Ruta";
            this.lblRuta.Click += new System.EventHandler(this.lblRuta_Click);
            // 
            // pcResult
            // 
            this.pcResult.Image = ((System.Drawing.Image)(resources.GetObject("pcResult.Image")));
            this.pcResult.Location = new System.Drawing.Point(17, 32);
            this.pcResult.Name = "pcResult";
            this.pcResult.Size = new System.Drawing.Size(76, 73);
            this.pcResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcResult.TabIndex = 23;
            this.pcResult.TabStop = false;
            this.pcResult.Click += new System.EventHandler(this.pcResult_Click);
            // 
            // pcArchivo
            // 
            this.pcArchivo.Image = ((System.Drawing.Image)(resources.GetObject("pcArchivo.Image")));
            this.pcArchivo.Location = new System.Drawing.Point(17, 32);
            this.pcArchivo.Name = "pcArchivo";
            this.pcArchivo.Size = new System.Drawing.Size(76, 73);
            this.pcArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcArchivo.TabIndex = 23;
            this.pcArchivo.TabStop = false;
            this.pcArchivo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // encriptarTextoToolStripMenuItem
            // 
            this.encriptarTextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiSubir});
            this.encriptarTextoToolStripMenuItem.Name = "encriptarTextoToolStripMenuItem";
            this.encriptarTextoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.encriptarTextoToolStripMenuItem.Text = "Archivo";
            this.encriptarTextoToolStripMenuItem.Click += new System.EventHandler(this.encriptarTextoToolStripMenuItem_Click);
            // 
            // smiSubir
            // 
            this.smiSubir.Name = "smiSubir";
            this.smiSubir.Size = new System.Drawing.Size(180, 22);
            this.smiSubir.Text = "Abrir Archivo";
            this.smiSubir.Click += new System.EventHandler(this.smiSubir_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(128, 377);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(111, 23);
            this.btnSubir.TabIndex = 30;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarTodo);
            this.groupBox1.Controls.Add(this.btnLimComentario);
            this.groupBox1.Controls.Add(this.btnLimllave);
            this.groupBox1.Controls.Add(this.btnLimContenido);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(664, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 157);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limpieza";
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTodo.Location = new System.Drawing.Point(6, 116);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(112, 23);
            this.btnLimpiarTodo.TabIndex = 19;
            this.btnLimpiarTodo.Text = "Todo";
            this.btnLimpiarTodo.UseVisualStyleBackColor = true;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // btnLimComentario
            // 
            this.btnLimComentario.Enabled = false;
            this.btnLimComentario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimComentario.Location = new System.Drawing.Point(6, 87);
            this.btnLimComentario.Name = "btnLimComentario";
            this.btnLimComentario.Size = new System.Drawing.Size(112, 23);
            this.btnLimComentario.TabIndex = 18;
            this.btnLimComentario.Text = "Comentario";
            this.btnLimComentario.UseVisualStyleBackColor = true;
            // 
            // btnLimllave
            // 
            this.btnLimllave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimllave.Location = new System.Drawing.Point(6, 29);
            this.btnLimllave.Name = "btnLimllave";
            this.btnLimllave.Size = new System.Drawing.Size(112, 23);
            this.btnLimllave.TabIndex = 17;
            this.btnLimllave.Text = "Llave";
            this.btnLimllave.UseVisualStyleBackColor = true;
            this.btnLimllave.Click += new System.EventHandler(this.btnLimllave_Click);
            // 
            // btnLimContenido
            // 
            this.btnLimContenido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimContenido.Location = new System.Drawing.Point(6, 58);
            this.btnLimContenido.Name = "btnLimContenido";
            this.btnLimContenido.Size = new System.Drawing.Size(112, 23);
            this.btnLimContenido.TabIndex = 16;
            this.btnLimContenido.Text = "Contenido";
            this.btnLimContenido.UseVisualStyleBackColor = true;
            this.btnLimContenido.Click += new System.EventHandler(this.btnLimContenido_Click);
            // 
            // Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbArchivo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Archivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.Archivos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbArchivo.ResumeLayout(false);
            this.gbArchivo.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcArchivo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcArchivo;
        private System.Windows.Forms.GroupBox gbArchivo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pcResult;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ToolStripMenuItem encriptarTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiSubir;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.Button btnLimComentario;
        private System.Windows.Forms.Button btnLimllave;
        private System.Windows.Forms.Button btnLimContenido;
    }
}