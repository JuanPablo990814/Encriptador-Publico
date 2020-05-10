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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //El combobox empieza mostrando la posicion 0 = Encriptar
            cmbAccion.SelectedIndex = 0 ;
        }

        clsAlgoritmos Encriptar = new clsAlgoritmos();
        clsDatos BaseDatos = new clsDatos();

        #region Variables
        private bool encriptar;
        string datos = "";
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mtVerificarCamposBaseDatos();
            //datos = Encriptar.Encriptar(txtContenido.Text, txtKey.Text);
            //txtContenido.Text = datos;
            //BaseDatos.mtInsertarBaseDatos(txtContenido.Text, txtComentario.Text);
            //BaseDatos.mtInsertarEnElServidor(txtContenido.Text, txtComentario.Text);
            //MessageBox.Show("Añadido a la base de datos", "Advertencia", MessageBoxButtons.OK,
            //MessageBoxIcon.Information);
        }

        #region Verificacion de Campos
        private void mtVerificarCamposBaseDatos()
        {
            if(txtContenido.Text == "")
            {
                MessageBox.Show("Ingrese un contenido a encriptar", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            if (txtKey.Text == "")
            {
                MessageBox.Show("Ingrese una llave para encriptar", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            if (txtComentario.Text == "")
            {
                MessageBox.Show("Ingrese un comentario para en caso de que vaya desencriptar, tenga idea de que es", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }
        
        private void mtVerificarCampos()
        {
            if (txtContenido.Text == "")
            {
                MessageBox.Show("Ingrese un contenido a encriptar", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }

            if (txtKey.Text == "")
            {
                MessageBox.Show("Ingrese una llave que recuerde para en caso de desencriptar el dato, tamaño requerido de 16 caracteres", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            #pragma warning disable CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            if (cmbAccion.SelectedItem == "Encriptar")
            #pragma warning restore CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            {
                btnAccion.Text = "Encriptar";
                encriptar = true;
            }

            #pragma warning disable CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            if (cmbAccion.SelectedItem== "Desencriptar")
            #pragma warning restore CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            {
                btnAccion.Text = "Desencriptar";
                encriptar = false;
            }

            #pragma warning disable CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            if (cmbAccion.SelectedItem == "")
            #pragma warning restore CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
            {
                btnAccion.Text = "Seleccione Primero la Accion a Realizar";
            }
            
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            mtVerificarCampos();
            string data = txtContenido.Text;
            string key = txtKey.Text;

            if (encriptar)
            {
                data = Encriptar.EncriptarTexto(data, key);
                txtContenido.Text = data;
                if (Encriptar.error)
                {
                    MessageBox.Show("Error al encriptar", "Advertencia",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Encriptar.error = false;
                }
            }
            else
            {
                if (!encriptar)
                {
                    data = Encriptar.DesencriptarTexto(data, key);
                    txtContenido.Text = data;
                    if (Encriptar.error)
                    {
                        MessageBox.Show("Error al Desencriptar", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        Encriptar.error = false;
                    }
                }
                else
                {
                    if (txtContenido.Text == null)
                    {
                        MessageBox.Show("añada el contenido para encriptar o desencriptar", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (txtKey.Text == null)
                    {
                        MessageBox.Show("Se necesita una llave a su gusto para encriptar", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Error", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
        }

        private void btnLimContenido_Click(object sender, EventArgs e)
        {
            txtContenido.Text = "";
        }

        private void btnLimComentario_Click(object sender, EventArgs e)
        {
            txtComentario.Text = "";
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
            txtContenido.Text = "";
            txtComentario.Text = "";
        }

        private void btnArchivos_Click(object sender, EventArgs e)
        {

        }

        private void encriptarArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivos arc = new Archivos();
            arc.Show();
            this.Visible = false;
        }

        private void guardarLlaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarTexto("keyText");
        }

        private void guardarTexto(string nombre)
        {
            using (var sfd = new SaveFileDialog())
            {
                string path = null;
                sfd.FileName = nombre;
                sfd.Filter = "Text Files|*.txt|Documentos|*.doc";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = sfd.FileName;
                    //para ahorrar lineas de codigo
                    
                    File.WriteAllText(path, txtKey.Text);
                    MessageBox.Show("Guardado Exitosamente", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void guardarContenidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guardarTexto("contentText");
        }

        private void abrirLlaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtKey.Text = File.ReadAllText(dialog.FileName);

                    MessageBox.Show("Abriendo llave");
                }
            }
        }

        private void abrirArchivoDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtContenido.Text = File.ReadAllText(dialog.FileName);
                    MessageBox.Show("Abriendo Contenido");
                }
            }
        }
    }
}
