using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace TBA.Theme
{
    /// <summary>
    /// Provides styling information for the theme
    /// </summary>
    class ThemeSettings
    {
        /* Colors */

        // Common colors
        public static Color ColorForeground { get; set; } = Color.FromArgb(255, 171, 178, 191);
        public static Color ColorBlack { get; set; } = Color.FromArgb(255, 40, 44, 52);
        public static Color ColorGray { get; set; } = Color.FromArgb(255, 92, 99, 112);
        public static Color ColorRed { get; set; } = Color.FromArgb(255, 224, 108, 117);
        public static Color ColorDarkRed { get; set; } = Color.FromArgb(255, 190, 80, 70);
        public static Color ColorGreen { get; set; } = Color.FromArgb(255, 152, 195, 121);
        public static Color ColorDarkGreen { get; set; } = Color.FromArgb(255, 122, 159, 96);
        public static Color ColorYellow { get; set; } = Color.FromArgb(255, 229, 192, 123);
        public static Color ColorDarkYellow { get; set; } = Color.FromArgb(255, 209, 154, 102);
        public static Color ColorBlue { get; set; } = Color.FromArgb(255, 97, 175, 239);
        public static Color ColorDarkBlue { get; set; } = Color.FromArgb(255, 59, 132, 192);
        public static Color ColorMagenta { get; set; } = Color.FromArgb(255, 198, 120, 221);
        public static Color ColorDarkMagenta { get; set; } = Color.FromArgb(255, 154, 82, 175);
        public static Color ColorCyan { get; set; } = Color.FromArgb(255, 86, 182, 194);
        public static Color ColorDarkCyan { get; set; } = Color.FromArgb(255, 60, 144, 155);





        // General
        public static Color WindowHandleForegroundColor { get; set; } = ColorForeground;
        public static Color WindowHandleBackgroundColor { get; set; } = ColorBlack;
        public static Color PrimaryBackgroundColor { get; set; } = ColorGray;
        public static Color SecondaryBackgroundColor { get; set; } = ColorBlack;
        public static Color AlternateBackgroundColor { get; set; } = ColorBlue;
        public static Color TextColor { get; set; } = ColorForeground;
        public static Font TextFontSmall { get; set; } = new Font("Segoe UI", 11);
        public static Font TextFontMedium { get; set; } = new Font("Segoe UI", 14);
        public static Font TextFontLarge { get; set; } = new Font("Segoe UI", 22);

        // Window Buttons
        public static Color WindowExitButtonForegroundColor { get; set; } = ColorForeground;
        public static Color WindowExitButtonBackgroundColor { get; set; } = ColorBlack;
        public static Color WindowExitButtonBackgroundHoveredColor { get; set; } = ColorDarkRed;
        public static Color WindowMinimizeButtonForegroundColor { get; set; } = ColorForeground;
        public static Color WindowMinimizeButtonBackgroundColor { get; set; } = ColorBlack;
        public static Color WindowMinimizeButtonBackgroundHoveredColor { get; set; } = ColorGray;
        public static Color WindowMaximizeButtonForegroundColor { get; set; } = ColorForeground;
        public static Color WindowMaximizeButtonBackgroundColor { get; set; } = ColorBlack;
        public static Color WindowMaximizeButtonBackgroundHoveredColor { get; set; } = ColorGray;
        public static Color WindowButtonDisabledColor { get; set; } = ColorGray;

        // TextBoxes
        public static Color TextBoxBackgroundColor { get; set; } = Color.FromArgb(255, 250, 250, 250);
        public static Color TextBoxBackgroundHighlightedColor { get; set; } = Color.FromArgb(255, 240, 240, 240);
        public static Color TextBoxForegroundColor { get; set; } = Color.FromArgb(255, 20, 20, 20);
        public static Color TextBoxBorderColor { get; set; } = Color.FromArgb(255, 200, 200, 200);
        public static Color TextBoxBorderHighlightedColor { get; set; } = AlternateBackgroundColor;

        // Buttons
        public static Color ButtonForegroundColor { get; set; } = TextColor;
        public static Color ButtonBackgroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
        public static Color ButtonBackgroundHoveredColor { get; set; } = Color.FromArgb(255, 255, 0, 0);
        public static Color ButtonBackgroundDarkColor { get; set; } = Color.FromArgb(255, 220, 220, 220);

        // Progress Bars
        public static Color ProgressBarForegroundColor { get; set; } = Color.FromArgb(255, 0, 255, 0);
        public static Color ProgressBarBackgroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);

        // Menu View
        public static Color MenuViewForegroundColor { get; set; } = TextColor;
        public static Color MenuViewBackgroundColor { get; set; } = ColorBlack;


        // Labels
        public static Color LabelTrueColor { get; set; } = Color.FromArgb(255, 0, 190, 0);
        public static Color LabelFalseColor { get; set; } = Color.FromArgb(255, 255, 0, 0);




    }
}
