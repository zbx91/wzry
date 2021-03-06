﻿namespace com.tencent.pandora
{
    using System;
    using System.Runtime.InteropServices;

    public class LuaStringBuffer
    {
        public byte[] buffer;

        public LuaStringBuffer(byte[] buf)
        {
            this.buffer = buf;
        }

        public LuaStringBuffer(IntPtr source, int len)
        {
            this.buffer = new byte[len];
            Marshal.Copy(source, this.buffer, 0, len);
        }
    }
}

