using System.Security.Cryptography;
using System.Text;

namespace Post.Application.Utils
{
    public static class CryptUtils
    {
        public static string EncryptPassword(string password)
        {
            var encryptedPassword = new StringBuilder();
            using (var hash = SHA256.Create()) {
                var enc = Encoding.UTF8;
                var result = hash.ComputeHash(enc.GetBytes(password));

                foreach (var b in result)
                    encryptedPassword.Append(b.ToString("x2"));
            }

            return encryptedPassword.ToString();
        }
    }
}