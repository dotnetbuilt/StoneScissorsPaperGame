using System.Text;

namespace Task3;

public static class Converter
{
    public static string ConvertFromByteToString(byte[] bytes)
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (byte b in bytes)
            stringBuilder.AppendFormat("{0:X2}", b);

        string hashString = stringBuilder.ToString();

        return hashString;
    }
}
