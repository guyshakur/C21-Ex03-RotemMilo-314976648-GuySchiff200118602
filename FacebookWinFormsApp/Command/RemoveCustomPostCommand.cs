using FacebookWinFormsApp.CostumText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsApp.Command
{
    public class RemoveCustomPostCommand : ICommand
    {
        public CustomText Client { get; set; }
        public int ClientIndex { get; set; }
        public void Execute()
        {
            Client.RemoveMessageFromList(ClientIndex);
            Client.SaveToFile();
        }
    }
}
