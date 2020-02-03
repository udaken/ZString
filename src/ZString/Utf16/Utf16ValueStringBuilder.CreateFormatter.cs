﻿using System;

namespace Cysharp.Text
{
    public ref partial struct Utf16ValueStringBuilder
    {
        static object CreateFormatter(Type type)
        {
            if (type == typeof(Byte))
            {
                return new TryFormat<Byte>((Byte x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(DateTime))
            {
                return new TryFormat<DateTime>((DateTime x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(DateTimeOffset))
            {
                return new TryFormat<DateTimeOffset>((DateTimeOffset x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(Decimal))
            {
                return new TryFormat<Decimal>((Decimal x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(Double))
            {
                return new TryFormat<Double>((Double x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(Guid))
            {
                return new TryFormat<Guid>((Guid x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(Int16))
            {
                return new TryFormat<Int16>((Int16 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(Int32))
            {
                return new TryFormat<Int32>((Int32 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(Int64))
            {
                return new TryFormat<Int64>((Int64 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(SByte))
            {
                return new TryFormat<SByte>((SByte x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(Single))
            {
                return new TryFormat<Single>((Single x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(TimeSpan))
            {
                return new TryFormat<TimeSpan>((TimeSpan x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(UInt16))
            {
                return new TryFormat<UInt16>((UInt16 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(UInt32))
            {
                return new TryFormat<UInt32>((UInt32 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }
            if (type == typeof(UInt64))
            {
                return new TryFormat<UInt64>((UInt64 x, Span<char> dest, out int written, ReadOnlySpan<char> format) => x.TryFormat(dest, out written, format));
            }

            return null;
        }
    }
}