namespace D_Encriptador_Proto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimContenido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.btnLimComentario = new System.Windows.Forms.Button();
            this.btnLimllave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.encriptarArchivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarContenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarLlaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarContenidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirLlaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(135, 174);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(518, 215);
            this.txtContenido.TabIndex = 0;
            this.txtContenido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "D-Encriptador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contenido";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(135, 395);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(518, 31);
            this.btnAccion.TabIndex = 3;
            this.btnAccion.Text = "Encriptar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Accion";
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
            this.cmbAccion.TabIndex = 7;
            this.cmbAccion.SelectedIndexChanged += new System.EventHandler(this.cmbAccion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Comentario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(132, 496);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(521, 23);
            this.txtComentario.TabIndex = 8;
            this.txtComentario.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(132, 525);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(521, 31);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Encriptar Contenido y Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Base de Datos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Llave";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(128, 82);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(125, 20);
            this.txtKey.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 91);
            this.label7.TabIndex = 14;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.groupBox1.TabIndex = 18;
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
            this.btnLimComentario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimComentario.Location = new System.Drawing.Point(6, 87);
            this.btnLimComentario.Name = "btnLimComentario";
            this.btnLimComentario.Size = new System.Drawing.Size(112, 23);
            this.btnLimComentario.TabIndex = 18;
            this.btnLimComentario.Text = "Comentario";
            this.btnLimComentario.UseVisualStyleBackColor = true;
            this.btnLimComentario.Click += new System.EventHandler(this.btnLimComentario_Click);
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
            this.btnLimllave.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encriptarArchivosToolStripMenuItem,
            this.guardarContenidoToolStripMenuItem,
            this.cargarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // encriptarArchivosToolStripMenuItem
            // 
            this.encriptarArchivosToolStripMenuItem.Name = "encriptarArchivosToolStripMenuItem";
            this.encriptarArchivosToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.encriptarArchivosToolStripMenuItem.Text = "Encriptar Archivos";
            this.encriptarArchivosToolStripMenuItem.Click += new System.EventHandler(this.encriptarArchivosToolStripMenuItem_Click);
            // 
            // guardarContenidoToolStripMenuItem
            // 
            this.guardarContenidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarLlaveToolStripMenuItem,
            this.guardarContenidoToolStripMenuItem1});
            this.guardarContenidoToolStripMenuItem.Name = "guardarContenidoToolStripMenuItem";
            this.guardarContenidoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.guardarContenidoToolStripMenuItem.Text = "Guardado";
            // 
            // guardarLlaveToolStripMenuItem
            // 
            this.guardarLlaveToolStripMenuItem.Name = "guardarLlaveToolStripMenuItem";
            this.guardarLlaveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.guardarLlaveToolStripMenuItem.Text = "Guardar llave";
            this.guardarLlaveToolStripMenuItem.Click += new System.EventHandler(this.guardarLlaveToolStripMenuItem_Click);
            // 
            // guardarContenidoToolStripMenuItem1
            // 
            this.guardarContenidoToolStripMenuItem1.Name = "guardarContenidoToolStripMenuItem1";
            this.guardarContenidoToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.guardarContenidoToolStripMenuItem1.Text = "Guardar Contenido";
            this.guardarContenidoToolStripMenuItem1.Click += new System.EventHandler(this.guardarContenidoToolStripMenuItem1_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirLlaveToolStripMenuItem,
            this.abrirArchivoDeTextoToolStripMenuItem});
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cargarToolStripMenuItem.Text = "Cargar";
            // 
            // abrirLlaveToolStripMenuItem
            // 
            this.abrirLlaveToolStripMenuItem.Name = "abrirLlaveToolStripMenuItem";
            this.abrirLlaveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.abrirLlaveToolStripMenuItem.Text = "Abrir Llave";
            this.abrirLlaveToolStripMenuItem.Click += new System.EventHandler(this.abrirLlaveToolStripMenuItem_Click);
            // 
            // abrirArchivoDeTextoToolStripMenuItem
            // 
            this.abrirArchivoDeTextoToolStripMenuItem.Name = "abrirArchivoDeTextoToolStripMenuItem";
            this.abrirArchivoDeTextoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.abrirArchivoDeTextoToolStripMenuItem.Text = "Abrir archivo de texto";
            this.abrirArchivoDeTextoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoDeTextoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D-Encriptador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimContenido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.Button btnLimComentario;
        private System.Windows.Forms.Button btnLimllave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem encriptarArchivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarContenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarLlaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarContenidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirLlaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoDeTextoToolStripMenuItem;
    }
}

