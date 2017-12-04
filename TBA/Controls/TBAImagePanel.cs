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
    public partial class TBAImagePanel : UserControl
    {
        public TBAImagePanel()
        {
            InitializeComponent();

            // Set color
            BackColor = ThemeSettings.ColorBlack;
        }

        public void SetPicture(string path)
        {
            pcbImage.Image = Image.FromFile(path);
            pcbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
