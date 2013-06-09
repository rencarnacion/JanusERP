using DevExpress.ExpressApp.Reports;


namespace YetAnotherERP.Module.Base
{

    public class BaseXafReport : XafReport
    {

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
            }
        }

        private bool _IsVisible;
        public bool IsVisible
        {
            get { return _IsVisible; }
            set
            {
                _IsVisible = value;
            }
        }


        protected override void SerializeProperties(DevExpress.XtraReports.Serialization.XRSerializer serializer)
        {
            base.SerializeProperties(serializer);
            serializer.SerializeString("Description", Description);
            serializer.SerializeBoolean("IsVisible", IsVisible);
        }

        protected override void DeserializeProperties(DevExpress.XtraReports.Serialization.XRSerializer serializer)
        {
            base.DeserializeProperties(serializer);
            Description = serializer.DeserializeString("Description", string.Empty);
            IsVisible = serializer.DeserializeBoolean("IsVisible", true);
        }

        
    }

}