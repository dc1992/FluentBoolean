namespace FluentBoolean
{
    public static class BoolExtensions
    {
        public static bool NOT(this bool @Value)
        {
            var result = !@Value;

            return result;
        }

        public static bool OR(this bool firstValue, bool secondValue, params bool[] additionalValues)
        {
            var result = firstValue || secondValue;

            foreach (var additionalValue in additionalValues)
                result = result || additionalValue;

            return result;
        }

        public static bool AND(this bool firstValue, bool secondValue, params bool[] additionalValues)
        {
            var result = firstValue && secondValue;

            foreach (var additionalValue in additionalValues)
                result = result && additionalValue;

            return result;
        }

        public static bool XOR(this bool firstValue, bool secondValue)
        {
            var result = firstValue != secondValue;

            return result;
        }

        public static bool NAND(this bool firstValue, bool secondValue)
        {
            var and = firstValue.AND(secondValue);
            var result = and.NOT();

            return result;
        }

        public static bool NOR(this bool firstValue, bool secondValue)
        {
            var or = firstValue.OR(secondValue);
            var result = or.NOT();

            return result;
        }

        public static bool XNOR(this bool firstValue, bool secondValue)
        {
            var xor = firstValue.XOR(secondValue);
            var result = xor.NOT();

            return result;
        }
    }
}