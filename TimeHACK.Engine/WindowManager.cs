using System;
using TimeHACK.Engine.Template;
using System.Windows.Forms;
using System.Drawing;

namespace TimeHACK.Engine
{
    public class WindowManager
    {
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();

        public WinClassic startWinClassic(UserControl content, string title, PictureBox icon, bool MaxButton, bool MinButton)
        {
            // Setup Window
            WinClassic app = new WinClassic();
            app.Text = title;
            app.Title.Text = title;
            app.Width = content.Width + 8;
            app.Height = content.Height + 26;
            // Initialize Font
            pfc.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\LeviWindows.ttf");
            Font fnt = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            app.fnt = fnt;
            // Setup UC
            content.Parent = app.programContent;
            content.BringToFront();
            content.Dock = DockStyle.Fill;

            // Check if icon is null
            if (icon == null)
            {
                icon = app.programIcon;
                icon.Image = Properties.Resources.nullIcon;
            }
            app.programIcon.Image = icon.Image;

            // Check if Max button is enabled and set proper X for Min button
            if (MaxButton == false)
            {
                app.maximizebutton.Visible = false;
                app.minimizebutton.Location = new Point(app.closebutton.Location.X - 14, app.minimizebutton.Location.Y);
            }

            // Check if Min button is enabled
            if (MinButton == false)
            {
                app.minimizebutton.Visible = false;
                app.minimizebutton.Location = new Point(app.minimizebutton.Location.X, app.minimizebutton.Location.Y);
            }

            // Show the app
            app.Show();
            app.BringToFront();
            app.TopMost = true;

            return app;
        }
    }
}