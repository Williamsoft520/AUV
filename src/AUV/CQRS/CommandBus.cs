using System.Linq;
using System.Reflection;

namespace System.CQRS
{
    /// <summary>
    /// 表示可发送命令处理的 <see cref="CommandBus"/> 总线。
    /// </summary>
    public static class CommandBus
    {
        /// <summary>
        /// 将指定命令对象发送到总线上。
        /// </summary>
        /// <typeparam name="TCommand">命令对象。</typeparam>
        /// <param name="command">要发送的命令对象。</param>
        /// <exception cref="System.InvalidOperationException">无法将当前的命令发送到命令总线，请查看内部异常</exception>
        public static void Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            try
            {
                //typeof(ICommandHandler<TCommand>)
                //    .GetType().get
                //    .Where(m => m.IsGenericType && m.GetGenericTypeDefinition() == typeof(ICommandHandler<TCommand>))
                //    .Select(m => (ICommandHandler<TCommand>)Activator.CreateInstance(m))
                //    .SingleOrDefault()?.Execute(command);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("命令总线在做命令处理时出现了异常，请查看内部异常", ex);
            }
        }
    }
}
