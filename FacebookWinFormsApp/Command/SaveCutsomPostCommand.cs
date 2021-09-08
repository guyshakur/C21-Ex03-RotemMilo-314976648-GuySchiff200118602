using FacebookWinFormsApp.CostumText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsApp.Command
{
    class SaveCutsomPostCommand : ICommand
    {
        
        public CustomText Client { get ; set; }
        public string Message { get; set; }

        public SaveCutsomPostCommand()
        {

        }
        public void Execute()
        {
            Client.createMessageAndAddToList(Message);
            Client.SaveToFile();

        }
    }
}
