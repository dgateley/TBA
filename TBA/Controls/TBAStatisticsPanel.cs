using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBA.Controls
{
    public partial class TBAStatisticsPanel : UserControl
    {
        public TBAStatisticsPanel()
        {
            if (DesignMode)
                return;

            InitializeComponent();
        }

        // Load data
        private void TBAStatisticsPanel_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

           
        }
    }
}
