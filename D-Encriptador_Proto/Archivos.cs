using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algoritmos;
using Datos;

namespace D_Encriptador_Proto
{
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();
            //El combobox empieza mostrando la posicion 0 = Encriptar
            cmbAccion.SelectedIndex = 0;
        }
        string archivo = null;
        string extension =".?";
        string nombre = "sin_archivo";
        bool encrip;
        string nombreExtensionModificado = null;
        //variable no necesesario, talvez para despues agregar mas funcionalidades
        //byte[] archivoEncriptado;
        //byte[] archivoDecriptado;
        //
        byte[] archivoBytes;
        clsAlgoritmos encriptar = new clsAlgoritmos();


        private void Archivos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            subirArchivo();
        }

        private void subirArchivo()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //tomando la ubicacion del archivo
                    archivo = dialog.FileName;
                    //tomando la extension del archivo
                    extension = Path.GetExtension(archivo);
                    //tomando el nombre del archivo sin la extensión
                    nombre = Path.GetFileNameWithoutExtension(archivo);
                    gbArchivo.Text = "Subido";

                    //HAY QUE AÑADIR TODAS LAS DIRECCIONES POSIBLES
                    tipoArchivo();
                }
            }
        }

        private void tipoArchivo()
        {
            if (extension == ".txt")
            {
                if (cmbAccion.SelectedText == "Desencriptar")
                {
                    pcArchivo.Image = Properties.Resources.bloqueado;
                }
                else
                {
                    //imagen del archivo subido
                    pcArchivo.Image = Properties.Resources.txtimagenes;
                }

                try
                {
                    //en caso de que el archivo tenga un nombre muy largo, el Substring lo recorta y le añado la extensión
                    lblNombre.Text = nombre.Substring(0, 14) + "..." + extension;
                }
                catch
                {
                    lblNombre.Text = nombre + extension;
                }
            }
            else
            {
                if (extension == ".pdf")
                {

                    if (cmbAccion.SelectedText == "Desencriptar")
                    {
                        pcArchivo.Image = Properties.Resources.bloqueado;
                    }
                    else
                    {
                        //imagen del archivo subido
                        pcArchivo.Image = Properties.Resources.pdfimagen;
                    }

                    try
                    {
                        //en caso de que el archivo tenga un nombre muy largo, el Substring lo recorta y le añado la extensión
                        lblNombre.Text = nombre.Substring(0, 14) + "..." + extension;
                    }
                    catch
                    {
                        lblNombre.Text = nombre + extension;
                    }
                }
                else
                {
                    if (extension == ".docx")
                    {
                        if (cmbAccion.SelectedText == "Desencriptar")
                        {
                            pcArchivo.Image = Properties.Resources.bloqueado;
                        }
                        else
                        {
                            //imagen del archivo subido
                            pcArchivo.Image = Properties.Resources.document;
                        }

                        try
                        {
                            //en caso de que el archivo tenga un nombre muy largo, el Substring lo recorta y le añado la extensión
                            lblNombre.Text = nombre.Substring(0, 14) + "..." + extension;
                        }
                        catch
                        {
                            lblNombre.Text = nombre + extension;
                        }
                    }
                    else
                    {
                        if (extension == ".xlsm")
                        {
                            if (cmbAccion.SelectedText == "Desencriptar")
                            {
                                pcArchivo.Image = Properties.Resources.bloqueado;
                            }
                            else
                            {
                                //imagen del archivo subido
                                pcArchivo.Image = Properties.Resources.excelimagen;
                            }

                            try
                            {
                                //en caso de que el archivo tenga un nombre muy largo, el Substring lo recorta y le añado la extensión
                                lblNombre.Text = nombre.Substring(0, 14) + "..." + extension;
                            }
                            catch
                            {
                                lblNombre.Text = nombre + extension;
                            }
                        }
                        else
                        {
                            if (extension == ".mp4" || extension == ".avi" || extension == ".mov" || extension == ".mkv"
                                || extension == ".flv" || extension == ".mpeg" || extension == "wmv"
                                || extension == ".rm" || extension == ".ram" || extension == ".asf" ||
                                extension == ".qt")
                            {
                                if (cmbAccion.SelectedText == "Desencriptar")
                                {
                                    pcArchivo.Image = Properties.Resources.bloqueado;
                                }
                                else
                                {
                                    //imagen del archivo subido
                                    pcArchivo.Image = Properties.Resources.videoimagen;
                                }
                                try
                                {
                                    //en caso de que el archivo tenga un nombre muy largo, el Substring lo recorta y le añado la extensión
                                    lblNombre.Text = nombre.Substring(0, 14) + "..." + extension;
                                }
                                catch
                                {
                                    lblNombre.Text = nombre + extension;
                                }
                            }
                            else
                            {
                                if (extension == ".img" || extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                                {
                                    if (cmbAccion.SelectedText == "Desencriptar")
                                    {
                                        pcArchivo.Image = Properties.Resources.bloqueado;
                                    }
                                    else
                                    {
                                        //imagen del archivo subido
                                        pcArchivo.Image = Properties.Resources.imagendeimagenes;
                                    }
                                    try
                                    {
                                        //en caso de que el archivo tenga un nombre muy largo, el Substring lo recorta y le añado la extensión
                                        lblNombre.Text = nombre.Substring(0, 14) + "..." + extension;
                                    }
                                    catch
                                    {
                                        lblNombre.Text = nombre + extension;
                                    }
                                }
                                else
                                {
                                    if (extension == ".gif")
                                    {
                                        if (cmbAccion.SelectedText == "Desencriptar")
                                        {
                                            pcArchivo.Image = Properties.Resources.bloqueado;
                                        }
                                        else
                                        {
                                            //imagen del archivo subido
                                            pcArchivo.Image = Properties.Resources.gifimagen;
                                        }
                                        try
                                        {
                                            //en caso de que el archivo tenga un nombre muy largo, el Substring lo recorta y le añado la extensión
                                            lblNombre.Text = nombre.Substring(0, 14) + "..." + extension;
                                        }
                                        catch
                                        {
                                            lblNombre.Text = nombre + extension;
                                        }
                                    }
                                    else
                                    {
                                        if (cmbAccion.SelectedText == "Desencriptar")
                                        {
                                            pcArchivo.Image = Properties.Resources.bloqueado;
                                        }
                                        else
                                        {
                                            //imagen del archivo subido
                                            pcArchivo.Image = Properties.Resources.noidea;
                                        }

                                        try
                                        {
                                            //en caso de que el archivo tenga un nombre muy largo, el Substring lo recorta y le añado la extensión
                                            lblNombre.Text = nombre.Substring(0, 14) + "..." + extension;
                                        }
                                        catch
                                        {
                                            lblNombre.Text = nombre + extension;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
           
        }

        private void cmbAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            #pragma warning disable CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            if (cmbAccion.SelectedItem == "Encriptar")
            #pragma warning restore CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            {
                btnAccion.Text = "Encriptar";
                encrip = true;
            }

            #pragma warning disable CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            if (cmbAccion.SelectedItem == "Desencriptar")
            #pragma warning restore CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            {
                btnAccion.Text = "Desencriptar";
                encrip = false;
            }

            #pragma warning disable CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            if (cmbAccion.SelectedItem == "")
            #pragma warning restore CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            {
                btnAccion.Text = "Seleccione Primero la Accion a Realizar";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;

            if (encrip)
            {
                mtVerificar();
                archivoBytes = encriptar.EncriptarArchivo(archivo, key);
                pcResult.Image = Properties.Resources.bloqueado;
                nombreExtensionModificado = nombre + "_Encriptado" + extension;
                lblResult.Text = nombreExtensionModificado;

            }
            else
            {
                if (!encrip)
                {
                    mtVerificar();
                    archivoBytes = encriptar.DesencriptarArchivo(archivo, key);
                    pcResult.Image = Properties.Resources.unlock;
                    nombreExtensionModificado = nombre + "_Desencriptado" + extension;
                    lblResult.Text = nombreExtensionModificado;
                }
                else
                {
                    if (archivo == null)
                    {
                        MessageBox.Show("añada el contenido para encriptar o desencriptar", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (txtKey.Text == null)
                    {
                        MessageBox.Show("Se necesita una llave de 16 caracteres a su gusto para encriptar", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Error", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string ruta;
                    ruta = fbd.SelectedPath + "\\" + nombreExtensionModificado;
                    lblRuta.Text = "Archivo nuevo guardado en: " + ruta;
                    //Creando nuevo archivo
                    File.WriteAllBytes(ruta, archivoBytes);
                    MessageBox.Show("Guardado Exitosamente","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void lblRuta_Click(object sender, EventArgs e)
        {

        }

        private void pcResult_Click(object sender, EventArgs e)
        {

        }

        private void encriptarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Visible = false;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            subirArchivo();
        }

        private void smiSubir_Click(object sender, EventArgs e)
        {
            subirArchivo();
        }

        private void mtVerificar()
        {
            if(txtKey.Text == "")
            {
                MessageBox.Show("Falta ingresar la clave para su encriptado, la debe de recordar para desencriptar el archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (archivo == "")
            {
                MessageBox.Show("Necesita montar un archivo para desencriptar o encriptar, dele en el boton subir o en la imagen","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnLimllave_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
        }

        private void btnLimContenido_Click(object sender, EventArgs e)
        {
            archivo = "";
            extension = ".?";
            nombre = "sin archivo";
            nombreExtensionModificado = null;
            archivoBytes = null;
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
            archivo = "";
            extension = ".?";
            nombre = "sin archivo";
            nombreExtensionModificado = null;
            archivoBytes = null;
            lblNombre.Text = "nombre del archivo";
            lblResult.Text = "nombre del archivo";
            pcArchivo.Image = Properties.Resources.cargar;
            pcResult.Image = Properties.Resources.lmao;
        }
    }
}
