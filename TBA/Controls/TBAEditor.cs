using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBA.Theme;
using TBA.Util;
using Be.Windows.Forms;
using Be.Windows;
using System.ComponentModel.Design;

namespace TBA.Controls
{
    public partial class TBAEditor : UserControl
    {
        private ByteViewer bv = new ByteViewer();

        public TBAEditor()
        {
            InitializeComponent();

            // Colors
            BackColor = ThemeSettings.ColorBlack;
            ForeColor = ThemeSettings.ColorForeground;
        }

        public void Setup(FileInfo file)
        {
            Visible = true;

            Controls.Remove(bv);

            bv = new ByteViewer();
            bv.Dock = DockStyle.Fill;
            bv.SetFile(file.Path);
            Controls.Add(bv);
        }
    }
}
