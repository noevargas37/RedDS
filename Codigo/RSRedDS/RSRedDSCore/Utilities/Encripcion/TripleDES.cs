using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSRedDSCore.Utilities.Encripcion
{
    public class TripleDES
    {
        private const string IV = "OkbSI7nqucQ=";
        private const string KEY = "LxNw6GN/4hCS3amDUgKzObGB6wdDwtAw";

        public static string Desencriptar(string value)
        {
            string str = string.Empty;
            try
            {
                byte[] buffer = Convert.FromBase64String(value);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, new TripleDESCryptoServiceProvider().CreateDecryptor(Convert.FromBase64String(KEY), Convert.FromBase64String(IV)), CryptoStreamMode.Write);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                stream2.Close();
                str = Encoding.UTF8.GetString(stream.ToArray());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
            return str;
        }

        public static string Encriptar(string Value)
        {
            string str = string.Empty;
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(Value);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, new TripleDESCryptoServiceProvider().CreateEncryptor(Convert.FromBase64String(KEY), Convert.FromBase64String(IV)), CryptoStreamMode.Write);
                stream2.Write(bytes, 0, bytes.Length);
                stream2.FlushFinalBlock();
                stream2.Close();
                str = Convert.ToBase64String(stream.ToArray());
            }
            catch (Exception exception)
            {
                throw new Exception(exception.ToString());
            }
            return str;
        }
    }
}
