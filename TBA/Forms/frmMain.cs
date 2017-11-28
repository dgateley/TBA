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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();

            // Create theme settings and style the page
            ThemeWindowCommands.WindowSettings windowSettings = new ThemeWindowCommands.WindowSettings();
            windowSettings.Maximizable = true;
            windowSettings.CloseType = ThemeWindowCommands.CloseTypes.Exit;

            ThemeStyling.Style(this, windowSettings);
        }


        /// <summary>
        /// Initial setup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Invoke theme drawing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            // Draw theme objects
            ThemeDrawing.DrawWindowHandle(this);
        }

        /// <summary>
        /// Invoke theme interaction handlers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            // Perform mouse dragging
            ThemeInteraction.Drag(this, e);
        }
    }
}
