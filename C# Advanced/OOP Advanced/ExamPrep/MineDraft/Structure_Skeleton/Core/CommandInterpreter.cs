using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Minedraft.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public IHarvesterController HarvesterController { get; private set; }
        public IProviderController ProviderController { get; private set; }

        public CommandInterpreter(IHarvesterController harvesterController, IProviderController ProviderController)
        {
            this.HarvesterController = harvesterController;
            this.ProviderController = ProviderController;
        }
        public string ProcessCommand(IList<string> args)
        {
            ICommand command = this.CreateCommand(args);

            string result = command.Execute();
            return result;
        }

        private ICommand CreateCommand(IList<string> arguments)
        {
            var commandName = arguments[0];
            Type commandType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(t => t.Name == commandName+ "Command");
            if (commandType == null)
            {
                throw new ArgumentException(string.Format(Constants.CommandNotFound, commandName));
            }
            if (!typeof(ICommand).IsAssignableFrom(commandType))
            {
                throw new InvalidOperationException(string.Format(Constants.InvalidCommand, commandName));
            }
            ConstructorInfo ctor = commandType.GetConstructors().First();
            ParameterInfo[] parameterInfos = ctor.GetParameters();
            object[] parameters = new object[parameterInfos.Length];

            for (int i = 0; i < parameterInfos.Length; i++)
            {
                Type paramType = parameterInfos[i].ParameterType;
                if (paramType == typeof(IList<string>))
                {
                    parameters[i] = arguments.Skip(1).ToList();
                }
                else
                {
                    PropertyInfo param = this.GetType().GetProperties().FirstOrDefault(p => p.PropertyType == paramType);
                    parameters[i] = param.GetValue(this);
                }
            }
            ICommand command = (ICommand)Activator.CreateInstance(commandType, parameters);
            return command;
        }
    }
}
    

//switch (command)
//{
//    case "RegisterHarvester":
//        var args = new List<string>(data.Skip(1).ToList());
//        manager.RegisterHarvester(args);
//        break;
//    case "RegisterProvider":
//        args = new List<string>(data.Skip(1).ToList());
//        manager.RegisterProvider(args);
//        break;
//    case "Day":
//        manager.Day();
//        break;
//    case "Mode":
//        args = new List<string>(data.Skip(1).ToList());
//        manager.Mode(args);
//        break;
//    case "Check":
//        args = new List<string>(data.Skip(1).ToList());
//        //Console.WriteLine(manager.Check(args));
//        break;
//    default:
//        manager.ShutDown();
//        Environment.Exit(0);
//        break;
//}
