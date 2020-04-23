using System;
using SoloKee;

namespace SoloKeyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SoloKeyWrapper provider = new SoloKeyWrapper("D:/Program Files (x86)/Python/Scripts/solo.exe");
            try
            {
                string credId = provider.createCredWithHMACExt();
                Console.WriteLine("----");
                Console.WriteLine(credId);
                provider.getChallengeResponse(credId);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            //Console.WriteLine(System.Text.Encoding.UTF8.GetString(key));
        }
    }
}
