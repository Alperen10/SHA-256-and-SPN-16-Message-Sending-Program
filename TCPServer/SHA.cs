using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    public class SHA
    {
        private string plainText;
        #region Constructor
        public SHA(string plain_Text)
        {
            this.plainText = plain_Text;
        }
        #endregion

        #region Encrypt
        //SHA-256 encryption method
        public string Encrypt()
        {
            SHA256Managed sha256 = new SHA256Managed();
            Byte[] vs = Encoding.ASCII.GetBytes(this.plainText);
            vs = sha256.ComputeHash(vs);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in vs)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();

        }
        #endregion
    }
}
