

using System.Collections.Generic;
using System.Threading.Tasks;

namespace AUV.Data
{
    /// <summary>
    /// 提供进行自定义 SQL 命令的操作功能。
    /// </summary>
    public interface ISqlCommand
    {
        /// <summary>
        /// 异步查询指定命令并返回指定类型的集合。
        /// </summary>
        /// <typeparam name="T">查询结果类型。</typeparam>
        /// <param name="commandText">需要执行的命令。</param>
        /// <param name="parameters">命令中所包含的参数列表。</param>
        /// <returns>查询的结果，必须是一个对象集合。</returns>
        Task<IEnumerable<T>> QueryAsync<T>(string commandText, params object[] parameters);

        /// <summary>
        /// 异步执行指定的命令文本并返回影响行数。
        /// </summary>
        /// <param name="commandText">命令文本。</param>
        /// <param name="parameters">命令中所包含的参数列表。</param>
        /// <returns>执行命令后影响的结果。</returns>
        Task<int> ExecuteAsync(string commandText, params object[] parameters);
    }
}
