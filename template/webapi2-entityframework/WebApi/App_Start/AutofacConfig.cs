using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using AUV.Data;
using AUV.Entityframework6;
using Autofac.Integration.WebApi;
using Autofac;

namespace Web
{
    /// <summary>
    /// Mvc 中的 Autofac 配置。
    /// </summary>
    public static class AutofacConfig
    {
        /// <summary>
        /// 为当前项目进行依赖注入配置。
        /// </summary>
        public static void Configure()
        {
            var buider = new ContainerBuilder();

            //如果使用 IIdentity 作为实体基类，可使用下面这段
            buider.RegisterGeneric(typeof(IIdentityRepository<>))
                .As(typeof(EntityframeworkIdentityRepository<>))
                .InstancePerRequest();

            //如果使用 IUniqueIdentifier 作为实体基类时，可使用下面这段
            buider.RegisterGeneric(typeof(IUniqueIdentifierRepository<>))
                .As(typeof(EntityframeworkUniqueIdentifierRepository<>))
                .InstancePerRequest();

            //如果使用 IEntity 作为实体基类时，可使用下面这段
            buider.RegisterGeneric(typeof(IRepository<,>))
                .As(typeof(EntityframeworkRepository<,>))
                .InstancePerRequest();

            //用户注册 Entityframework 的 DbContext 实例，MyDbContext 可由自己修改，支持 Code first            
            buider.Register(instance => new EntityframeworkDbContext(new Data.MyDbContext()))
                .As<IUnitOfWork>().InstancePerRequest();

            buider.RegisterTypes(System.Reflection.Assembly.Load("Services")//读取的程序集，可自行修改
                .ExportedTypes.Where(m =>

                //批量注册的名称，由 Service 结尾，可自行定义。
                m.FullName.EndsWith("Service"))

                .ToArray()).AsSelf();

            //注册所有 Api Controller
            buider.RegisterApiControllers(System.Reflection.Assembly.Load("WebApi"));

            var container = buider.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}