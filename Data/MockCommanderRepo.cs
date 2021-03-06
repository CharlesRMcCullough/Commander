using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo="Check version of Node.js", Line="node --version", Platform="Node.js"},
                new Command{Id = 1, HowTo="Get list of files in directory", Line="dir", Platform="Windows"},
                new Command{Id = 0, HowTo="Remove File", Line="del", Platform="Windows"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
          return new Command{Id = 0, HowTo="Check version of Node.js", Line="node --version", Platform="Node.js"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}