namespace TMake.LuaScript
{
    public static partial class Tool
    {
        public static bool IsOne<T>(T value, int bit) where T : struct, IConvertible, IComparable, IFormattable
        {
            return !IsZero(value, bit);
        }
        public static bool IsZero<T>(T value, int bit) where T : struct, IConvertible, IComparable, IFormattable
        {
            if (!typeof(T).IsEnum && !typeof(T).IsPrimitive)
                throw new ArgumentException("The type must be an enum or a primitive integer type.");

            return ((1 << bit) & Convert.ToInt64(value)) == 0;
        }
    }
}
