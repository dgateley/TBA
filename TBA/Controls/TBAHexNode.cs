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
    public partial class TBAHexNode : UserControl
    {
        // Textbox to hold the value
        public TextBox text { get; set; }


        // Set up control
        public TBAHexNode()
        {
            InitializeComponent();

            
        }
    }
}
