using System;
using System.Security.Cryptography;
using System.Text;
namespace kss_Verificador_PT
{
    internal class encryptHelper
    {
        //public static string Encrypt(string clearText, string EncryptionKey)
        //{
        //    byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        //    using (Aes encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(clearBytes, 0, clearBytes.Length);
        //                cs.Close();
        //            }
        //            clearText = Convert.ToBase64String(ms.ToArray());
        //        }
        //    }
        //    return clearText;
        //}
        //public static string Decrypt(string cipherText, string EncryptionKey)
        //{
        //    cipherText = cipherText.Replace(" ", "+");
        //    byte[] cipherBytes = Convert.FromBase64String(cipherText);
        //    using (Aes encryptor = Aes.Create())
        //    {
        //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        //        encryptor.Key = pdb.GetBytes(32);
        //        encryptor.IV = pdb.GetBytes(16);
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
        //            {
        //                cs.Write(cipherBytes, 0, cipherBytes.Length);
        //                cs.Close();
        //            }
        //            cipherText = Encoding.Unicode.GetString(ms.ToArray());
        //        }
        //    }
        //    return cipherText;
        //}
        public static string encryptus(string x, string KeyEncrypt="12345678")//function
        {
            try
            {

                string y = x;
                byte[] etext = UTF8Encoding.UTF8.GetBytes(y);
                string Code = KeyEncrypt;
                MD5CryptoServiceProvider mdhash = new MD5CryptoServiceProvider();
                byte[] keyarray = mdhash.ComputeHash(UTF8Encoding.UTF8.GetBytes(Code));
                TripleDESCryptoServiceProvider tds = new TripleDESCryptoServiceProvider();
                tds.Key = keyarray;
                tds.Mode = CipherMode.ECB;
                tds.Padding = PaddingMode.PKCS7;

                ICryptoTransform itransform = tds.CreateEncryptor();
                byte[] result = itransform.TransformFinalBlock(etext, 0, etext.Length);
                string encryptresult = Convert.ToBase64String(result);
                return encryptresult.ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error encriptando: " + ex.Message);
                return "";
            }
        }
        public static string dencryptus(string x, string KeyEncrypt="12345678")
        {
            try
            {
                string y = x.Replace("\0", null).Replace(" ", null);
                byte[] etext = Convert.FromBase64String(y);
                string key = KeyEncrypt;
                MD5CryptoServiceProvider mdhash = new MD5CryptoServiceProvider();
                byte[] keyarray = mdhash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tds = new TripleDESCryptoServiceProvider();
                tds.Key = keyarray;
                tds.Mode = CipherMode.ECB;
                tds.Padding = PaddingMode.PKCS7;

                ICryptoTransform itransform = tds.CreateDecryptor();
                byte[] result = itransform.TransformFinalBlock(etext, 0, etext.Length);
                string dencryptresult = UTF8Encoding.UTF8.GetString(result);
                return dencryptresult.ToString();
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show("Error encriptando: " + ex.Message);
                string EncriptVacio = encryptus("", KeyEncrypt);
                return dencryptus(EncriptVacio,  KeyEncrypt);
            }
        }
    }
}
