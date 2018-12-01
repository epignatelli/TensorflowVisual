namespace BH.oM.Tensorflow
{
    public enum TFDataType : uint
    {
        /// <summary>
        /// The TFDataType has not been set
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Single precission floatint point, 32-bits (C# float)
        /// </summary>
        Float = 1,
        /// <summary>
        /// Double precission floatint point, 64-bits (C# double)
        /// </summary>
        Double = 2,
        /// <summary>
        /// 32-bit signed integers (C# int)
        /// </summary>
        Int32 = 3,
        /// <summary>
        /// 8 bit unsigned integers (C# byte)
        /// </summary>
        UInt8 = 4,
        /// <summary>
        /// 16-bit signed integers (C# short)
        /// </summary>
        Int16 = 5,
        /// <summary>
        /// 8-bit signed integers (C# sbyte)
        /// </summary>
        Int8 = 6,
        /// <summary>
        /// Binary blob
        /// </summary>
        String = 7,
        /// <summary>
        /// Single precission complex numbers (32-bit floats)
        /// </summary>
        Complex64 = 8,
        /// <summary>
        /// 32-bit float based complex numbers
        /// </summary>
        Complex = 8,
        /// <summary>
        /// 64-bit signed integers (C# long)
        /// </summary>
        Int64 = 9,
        /// <summary>
        /// 8-bit boolean (C# bool)
        /// </summary>
        Bool = 10,
        /// <summary>
        /// Quantized 8-bit signed integer
        /// </summary>
        QInt8 = 11,
        /// <summary>
        /// Quantized 8-bit unsigned integer
        /// </summary>
        QUInt8 = 12,
        /// <summary>
        /// Quantized 32-bit signed integer
        /// </summary>
        QInt32 = 13,
        /// <summary>
        /// Float32 truncated to 16 bits.  Only for cast operations.
        /// </summary>
        BFloat16 = 14,
        /// <summary>
        /// Quantized 16-bit signed integer
        /// </summary>
        QInt16 = 15,
        /// <summary>
        /// Quantized 16-bit unsigned integer
        /// </summary>
        QUInt16 = 16,
        /// <summary>
        /// 16-bit unsigned integers (C# long)
        /// </summary>
        UInt16 = 17,
        /// <summary>
        /// Double precission complex numbers (32-bit floats)
        /// </summary>
        Complex128 = 18,

        /// <summary>
        /// Half floats - 16-bit half precision floating point.
        /// </summary>
        Half = 19,

        /// <summary>
        /// Handle to a mutable resource.
        /// </summary>
        Resource = 20,

        /// <summary>
        /// Variant data type
        /// </summary>
        Variant = 21,

        /// <summary>
        /// 32-bit unsigned integers
        /// </summary>
        UInt32 = 22,

        /// <summary>
        /// 64-bit unsigned integers
        /// </summary>
        UInt64 = 23
    }
}