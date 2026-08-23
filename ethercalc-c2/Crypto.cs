using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ethercalc_c2
{
    internal class Crypto
    {
        public static string encrypt(string message, string key)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(key));
                aes.GenerateIV();

                using (var ms = new MemoryStream())
                {
                    ms.Write(aes.IV, 0, aes.IV.Length);

                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                        sw.Write(message);

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string decrypt(string message, string key)
        {
            byte[] data = Convert.FromBase64String(message);

            using (var aes = Aes.Create())
            {
                aes.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(key));

                byte[] iv = new byte[16];
                Array.Copy(data, iv, 16);
                aes.IV = iv;

                using (var ms = new MemoryStream(data, 16, data.Length - 16))
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                    return sr.ReadToEnd();
            }
        }

        public static string md5(string input)
        {
            if (input != null)
            {
                using (var md5 = System.Security.Cryptography.MD5.Create())
                    return BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(input)))
                        .Replace("-", "").ToLower();
            }
            else { return ""; }
        }
    }
}
