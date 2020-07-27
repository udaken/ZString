using System.Runtime.CompilerServices;

namespace Cysharp.Text
{
    public static partial class ZString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ConcatInternal<T>(ref Utf16ValueStringBuilder sb, T arg)
        {
            if (typeof(T) == typeof(string))
            {
                if (arg != null)
                {
                    sb.Append(Unsafe.As<string>(arg));
                }
            }
#if true
            else if (typeof(T) == typeof(System.Byte))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.DateTime))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.DateTimeOffset))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.Decimal))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.Double))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.Int16))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.Int32))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.Int64))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.SByte))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.Single))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.TimeSpan))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.UInt16))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.UInt32))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.UInt64))
            {
                sb.Append(arg);
            }
            else if (typeof(T) == typeof(System.Guid))
            {
                sb.Append(arg);
            }
#endif
            else
            {
                sb.Append(arg);
            }
        }
        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1>(T1 arg1)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2>(T1 arg1, T2 arg2)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                    ConcatInternal(ref sb, arg8);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                    ConcatInternal(ref sb, arg8);

                    ConcatInternal(ref sb, arg9);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                    ConcatInternal(ref sb, arg8);

                    ConcatInternal(ref sb, arg9);

                    ConcatInternal(ref sb, arg10);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                    ConcatInternal(ref sb, arg8);

                    ConcatInternal(ref sb, arg9);

                    ConcatInternal(ref sb, arg10);

                    ConcatInternal(ref sb, arg11);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                    ConcatInternal(ref sb, arg8);

                    ConcatInternal(ref sb, arg9);

                    ConcatInternal(ref sb, arg10);

                    ConcatInternal(ref sb, arg11);

                    ConcatInternal(ref sb, arg12);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                    ConcatInternal(ref sb, arg8);

                    ConcatInternal(ref sb, arg9);

                    ConcatInternal(ref sb, arg10);

                    ConcatInternal(ref sb, arg11);

                    ConcatInternal(ref sb, arg12);

                    ConcatInternal(ref sb, arg13);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                    ConcatInternal(ref sb, arg8);

                    ConcatInternal(ref sb, arg9);

                    ConcatInternal(ref sb, arg10);

                    ConcatInternal(ref sb, arg11);

                    ConcatInternal(ref sb, arg12);

                    ConcatInternal(ref sb, arg13);

                    ConcatInternal(ref sb, arg14);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                    ConcatInternal(ref sb, arg8);

                    ConcatInternal(ref sb, arg9);

                    ConcatInternal(ref sb, arg10);

                    ConcatInternal(ref sb, arg11);

                    ConcatInternal(ref sb, arg12);

                    ConcatInternal(ref sb, arg13);

                    ConcatInternal(ref sb, arg14);

                    ConcatInternal(ref sb, arg15);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

        /// <summary>Concatenates the string representation of some specified objects.</summary>
        public static string Concat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            var sb = new Utf16ValueStringBuilder(true);
            try
            {
                    ConcatInternal(ref sb, arg1);

                    ConcatInternal(ref sb, arg2);

                    ConcatInternal(ref sb, arg3);

                    ConcatInternal(ref sb, arg4);

                    ConcatInternal(ref sb, arg5);

                    ConcatInternal(ref sb, arg6);

                    ConcatInternal(ref sb, arg7);

                    ConcatInternal(ref sb, arg8);

                    ConcatInternal(ref sb, arg9);

                    ConcatInternal(ref sb, arg10);

                    ConcatInternal(ref sb, arg11);

                    ConcatInternal(ref sb, arg12);

                    ConcatInternal(ref sb, arg13);

                    ConcatInternal(ref sb, arg14);

                    ConcatInternal(ref sb, arg15);

                    ConcatInternal(ref sb, arg16);

                return sb.ToString();
            }
            finally
            {
                sb.Dispose();
            }
        }

    }
}