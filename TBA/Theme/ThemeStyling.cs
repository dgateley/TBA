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
            exitButton.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            TBAWindowMaximizeButton maximizeButton = new TBAWindowMaximizeButton();
            form.Controls.Add(maximizeButton);
            maximizeButton.Size = new Size(28, 28);
            maximizeButton.Location = new Point(form.Width - exitButton.Width - maximizeButton.Width, 0);
            maximizeButton.Clickable = settings.Maximizable;
            maximizeButton.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            TBAWindowMinimizeButton minimizeButton = new TBAWindowMinimizeButton();
            form.Controls.Add(minimizeButton);
            minimizeButton.Size = new Size(28, 28);
            minimizeButton.Location = new Point(form.Width - exitButton.Width - maximizeButton.Width - minimizeButton.Width, 0);
            minimizeButton.Clickable = settings.Minimizable;
            minimizeButton.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            foreach (Control control in form.Controls)
            {
                StyleControl(control);
            }
        }

        private static void StyleControl(Control control)
        {
            if (control.HasChildren)
            {
                foreach (Control c in control.Controls)
                {
                    StyleControl(c);
                }
            }

            if (control is MenuStrip)
            {
                // Set size/location
                MenuStrip menu = (MenuStrip)control;
                menu.Dock = DockStyle.None;
                menu.Location = new Point(0, 28);
                menu.Padding = new Padding(0, 0, 9999, 0);

                // Set colors
                menu.BackColor = ThemeSettings.MenuViewBackgroundColor;
                menu.ForeColor = ThemeSettings.MenuViewForegroundColor;
            }

            if (control is Label)
            {
                Label label = (Label)control;

                // Set colors
 
                //label.BackColor = ThemeSettings.;
                label.ForeColor = ThemeSettings.TextColor;
            }
        }

    }
}
