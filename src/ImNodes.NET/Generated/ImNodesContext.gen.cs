using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace imnodesNET
{
    public unsafe partial struct ImNodesContext
    {
    }
    public unsafe partial struct ImNodesContextPtr
    {
        public ImNodesContext* NativePtr { get; }
        public ImNodesContextPtr(ImNodesContext* nativePtr) => NativePtr = nativePtr;
        public ImNodesContextPtr(IntPtr nativePtr) => NativePtr = (ImNodesContext*)nativePtr;
        public static implicit operator ImNodesContextPtr(ImNodesContext* nativePtr) => new ImNodesContextPtr(nativePtr);
        public static implicit operator ImNodesContext* (ImNodesContextPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImNodesContextPtr(IntPtr nativePtr) => new ImNodesContextPtr(nativePtr);
    }
}
