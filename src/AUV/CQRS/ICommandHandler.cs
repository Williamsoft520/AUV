namespace System.CQRS
{
    /// <summary>
    /// 提供对命令进行执行的功能。每一种命令只能有一个 <see cref="ICommandHandler{TCommand}"/> 处理实例。
    /// </summary>
    /// <typeparam name="TCommand">命令类型。</typeparam>
    public interface ICommandHandler<in TCommand>
        where TCommand:ICommand
    {
        /// <summary>
        /// 对当前指定的命令进行执行处理。
        /// </summary>
        /// <param name="command">要处理的命令。</param>
        void Execute(TCommand command);
    }
}
