using System;

namespace Python.Test
{
    //========================================================================
    // Supports CLR enum unit tests.
    //========================================================================

    public enum ByteEnum : byte
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five
    }

    public enum SByteEnum : sbyte
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five
    }

    public enum ShortEnum : short
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five
    }

    public enum UShortEnum : ushort
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five
    }

    public enum IntEnum : int
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five
    }

    public enum UIntEnum : uint
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five
    }

    public enum LongEnum : long
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five
    }

    public enum ULongEnum : ulong
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five
    }

    [FlagsAttribute]
    public enum FlagsEnum
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five
    }
}