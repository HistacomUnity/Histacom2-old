using System;
using System.Windows.Forms;
using System.Drawing;
using TimeHACK.Engine.Template;

namespace TimeHACK.Engine
{
    public class WindowManager
    {
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();


        public WinClassic startWin95(UserControl content, String title, PictureBox icon, Boolean MaxButton, Boolean MinButton)
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
                icon.Image = Engine.Properties.Resources.nullIcon;
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

        public Infobox95 startInfobox95(String title, String text)
        {
            Infobox95 app = new Infobox95();
            app.Title.Text = title;
            app.Text = title;
            app.infoText.Text = text;
            app.Show();
            return app;
        }
    }
}
