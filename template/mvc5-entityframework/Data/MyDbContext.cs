using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyDbContext:DbContext
    {
        /* 该数据库连接字符串在 web.config 中配置
             * MyDbConnection 是 connectionString 的 name 值。
        */
        public MyDbContext()
            : base("MyDbConnection")
            
        {

        }
    }
}
