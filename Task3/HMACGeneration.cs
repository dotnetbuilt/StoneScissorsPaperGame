using System.Security.Cryptography;

namespace Task3;

public static class HMACGeneration
{
    public static byte[] Generate(byte[] key, string message)
    {
        var messageBased64 = System.Text.Encoding.UTF8.GetBytes(message);

        var hash = new HMACSHA256(key);

        return hash.ComputeHash(messageBased64);
    }
}
