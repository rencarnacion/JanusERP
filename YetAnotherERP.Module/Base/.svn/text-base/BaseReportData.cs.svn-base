using System;
using DevExpress.ExpressApp.Reports;
using DevExpress.Xpo;

namespace YetAnotherERP.Module.Base
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class BaseReportData : ReportData
    {
      public BaseReportData(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

      private string _Description;
      public string Description
      {
          get
          {
              return _Description;
          }
          set
          {
              SetPropertyValue("Description", ref _Description, value);
          }
      }


      private bool _Visible;
      public bool Visible
      {
          get
          {
              return _Visible;
          }
          set
          {
              SetPropertyValue("Visible", ref _Visible, value);
          }
      }


      protected override XafReport CreateReport()
      {
          BaseXafReport newReport = new BaseXafReport { Description = _Description, Visible = _Visible };
          return newReport;
      }

      public override void SaveXtraReport(XafReport report)
      {
          base.SaveXtraReport(report);
          Description = ((BaseXafReport)report).Description;
          Visible = ((BaseXafReport)report).IsVisible;
      }



     
    }

}