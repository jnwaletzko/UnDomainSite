using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using ServiceStack.Caching;
using Undomain.API.ServiceDefinition;
using Undomain.API.Interfaces;
using Undomain.API.Repositories;
using Undomain.API.Managers;

namespace Undomain.API
{
    public class UndomainAPIAppHost : AppHostBase
    {
        public UndomainAPIAppHost() : base("UndomainAPI", typeof(ServiceDefinitionInfo).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            this.InitializeContainer(container);
            this.InitializePlugins();
        }

        void InitializeContainer(Funq.Container container)
        {
            container.RegisterAutoWiredAs<ElementsRepository, IElementsRepository>();
            container.RegisterAutoWiredAs<ElementsManager, IElementsManager>();
        }

        void InitializePlugins()
        {
        }
    }
}