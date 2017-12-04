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
using TBA.Controls;
using System.ComponentModel.Design;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using TBA_DLL;

namespace TBA.Forms
{
    public partial class frmMain : Form
    {
        // Current file
        Util.FileInfo currentfile;

        public frmMain()
        {
            InitializeComponent();

            // Create theme settings and style the page
            ThemeWindowCommands.WindowSettings windowSettings = new ThemeWindowCommands.WindowSettings();
            windowSettings.Maximizable = false;
            windowSettings.CloseType = ThemeWindowCommands.CloseTypes.Exit;

            ThemeStyling.Style(this, windowSettings);

            lblNothing.Visible = false;
            lblNothing.BackColor = ThemeSettings.ColorBlack;
        }


        /// <summary>
        /// Initial setup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Add the editor to the form
            Controls.Add(editor);
            editor.Visible = false;

            // Color panel
            pnlInfo.BackColor = ThemeSettings.ColorBlack;
            pnlInfo.Visible = false;
            pnlInfo.Paint += (object s, PaintEventArgs ev) =>
            {
                ev.Graphics.DrawRectangle(new Pen(ThemeSettings.AlternateBackgroundColor), new Rectangle(20, 60, pnlInfo.Size.Width - 40, pnlInfo.Size.Height / 2 - 80));
                ev.Graphics.DrawRectangle(new Pen(ThemeSettings.AlternateBackgroundColor), new Rectangle(20, pnlInfo.Size.Height / 2 + 50, pnlInfo.Size.Width - 40, pnlInfo.Size.Height / 2 - 80));
            };
            btnUpload.BackColor = ThemeSettings.ColorGray;
            btnUpload.ForeColor = Color.White;

            // Hide specific panels
            pnlExecutable.Visible = false;
            pnlImage.Visible = false;
            lblNothing.Visible = false;
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

        /// <summary>
        /// Open the file the user dragged in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                // Open the file
                TBA.Util.FileInfo f = new Util.FileInfo(file);
                currentfile = f;
                editor.Setup(f);
                pnlInfo.Visible = true;
                lblDrag.Visible = false;
                pnlImage.Visible = false;
                pnlExecutable.Visible = false;

                // Set labels
                lblFilename.Text = f.Path.Replace(' ', '_');
                lblExtension.Text = f.Extension;
                lblExecutable.Text = (f.IsExecutable) ? "Yes" : "No";
                lblImage.Text = (f.IsImage) ? "Yes" : "No";
                lblSize.Text = Util.FileInfo.GetPrettySize(f.Size);
                lblNothing.Visible = false;

                if (f.IsExecutable)
                {
                    pnlExecutable.Visible = true;
                    pnlExecutable.Setup(f);
                }
                else if (f.IsImage)
                {
                    pnlImage.Visible = true;
                    pnlImage.SetPicture(f.Path);
                }
                else
                {
                    lblNothing.Visible = true;
                }

                // Upload analysis
                try
                {
                    SqlWrapper.Analysis a = new SqlWrapper.Analysis();
                    a.active = true;
                    a.analyzed = DateTime.Now;
                    a.executable = f.IsExecutable;
                    a.image = f.IsImage;
                    a.extension= f.Extension;
                    a.size = f.Size;
                    a.path = f.Path;

                    SqlWrapper.AddReport(a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not upload analysis: " + ex.Message);
                }

            }
        }

        /// <summary>
        /// Add effect to drag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        // Open notes form
        private void itmNotes_Click(object sender, EventArgs e)
        {
            frmNotes form = new frmNotes();
            Hide();
            form.ShowDialog();
            Show();
        }

        // Open the Analysis report form
        private void itmAnalysisReport_Click(object sender, EventArgs e)
        {
            frmReport form = new frmReport();
            Hide();
            form.ShowDialog();
            Show();
        }

        // Open the Note report form
        private void itmNoteReport_Click(object sender, EventArgs e)
        {
            frmReportNotes form = new frmReportNotes();
            Hide();
            form.ShowDialog();
            Show();
        }

        // Open the Stats report form
        private void itmStatisticsReport_Click(object sender, EventArgs e)
        {
            frmReportCharts form = new frmReportCharts();
            Hide();
            form.ShowDialog();
            Show();
        }

        // Upload to file host
        private void btnUpload_Click(object sender, EventArgs e)
        {
            Upload();

            btnUpload.Enabled = false;
        }

        // Upload a file
        async void Upload()
        {
            using (HttpClient http = new HttpClient())
            {
                try
                {
                    // File content
                    MultipartFormDataContent form = new MultipartFormDataContent();

                    // Add the file to the form
                    form.Add(new ByteArrayContent(currentfile.Bytes.ToArray(), 0, currentfile.Bytes.ToArray().Length), "f", System.IO.Path.GetFileName(currentfile.Path));

                    // Upload
                    HttpResponseMessage res = await http.PostAsync("http://filehawk.net/upload", form);
                    Clipboard.SetText(await res.Content.ReadAsStringAsync());

                    // Alert user
                    MessageBox.Show("File uploaded. Link has been copied to your clipboard.", "Success");

                    btnUpload.Enabled = true;
                }
                catch (Exception e)
                {
                    // Something went wrong
                    MessageBox.Show("File could not be uploaded: " + e.Message, "Error");
                }
            }
        }

        // Open about form
        private void itmAbout_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            Hide();
            form.ShowDialog();
            Show();
        }

        // Exit the program
        private void itmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Open a file
        private void itmOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();

            if (d.ShowDialog() == DialogResult.OK)
            {
                string file = d.FileName;

                // Open the file
                TBA.Util.FileInfo f = new Util.FileInfo(file);
                currentfile = f;
                editor.Setup(f);
                pnlInfo.Visible = true;
                lblDrag.Visible = false;
                pnlImage.Visible = false;
                pnlExecutable.Visible = false;
                lblNothing.Visible = false;

                // Set labels
                lblFilename.Text = f.Path.Replace(' ', '_');
                lblExtension.Text = f.Extension;
                lblExecutable.Text = (f.IsExecutable) ? "Yes" : "No";
                lblImage.Text = (f.IsImage) ? "Yes" : "No";
                lblSize.Text = Util.FileInfo.GetPrettySize(f.Size);

                if (f.IsExecutable)
                {
                    pnlExecutable.Visible = true;
                    pnlExecutable.Setup(f);
                }
                else if (f.IsImage)
                {
                    pnlImage.Visible = true;
                    pnlImage.SetPicture(f.Path);
                }
                else
                {
                    lblNothing.Visible = true;
                }


                // Upload analysis
                try
                {
                    SqlWrapper.Analysis a = new SqlWrapper.Analysis();
                    a.active = true;
                    a.analyzed = DateTime.Now;
                    a.executable = f.IsExecutable;
                    a.image = f.IsImage;
                    a.extension = f.Extension;
                    a.size = f.Size;
                    a.path = f.Path;

                    SqlWrapper.AddReport(a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not upload analysis: " + ex.Message);
                }
            }
        }
    }
}
