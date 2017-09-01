namespace System.CQRS
{
    /// <summary>
    /// 表示一种命令类型。
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 表示唯一的命令标识。
        /// </summary>
        Guid CommandId { get; }
    }
}
