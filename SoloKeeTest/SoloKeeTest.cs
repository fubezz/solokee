using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SoloKeeHmac;

namespace SoloKeeTest
{
    [TestClass]
    public class SoloKeeTest
    {
        [TestMethod]
        public void TestGetKey()
        {
            HMACKeyProvider provider = new HMACKeyProvider();
            byte[] key = provider.GetKey(null);
            Console.WriteLine(provider.Name);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(key));
            Assert.IsFalse(key.Length == 0, String.Format("Expected Key but result is 0 length"));
        }
    }
}
