namespace System.CQRS
{

    /// <summary>
    /// 表示继承该接口的都是属于事件领域驱动的对象。
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IEvent<out TKey>
    {
        /// <summary>
        /// 表示事件唯一的标识。
        /// </summary>
        TKey EventId { get; }
    }

    /// <summary>
    /// 提供使用 <see cref="System.Int32"/> 作为事件标识。
    /// </summary>
    public interface IIdentityEvent : IEvent<int>
    {

    }

    /// <summary>
    /// 提供使用 <see cref="System.Guid"/> 作为事件标识。
    /// </summary>
    public interface IUniqueIdentifierEvent : IEvent<Guid>
    {

    }
}
