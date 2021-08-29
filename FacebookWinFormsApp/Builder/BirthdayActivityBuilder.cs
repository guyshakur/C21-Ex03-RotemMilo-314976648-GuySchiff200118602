using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsApp.Builder
{
    public interface IBirthdayActivityBuilder
    {
       void BuildAlbum();

       void BuildStatus();

       BirthdayActivity BirthdayActivity { get; }
    }
}
