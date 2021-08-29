using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Builder
{
    public class BirthdayActivity : IBirthday
    {
        public Status Status { get; private set; }

        public Album Album { get; private set; }

        private User m_FromUser;

        private User m_ToUser;

        public BirthdayActivity(User i_FromUser, User i_ToUser)
        {
            m_FromUser = i_FromUser;
            m_ToUser = i_ToUser;
        }

        public void SetHappyBirthdayBlessing(string i_BirthdayBlessing)
        {
            try
            {
                if (m_ToUser != null && m_FromUser != null)
                {
                    Status = m_FromUser?.PostStatus(i_BirthdayBlessing, null, null, m_ToUser.Id, @"https://www.youtube.com/watch?v=t4-Z8vVMRBs");
                }
            }
            catch(Exception)
            {
                throw new Exception("can't post status");
            }
        }

        public void SetBirthdayAlbum(string i_BirthdayAlbum)
        {
            try
            {
                if (m_ToUser != null && m_FromUser != null)
                {
                    Album = m_FromUser?.CreateAlbum(i_BirthdayAlbum);
                }
            }
            catch (Exception)
            {
                throw new Exception("can't make happy Birthday album");
            }
        }
    }
}
