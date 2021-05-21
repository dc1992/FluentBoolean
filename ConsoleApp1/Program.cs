using System;
using FluentBoolean;

namespace ConsoleApp1
{
    class Program
    {
        public void Test()
        {
            var fluentResult = true
                .OR(false)
                .OR(true)
                .OR(true);

            var classicResult = true || false || true || true;

            //fluentResult and classicResult produce the same result
        }
    }
}
