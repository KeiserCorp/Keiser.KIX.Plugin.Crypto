namespace Keiser.KIX.Plugin.Crypto
{
    public interface ICrypto
    {
        byte[] GetSHA1(byte[] data);
    }
}
