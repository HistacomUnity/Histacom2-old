using System;
using System.Windows.Forms;
using System.Drawing;
using TimeHACK.Engine.Template;

namespace TimeHACK.Engine
{
    public class WindowManager
    {
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();


        public WinClassic startWin95(UserControl content, String title, Image icon, Boolean MaxButton, Boolean MinButton)
        {
            // Setup Window
            WinClassic app = new WinClassic();
            app.Text = title;
            app.Title.Text = title;
            app.Width = content.Width + 8;
            app.Height = content.Height + 26;
            // Initialize Font
            pfc.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "\\LeviWindows.ttf");
            Font fnt = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
            app.fnt = fnt;
            app.Title.Font = new Font(pfc.Families[0], 16F, FontStyle.Bold, GraphicsUnit.Point, ((0)));
            // Setup UC
            content.Parent = app.programContent;
            content.BringToFront();
            content.Dock = DockStyle.Fill;

            // Check if icon is null
            if (icon == null)
            {
                app.programIcon.Hide();
                app.programIcon.Image = Engine.Properties.Resources.nullIcon;
                app.Title.Location = new Point(2, 1);
            }
            else app.programIcon.Image = icon;

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

        public WinClassic startInfobox95(String title, String text, Image erroricon)
        {
            Infobox95 app = new Infobox95();
            app.infoText.Text = text;
            return startWin95(app, title, null, false, false);
        }

        public WinClassic startAboutBox95(String shortname, String longname, Image appicon)
        {
            AboutBox95 uc = new AboutBox95();
            uc.pictureBox1.Image = appicon;
            uc.textBox1.Text = longname + "\r\nWindows 95\r\nCopyright © 1981-1995 Microsoft Corp.";
            uc.Font = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));

            return startWin95(uc, "About " + shortname, null, false, false);
        }
    }
}
