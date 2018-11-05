using System.Collections.Generic;
using Autofac;

namespace RM.SnakesAndLadders.GameUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>()
                .WithParameter(new TypedParameter(typeof(List<string>), "playerNames"));

            return builder.Build();
        }
    }
}
