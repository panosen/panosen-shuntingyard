using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.ShuntingYard
{
    /// <summary>
    /// 比较运算符优先级
    /// </summary>
    public interface IOperatorPriority
    {
        /// <summary>
        /// 比较两个运算符的优先级：数字越大，优先级越高。
        /// 如果返回大于0，则第一个的优先级更高；如果返回小于0，则第二个的优先级更高；如果返回等于0，则两个的优先级相等。
        /// </summary>
        int Compare(OpNode first, OpNode second);
    }

    /// <summary>
    /// 加减乘除
    /// </summary>
    public class ArithmeticOperatorPriority : IOperatorPriority
    {
        public int Compare(OpNode first, OpNode second)
        {
            return Calc(first.Text) - Calc(second.Text);
        }

        private static int Calc(string text)
        {
            switch (text)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
