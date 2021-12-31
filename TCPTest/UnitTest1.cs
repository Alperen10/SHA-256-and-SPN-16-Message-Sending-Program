using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TCPClient;

namespace TCPTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]

        //String to binary test method
        public void StringToBinary()
        {
            SPN spn = new SPN("turkey","password");
            string result = spn.StringToBinary("turkey");
            Assert.AreEqual("011101000111010101110010011010110110010101111001", result);
        }

        [TestMethod]
        //Binary to string test method
        public void BinaryToString()
        {
            SPN spn = new SPN("turkey", "password");
            string result = spn.BinaryToString("1100111111101001");
            Assert.AreEqual("??", result);
        }

 
        [TestMethod]

        //SPN-16 decryption test method
        public void Decrypt()
        {
            SPN spn = new SPN("turkey", "password");
            string result = spn.Decrypt("110011111101110100001111011001010110110111111101");
            Assert.AreEqual("turkey", result);
        }

 

        [TestMethod]
        //SPN-16 encryption test method
        public void EncryptSPN()
        {
            SPN spn = new SPN("turkey", "password");
            string result = spn.Encrypt();
            Assert.AreEqual("110011111101110100001111011001010110110111111101", result);
           
        }

        [TestMethod]
        //SHA-256 encryption test method
        public void EncryptSHA()
        {
            SHA sha = new SHA("turkey");
            string result = sha.Encrypt();
            Assert.AreEqual("8d7d5397f8842b4181d38bc57b85b9ff1860456f92872c43f991a904c45062d5", result);
        }
    }
}
