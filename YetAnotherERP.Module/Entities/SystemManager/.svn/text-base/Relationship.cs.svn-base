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
    [DefaultProperty("RelationshipDescription")]
  public  class Relationship : BasePersistentObject
    {

        public Relationship(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            IsActive = true;
        }

        private string _RelationshipDescription;
        public string RelationshipDescription
        {
            get
            {
                return _RelationshipDescription;
            }
            set
            {
                SetPropertyValue("RelationshipDescription", ref _RelationshipDescription, value);
            }
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
    }
}
