using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsApp.Builder
{
    public class BirthdayManager
    {
        private IBirthdayActivityBuilder m_BirthdayActivityBuilder;

        public BirthdayManager(params object[] i_Params)
        {
            m_BirthdayActivityBuilder = BirthdayActivityBuilderFactory.CreateBuilder(i_Params);
        }

        public BirthdayActivity BirthdayActivity => m_BirthdayActivityBuilder.BirthdayActivity;

        public void ConstructHappyBirthdayActivity()
        {
            try
            {
                m_BirthdayActivityBuilder.BuildStatus();
                m_BirthdayActivityBuilder.BuildAlbum();
            }
            catch
            {
                throw new Exception("Can not Construct HappyBirthdayActivity. There is a issiue");
            }
        }
    }
}
