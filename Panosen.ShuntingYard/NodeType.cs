namespace Panosen.ShuntingYard
{
    /// <summary>
    /// 节点类型
    /// </summary>
    public enum NodeType
    {
        /// <summary>
        /// 基础节点，例如数字
        /// </summary>
        Basic,

        /// <summary>
        /// 操作符节点，例如加减乘除
        /// </summary>
        Operator,

        /// <summary>
        /// 左括号
        /// </summary>
        LeftBracket,

        /// <summary>
        /// 右括号
        /// </summary>
        RightBracket
    }
}
