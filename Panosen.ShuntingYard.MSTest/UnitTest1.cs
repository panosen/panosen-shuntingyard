using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace Panosen.ShuntingYard.MSTest
{
    /// <summary>
    /// https://baike.baidu.com/item/%E8%B0%83%E5%BA%A6%E5%9C%BA%E7%AE%97%E6%B3%95/23121016?fr=aladdin
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Àƒ‘Ú‘ÀÀ„
        /// </summary>
        private readonly ArithmeticOperatorPriority arithmeticOperatorPriority = new ArithmeticOperatorPriority();

        [TestMethod]
        public void TestMethod1()
        {
            var text = "A+B*C/D";

            var expected = "ABC*D/+";

            var actual = ToText(ShuntingYardAlgorithm.Transform(ToNodeCollection(text), arithmeticOperatorPriority));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var text = "A+B-C*D";

            var expected = "AB+CD*-";

            var actual = ToText(ShuntingYardAlgorithm.Transform(ToNodeCollection(text), arithmeticOperatorPriority));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var text = "3+2*4-1";

            var expected = "324*+1-";

            var actual = ToText(ShuntingYardAlgorithm.Transform(ToNodeCollection(text), arithmeticOperatorPriority));

            Assert.AreEqual(expected, actual);
        }

        private static NodeCollection ToNodeCollection(string text)
        {
            NodeCollection nodes = new NodeCollection();

            foreach (var item in text)
            {
                switch (item)
                {
                    case '(':
                        nodes.AddLeftBracket();
                        break;
                    case ')':
                        nodes.AddRightBracket();
                        break;
                    case '+':
                    case '-':
                        {
                            var node = nodes.AddNode<OpNode>(item.ToString());
                        }
                        break;
                    case '*':
                    case '/':
                        {
                            var node = nodes.AddNode<OpNode>(item.ToString());
                        }
                        break;
                    default:
                        {
                            nodes.AddNode<BasicNode>(item.ToString());
                        }
                        break;
                }
            }

            return nodes;
        }

        private static string ToText(NodeCollection nodes)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in nodes.Nodes)
            {
                builder.Append(item.Text);
            }

            return builder.ToString();
        }
    }
}
