using System;
using System.ComponentModel;
using System.IO;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Reports;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.General;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.XtraReports.Extensions;

namespace JanusERP.Module.Base
{
#pragma warning disable 0618
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class BaseReportData : XPObject, IReportData, IInplaceReport
    {
#pragma warning restore 0618

        public const string EmptyNameMessage = @"The ""ReportName"" field must have a value...";
        public const string IsInplaceReportMember = "IsInplaceReport";
        private string reportName = "";
        private bool isInplaceReport = false;

#if MediumTrust
        private string dataTypeName = string.Empty
#else
        [Persistent("ObjectTypeName"), Size(512)] private string dataTypeName = string.Empty;
#endif

        [Delayed, Persistent("Content"), Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public byte[] Content
        {
            get { return GetDelayedPropertyValue<byte[]>("Content"); }
            set { SetDelayedPropertyValue<byte[]>("Content", value); }
        }

        protected virtual XafReport CreateReport()
        {
            return new XafReport();
        }

        protected override void OnSaving()
        {
            if (String.IsNullOrEmpty(reportName) || (reportName.Trim() == ""))
            {
                throw new Exception(EmptyNameMessage);
            }
            base.OnSaving();
        }

      public BaseReportData(Session session): base(session) { }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public BaseReportData(Session session, Type dataType) : base(session)
        {
            Guard.ArgumentNotNull(dataType, "dataType");
            dataTypeName = dataType.FullName;
        }

        public virtual XafReport LoadXtraReport(IObjectSpace objectSpace)
        {
            XafReport result = CreateReport();
            result.ObjectSpace = objectSpace;
            if ((Content != null) && (Content.Length > 0))
            {
                int realLength = Content.Length;
                while (Content[realLength - 1] == 0)
                {
                    realLength--;
                }

                MemoryStream stream = new MemoryStream(Content, 0, realLength);
                result.CustomDeserializeValue += new EventHandler<CustomDeserializeValueEventArgs>(result_CustomDeserializeValue);
                result.LoadLayout(stream);
                ReportDesignExtension.AssociateReportWithExtension(result, XafReport.XafReportContextName);
                stream.Close();
            }

            result.ReportName = reportName;
            return result;
        }

        void result_CustomDeserializeValue(object sender, CustomDeserializeValueEventArgs e)
        {
            OnCustomDeserializeReportValue((XafReport)sender, e);
        }

        protected virtual void OnCustomDeserializeReportValue(XafReport report, CustomDeserializeValueEventArgs e)
        {
            if (CustomDeserializeReportValue != null)
            {
                CustomDeserializeReportValue(report, e);
            }
        }

        public virtual void SaveXtraReport(XafReport report)
        {
            MemoryStream stream = new MemoryStream();
            report.SaveLayout(stream, true);
            Content = stream.GetBuffer();
            stream.Close();
            if (report.ReportName != reportName)
            {
                reportName = report.ReportName;
                OnChanged("ReportName");
            }
            if (report.DataType != null)
            {
                dataTypeName = report.DataType.FullName;
            }
        }

        [Persistent("Name")]
        public string ReportName
        {
            get { return reportName; }
            set
            {
                reportName = value;
                OnChanged("ReportName");
            }
        }

#if MediumTrust
		[Browsable(false)]
		[Persistent("ObjectTypeName")]
		public string DataTypeName {
			get { return dataTypeName; }
			set { dataTypeName = value; }
		}
#else
        [Browsable(false), PersistentAlias("dataTypeName")]
        public string DataTypeName
        {
            get { return dataTypeName; }
        }
#endif


        [NonPersistent, System.ComponentModel.DisplayName("Data Type")]
        public string DataTypeCaption
        {
            get { return CaptionHelper.GetClassCaption(dataTypeName); }
        }

        [VisibleInListView(false)]
        public bool IsInplaceReport
        {
            get { return isInplaceReport; }
            set { isInplaceReport = value; OnChanged(IsInplaceReportMember); }
        }

        public static void MassUpdateDataType(IObjectSpace objectSpace, string oldDataType, Type newDataType)
        {
            foreach (ReportData reportData in objectSpace.GetObjects<ReportData>(new BinaryOperator("dataTypeName", oldDataType)))
            {
                XafReport report = reportData.LoadXtraReport(objectSpace);
                report.DataType = newDataType;
                reportData.SaveXtraReport(report);
            }
            objectSpace.CommitChanges();
        }

        public event EventHandler<CustomDeserializeValueEventArgs> CustomDeserializeReportValue;

        #region IContentHolder Members
   
        #endregion


        public DevExpress.XtraReports.UI.XtraReport LoadReport(IObjectSpace objectSpace)
        {
            throw new NotImplementedException();
        }

        public void SaveReport(DevExpress.XtraReports.UI.XtraReport report)
        {
            throw new NotImplementedException();
        }
    }

}