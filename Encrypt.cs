namespace Encrypt
{

    /// <summary>
    /// Encrypts a given string.
    /// </summary>
    public class Encrypt
    {
        
        public Encrypt()
        {

        }

        /// <summary>
        /// Encrypts the string into MD5.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>The encrypted string.</returns>
        public static string MD5(string str)
        {
            using (var x = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                var bs = System.Text.Encoding.UTF8.GetBytes(str);
                bs = x.ComputeHash(bs);
                var encstr = new System.Text.StringBuilder();
                foreach (byte b in bs)
                {
                    encstr.Append(b.ToString("x2").ToLower());
                }
                return encstr.ToString();
            }
        }
    }
}
