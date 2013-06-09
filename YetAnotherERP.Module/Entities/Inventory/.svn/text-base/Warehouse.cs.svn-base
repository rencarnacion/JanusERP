using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

using YetAnotherERP.Module.Base;

namespace YetAnotherERP.Module.Entities.Inventory
{
    [DefaultClassOptions, CreatableItem(false), NavigationItem("Inventory")]
    [DefaultProperty("WarehouseName"), VisibleInReports(true)]
    public class Warehouse : BasePersistentObject
    {
        public Warehouse(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here or place it only when the IsLoading property is false:
            // if (!IsLoading){
            //    It is now OK to place your initialization code here.
            // }
            // or as an alternative, move your initialization code into the AfterConstruction method.
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            IsActive = true;
            IsDefault = false;
        }

        protected override void OnDeleting()
        {
            if (Session.CollectReferencingObjects(this).Count > 0)
            {
                throw new Exception("");               
            }
            base.OnDeleting();
        }

        private string _WarehouseName;
        [Size(50)]
        [RuleRequiredField("RRF for Warehouse.WarehouseName",DefaultContexts.Save)]
        [RuleUniqueValue("RUV for Warehouse.WarehouseName", DefaultContexts.Save, CriteriaEvaluationBehavior=PersistentCriteriaEvaluationBehavior.BeforeTransaction)]
        public string WarehouseName
        {
            get
            {
                return _WarehouseName;
            }
            set
            {
                SetPropertyValue("WarehouseName", ref _WarehouseName, value);
            }
        }

        private string _Description;
        [Size(250)]
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

        private bool _IsDefault;
        public bool IsDefault
        {
            get
            {
                return _IsDefault;
            }
            set
            {
                SetPropertyValue("IsDefault", ref _IsDefault, value);
            }
        }


        [Association("Warehouse-Locations", typeof(WarehouseLocation)), Aggregated]
        public XPCollection<WarehouseLocation> Locations
        {
            get
            {
                return GetCollection<WarehouseLocation>("Locations");
            }
        }
    }

}
