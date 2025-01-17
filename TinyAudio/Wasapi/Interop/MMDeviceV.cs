﻿using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TinyAudio.Wasapi.Interop
{
    [SupportedOSPlatform(("windows"))]
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct MMDeviceV
    {
        public delegate* unmanaged[Stdcall]<MMDeviceInst*, Guid*, void**, uint> QueryInterface;
        public delegate* unmanaged[Stdcall]<MMDeviceInst*, uint> AddRef;
        public delegate* unmanaged[Stdcall]<MMDeviceInst*, uint> Release;

        public delegate* unmanaged[Stdcall]<MMDeviceInst*, Guid*, uint, void*, void**, uint> Activate;
        public IntPtr OpenPropertyStore;
        public IntPtr GetId;
        public IntPtr GetState;
    }
}
