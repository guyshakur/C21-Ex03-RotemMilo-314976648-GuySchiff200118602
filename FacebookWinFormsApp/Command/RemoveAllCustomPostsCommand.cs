using FacebookWinFormsApp.CostumText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsApp.Command
{
    class RemoveAllCustomPostsCommand : ICommand
    {
        public CustomText Client { get; set; }
        public void Execute()
        {
            Client.ClearMessages();
            Client.SaveToFile();
        }
    }
}
