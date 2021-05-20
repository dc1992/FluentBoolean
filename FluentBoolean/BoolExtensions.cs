namespace FluentBoolean
{
    public static class BoolExtensions
    {
        public static bool NOT(this bool @operator)
        {
            var result = !@operator;

            return result;
        }

        public static bool OR(this bool firstOperator, bool secondOperator)
        {
            var result = firstOperator || secondOperator;

            return result;
        }

        public static bool AND(this bool firstOperator, bool secondOperator)
        {
            var result = firstOperator && secondOperator;

            return result;
        }

        public static bool XOR(this bool firstOperator, bool secondOperator)
        {
            var result = firstOperator != secondOperator;

            return result;
        }

        public static bool NAND(this bool firstOperator, bool secondOperator)
        {
            var and = firstOperator.AND(secondOperator);
            var result = and.NOT();

            return result;
        }

        public static bool NOR(this bool firstOperator, bool secondOperator)
        {
            var or = firstOperator.OR(secondOperator);
            var result = or.NOT();

            return result;
        }

        public static bool XNOR(this bool firstOperator, bool secondOperator)
        {
            var xor = firstOperator.XOR(secondOperator);
            var result = xor.NOT();

            return result;
        }
    }
}