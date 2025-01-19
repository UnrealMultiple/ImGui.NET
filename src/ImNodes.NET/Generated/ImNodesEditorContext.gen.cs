using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace imnodesNET
{
    public unsafe partial struct ImNodesEditorContext
    {
    }
    public unsafe partial struct ImNodesEditorContextPtr
    {
        public ImNodesEditorContext* NativePtr { get; }
        public ImNodesEditorContextPtr(ImNodesEditorContext* nativePtr) => NativePtr = nativePtr;
        public ImNodesEditorContextPtr(IntPtr nativePtr) => NativePtr = (ImNodesEditorContext*)nativePtr;
        public static implicit operator ImNodesEditorContextPtr(ImNodesEditorContext* nativePtr) => new ImNodesEditorContextPtr(nativePtr);
        public static implicit operator ImNodesEditorContext* (ImNodesEditorContextPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImNodesEditorContextPtr(IntPtr nativePtr) => new ImNodesEditorContextPtr(nativePtr);
    }
}
