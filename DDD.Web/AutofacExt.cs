using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Configuration;
using Autofac.Integration.Mvc;
using DDD.Application;
using DDD.Application.Interface;
using DDD.Domain.IRepository;
using DDD.Repository;

namespace DDD.Web
{
    internal static class AutofacExt
    {
        public static void InitAutofac()
        {
            var builder = new ContainerBuilder();

            //����ע��
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IRepository<>));

            //Ӧ�ò�ע��
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));

            builder.RegisterType<RoleService>().As<IRoleService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            // Register your MVC controllers.1
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        /// 从容器中获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static T GetFromFac<T>()
        {
            return (T)DependencyResolver.Current.GetService(typeof(T));
        }
    }
}