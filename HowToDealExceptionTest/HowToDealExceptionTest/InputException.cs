using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToDealExceptionTest
{
    public sealed class InputException : Exception
    {
        /// <summary>
        /// 入力値エラー用クラス
        /// </summary>
        /// <param name="message"></param>
        public InputException(string message) : base(message)
        {

        }
    }
}
