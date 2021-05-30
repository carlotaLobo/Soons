
using Autofac;
using Soons.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Soons.Services
{
    public class ServiceIoC
    {
        private IContainer container;
        public ServiceIoC()
        {
            this.RegisterDependencies();
        }
        private void RegisterDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<ServiceSoons>();
            builder.RegisterType<ModelViewStock>();
            this.container = builder.Build();
        }
        public ModelViewStock ModelViewStock
        {
            get
            {
                return this.container.Resolve<ModelViewStock>();
            }
        }

    }
}

