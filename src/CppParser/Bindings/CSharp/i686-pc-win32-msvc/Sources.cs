//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace Parser
    {
        public unsafe partial struct SourceLocation
        {
            [StructLayout(LayoutKind.Explicit, Size = 4)]
            public partial struct Internal
            {
                [FieldOffset(0)]
                public uint ID;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0SourceLocation@CppParser@CppSharp@@QAE@XZ")]
                internal static extern global::System.IntPtr ctor_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0SourceLocation@CppParser@CppSharp@@QAE@I@Z")]
                internal static extern global::System.IntPtr ctor_1(global::System.IntPtr instance, uint ID);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0SourceLocation@CppParser@CppSharp@@QAE@ABU012@@Z")]
                internal static extern global::System.IntPtr cctor_2(global::System.IntPtr instance, global::System.IntPtr _0);
            }

            private SourceLocation.Internal __instance;
            public SourceLocation.Internal __Instance { get { return __instance; } }

            public static SourceLocation __CreateInstance(global::System.IntPtr native)
            {
                return new SourceLocation((SourceLocation.Internal*) native);
            }

            public static SourceLocation __CreateInstance(SourceLocation.Internal native)
            {
                return new SourceLocation(native);
            }

            private SourceLocation(SourceLocation.Internal native)
                : this()
            {
                __instance = native;
            }

            private SourceLocation(SourceLocation.Internal* native, bool isInternalImpl = false) : this()
            {
                __instance = *native;
            }

            public SourceLocation(uint ID)
                : this()
            {
                fixed (Internal* __instancePtr = &__instance)
                {
                    Internal.ctor_1(new global::System.IntPtr(__instancePtr), ID);
                }
            }

            public SourceLocation(CppSharp.Parser.SourceLocation _0)
                : this()
            {
                var __arg0 = _0.__Instance;
                var arg0 = new global::System.IntPtr(&__arg0);
                fixed (Internal* __instancePtr = &__instance)
                {
                    Internal.cctor_2(new global::System.IntPtr(__instancePtr), arg0);
                }
            }

            public uint ID
            {
                get
                {
                    return __instance.ID;
                }

                set
                {
                    __instance.ID = value;
                }
            }
        }
    }
}
