using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBA.Theme;

namespace TBA.Forms
{
    public partial class frmAbout : Form
    {
        // Set up theme
        public frmAbout()
        {
            InitializeComponent();

            // Create theme settings and style the page
            ThemeWindowCommands.WindowSettings windowSettings = new ThemeWindowCommands.WindowSettings();
            windowSettings.Maximizable = false;
            windowSettings.CloseType = ThemeWindowCommands.CloseTypes.Close;

            ThemeStyling.Style(this, windowSettings);

            lblInfo.ForeColor = Color.White;
        }

        private void frmAbout_Paint(object sender, PaintEventArgs e)
        {
            // Draw theme objects
            ThemeDrawing.DrawWindowHandle(this);
        }

        private void frmAbout_MouseDown(object sender, MouseEventArgs e)
        {
            // Perform mouse dragging
            ThemeInteraction.Drag(this, e);
        }
    }
}
