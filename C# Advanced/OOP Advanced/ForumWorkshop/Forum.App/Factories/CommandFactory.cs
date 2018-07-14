namespace Forum.App.Factories
{
    using Contracts;
    using System;

    public class CommandFactory : ICommandFactory
    {
        private IServiceProvider serviceProvider;
        public ICommand CreateCommand(IServiceProvider serviceProvider, string commandName)
        {
            this.serviceProvider = serviceProvider;
        }
    }
}
