namespace Panosen.ShuntingYard
{
    /// <summary>
    /// 括号
    /// </summary>
    public sealed class LeftBracketNode : Node
    {
        /// <summary>
        /// 左括号
        /// </summary>
        public override NodeType NodeType => NodeType.LeftBracket;
    }
}
