using System.Security.Cryptography;

namespace Task3;

public static class Key
{
    public static byte[] Generate(int length)
    {
        const int OneByteOnBits = 8;
        using RandomNumberGenerator rnd = RandomNumberGenerator.Create();

        byte[] bytes = new byte[length/OneByteOnBits];
         
        rnd.GetBytes(bytes);

        return bytes;
    }
}
