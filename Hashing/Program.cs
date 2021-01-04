using System;
using System.Collections.Generic;
using System.Text;

namespace Hashing
{
    class Program
    {
        static byte[] key = Hmac.GenerateKey();
        static void Main(string[] args)
        {
            List<string> options = new List<string>() { "Sha1", "Sha256", "Sha512", "Md5", "HMAC Sha1", "HMAC Sha256", "HMAC Sha512", "HMAC Md5" };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("HMAC KEY = {0}", Convert.ToBase64String(key));
                Console.WriteLine("Enter message to hash");
                byte[] message = Encoding.UTF8.GetBytes(Console.ReadLine());
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, options[i]);
                }
                HandleInput(int.Parse(Console.ReadLine()), message);
                Console.WriteLine();
                Console.WriteLine("Press any key to return...");
                Console.ReadLine();
            }
        }

        static void HandleInput(int input, byte[] message)
        {
            switch (input)
            {
                case 1:
                    string sha1 = Convert.ToBase64String(HashData.ComputeHashSha1(message));
                    Console.WriteLine(sha1);
                    break;
                case 2:
                    string sha256 = Convert.ToBase64String(HashData.ComputeHashSha256(message));
                    Console.WriteLine(sha256);
                    break;
                case 3:
                    string sha512 = Convert.ToBase64String(HashData.ComputeHashSha512(message));
                    Console.WriteLine(sha512);
                    break;
                case 4:
                    string md5 = Convert.ToBase64String(HashData.ComputeHashMd5(message));
                    Console.WriteLine(md5);
                    break;
                case 5:
                    string hsha1 = Convert.ToBase64String(Hmac.ComputeHmacsha1(message, key));
                    Console.WriteLine(hsha1);
                    break;
                case 6:
                    string hsha256 = Convert.ToBase64String(Hmac.ComputeHmacsha256(message, key));
                    Console.WriteLine(hsha256);
                    break;
                case 7:
                    string hsha512 = Convert.ToBase64String(Hmac.ComputeHmacsha512(message, key));
                    Console.WriteLine(hsha512);
                    break;
                case 8:
                    string hmd5 = Convert.ToBase64String(Hmac.ComputeHmacmd5(message, key));
                    Console.WriteLine(hmd5);
                    break;
                default:
                    break;
            }
        }
    }
}
