using System;
using System.Collections.Generic;
using System.Text;

namespace IOLink.NET;

#if NETSTANDARD2_0
public static class ByteExtensions
{
    public static string ToHexString(this ReadOnlySpan<byte> data)
    {
        if (data == null)
            throw new ArgumentNullException(nameof(data));

        var sb = new System.Text.StringBuilder(data.Length * 2);
        foreach (var b in data)
        {
            sb.AppendFormat("{0:x2}", b);
        }
        return sb.ToString();
    }


    public static float ReadSingleBigEndian(this ReadOnlySpan<byte> data, int startIndex = 0)
    {
        if (data == null)
            throw new ArgumentNullException(nameof(data));
        if (data.Length < startIndex + 4)
            throw new ArgumentException("Not enough bytes to read a Single.");

        // Extract 4 bytes in big-endian order
        byte[] bytes =
        [
            data[startIndex + 3],
            data[startIndex + 2],
            data[startIndex + 1],
            data[startIndex + 0],
        ];

        // Convert to float using BitConverter (which expects little-endian on most platforms)
        return BitConverter.ToSingle(bytes, 0);
    }

    public static void WriteSingleBigEndian(this byte[]? destination, float value, int startIndex = 0)
    {
        if (destination == null)
            throw new ArgumentNullException(nameof(destination));
        if (destination.Length < startIndex + 4)
            throw new ArgumentException("Destination array is too small.");

        // Get bytes in platform endianness (usually little-endian)
        byte[] bytes = BitConverter.GetBytes(value);

        // Reverse bytes for big-endian
        destination[startIndex] = bytes[3];
        destination[startIndex + 1] = bytes[2];
        destination[startIndex + 2] = bytes[1];
        destination[startIndex + 3] = bytes[0];
    }

}
#endif