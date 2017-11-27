using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBA.Controls;
using System.Drawing;

namespace TBA.Theme
{
    class ThemeStyling
    {

        /// <summary>
        /// Called in the constructor to style a form
        /// </summary>
        /// <param name="form">The form to style</param>
        public static void Style(Form form, ThemeWindowCommands.WindowSettings settings)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.BackColor = ThemeSettings.PrimaryBackgroundColor;


            // Add window handle controls
            TBAWindowExitButton exitButton = new TBAWindowExitButton();
            form.Controls.Add(exitButton);
            exitButton.Size = new Size(28, 28);
            exitButton.Location = new Point(form.Width - exitButton.Width, 0);
            exitButton.Clickable = settings.Closable;
            exitButton.Type = settings.CloseType;

            TBAWindowMaximizeButton maximizeButton = new TBAWindowMaximizeButton();
            form.Controls.Add(maximizeButton);
            maximizeButton.Size = new Size(28, 28);
            maximizeButton.Location = new Point(form.Width - exitButton.Width - maximizeButton.Width, 0);
            maximizeButton.Clickable = settings.Maximizable;

            TBAWindowMinimizeButton minimizeButton = new TBAWindowMinimizeButton();
            form.Controls.Add(minimizeButton);
            minimizeButton.Size = new Size(28, 28);
            minimizeButton.Location = new Point(form.Width - exitButton.Width - maximizeButton.Width - minimizeButton.Width, 0);
            minimizeButton.Clickable = settings.Minimizable;

            foreach (var control in form.Controls)
            {
                if (control is TextBox)
                {

                }
            }
        }

    }
}
