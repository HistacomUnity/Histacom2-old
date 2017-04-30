using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TimeHACK.Engine
{
    public class TaskBarController
    {
        public static int AvalibleApplicationID;

        public Panel AddTaskbarItem95(int ApplicationID, string ApplicationName, Image ApplicationIcon, UserControl taskbar_item, Panel oldPanel)
        {
            Panel returnPanel = oldPanel;

            AvalibleApplicationID++;

            taskbar_item.BackgroundImage = ApplicationIcon;
            taskbar_item.Tag = ApplicationName;
            taskbar_item.Dock = DockStyle.Left;
            returnPanel.Controls.Add(taskbar_item);

            return returnPanel;
        }

        public List<Form> GetAllOpenApps()
        {
            List<Form> AppsList = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if ((string)form.Tag != "ignoreFormOnTaskbar")
                {
                    AppsList.Add(form);
                }             
            }

            return AppsList;
        }
    }
}
