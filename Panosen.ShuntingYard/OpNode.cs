namespace Panosen.ShuntingYard
{
    /// <summary>
    /// 运算符
    /// </summary>
    public class OpNode : Node
    {
        /// <summary>
        /// 运算符
        /// </summary>
        public override NodeType NodeType => NodeType.Operator;
    }
}
