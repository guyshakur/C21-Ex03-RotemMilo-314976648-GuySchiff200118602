using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsApp.Command
{
    public class CommandInvoker : ICommand
    {
        public ICommand Command { get; set; }
        public CommandInvoker()
        {
        }

        public void SetCommand(ICommand i_Command)
        {
            Command = i_Command;
        }
        public void Execute()
        {
            Command.Execute();
        }
    }
}
