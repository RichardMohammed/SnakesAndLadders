using System;
using System.Collections.Generic;
using Autofac;

namespace RM.SnakesAndLadders.GameUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>(new NamedParameter("playerNames",new List<string>{ "Player 1", "Player 2"}));
                app.Run();
            }
            Console.ReadLine();
        }
    }
}
