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
    public partial class frmReportCharts : Form
    {
        public frmReportCharts()
        {
            InitializeComponent();


            // Set report & login
            crCharts report = new crCharts();
            report.SetDatabaseLogon("dlgateley", "1616190");
            crvReport.ReportSource = report;
        }
    }
}
