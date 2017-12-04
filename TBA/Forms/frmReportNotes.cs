using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBA.Forms
{
    public partial class frmReportNotes : Form
    {
        public frmReportNotes()
        {
            InitializeComponent();

            // Set report & login
            crNotes report = new crNotes();
            report.SetDatabaseLogon("dlgateley", "1616190");
            crvReport.ReportSource = report;
        }
    }
}
