using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore
{
    public class DelegateTest
    {
        private delegate int FuncTwoInts(int one, int two);

        private static int Add(int one, int two)
        {
            return one + two;
        }

        private FuncTwoInts theFunc = Add;


        FuncTwoInts theFunc2 = delegate (int one, int two)
        {
            return one + two;
        };


        FuncTwoInts theFunc1 = (one, two) =>
        {
            return one + two;
        };
    }
}
