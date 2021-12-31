using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    public class SPN
    {
        private string plainText, binPlainText, key, binKey, kBox = "", cipherText;


        #region Constructors
        public SPN(string key)
        {
            this.key = key;
            this.binKey = this.StringToBinary(this.key);
        }
        public SPN(string plain_Text, string key)
        {
            this.key = key;
            this.binKey = this.StringToBinary(this.key);
            this.plainText = plain_Text;
            this.binPlainText = this.StringToBinary(this.plainText);
        }

        public SPN()
        {
        }
        #endregion

        #region Convert to Binary/ to String
        //Convert string to binary
        public string StringToBinary(string data)
        {
            string binary = "";
            for (int i = 0; i < data.Length; i++)
            {
                binary += Convert.ToString(data[i], 2).PadLeft(8, '0');
            }

            return binary;
        }

        //Convert binary to string
        public string BinaryToString(string encodingtxt)
        {
            //Use your encoding here
            Encoding encoding = System.Text.Encoding.ASCII;

            string binaryString = encodingtxt.Replace(" ", "");

            var bytes = new byte[binaryString.Length / 8];

            var iLength = (int)(binaryString.Length / 8);

            for (var i = 0; i < iLength; i++)
            {
                bytes[i] = Convert.ToByte(binaryString.Substring(i * 8, 8), 2);
            }

            string str = encoding.GetString(bytes);

            return str;

        }

        #endregion

        #region XOR
        //XOR method
        public string Xor(string text, string key)
        {
            string binXor = "";
            int xor = 0;
            for (int i = 0; i < 16; i++)
            {
                xor = Convert.ToInt32(text[i]) ^ Convert.ToInt32(key[i]);
                binXor += xor.ToString();
            }
            return binXor;
        }
        #endregion

        #region Substitution
        public string Substitution(string data)
        {
            string plainData = "";
            plainData += data[2]; plainData += data[8]; plainData += data[12]; plainData += data[5];
            plainData += data[9]; plainData += data[0]; plainData += data[14]; plainData += data[4];
            plainData += data[11]; plainData += data[1]; plainData += data[15]; plainData += data[6];
            plainData += data[3]; plainData += data[10]; plainData += data[7]; plainData += data[13];


            return plainData;
        }

        private string RSubstitution(string data)
        {
            string rData = "";
            rData += data[5]; rData += data[9]; rData += data[0]; rData += data[12];
            rData += data[7]; rData += data[3]; rData += data[11]; rData += data[14];
            rData += data[1]; rData += data[4]; rData += data[13]; rData += data[8];
            rData += data[2]; rData += data[15]; rData += data[6]; rData += data[10];




            return rData;

        }
        #endregion

        #region encrypt-decrypt
        //SPN-16 encryption method
        public string Encrypt()
        {

            string xor = "";
            string data = this.binPlainText;

            for (int i = 0; i < this.binPlainText.Length; i += 16)
            {
                data = this.binPlainText.Substring(i, 16);//Take 2 character of text(binary version)

                for (int j = 0; j < 64; j += 16)//Take 2 character of key(binary version)
                {
                    xor = this.Xor(data, this.binKey.Substring(j, 16));

                    if (j < 32)
                    {
                        kBox = this.Substitution(xor);
                    }
                    else
                    {
                        kBox = xor;
                    }

                    data = kBox;

                }
                this.cipherText += data;
            }

            return this.cipherText;
        }

        //SPN-16 decryption method
        public string Decrypt(string data)
        {

            string xor = "";
            string plain_Text = "";
            string cipher_Text = data;

            for (int i = 0; i < cipher_Text.Length; i += 16)
            {
                data = cipher_Text.Substring(i, 16);//Take 2 character of crypted text(binary version)

                for (int j = 48; j >= 0; j -= 16)//Take 2 character of key(binary version)
                {
                    xor = this.Xor(data, this.binKey.Substring(j, 16));

                    if (j == 48 || j == 0)
                    {
                        kBox = xor;
                    }
                    else
                    {
                        kBox = this.RSubstitution(xor);
                    }

                    data = kBox;

                }

                plain_Text += data;
            }

            return this.BinaryToString(plain_Text);//plain_Text is binary string so we have to convert it to  string
        }

        #endregion
    }
}
