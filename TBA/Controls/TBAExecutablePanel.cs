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

namespace TBA.Controls
{
    public partial class TBAExecutablePanel : UserControl
    {
        public TBAExecutablePanel()
        {
            InitializeComponent();

            // Set color
            BackColor = ThemeSettings.ColorBlack;
        }

        // Set labels
        public void Setup(Util.FileInfo f)
        {
            // Machine
            switch (f.PEInfo.machine)
            {
                case 0x014c:
                    lblMachine.Text = "x86";
                    break;
                case 0x0200:
                    lblMachine.Text = "Intel Itanium";
                    break;
                case 0x8664:
                    lblMachine.Text = "x64";
                    break;
                default:
                    lblMachine.Text = "Unknown";
                    break;
            }

            // Time
            lblTime.Text = f.PEInfo.timestamp.ToString();

            // Size of code
            lblCodeSize.Text = Util.FileInfo.GetPrettySize(f.PEInfo.codesize);

            // Sections
            lblSections.Text = f.PEInfo.sections.ToString();
        }
    }
}
