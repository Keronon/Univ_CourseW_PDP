using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;

namespace Email_Service
{
    internal class Crypto_module
    {
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        /*
        Симметричный алгоритм шифрования – AES.
        Ассиметричный алгоритм шифрования для шифрования ключей симметричного алгоритма – RSA.
        Алгоритм хеширования – MD5.
        Ассиметричный алгоритм шифрования для ЭЦП – RSA.

        Для стандартной инициализации RSAProvider'а в .Net :
        KeySize = 256, BlockSize = 128, Mode = CipherMode.CBC
        */

        private Keys_Core Get_core(Keys_Core[] cores, string name)
        {
            foreach (Keys_Core core_crypt in cores)
            {
                if (core_crypt.User == name) return core_crypt;
            }
            return null;
        }

        /// <summary>
        /// Perform encryption to byte array using AES-algorithm to data, and RSA-algorythm to AES-key
        /// </summary>
        /// <param name="to_encrypt">data to be encrypted</param>
        /// <param name="encrypt_key">public key for RSA to encrypt</param>
        /// <returns></returns>
        public static byte[] Encrypt_data(byte[] to_encrypt, string encrypt_key)
        {
            using (var input = new MemoryStream(to_encrypt))
            using (var output = new MemoryStream())
            using (var aes = Aes.Create())
            {
                output.Write(aes.IV, 0, aes.IV.Length);
                byte[] encryptedAesKey = RSA_encrypt(aes.Key, encrypt_key);
                byte[] lengthBytes = BitConverter.GetBytes(encryptedAesKey.Length);
                output.Write(lengthBytes, 0, lengthBytes.Length);
                output.Write(encryptedAesKey, 0, encryptedAesKey.Length);
                using (var cs = new CryptoStream(output, aes.CreateEncryptor(), CryptoStreamMode.Write)) input.CopyTo(cs);

                return output.ToArray();
            }
        }

        /// <summary>
        /// Perform decryption to byte array that hold into them AES key, using RSA-algorythm to AES-key before
        /// </summary>
        /// <param name="to_decrypt">data to be decrypted</param>
        /// <param name="decrypt_key">private key for RSA to decrypt</param>
        public static byte[] Decrypt_data(byte[] to_decrypt, string decrypt_key)
        {
            using (var input = new MemoryStream(to_decrypt))
            using (var output = new MemoryStream())
            using (var aes = Aes.Create())
            {
                byte[] iv = new byte[aes.BlockSize / 8];
                input.Read(iv, 0, iv.Length);
                aes.IV = iv;
                byte[] lengthBytes = new byte[sizeof(int)];
                input.Read(lengthBytes, 0, lengthBytes.Length);
                int length = BitConverter.ToInt32(lengthBytes, 0);
                byte[] encryptedAesKey = new byte[length];
                input.Read(encryptedAesKey, 0, encryptedAesKey.Length);
                aes.Key = RSA_decrypt(encryptedAesKey, decrypt_key);
                using (var crypto = new CryptoStream(input, aes.CreateDecryptor(), CryptoStreamMode.Read)) crypto.CopyTo(output);

                return output.ToArray();
            }
        }

        public static byte[] RSA_encrypt(byte[] data, string encrypt_key)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(encrypt_key);
                return rsa.Encrypt(data, true);
            }
        }

        public static byte[] RSA_decrypt(byte[] data, string decrypt_key)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(decrypt_key);
                return rsa.Decrypt(data, true);
            }
        }

        /// <summary>
        /// Creates sign for data using MD5-hash and RSA-signification
        /// </summary>
        /// <param name="to_sign">data to be signed</param>
        /// <param name="sign_key">private key for RSA to sign data-hash</param>
        /// <returns></returns>
        public static byte[] Sign_data(byte[] to_sign, string sign_key)
        {
            using (var input = new MemoryStream(to_sign))
            using (var rsa = new RSACryptoServiceProvider(256))
            {
                rsa.FromXmlString(sign_key);
                return rsa.SignData(input, MD5.Create());
            }
        }

        /// <summary>
        /// Checks data that signed by MD5-RSA-signification
        /// </summary>
        /// <param name="to_check">data to be checked</param>
        /// <param name="check_key">public key for RSA that signed data-hash</param>
        /// <param name="sign">data-sign</param>
        /// <returns></returns>
        public static bool Check_data(byte[] to_check, string check_key, byte[] sign)
        {
            using (var rsa = new RSACryptoServiceProvider(256))
            {
                rsa.FromXmlString(check_key);
                return rsa.VerifyData(to_check, MD5.Create(), sign);
            }
        }
    }

    public class Keys_Core
    {
        public string User        { get; }
        public string Encrypt_key { get; set; }
        public string Decrypt_key { get; set; }

        public Keys_Core(string user, string encrypt_key = null, string decrypt_key = null)
        {
            User        = user;
            Encrypt_key = encrypt_key;
            Decrypt_key = decrypt_key;
        }

        public override string ToString()
        {
            return User;
        }
    }
}
