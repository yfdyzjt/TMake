using System.Runtime.InteropServices;

namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static T[] BinaryToInvGrayCodeAny<T>(T[] value) where T : struct, IConvertible, IComparable, IFormattable
        {
            return BinaryToInvGrayCodeAnyCarry(value, default);
        }
        public static T[] BinaryToInvGrayCodeAnyCarry<T>(T[] value, T carry) where T : struct, IConvertible, IComparable, IFormattable
        {
            return BinaryToInvGrayCodeAnyCarryRef(value, ref carry);
        }
        public static T[] BinaryToInvGrayCodeAnyCarryRef<T>(T[] value, ref T carry) where T : struct, IConvertible, IComparable, IFormattable
        {
            T[] result = new T[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                result[i] = BinaryToInvGrayCodeCarryRef(value[i], ref carry);
            }

            return result;
        }
        public static T BinaryToInvGrayCode<T>(T value) where T : struct, IConvertible, IComparable, IFormattable
        {
            return BinaryToInvGrayCodeCarry(value, default);
        }
        public static T BinaryToInvGrayCodeCarry<T>(T value, T carry) where T : struct, IConvertible, IComparable, IFormattable
        {
            return BinaryToInvGrayCodeCarryRef(value, ref carry);
        }
        public static T BinaryToInvGrayCodeCarryRef<T>(T value, ref T carry) where T : struct, IConvertible, IComparable, IFormattable
        {
            if (!typeof(T).IsEnum && !typeof(T).IsPrimitive)
                throw new ArgumentException("The type must be an enum or a primitive integer type.");

            int size = Marshal.SizeOf<T>() * 8;

            dynamic carValue = carry;
            dynamic binValue = value;

            dynamic grayValue = binValue ^ (binValue << 1) ^ carValue;

            carry = (T)((binValue >> (size - 1)) & 1);
            return (T)grayValue;
        }
        public static T[] InvGrayCodeToBinaryAny<T>(T[] value) where T : struct, IConvertible, IComparable, IFormattable
        {
            return InvGrayCodeToBinaryAnyCarry(value, default);
        }
        public static T[] InvGrayCodeToBinaryAnyCarry<T>(T[] value, T carry) where T : struct, IConvertible, IComparable, IFormattable
        {
            return InvGrayCodeToBinaryAnyCarryRef(value, ref carry);
        }
        public static T[] InvGrayCodeToBinaryAnyCarryRef<T>(T[] value, ref T carry) where T : struct, IConvertible, IComparable, IFormattable
        {
            T[] result = new T[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                result[i] = InvGrayCodeToBinaryCarryRef(value[i], ref carry);
            }

            return result;
        }
        public static T InvGrayCodeToBinary<T>(T value) where T : struct, IConvertible, IComparable, IFormattable
        {
            return InvGrayCodeToBinaryCarry(value, default);
        }
        public static T InvGrayCodeToBinaryCarry<T>(T value, T carry) where T : struct, IConvertible, IComparable, IFormattable
        {
            return InvGrayCodeToBinaryCarryRef(value, ref carry);
        }
        public static T InvGrayCodeToBinaryCarryRef<T>(T value, ref T carry) where T : struct, IConvertible, IComparable, IFormattable
        {
            if (!typeof(T).IsEnum && !typeof(T).IsPrimitive)
                throw new ArgumentException("The type must be an enum or a primitive integer type.");

            int size = Marshal.SizeOf<T>() * 8;

            dynamic carValue = carry;
            dynamic grayValue = value ^ carValue;

            dynamic binValue = grayValue;

            for (int i = 0; i < size; i++)
            {
                grayValue <<= 1;
                binValue ^= grayValue;
            }

            carry = (T)((binValue >> (size - 1)) & 1);
            return (T)binValue;
        }
    }
}
