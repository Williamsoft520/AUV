namespace System.CQRS
{
    /// <summary>
    /// 提供一种命令的基类。
    /// </summary>
    public abstract class Command : ICommand
    {
        /// <summary>
        /// 获取唯一的命令标识。
        /// </summary>
        public Guid CommandId => Guid.NewGuid();
    }
}
