using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Observer.Proxy
{
    [Serializable]
    public class PanelTheme : Panel, IThemable
    {
        private readonly ThemeComponentMaker r_ThemeComponentMaker;
        private const int k_ChildrenBrigthness = 20;

        public PanelTheme()
        {
            r_ThemeComponentMaker = new ThemeComponentMaker(this, k_ChildrenBrigthness);
        }

        ThemeMaker IThemable.ThemeMaker => r_ThemeComponentMaker;
    }
}
