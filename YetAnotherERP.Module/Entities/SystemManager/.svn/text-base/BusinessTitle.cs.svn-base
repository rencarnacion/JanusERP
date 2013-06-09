using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using YetAnotherERP.Module.Base;
using System.Drawing;
using DevExpress.Xpo.Metadata;
namespace YetAnotherERP.Module.Entities.SystemManager
{
    [VisibleInReports(true)]
    [CreatableItem(false), NavigationItem("System Manager")]
    [DefaultProperty("BusinessTitleCode")]
   public  class BusinessTitle : BasePersistentObject
    {

        public BusinessTitle(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            IsActive = true;
        }

        private bool _IsActive;
        public bool IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                SetPropertyValue("IsActive", ref _IsActive, value);
            }
        }

        private string _BusinessTitleCode;
        [Size(30)]
        public string BusinessTitleCode
        {
            get
            {
                return _BusinessTitleCode;
            }
            set
            {
                SetPropertyValue("BusinessTitleCode", ref _BusinessTitleCode, value);
            }
        }

        private string _BusinessTitleDescription;
        [Size(100)]
        public string BusinessTitleDescription
        {
            get
            {
                return _BusinessTitleDescription;
            }
            set
            {
                SetPropertyValue("BusinessTitleDescription", ref _BusinessTitleDescription, value);
            }
        }
    }
}
