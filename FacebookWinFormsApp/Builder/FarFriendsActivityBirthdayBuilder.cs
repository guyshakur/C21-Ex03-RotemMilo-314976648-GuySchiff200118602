using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Builder
{
    public class FarFriendsBirthdayActivityBuilder : IBirthdayActivityBuilder
    {
        private BirthdayActivity m_BirthdayActivity;
        private User m_FromUser;
        private User m_ToUser;

        public FarFriendsBirthdayActivityBuilder(User i_FromUser, User i_ToUser)
        {
            m_FromUser = i_FromUser;
            m_ToUser = i_ToUser;
            m_BirthdayActivity = new BirthdayActivity(m_FromUser, m_ToUser);
        }

        public BirthdayActivity BirthdayActivity => m_BirthdayActivity;

        public void BuildAlbum()
        {
            string albumName = $"Happy Birthday {m_ToUser.Name}";
            m_BirthdayActivity.SetBirthdayAlbum(albumName);
        }

        public void BuildStatus()
        {
            string blessingStatus = string.Format($@"Wishing you {m_ToUser.Name} the best");
            m_BirthdayActivity.SetHappyBirthdayBlessing(blessingStatus);
        }
    }
}
