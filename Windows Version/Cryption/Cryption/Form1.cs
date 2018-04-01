using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Security.Cryptography;


namespace WindowsFormsApp1
{
    public partial class Cryption : Form
    {
        public Cryption()
        {
            InitializeComponent();
        }

        //##################################################################################################

        #region Right Sidebar

        //##    创建证书

        private void buttonSelectMakecret_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBoxPathMakecret.Text = openFile.FileName;
            }
        }

        private void buttonCreatePfx_Click(object sender, EventArgs e)
        {
            string MakeCert = textBoxPathMakecret.Text;
            string x509Name = "CN=" + textBoxCnName.Text.Trim();
            string param = " -pe -ss my -n \"" + x509Name + "\" ";
            Process p = Process.Start(MakeCert, param);
            p.WaitForExit();
            p.Close();
            MessageBox.Show("已成功创建证书：" + x509Name);
        }

        private void buttonSelectExportPfxPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseFile = new FolderBrowserDialog();
            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                textBoxExportPfxPath.Text = browseFile.SelectedPath;
            }
        }

        private void buttonExportPfx_Click(object sender, EventArgs e)
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadWrite);
            X509Certificate2Collection storecollection = (X509Certificate2Collection)store.Certificates;
            foreach (X509Certificate2 x509 in storecollection)
            {
                if (x509.Subject == "CN=" + textBoxCnName.Text.Trim())
                {
                    Debug.Print(string.Format("certificate name: {0}", x509.Subject));
                    byte[] pfxByte = x509.Export(X509ContentType.Pfx, textBoxExportKey.Text.Trim());
                    using (FileStream fileStream = new FileStream(Path.Combine(textBoxExportPfxPath.Text.Trim(), textBoxCnName.Text.Trim() + ".pfx"), FileMode.Create))
                    {
                        // Write the data to the file, byte by byte.   
                        for (int i = 0; i < pfxByte.Length; i++)
                            fileStream.WriteByte(pfxByte[i]);
                        // Set the stream position to the beginning of the file.   
                        fileStream.Seek(0, SeekOrigin.Begin);
                        // Read and verify the data.   
                        for (int i = 0; i < fileStream.Length; i++)
                        {
                            if (pfxByte[i] != fileStream.ReadByte())
                            {
                                MessageBox.Show("Error writing data.");
                                return;
                            }
                        }
                        fileStream.Close();
                        MessageBox.Show("导出PFX完毕");
                    }
                }
            }
            store.Close();
            store = null;
            storecollection = null;
        }

        private void buttonSetExportCerPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseFile = new FolderBrowserDialog();
            if (browseFile.ShowDialog() == DialogResult.OK)
            {
                textBoxExportCerPath.Text = browseFile.SelectedPath;
            }
        }

        private void buttonExportCer_Click(object sender, EventArgs e)
        {
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadWrite);
            X509Certificate2Collection storecollection = (X509Certificate2Collection)store.Certificates;
            foreach (X509Certificate2 x509 in storecollection)
            {
                if (x509.Subject == "CN=" + textBoxCnName.Text.Trim())
                {
                    Debug.Print(string.Format("certificate name: {0}", x509.Subject));
                    byte[] pfxByte = x509.Export(X509ContentType.Cert);
                    using (FileStream fileStream = new FileStream(Path.Combine(textBoxExportCerPath.Text.Trim(), textBoxCnName.Text.Trim() + ".cert"), FileMode.Create))
                    {
                        // 逐字节写入文件  
                        for (int i = 0; i < pfxByte.Length; i++)
                            fileStream.WriteByte(pfxByte[i]);
                        // 把流位置放到文件头部  
                        fileStream.Seek(0, SeekOrigin.Begin);
                        // 读取并验证数据  
                        for (int i = 0; i < fileStream.Length; i++)
                        {
                            if (pfxByte[i] != fileStream.ReadByte())
                            {
                                MessageBox.Show("Error writing data.");
                                return;
                            }
                        }
                        fileStream.Close();
                        MessageBox.Show("导出CERT完毕");
                    }
                }
            }
            store.Close();
            store = null;
            storecollection = null;
        }

        //##    RSA加密

        public string RSAEncrypt(string xmlPublicKey, string m_strEncryptString)
        {
            try
            {
                RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
                provider.FromXmlString(xmlPublicKey);
                byte[] bytes = new UnicodeEncoding().GetBytes(m_strEncryptString);
                return Convert.ToBase64String(provider.Encrypt(bytes, false));
            }
            catch (Exception)
            {

                return m_strEncryptString;
            }

        }

        public string RSADecrypt(string xmlPrivateKey, string m_strDecryptString)
        {
            try
            {
                RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
                provider.FromXmlString(xmlPrivateKey);
                byte[] rgb = Convert.FromBase64String(m_strDecryptString);
                byte[] bytes = provider.Decrypt(rgb, false);
                return new UnicodeEncoding().GetString(bytes);
            }
            catch (Exception)
            {

                return m_strDecryptString;
            }

        }

        private void buttonSelectPfx_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBoxPfxPath.Text = openFile.FileName;
            }
        }

        private void buttonGetKeyPair_Click(object sender, EventArgs e)
        {
            try
            {
                X509Certificate2 pc = new X509Certificate2(textBoxPfxPath.Text.Trim(), textBoxPfxKey.Text.Trim(), X509KeyStorageFlags.Exportable);
                labelCerMD5.Text = pc.Thumbprint;
                labelCerName.Text = pc.SubjectName.Name;
                textBoxPubKey.Text = pc.PublicKey.Key.ToXmlString(false);
                textBoxPrivKey.Text = pc.PrivateKey.ToXmlString(true);
                pc = null;
            }
            catch
            {
                textBoxPfxKey.Text = "";
                MessageBox.Show("密码错误");
            }
        }

        private void buttonPubCrypt_Click(object sender, EventArgs e)
        {
            textBoxCrypted.Text = this.RSAEncrypt(textBoxPubKey.Text.Trim(), textBoxCrypOrigin.Text.Trim());
        }

        private void buttonPrivDecry_Click(object sender, EventArgs e)
        {
            textBoxDecrypted.Text = this.RSADecrypt(textBoxPrivKey.Text, textBoxDecOrigin.Text);
        }

        //##    MD5和DES


        //####      MD5

        public static string MD5Encrypt(string strText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.Default.GetBytes(strText));
            return BitConverter.ToString(result);
        }

        private void buttonMD5calc_Click(object sender, EventArgs e)
        {
            textBoxMD5.Text = MD5Encrypt(textBoxCrypOrigin.Text);
        }

        private void buttonImportToMD5_Click(object sender, EventArgs e)
        {
            textBoxImportedToMD5.Text = textBoxCrypOrigin.Text;
        }

        private void buttonCheckMD5_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.Default.GetBytes(textBoxImportedToMD5.Text));
            MD5CheckResult.Text = (BitConverter.ToString(result) == textBoxMD5.Text)?"匹配":"不对";
        }
        //####      DES

        public static string DesEncrypt(string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.Default.GetBytes(encryptKey.Substring(0, 8));
                //rgbIV与rgbKey可以不一样，这里只是为了简便，读者可以自行修改
                byte[] rgbIV = Encoding.Default.GetBytes(encryptKey.Substring(0, 8));
                byte[] inputByteArray = Encoding.Default.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }

        public static string DesDecrypt(string decryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.Default.GetBytes(encryptKey.Substring(0, 8));
                //rgbIV与rgbKey可以不一样，这里只是为了简便，读者可以自行修改
                byte[] rgbIV = Encoding.Default.GetBytes(encryptKey.Substring(0, 8));
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.Default.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        }

        private void buttonDesEncode_Click(object sender, EventArgs e)
        {
            if (textBoxSetDesPasswd.Text == "")
            {
                MessageBox.Show("密码为空，使用默认密码");
                textBoxSetDesPasswd.Text = "MdM5jkH7";
            }
            if (textBoxSetDesPasswd.Text.Length != 8)
            {
                MessageBox.Show("请输入长度为8位的密码");
            }
            else
            {
                textBoxCrypted.Text = DesEncrypt(textBoxCrypOrigin.Text, textBoxSetDesPasswd.Text);
            }
            if (textBoxCrypted.Text == textBoxCrypOrigin.Text)
            {
                MessageBox.Show("加密失败");
            }
        }

        private void buttonDesDecode_Click(object sender, EventArgs e)
        {
            if (textBoxImputDesPasswd.Text == "")
            {
                MessageBox.Show("密码为空，将使用默认密码进行 Brute Force 破解");
                textBoxImputDesPasswd.Text = "MdM5jkH7";
            }
            if (textBoxImputDesPasswd.Text.Length != 8)
            {
                MessageBox.Show("请输入长度为8位的密码");
            }
            else
            {
                textBoxDecrypted.Text = DesDecrypt(textBoxDecOrigin.Text, textBoxImputDesPasswd.Text);
            }
            if (textBoxDecrypted.Text == textBoxDecOrigin.Text)
            {
                MessageBox.Show("解密失败");
            }
        }

        //##    AES和SHA

        //####      AES

        public static string AESEncode(string text, string key, string iv)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.Zeros;
            rijndaelCipher.KeySize = 128;
            rijndaelCipher.BlockSize = 128;
            byte[] pwdBytes = System.Text.Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
                len = keyBytes.Length;
            System.Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = Encoding.UTF8.GetBytes(iv);
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(text);
            byte[] cipherBytes = transform.TransformFinalBlock(plainText, 0, plainText.Length);
            return Convert.ToBase64String(cipherBytes);
        }
        
        public static string AESDecode(string text, string key, string iv)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.Zeros;
            rijndaelCipher.KeySize = 128;
            rijndaelCipher.BlockSize = 128;
            byte[] encryptedData = Convert.FromBase64String(text);
            byte[] pwdBytes = System.Text.Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
                len = keyBytes.Length;
            System.Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = Encoding.UTF8.GetBytes(iv);
            ICryptoTransform transform = rijndaelCipher.CreateDecryptor();
            byte[] plainText = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(plainText);
        }



        private void buttonAesEncode_Click(object sender, EventArgs e)
        {
            if (textBoxSetAesPasswd.Text == "")
            {
                MessageBox.Show("密码为空，使用默认密码");
                textBoxSetAesPasswd.Text = "MdM5jkH7HfhGFRk7";
            }
            else
            {
                if (textBoxSetAesPasswd.Text.Length > 16)
                {
                    MessageBox.Show("密码长度超过16位，将只使用前16位");
                }
                String iv = "MdM5jkH7HfhGFRk7";
                textBoxCrypted.Text = AESEncode(textBoxCrypOrigin.Text, textBoxSetAesPasswd.Text, iv);
            }
            if (textBoxCrypted.Text == textBoxCrypOrigin.Text)
            {
                MessageBox.Show("加密失败");
            }
        }

        private void buttonAesDecode_Click(object sender, EventArgs e)
        {
            if (textBoxImputAesPasswd.Text == "")
            {
                MessageBox.Show("密码为空，将使用默认密码进行 Brute Force 破解");
                textBoxImputAesPasswd.Text = "MdM5jkH7HfhGFRk7";
            }
            else
            {
                if (textBoxImputAesPasswd.Text.Length > 16)
                {
                    MessageBox.Show("密码长度超过16位，将只使用前16位");
                }
                String iv = "MdM5jkH7HfhGFRk7";
                textBoxDecrypted.Text = AESDecode(textBoxDecOrigin.Text, textBoxImputAesPasswd.Text, iv);
            }
            if (textBoxDecrypted.Text == textBoxDecOrigin.Text)
            {
                MessageBox.Show("解密失败");
            }
        }

        //####      SHA

        private void buttonSHA_Click(object sender, EventArgs e)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider();
            if (radioButtonSHA1.Checked)
            {
                byte[] str1 = Encoding.UTF8.GetBytes(textBoxCrypOrigin.Text);
                byte[] str2 = sha1.ComputeHash(str1);
                sha1.Clear();
                (sha1 as IDisposable).Dispose();
                textBoxCrypted.Text = Convert.ToBase64String(str2);
            }
            else if (radioButtonSHA256.Checked)
            {
                byte[] str1 = Encoding.UTF8.GetBytes(textBoxCrypOrigin.Text);
                byte[] str2 = sha256.ComputeHash(str1);
                sha256.Clear();
                (sha256 as IDisposable).Dispose();
                textBoxCrypted.Text = Convert.ToBase64String(str2);
            }
            else if (radioButtonSHA512.Checked)
            {
                byte[] str1 = Encoding.UTF8.GetBytes(textBoxCrypOrigin.Text);
                byte[] str2 = sha512.ComputeHash(str1);
                sha512.Clear();
                (sha512 as IDisposable).Dispose();
                textBoxCrypted.Text = Convert.ToBase64String(str2);
            }
        }
        #endregion

        //##################################################################################################

        #region Left Sidebar

        private void textBoxCrypted_TextChanged(object sender, EventArgs e)
        {
            textBoxDecOrigin.Text = textBoxCrypted.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCrypOrigin.Text = textBoxCrypted.Text = textBoxDecrypted.Text = "";
        }

        #endregion

        //##################################################################################################

    }
}
