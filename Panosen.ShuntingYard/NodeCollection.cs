using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.ShuntingYard
{
    /// <summary>
    /// 节点集合
    /// </summary>
    public class NodeCollection
    {
        public List<Node> Nodes { get; set; }
    }

    /// <summary>
    /// 节点集合扩展
    /// </summary>
    public static class NodeCollectionExtension
    {
        /// <summary>
        /// 增加一个节点
        /// </summary>
        public static NodeCollection AddNode(this NodeCollection nodeCollection, Node node)
        {
            if (nodeCollection.Nodes == null)
            {
                nodeCollection.Nodes = new List<Node>();
            }

            nodeCollection.Nodes.Add(node);
            return nodeCollection;
        }

        /// <summary>
        /// 增加一个节点
        /// </summary>
        public static TNode AddNode<TNode>(this NodeCollection nodeCollection, string text = null)
            where TNode : Node, new()
        {
            if (nodeCollection.Nodes == null)
            {
                nodeCollection.Nodes = new List<Node>();
            }

            TNode node = new TNode();
            node.Text = text;

            nodeCollection.Nodes.Add(node);
            return node;
        }

        /// <summary>
        /// 增加一个节点
        /// </summary>
        public static LeftBracketNode AddLeftBracket(this NodeCollection nodeCollection)
        {
            var node = AddNode<LeftBracketNode>(nodeCollection);
            node.Text = "(";
            return node;
        }

        /// <summary>
        /// 增加一个节点
        /// </summary>
        public static RightBracketNode AddRightBracket(this NodeCollection nodeCollection)
        {
            var node = AddNode<RightBracketNode>(nodeCollection);
            node.Text = ")";
            return node;
        }
    }
}
