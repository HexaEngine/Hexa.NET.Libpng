namespace Hexa.NET.Libpng
{
    public unsafe struct SetJmpFloat128
    {
        public ulong High;
        public ulong Low;
    }

    public unsafe struct JmpBuf
    {
        public SetJmpFloat128 Buf_0;
        public SetJmpFloat128 Buf_1;
        public SetJmpFloat128 Buf_2;
        public SetJmpFloat128 Buf_3;
        public SetJmpFloat128 Buf_4;
        public SetJmpFloat128 Buf_5;
        public SetJmpFloat128 Buf_6;
        public SetJmpFloat128 Buf_7;
        public SetJmpFloat128 Buf_8;
        public SetJmpFloat128 Buf_9;
        public SetJmpFloat128 Buf_10;
        public SetJmpFloat128 Buf_11;
        public SetJmpFloat128 Buf_12;
        public SetJmpFloat128 Buf_13;
        public SetJmpFloat128 Buf_14;
        public SetJmpFloat128 Buf_15;
    }

    public unsafe struct PngWarningParameters
    {
        public PngWarningParameter Parameter_0;
        public PngWarningParameter Parameter_1;
        public PngWarningParameter Parameter_2;
        public PngWarningParameter Parameter_3;
        public PngWarningParameter Parameter_4;
        public PngWarningParameter Parameter_5;
        public PngWarningParameter Parameter_6;
        public PngWarningParameter Parameter_7;

        public PngWarningParameters(PngWarningParameter parameter_0, PngWarningParameter parameter_1, PngWarningParameter parameter_2, PngWarningParameter parameter_3, PngWarningParameter parameter_4, PngWarningParameter parameter_5, PngWarningParameter parameter_6, PngWarningParameter parameter_7)
        {
            Parameter_0 = parameter_0;
            Parameter_1 = parameter_1;
            Parameter_2 = parameter_2;
            Parameter_3 = parameter_3;
            Parameter_4 = parameter_4;
            Parameter_5 = parameter_5;
            Parameter_6 = parameter_6;
            Parameter_7 = parameter_7;
        }
    }

    public unsafe struct PngWarningParameter
    {
        public fixed byte Value[Libpng.PNG_WARNING_PARAMETER_SIZE];
    }

    public struct Tm
    {
        /// <summary>
        /// seconds after the minute - [0, 60] including leap second
        /// </summary>
        public int Sec;

        /// <summary>
        /// minutes after the hour - [0, 59]
        /// </summary>
        public int Min;

        /// <summary>
        /// hours since midnight - [0, 23]
        /// </summary>
        public int Hour;

        /// <summary>
        /// day of the month - [1, 31]
        /// </summary>
        public int Mday;

        /// <summary>
        /// months since January - [0, 11]
        /// </summary>
        public int Mon;

        /// <summary>
        /// years since 1900
        /// </summary>
        public int Year;

        /// <summary>
        /// days since Sunday - [0, 6]
        /// </summary>
        public int Wday;

        /// <summary>
        /// days since January 1 - [0, 365]
        /// </summary>
        public int YDay;

        /// <summary>
        /// daylight savings time flag
        /// </summary>
        public int IsDst;

        public Tm(int sec, int min, int hour, int mday, int mon, int year, int wday, int yDay, int isDst)
        {
            Sec = sec;
            Min = min;
            Hour = hour;
            Mday = mday;
            Mon = mon;
            Year = year;
            Wday = wday;
            YDay = yDay;
            IsDst = isDst;
        }
    };
}