using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBA.Theme;

namespace TBA.Controls
{
    class TBALabel : Label
    {
        public TBALabel()
        {
            Font = ThemeSettings.TextFontSmall;
            ForeColor = ThemeSettings.TextColor;
            BackColor = ThemeSettings.PrimaryBackgroundColor;
        }
    }
}
