using System;
using System.Windows.Forms;
using System.Drawing;
using Histacom2.Engine.Template;
using System.Media;

namespace Histacom2.Engine
{
    public class WindowManager
    {
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();

        /// <summary>
        /// Creates and returns a WinClassic window.
        /// </summary>
        /// <param name="content">The UserControl to put inside the window.</param>
        /// <param name="title">The name of the window.</param>
        /// <param name="icon">The window's icon. If set to null, then the title moves over to compensate.</param>
        /// <param name="MaxButton">Whether or not the maximize button is shown.</param>
        /// <param name="MinButton">Whether or not the minimize button is shown.</param>
        /// <param name="ShowApplicationAsDialog">Whether or not to interrupt all other processes while this window is open.</param>
        /// <param name="resize">Whether or not this window is resizable.</param>
        /// <returns></returns>
        public WinClassic Init(UserControl content, string title, Image icon, bool MaxButton, bool MinButton, bool ShowApplicationAsDialog = false, bool resize = true)
        {
            WinClassic app = new WinClassic();

            app.Text = title;
            app.Title.Text = title;
            app.Width = content.Width + 8;
            app.Height = content.Height + 26;
            // Initialize Font
            pfc.AddFontFile(SaveSystem.GameDirectory + "\\Data\\LeviWindows.ttf");
            Font fnt = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
            app.fnt = fnt;
            app.Title.Font = new Font(pfc.Families[0], 16F, FontStyle.Bold, GraphicsUnit.Point, ((0)));
            // Setup UC
            content.Parent = app.programContent;
            content.BringToFront();
            content.Dock = DockStyle.Fill;
            app.progContent = content;

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

            //Resize
            app.resizable = resize;

            // Time for the colors
            app.programtopbar.BackColor = SaveSystem.currentTheme.activeTitleBarColor;
            app.Title.ForeColor = SaveSystem.currentTheme.activeTitleTextColor;

            // Convert an image to an icon (for the taskbar)
            if (icon != null)
            {
                Bitmap theBitmap = new Bitmap(icon, new Size(icon.Width, icon.Height));
                IntPtr Hicon = theBitmap.GetHicon(); // Get an Hicon for myBitmap.
                Icon newIcon = Icon.FromHandle(Hicon); // Create a new icon from the handle.
                app.Icon = newIcon;
            }

            // Set some values (for the taskbar)
            app.Tag = TaskBarController.AvalibleApplicationID;
            app.Text = title;

            // Show the app
            app.TopMost = true;
            if (ShowApplicationAsDialog == false) { app.Show(); } else { app.ShowDialog(); }
            return app;
        }
        
        public WinXP InitXP(UserControl content, string title, Image icon, bool MaxButton, bool MinButton, bool ShowApplicationAsDialog = false, bool resize = true)
        {
            WinXP app = new WinXP();
            
            app.Text = title;
            app.programname.Text = title;
            app.Width = content.Width + 8;
            app.Height = content.Height + 26;
            // Initialize Font
            pfc.AddFontFile(SaveSystem.GameDirectory + "\\Data\\LeviWindows.ttf");
            Font fnt = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
            app.fnt = fnt;
            // Setup UC
            content.Parent = app.flowLayoutPanel1;
            content.BringToFront();
            content.Dock = DockStyle.Fill;
            app.progContent = content;

            // Check if icon is null
            if (icon == null)
            {
                app.programIcon.Hide();
                app.programIcon.Image = Properties.Resources.nullIcon;
                app.programname.Location = new Point(6, 7);
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

            //Resize
            app.resizable = resize;

            // Convert an image to an icon (for the taskbar)
            if (icon != null)
            {
                Bitmap theBitmap = new Bitmap(icon, new Size(icon.Width, icon.Height));
                IntPtr Hicon = theBitmap.GetHicon(); // Get an Hicon for myBitmap.
                Icon newIcon = Icon.FromHandle(Hicon); // Create a new icon from the handle.
                app.Icon = newIcon;
            }

            // Set some values (for the taskbar)
            app.Tag = TaskBarController.AvalibleApplicationID;
            app.Text = title;

            // Show the app
            app.TopMost = true;
            if (ShowApplicationAsDialog == false) { app.Show(); } else { app.ShowDialog(); }
            return app;
        }

        public WinClassic StartInfobox95(string title, string text, InfoboxType type, InfoboxButtons btns)
        {
            pfc.AddFontFile(SaveSystem.GameDirectory + "\\Data\\LeviWindows.ttf");
            Infobox95 app = new Infobox95(type, btns);
            app.infoText.Text = text;
            app.infoText.Font = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));

            return Init(app, title, null, false, false, resize: false);
        }

        public WinClassic StartAboutBox95(string shortname, string longname, Image appicon)
        {
            AboutBox95 uc = new AboutBox95();
            uc.pictureBox1.Image = appicon;
            uc.textBox1.Text = longname + "\r\nWindows 95\r\nCopyright © 1981-1995 Microsoft Corp.";
            uc.Font = new Font(pfc.Families[0], 16F, FontStyle.Regular, GraphicsUnit.Point, ((0)));

            return Init(uc, "About " + shortname, null, false, false, resize: false);
        }
    }
}
