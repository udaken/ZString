using System;
using System.Runtime.CompilerServices;

namespace Cysharp.Text
{
    public partial struct Utf16ValueStringBuilder
    {
        static unsafe void RegisterPrimitives()
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool SByteFunc(System.SByte x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return format.Length == 0 ? FastNumberWriter.TryWriteInt64(dest, out written, x) : x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.SByte>.TryFormatDelegate = &SByteFunc;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool Int16Func(System.Int16 x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return format.Length == 0 ? FastNumberWriter.TryWriteInt64(dest, out written, x) : x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.Int16>.TryFormatDelegate = &Int16Func;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool Int32Func(System.Int32 x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return format.Length == 0 ? FastNumberWriter.TryWriteInt64(dest, out written, x) : x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.Int32>.TryFormatDelegate = &Int32Func;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool Int64Func(System.Int64 x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return format.Length == 0 ? FastNumberWriter.TryWriteInt64(dest, out written, x) : x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.Int64>.TryFormatDelegate = &Int64Func;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool ByteFunc(System.Byte x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return format.Length == 0 ? FastNumberWriter.TryWriteUInt64(dest, out written, x) : x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.Byte>.TryFormatDelegate = &ByteFunc;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool UInt16Func(System.UInt16 x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return format.Length == 0 ? FastNumberWriter.TryWriteUInt64(dest, out written, x) : x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.UInt16>.TryFormatDelegate = &UInt16Func;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool UInt32Func(System.UInt32 x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return format.Length == 0 ? FastNumberWriter.TryWriteUInt64(dest, out written, x) : x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.UInt32>.TryFormatDelegate = &UInt32Func;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool UInt64Func(System.UInt64 x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return format.Length == 0 ? FastNumberWriter.TryWriteUInt64(dest, out written, x) : x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.UInt64>.TryFormatDelegate = &UInt64Func;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool SingleFunc(System.Single x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.Single>.TryFormatDelegate = &SingleFunc;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool DoubleFunc(System.Double x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.Double>.TryFormatDelegate = &DoubleFunc;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool TimeSpanFunc(System.TimeSpan x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.TimeSpan>.TryFormatDelegate = &TimeSpanFunc;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool DateTimeFunc(System.DateTime x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.DateTime>.TryFormatDelegate = &DateTimeFunc;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool DateTimeOffsetFunc(System.DateTimeOffset x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.DateTimeOffset>.TryFormatDelegate = &DateTimeOffsetFunc;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool DecimalFunc(System.Decimal x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.Decimal>.TryFormatDelegate = &DecimalFunc;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool GuidFunc(System.Guid x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                return x.TryFormat(dest, out written, format);
            }
            FormatterCache<System.Guid>.TryFormatDelegate = &GuidFunc;

            FormatterCache<System.Byte?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.DateTime?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.DateTimeOffset?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.Decimal?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.Double?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.Int16?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.Int32?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.Int64?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.SByte?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.Single?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.TimeSpan?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.UInt16?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.UInt32?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.UInt64?>.TryFormatDelegate = &NullableFormat;

            FormatterCache<System.Guid?>.TryFormatDelegate = &NullableFormat;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool IntPtrFunc(System.IntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                // ignore format
                return  System.IntPtr.Size == 4
                    ? x.ToInt32().TryFormat(dest, out written, default)
                    : x.ToInt64().TryFormat(dest, out written, default);
            }
            FormatterCache<System.IntPtr>.TryFormatDelegate = &IntPtrFunc;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool UIntPtrFunc(System.UIntPtr x, Span<char> dest, out int written, ReadOnlySpan<char> format)
            {
                // ignore format
                return  System.UIntPtr.Size == 4
                    ? x.ToUInt32().TryFormat(dest, out written, default)
                    : x.ToUInt64().TryFormat(dest, out written, default);
            }
            FormatterCache<System.UIntPtr>.TryFormatDelegate = &UIntPtrFunc;

        }
    }
}