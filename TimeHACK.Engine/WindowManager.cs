using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeHACK.Engine.Template;

namespace TimeHACK.Engine
{
    class WindowManager
    {
        private void startWinClassic(String title, int width, int height)
        {
            WinClassic app = new WinClassic();
            app.Title.Text = title;
            app.Width = width + 8;
            app.Height = height + 26;
        }
    }
}
