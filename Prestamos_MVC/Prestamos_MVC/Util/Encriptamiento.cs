using System;
using System.Security.Cryptography;
using System.Text;

namespace Prestamos_MVC.Util
{
    public class Encriptamiento
    {


        public static string GenerateKey(string serverName, int portNumber, string databaseName, string userName, string passwordUser, int trustedConnection, string typeDeployment)
        {
            if (serverName.Split(' ').Length < 10 || databaseName.Split(' ').Length < 5 || userName.Split(' ').Length < 2 || passwordUser.Split(' ').Length < 2 || typeDeployment.Split(' ').Length < 3)
            {
                throw new ArgumentException("Una o mas entradas no cumplen con el requerimiento minimo de palabras");
            }

            if (portNumber.ToString().Length < 4)
            {
                throw new ArgumentException("Puerto necesita un minimo de 4 letras");
            }

            string key = serverName +
                         portNumber.ToString().Substring(0, 2) +
                         databaseName +
                         portNumber.ToString().Substring(portNumber.ToString().Length - 2) +
                         userName +
                         passwordUser +
                         trustedConnection +
                         typeDeployment;

            return key;
        }


        public static string EncryptString(string plainText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    aes.Key = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
                }

                aes.GenerateIV();
                byte[] iv = aes.IV;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, iv);

                using (var ms = new System.IO.MemoryStream())
                {
                    ms.Write(iv, 0, iv.Length);
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (var sw = new System.IO.StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

    }
}
