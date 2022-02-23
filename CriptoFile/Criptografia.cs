using System;
using System.IO;
using System.Security.Cryptography;


namespace CriptoFile
{
    class Criptografia
    {
        public static CspParameters cspp;
        public static RSACryptoServiceProvider rsa;

        private static string _encrFolder;
        public static string EncrFolder
        {
            get
            {
                return _encrFolder;
            }
            set
            {
                _encrFolder = value;
                PubKeyFile = _encrFolder + "rsaPublicKey.txt";
            }
        }

        public static string DecrFolder { get; set; }
        public static string SrcFolder { get; set; }

        private static string PubKeyFile = EncrFolder + "rsaPublicKey.txt";

        public static string keyName;

        //Metodo para Criar a chave publica
        public static string CreateAsmKeys()
        {
            string result = "";
            if (string.IsNullOrEmpty(keyName))
            {
                result = "Chave Publica não Definida";
                return result;
            }
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly)
            {
                result = "Key: " + cspp.KeyContainerName + " - Somente Publica";
            }
            else
            {
                result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }

            return result;
        }

        //Metodo para Exportar a chave publica
        public static bool ExportPublicKey()
        {
            bool result = true;

            if (rsa == null)
            {
                return false;
            }

            if (!Directory.Exists(EncrFolder))
            {
                Directory.CreateDirectory(EncrFolder);
            }

            StreamWriter sw = new StreamWriter(PubKeyFile, false);

            try
            {
                sw.Write(rsa.ToXmlString(false));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            finally
            {
                sw.Close();
            }

            return result;
        }

        //Metodo para Imprtar a chave publica de um arquivo
        public static string ImportPublicKey()
        {
            string result = "";

            if (!File.Exists(PubKeyFile))
            {
                result = "Arquivo de chave publica não encontrado";
                return result;
            }

            if (string.IsNullOrEmpty(keyName))
            {
                result = "Chave Publica não Definida";
                return result;
            }

            StreamReader sr = new StreamReader(PubKeyFile);

            try
            {
                cspp.KeyContainerName = keyName;
                rsa = new RSACryptoServiceProvider(cspp);
                string keytxt = sr.ReadToEnd();
                rsa.FromXmlString(keytxt);
                rsa.PersistKeyInCsp = true;
                if (rsa.PublicOnly)
                {
                    result = "Key: " + cspp.KeyContainerName + " - Somente Publica";
                }
                else
                {
                    result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
                }
            }
            catch(Exception ex)
            {
                result = ex.Message;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }

            return result;
        }

        //Metodo para Criar a chave privada
        public static string GetPrivateKey()
        {
            string result = "";

            if (string.IsNullOrEmpty(keyName))
            {
                result = "Chave Privada não Definida";
                return result;
            }

            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly)
            {
                result = "Key: " + cspp.KeyContainerName + " - Somente Publica";
            }
            else
            {
                result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }

            return result;
        }

        //Metodo para criptografar um arquivo
        public static string EncryptFile(string inFile)
        {
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            int startFileName = inFile.LastIndexOf("\\") + 1;
            string outFile = EncrFolder + inFile.Substring(startFileName) + ".enc";

            try
            {
                using(FileStream outFs = new FileStream(outFile, FileMode.Create))
                {
                    outFs.Write(LenK, 0, 4);
                    outFs.Write(LenIV, 0, 4);
                    outFs.Write(keyEncrypted, 0, lKey);
                    outFs.Write(aes.IV, 0, lIV);

                    using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        int count = 0;
                        int offset = 0;

                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];
                        int bytesRead = 0;

                        using (FileStream inFs = new FileStream(inFile, FileMode.Open))
                        {
                            do
                            {
                                count = inFs.Read(data, 0, blockSizeBytes);
                                offset += count;
                                outStreamEncrypted.Write(data, 0, count);
                                bytesRead += blockSizeBytes;
                            } while (count > 0);
                            inFs.Close();
                        }
                        outStreamEncrypted.FlushFinalBlock();
                        outStreamEncrypted.Close();
                    }
                    outFs.Close();
                    File.Delete(inFile);
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

            return $"Arquivo Criptografado.\n" +
                    $"Origem: {inFile}\n" +
                    $"Destino: {outFile}";
        }

        //Metodo para descriptografar um arquivo
        public static string DecryptFile(string inFile)
        {
            Aes aes = Aes.Create();

            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            string outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf("."));
            try
            {
                using (FileStream inFs = new FileStream(EncrFolder + inFile, FileMode.Open))
                {
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Seek(0, SeekOrigin.Begin);
                    inFs.Read(LenK, 0, 3);
                    inFs.Seek(4, SeekOrigin.Begin);
                    inFs.Read(LenIV, 0, 3);

                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    int startC = lenK + lenIV + 8;
                    int lenC = (int)inFs.Length - startC;

                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];

                    inFs.Seek(8, SeekOrigin.Begin);
                    inFs.Read(KeyEncrypted, 0, lenK);
                    inFs.Seek(8 + lenK, SeekOrigin.Begin);
                    inFs.Read(IV, 0, lenIV);

                    if (!Directory.Exists(DecrFolder))
                    {
                        Directory.CreateDirectory(DecrFolder);
                    }

                    byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);
                    ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                    using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                    {
                        int count = 0;
                        int offset = 0;

                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];

                        inFs.Seek(startC, SeekOrigin.Begin);
                        using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                        {
                            do
                            {
                                count = inFs.Read(data, 0, blockSizeBytes);
                                offset += count;
                                outStreamDecrypted.Write(data, 0, count);
                            } while (count > 0);

                            outStreamDecrypted.FlushFinalBlock();
                            outStreamDecrypted.Close();
                        }
                        outFs.Close();
                    }
                    inFs.Close();
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return $"Arquivo Descriptografado.\n Origem: {inFile}\n Destino: {outFile}";
        }
    }
}
