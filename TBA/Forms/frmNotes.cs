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
using TBA_DLL;

namespace TBA.Forms
{
    public partial class frmNotes : Form
    {
        // Is the note new?
        bool isNew = true;
        List<SqlWrapper.Note> notes;
        SqlWrapper.Note current = new SqlWrapper.Note();

        public frmNotes()
        {
            InitializeComponent();

            // Create theme settings and style the page
            ThemeWindowCommands.WindowSettings windowSettings = new ThemeWindowCommands.WindowSettings();
            windowSettings.Maximizable = false;
            windowSettings.CloseType = ThemeWindowCommands.CloseTypes.Close;

            ThemeStyling.Style(this, windowSettings);

            // Get notes
            notes = SqlWrapper.GetAllNotes();

            // Populate
            foreach (SqlWrapper.Note note in notes)
            {
                cmbNotes.Items.Add(note.content.Substring(0, (note.content.Length > 40) ? note.content.Length : note.content.Length));
            }

            // Hide Delete button
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
        }
    

        // Edit or create note
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (isNew)
            {
                if (txtContent.Text == "")
                {
                    MessageBox.Show("Enter note content.", "Invalid note");
                    return;
                }

                current.content = txtContent.Text;
                current.active = true;
                SqlWrapper.AddNote(current);

                MessageBox.Show("Note created.", "Success");
            }
            else
            {
                current.content = txtContent.Text;
                SqlWrapper.UpdateNote(current);

                MessageBox.Show("Note edited.", "Success");
            }
        }

        // Theme painting
        private void frmNotes_Paint(object sender, PaintEventArgs e)
        {
            ThemeDrawing.DrawWindowHandle(this);
        }

        // Theme interaction
        private void frmNotes_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeInteraction.Drag(this, e);
        }


        // Get note
        private void cmbNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNotes.SelectedIndex == -1)
            {
                return;
            }

            isNew = false;

            // Show Delete button
            btnDelete.Visible = true;
            btnDelete.Enabled = true;

            SqlWrapper.Note note = notes[cmbNotes.SelectedIndex];
            current = note;


            // Set textbox
            txtContent.Text = note.content;
        }

        // Hide note
        private void btnDelete_Click(object sender, EventArgs e)
        {
            current.active = false;
            SqlWrapper.UpdateNote(current);

            MessageBox.Show("Note deleted.", "Success");

            cmbNotes.SelectedIndex = -1;
            txtContent.Clear();
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
            isNew = true;
        }
    }
}
