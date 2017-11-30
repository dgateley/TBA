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
    public partial class TBAEditor : UserControl
    {       
        public TBAEditor()
        {
            InitializeComponent();


            // Size
            Size = new Size(400, 800);

            // Anchor to the right
            Anchor = AnchorStyles.Right;

            // Colors
            BackColor = ThemeSettings.AlternateBackgroundColor;
        }
    }
}
