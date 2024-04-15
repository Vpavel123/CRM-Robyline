using CRM_Robyline.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Robyline.Service.Until
{
    public static class Ioc
    {
        public static readonly ServiceProvider _provider;
        static Ioc()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton(typeof(SidebarModel));
            services.AddSingleton(typeof(MainWindowModel));

            _provider = services.BuildServiceProvider();
        }

        public static T ReResolve<T>() => _provider.GetService<T>();
    }
}
