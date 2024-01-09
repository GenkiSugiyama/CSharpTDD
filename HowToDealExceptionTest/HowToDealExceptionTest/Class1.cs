using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToDealExceptionTest
{
    public class Class1
    {
        public static int Add(int a, int b)
        {
            // 入力値がマイナスの場合はエラーをとばす要件を追加する
            if (a < 0)
            {
                throw new InputException("マイナス値は入力できません");
            }
            return a + b;
        }
    }
}
