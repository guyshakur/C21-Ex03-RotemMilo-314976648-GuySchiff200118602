using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Observer.Proxy
{
    public abstract class ThemeMaker
    {
        protected IThemable m_ControlTheme;
        private ColorScheme m_ColorScheme = null;
        private ColorScheme m_OriginalColorScheme = null;

        protected ThemeMaker(IThemable i_ControlTheme)
        {      
            m_ControlTheme = i_ControlTheme;
        }
        public ColorScheme ColorScheme
        {
            get
            {
                return m_OriginalColorScheme;
            }
            set
            {
                if (m_OriginalColorScheme == null)
                {
                    throw new Exception("Original Theme not initialized");
                }
                else
                {
                    setTheme(value);
                }
            }
        }


        public ColorScheme OriginialColorScheme
        {
            get
            {
                return m_OriginalColorScheme;
            }
            protected set
            {
                m_OriginalColorScheme = value;
            }
        }



        protected void setTheme(ColorScheme i_ColorScheme)
        {
            Control control = this.m_ControlTheme as Control;
            try
            {
                MakeTheme(i_ColorScheme);
            }

            catch (Exception)
            {
                throw new NullReferenceException("The Component should be a Control ");
            }
        }

        public void ClearToOriginTheme()
        {
            ClearScheme();
        }
        protected virtual void ClearScheme()
        {
            Control component = m_ControlTheme as Control;

            try
            {
                ClearSpecificTheme();
            }
            catch (Exception)
            {
                throw new NullReferenceException("The Component should be a Control ");
            }
        }

        public void InitializeTheme()
        {
            if(m_OriginalColorScheme == null)
            {
                InitializeSpecificTheme();
            }
            else
            {
                throw new Exception("Original Theme has been initialized");
            }
        }

        protected abstract void InitializeSpecificTheme();
        protected abstract void MakeTheme(ColorScheme i_ColorScheme);
        protected abstract void ClearSpecificTheme();

    }
}