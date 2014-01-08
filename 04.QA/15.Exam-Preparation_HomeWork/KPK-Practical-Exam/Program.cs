namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor cmdExecutor = new CommandExecutor();
            
            var commandList = ReadInputCommands();
            foreach (ICommand cmd in commandList)
            {
                cmdExecutor.ExecuteCommand(catalog, cmd, output);
            }

            Console.Write(output); 
        }

        private static List<ICommand> ReadInputCommands()
        {
            List<ICommand> commands = new List<ICommand>();

            while(true)
            {
                string line = Console.ReadLine();
                if (line.Trim() == "End")
                {
                    break;
                }
                commands.Add(new Command(line));
            }

            return commands;
        }
    }
}