using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class clsAlgoritmos
    {
        public bool error;


        //incodificable (Para contraseñas)
        public string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        #region Encriptado de texto
        public string EncriptarTexto(string texto, string personalkey)
        {
            byte[] bytesEncriptados = null;
            byte[] bytesAencriptar = Encoding.UTF8.GetBytes(texto);
            byte[] clave = Encoding.UTF8.GetBytes(personalkey);
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            string encriptado = null;
            using (var memoStream = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(clave, salt, 1000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;
                    using (CryptoStream cryptoStream = new CryptoStream(memoStream, aes.CreateEncryptor(),
                        CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(bytesAencriptar, 0, bytesAencriptar.Length);
                        cryptoStream.Close();
                    }
                    bytesEncriptados = memoStream.ToArray();
                    encriptado = Convert.ToBase64String(bytesEncriptados, 0, bytesEncriptados.Length);
                }
            }
            return encriptado;
        }

        public string DesencriptarTexto(string texto, string personalkey)
        {
            byte[] bytesEncriptados = null;
            byte[] bytesADesencriptar = Convert.FromBase64String(texto);
            byte[] clave = Encoding.UTF8.GetBytes(personalkey);
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            string decriptado = null;
            using (var memoStream = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(clave, salt, 1000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;
                    using (CryptoStream cryptoStream = new CryptoStream(memoStream, aes.CreateDecryptor(),
                        CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(bytesADesencriptar, 0, bytesADesencriptar.Length);
                        cryptoStream.Close();
                    }
                    bytesEncriptados = memoStream.ToArray();
                    decriptado = Encoding.UTF8.GetString(bytesEncriptados, 0, bytesEncriptados.Length);
                }
            }
            return decriptado;
        }

        #endregion

        #region Encriptado de Archivos
        public byte[] EncriptarArchivo(string rutaArchivo, string personalkey)
        {
            byte[] bytesEncriptados = null;
            byte[] bytesAencriptar = File.ReadAllBytes(rutaArchivo);
            byte[] clave = Encoding.UTF8.GetBytes(personalkey);
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using (var memoStream = new MemoryStream())
            {
                using(var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(clave, salt, 1000);
                    aes.Key = key.GetBytes(aes.KeySize/8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;
                    using(CryptoStream cryptoStream = new CryptoStream(memoStream, aes.CreateEncryptor(),
                        CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(bytesAencriptar, 0, bytesAencriptar.Length);
                        cryptoStream.Close();
                    }
                    bytesEncriptados = memoStream.ToArray();
                }
            }
            return bytesEncriptados;
        }

        public byte[] DesencriptarArchivo(string rutaArchivo, string personalkey)
        {
            byte[] bytesEncriptados = null;
            byte[] bytesADesencriptar = File.ReadAllBytes(rutaArchivo);
            byte[] clave = Encoding.UTF8.GetBytes(personalkey);
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using (var memoStream = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(clave, salt, 1000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;
                    using (CryptoStream cryptoStream = new CryptoStream(memoStream, aes.CreateDecryptor(),
                        CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(bytesADesencriptar, 0, bytesADesencriptar.Length);
                        cryptoStream.Close();
                    }
                    bytesEncriptados = memoStream.ToArray();
                }
            }
            return bytesEncriptados;
        }
        #endregion

        //Encriptacion de Texto ¡DESCARTADO DEL PROCESO!
        #region Encriptado y Desencriptado con algoritmo AES
        public string Encriptar(string dato, string llave)
        {
            byte[] keyArray;
            byte[] encriptar = Encoding.UTF8.GetBytes(dato);
            string resultadofinal = null;

            keyArray = Encoding.UTF8.GetBytes(llave);
            //var tdes = new TripleDESCryptoServiceProvider();
            var aes = new AesCryptoServiceProvider();
            try
            {
                aes.Key = keyArray;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = aes.CreateEncryptor();
                byte[] resultado = cTransform.TransformFinalBlock(encriptar, 0, encriptar.Length);
                resultadofinal = Convert.ToBase64String(resultado, 0, resultado.Length);
                aes.Clear();
                error = false;

            }
            catch
            {
                error = true;
                resultadofinal = "Error";
            }

            return resultadofinal;
        }

        public string Desencriptar(string dato, string llave)
        {
            byte[] keyArray;
            byte[] decriptar = Convert.FromBase64String(dato);
            string resultadofinal = null;

            keyArray = Encoding.UTF8.GetBytes(llave);
            //var tdes = new TripleDESCryptoServiceProvider();
            var aes = new AesCryptoServiceProvider();
            try
            {
                aes.Key = keyArray;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = aes.CreateDecryptor();
                byte[] resultado = cTransform.TransformFinalBlock(decriptar, 0, decriptar.Length);
                resultadofinal = Encoding.UTF8.GetString(resultado);
                aes.Clear();
                error = false;
            }
            catch
            {
                error = true;
                resultadofinal = "Error";
            }


            return resultadofinal;
        }
        #endregion
    }
}
