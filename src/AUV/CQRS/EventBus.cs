using System.Linq;

namespace System.CQRS
{
    /// <summary>
    /// 表示事件驱动的总线。
    /// </summary>
    public static class EventBus
    {
        /// <summary>
        /// 通知事件总线对指定的事件进行发布。
        /// </summary>
        /// <typeparam name="TEvent">事件类型。</typeparam>
        /// <typeparam name="TKey">事件类型的主键。</typeparam>
        /// <param name="event">要发布的事件对象。</param>
        /// <exception cref="System.InvalidOperationException">事件总线在做事件处理时出现了异常，请查看内部异常</exception>
        public static void Publish<TEvent, TKey>(TEvent @event)
            where TEvent : IEvent<TKey>
        {
            try
            {
                //typeof(IEventHandler<TEvent, TKey>).Assembly.ExportedTypes
                //    .Where(m => m.IsGenericType && m.IsInterface
                //    && m.GetGenericTypeDefinition() == typeof(IEventHandler<TEvent, TKey>))
                //    .Select(m => (IEventHandler<TEvent, TKey>)Activator.CreateInstance(m))
                //    .ToList()
                //    .ForEach(item =>
                //    {
                //        item.Handle(@event);
                //    });
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("事件总线在做事件处理时出现了异常，请查看内部异常", ex);
            }
        }
    }
}
