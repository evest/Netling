﻿namespace Netling.Core.Extensions
{
    internal static class ByteExtensions
    {
        public static int ConvertToInt(this byte[] bytes, int start, int length, int end)
        {
            var result = 0;

            if (end < start + length)
                return result;

            for (var i = 0; i < length; i++)
            {
                result = result * 10 + (bytes[start + i] - '0');
            }

            return result;
        }
    }
}
