using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string compressedEncryptedFile = "output.enc.gz";
        string text = "Hello, this is a test text for streams!";
        byte[] key = new byte[32]; // klucz AES (256 bit)
        byte[] iv = new byte[16];  // wektor inicializacji
        RandomNumberGenerator.Fill(key);
        RandomNumberGenerator.Fill(iv);

        // StringBuilder и StringWriter
        StringBuilder sb = new StringBuilder();
        using (StringWriter sw = new StringWriter(sb))
        {
            sw.Write(text);
            Console.WriteLine("StringWriter: " + sb.ToString());
        }

        // StreamWriter dla tworzenia
        using (FileStream fs = new FileStream(inputFile, FileMode.Create))
        using (StreamWriter sw = new StreamWriter(fs))
        {
            sw.Write(text);
        }

        // StreamReader
        using (FileStream fs = new FileStream(inputFile, FileMode.Open))
        using (StreamReader sr = new StreamReader(fs))
        {
            Console.WriteLine("StreamReader: " + sr.ReadToEnd());
        }

        // szyfrujemy i kompresja
        using (FileStream fs = new FileStream(compressedEncryptedFile, FileMode.Create))
        using (GZipStream gzip = new GZipStream(fs, CompressionMode.Compress))
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            using (CryptoStream crypto = new CryptoStream(gzip, aes.CreateEncryptor(), CryptoStreamMode.Write))
            using (StreamWriter sw = new StreamWriter(crypto))
            {
                sw.Write(text);
            }
        }

        // Рdeszyfrowanie i dekompresja
        using (FileStream fs = new FileStream(compressedEncryptedFile, FileMode.Open))
        using (GZipStream gzip = new GZipStream(fs, CompressionMode.Decompress))
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            using (CryptoStream crypto = new CryptoStream(gzip, aes.CreateDecryptor(), CryptoStreamMode.Read))
            using (StreamReader sr = new StreamReader(crypto))
            {
                Console.WriteLine("Decrypted: " + sr.ReadToEnd());
            }
        }

        // BinaryWriter и BinaryReader
        using (FileStream fs = new FileStream("binary.dat", FileMode.Create))
        using (BinaryWriter bw = new BinaryWriter(fs))
        {
            bw.Write(42);
            bw.Write("Binary test");
        }

        using (FileStream fs = new FileStream("binary.dat", FileMode.Open))
        using (BinaryReader br = new BinaryReader(fs))
        {
            int number = br.ReadInt32();
            string str = br.ReadString();
            Console.WriteLine($"BinaryReader: {number}, {str}");
        }
    }
}
