using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.ShuntingYard
{

    /// <summary>
    /// 节点
    /// </summary>
    public abstract class Node
    {
        /// <summary>
        /// 节点类型
        /// </summary>
        public abstract NodeType NodeType { get; }

        /// <summary>
        /// 节点字符
        /// </summary>
        public string Text { get; set; }
    }
}
