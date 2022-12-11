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

        private void EXAMPLE_Load(object sender, EventArgs e)
        {
            RSA_Core[] keys_list;
            RSA_Core[] signs_list;

            using (FileStream file = new FileStream("core_crypt.keys", FileMode.OpenOrCreate))
                if (file.Length > 0) keys_list = JsonSerializer.Deserialize<RSA_Core[]>(file);
            using (FileStream file = new FileStream("core_sign.keys", FileMode.OpenOrCreate))
                if (file.Length > 0) signs_list = JsonSerializer.Deserialize<RSA_Core[]>(file);
        }
        private void EXAMPLE_FormClosed(object sender, EventArgs e)
        {
            RSA_Core[] keys_list  = new RSA_Core[1];
            RSA_Core[] signs_list = new RSA_Core[1];

            using (FileStream file = new FileStream("core_crypt.keys", FileMode.OpenOrCreate))
                JsonSerializer.Serialize(file, keys_list, options);
            using (FileStream file = new FileStream("core_sign.keys", FileMode.OpenOrCreate))
                JsonSerializer.Serialize(file, signs_list, options);
        }

        private void EXAMPLE_encrypt_Click(object sender, EventArgs e)
        {
            RSA_Core[] keys_list = new RSA_Core[1];
            if (keys_list[0].Name == "") { Console.WriteLine("ПЕРЕД ШИФРОВАНИЕМ УКАЖИТЕ ИМЯ ШИФРОВОЙ ГРУППЫ\n\n(первый выпадающий список)"); return; }

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA_Core core;

            if ((core = Get_core(keys_list, "core name")) == null)
            {
                core = new RSA_Core(keys_list[0].Name, RSA.ToXmlString(true), RSA.ToXmlString(false));
                // keys_list.Add(core);
            }

            // if (DIALOG_file.ShowDialog() == DialogResult.OK)
            {
                string file = "FileName";
                RSAEncryptFile(file, file.Insert(file.LastIndexOf('.'), "(!)"), core.Public_key);

                Console.WriteLine("зашифровано");
            }
        }
        private void EXAMPLE_decrypt_Click(object sender, EventArgs e)
        {
            RSA_Core[] keys_list = new RSA_Core[1];
            if (keys_list[0].Name == "") { Console.WriteLine("ПЕРЕД РАСШИФРОВЫВАНИЕМ УКАЖИТЕ ИМЯ ШИФРОВОЙ ГРУППЫ\n\n(первый выпадающий список)"); return; }

            RSA_Core core;

            if ((core = Get_core(keys_list, "core name")) == null)
            {
                Console.WriteLine("У ВАС НЕТ ДАННЫХ ДЛЯ ДЕШИФРОВКИ УКАЗАННОЙ ШИФРОВОЙ ГРУППЫ\n\n(первый выпадающий список)"); return;
            }

            // if (DIALOG_file.ShowDialog() == DialogResult.OK)
            {
                string file = "FileName";
                int index = file.LastIndexOf("!");
                RSADecryptFile(file, file.Remove(index, 1).Insert(index, "+"), core.Private_key);

                Console.WriteLine("расшифровано");
            }
        }

        private void EXAMPLE_put_sign_Click(object sender, EventArgs e)
        {
            RSA_Core[] signs_list = new RSA_Core[1];
            if (signs_list[0].Name == "") { Console.WriteLine("ПЕРЕД ПОДПИСЫВАНИЕМ УКАЖИТЕ ИМЯ ПОДПИСИ\n\n(второй выпадающий список)"); return; }

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA_Core core;

            if ((core = Get_core(signs_list, "sign name")) == null)
            {
                core = new RSA_Core(signs_list[0].Name, RSA.ToXmlString(true), RSA.ToXmlString(false));
                // COMBO_core_sign.Items.Add(core);
            }

            // if (DIALOG_file.ShowDialog() == DialogResult.OK)
            {
                string file = "FileName";
                SignFile(file, file.Insert(file.LastIndexOf('.'), "($)"), core.Private_key);

                Console.WriteLine("подписано");
            }
        }
        private void EXAMPLE_check_sign_Click(object sender, EventArgs e)
        {
            RSA_Core[] signs_list = new RSA_Core[1];
            if (signs_list[0].Name == "") { Console.WriteLine("ПЕРЕД ПРОВЕРКОЙ ПОДПИСИ УКАЖИТЕ ИМЯ ПОДПИСИ\n\n(второй выпадающий список)"); return; }

            RSA_Core core;

            if ((core = Get_core(signs_list, "sign name")) == null)
            {
                Console.WriteLine("У ВАС НЕТ ДАННЫХ ДЛЯ ПРОВЕРКИ УКАЗАННОЙ ПОДПИСИ\n\n(второй выпадающий список)"); return;
            }

            // if (DIALOG_file.ShowDialog() == DialogResult.OK)
            {
                string file = "FileName";
                if (CheckFile(file, core.Private_key))
                    Console.WriteLine("подпись подтверждена");
                else
                    Console.WriteLine("целостность файла нарушена");
            }
        }

        private RSA_Core Get_core(RSA_Core[] cores, string name)
        {
            foreach (RSA_Core core_crypt in cores)
            {
                if (core_crypt.Name == name) return core_crypt;
            }
            return null;
        }

        public static void RSAEncryptFile(string standart_file, string encrypted_file, string public_key)
        {
            using (var input = File.OpenRead(standart_file))
            using (var output = File.Create(encrypted_file))
            using (var aes = Aes.Create())
            {
                output.Write(aes.IV, 0, aes.IV.Length);
                byte[] encryptedAesKey = RSAEncrypt(aes.Key, public_key);
                byte[] lengthBytes = BitConverter.GetBytes(encryptedAesKey.Length);
                output.Write(lengthBytes, 0, lengthBytes.Length);
                output.Write(encryptedAesKey, 0, encryptedAesKey.Length);
                using (var cs = new CryptoStream(output, aes.CreateEncryptor(), CryptoStreamMode.Write)) input.CopyTo(cs);
            }
        }

        public static void RSADecryptFile(string encrypted_file, string standart_file, string private_key)
        {
            using (var input = File.OpenRead(encrypted_file))
            using (var output = File.Create(standart_file))
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
                aes.Key = RSADecrypt(encryptedAesKey, private_key);
                using (var cs = new CryptoStream(input, aes.CreateDecryptor(), CryptoStreamMode.Read)) cs.CopyTo(output);
            }
        }

        public static byte[] RSAEncrypt(byte[] data, string public_key)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(public_key);
                return rsa.Encrypt(data, true);
            }
        }

        public static byte[] RSADecrypt(byte[] data, string private_key)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(private_key);
                return rsa.Decrypt(data, true);
            }
        }

        public void SignFile(string standart_file, string signed_file, string private_key)
        {
            using (var input = File.OpenRead(standart_file))
            using (var output = File.Create(signed_file))
            using (var rsa = new RSACryptoServiceProvider(256))
            {
                rsa.FromXmlString(private_key);
                byte[] sign = rsa.SignData(input, MD5.Create());

                input.Position = 0;
                input.CopyTo(output);
                output.Write(sign, 0, sign.Length);
            }
        }

        public bool CheckFile(string file, string private_key)
        {
            using (var file_stream = File.OpenRead(file))
            {
                byte[] data = new byte[file_stream.Length - 128];
                file_stream.Read(data, 0, data.Length);
                byte[] sign = new byte[128];
                file_stream.Read(sign, 0, sign.Length);

                using (var rsa = new RSACryptoServiceProvider(256))
                {
                    rsa.FromXmlString(private_key);
                    return rsa.VerifyData(data, MD5.Create(), sign);
                }
            }
        }
    }

    public class RSA_Core
    {
        public string Name { get; }
        public string Private_key { get; }
        public string Public_key { get; }

        public RSA_Core(string name, string private_key, string public_key)
        {
            Name = name;
            Private_key = private_key;
            Public_key = public_key;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
