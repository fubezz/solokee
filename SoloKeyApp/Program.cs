using SoloKeeHmac;
using System;

namespace SoloKeyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HMACKeyProvider provider = new HMACKeyProvider();
            byte[] key = provider.GetKey(null);
            Console.WriteLine(provider.Name);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(key));
        }
    }
}
