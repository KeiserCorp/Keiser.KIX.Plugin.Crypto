namespace Keiser.MvxPlugins.Crypto
{
    using System.Security.Cryptography;

    public class Crypto : ICrypto
    {
        public Crypto() { }

        protected static SHA1 _sha1 = SHA1.Create();

        public byte[] GetSHA1(byte[] data)
        {
            return _sha1.ComputeHash(data);
        }
    }
}
