namespace AUV.Data
{
    using System.Threading.Tasks;
    /// <summary>
    /// 表示工作单元。
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IUnitOfWork : System.IDisposable
    {
        /// <summary>
        /// 表示使用异步的方式将当前的工作单元完结。
        /// </summary>
        /// <exception cref="System.InvalidOperationException"></exception>
        Task CompleteAsync();
    }
}
