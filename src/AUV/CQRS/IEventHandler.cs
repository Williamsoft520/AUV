namespace System.CQRS
{
    /// <summary>
    /// 提供事件处理的功能。
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public interface IEventHandler<in TEvent, out TKey>
        where TEvent : IEvent<TKey>
    {
        /// <summary>
        /// 为订阅的事件进行处理。
        /// </summary>
        /// <param name="e">需要处理的事件对象。</param>
        void Handle(TEvent e);
    }
}
