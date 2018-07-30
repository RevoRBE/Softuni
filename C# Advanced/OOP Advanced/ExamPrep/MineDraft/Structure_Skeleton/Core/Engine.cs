using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private ICommandInterpreter interpreter;
    private IReader reader;
    private IWriter writer;

    public Engine(ICommandInterpreter interpreter, IReader reader, IWriter writer)
    {
        this.interpreter = interpreter;
        this.reader = reader;
        this.writer = writer;
    }

    public void Run()
    {
        while (true)
        {
            var inputArgs = reader.ReadLine().Split().ToList();
            string commandOutput = interpreter.ProcessCommand(inputArgs);
            writer.WriteLine(commandOutput);
            if (inputArgs[0] == "Shutdown")
            {
                break;
            }
            //switch (command)
            //{
            //    case "RegisterHarvester":
            //        var args = new List<string>(inputArgs.Skip(1).ToList());
            //        manager.RegisterHarvester(args);
            //        break;
            //    case "RegisterProvider":
            //        args = new List<string>(inputArgs.Skip(1).ToList());
            //        manager.RegisterProvider(args);
            //        break;
            //    case "Day":
            //        manager.Day();
            //        break;
            //    case "Mode":
            //        args = new List<string>(inputArgs.Skip(1).ToList());
            //        manager.Mode(args);
            //        break;
            //    case "Check":
            //        args = new List<string>(inputArgs.Skip(1).ToList());
            //        //Console.WriteLine(manager.Check(args));
            //        break;
            //    default:
            //        manager.ShutDown();
            //        Environment.Exit(0);
            //        break;
            //}
        }
    }
}
