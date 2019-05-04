using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

namespace medical_encyclopedia_DB62
{
    public partial class DB62_aspx_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument Report = new ReportDocument();
            Report.Load(Server.MapPath("~/DB62_reporting.rpt"));
            CrystalReportViewer1.ReportSource = Report;
        }
    }
}