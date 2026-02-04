namespace IOLink.NET.Vendors.Ifm;

internal class Converter
{
    public static byte[] FromHexString(string hex)
    {
        if (hex.Length % 2 != 0)
            throw new ArgumentException("Die hexadezimale Zeichenkette muss eine gerade Länge haben.");

        byte[] bytes = new byte[hex.Length / 2];

        for (int i = 0; i < bytes.Length; i++)
        {
            string hexPair = hex.Substring(i * 2, 2);
            bytes[i] = Convert.ToByte(hexPair, 16);
        }

        return bytes;
    }
}
