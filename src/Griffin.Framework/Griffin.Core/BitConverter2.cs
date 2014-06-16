﻿using System;

namespace Griffin
{
    /// <summary>
    /// Missing <see cref="BitConverter"/> methods.
    /// </summary>
    public static class BitConverter2
    {
        public static void GetBytes(int value, byte[] destination, int offset)
        {
            destination[offset] = (byte)(value & 0xff);
            destination[offset + 1] = (byte)((value >> 8) & 0xff);
            destination[offset + 2] = (byte)((value >> 16) & 0xff);
            destination[offset + 3] = (byte)(value >> 24);
        }

        public static void GetBytes(short value, byte[] destination, int offset)
        {
            destination[offset] = (byte)(value & 0xff);
            destination[offset + 1] = (byte)((value >> 8) & 0xff);
        }
    }
}
