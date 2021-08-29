using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Builder
{
    public static class BirthdayActivityBuilderFactory
    {
        public static IBirthdayActivityBuilder CreateBuilder(params object[] i_Params)
        {
            Builder.IBirthdayActivityBuilder birthdayActivityBuilder;
            switch ((eBuilderType)i_Params[0])
            {
                case eBuilderType.CloseFriend:
                    birthdayActivityBuilder = new Builder.CloseFriendsBirthdayActivityBuilder((User)i_Params[1], (User)i_Params[2]);
                    break;
                default:
                    birthdayActivityBuilder = new Builder.FarFriendsBirthdayActivityBuilder((User)i_Params[1], (User)i_Params[2]);
                    break;
            }

            return birthdayActivityBuilder;
        }
    }
}

public enum eBuilderType
{
    CloseFriend,
    FarFriend
}
