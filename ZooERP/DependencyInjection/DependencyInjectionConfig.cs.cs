using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooERP.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ZooERP.DependencyInjection
{
    public static class DependencyInjectionConfig
    {
        public static IServiceProvider Configure()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ZooService>();
            services.AddSingleton<VeterinaryClinic>();
            services.AddSingleton<ReportService>();
            return services.BuildServiceProvider();
        }
    }
}
