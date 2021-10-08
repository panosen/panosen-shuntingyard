using System;
using System.Collections.Generic;

namespace Panosen.ShuntingYard
{
    public class ShuntingYardAlgorithm
    {
        public static NodeCollection Transform(NodeCollection text, IOperatorPriority operatorPriority)
        {
            NodeCollection output = new NodeCollection();
            Stack<Node> ops = new Stack<Node>();

            foreach (var ch in text.Nodes)
            {
                switch (ch.NodeType)
                {
                    case NodeType.Basic:
                        {
                            output.AddNode(ch);
                        }
                        break;
                    case NodeType.Operator:
                        {
                            while (ops.Count > 0 && ops.Peek().NodeType == NodeType.Operator && operatorPriority.Compare((OpNode)ops.Peek(), (OpNode)ch) >= 0)
                            {
                                output.AddNode(ops.Pop());
                                if (ops.Count == 0)
                                {
                                    break;
                                }
                            }
                            ops.Push(ch);
                        }
                        break;
                    case NodeType.LeftBracket:
                        {
                            ops.Push(ch);
                        }
                        break;
                    case NodeType.RightBracket:
                        {
                            while (ops.Count > 0 && ops.Peek().NodeType != NodeType.LeftBracket)
                            {
                                output.AddNode(ops.Pop());
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            while (ops.Count > 0 && ops.Peek().NodeType != NodeType.LeftBracket)
            {
                output.AddNode(ops.Pop());
            }

            return output;
        }
    }
}
