using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SoloKee;

namespace SoloKeeTest
{
    [TestClass]
    public class SoloKeeTest
    {
        [TestMethod]
        public void TestGetKey()
        {
            SoloKeyProvider provider = new SoloKeyProvider();
            byte[] key = provider.GetKey(null);
            Console.WriteLine(provider.Name);
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(key));
            Assert.IsFalse(key.Length == 0, String.Format("Expected Key but result is 0 length"));
        }
    }
}
