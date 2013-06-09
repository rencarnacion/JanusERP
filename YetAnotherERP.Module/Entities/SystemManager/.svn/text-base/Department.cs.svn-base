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
    [DefaultProperty("DepartmentCode")]
  public   class Department: BasePersistentObject
    {
      public Department(Session session) : base(session) { }

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

      private string _DepartmentCode;
        [Size(30)]
      public string DepartmentCode
      {
          get
          {
              return _DepartmentCode;
          }
          set
          {
              SetPropertyValue("DepartmentCode", ref _DepartmentCode, value);
          }
      }

        private string _DepartmentDescription;
        [Size(100)]
        public string DepartmentDescription
        {
            get
            {
                return _DepartmentDescription;
            }
            set
            {
                SetPropertyValue("DepartmentDescription", ref _DepartmentDescription, value);
            }
        }
    }
}
