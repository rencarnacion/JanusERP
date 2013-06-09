using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

using JanusERP.Module.Base;

namespace JanusERP.Module.Entities.Inventory
{
    [DefaultClassOptions, NavigationItem("Inventory"), CreatableItem(false)]
    [DefaultProperty("LocationName")]
    public class WarehouseLocation : BasePersistentObject
    {
        public WarehouseLocation(Session session)
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
            // Place here your initialization code.
        }

        private string _LocationName;
        [RuleRequiredField("RRF for WarehouseLocation.LocationName", DefaultContexts.Save)]
        [RuleUniqueValue("RUV for WarehouseLocation.LocationName", DefaultContexts.Save, CriteriaEvaluationBehavior=PersistentCriteriaEvaluationBehavior.InTransaction)]
        public string LocationName
        {
            get
            {
                return _LocationName;
            }
            set
            {
                SetPropertyValue("LocationName", ref _LocationName, value);
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

        private bool _IsWasteOrScrap;
        public bool IsWasteOrScrap
        {
            get
            {
                return _IsWasteOrScrap;
            }
            set
            {
                SetPropertyValue("IsWasteOrScrap", ref _IsWasteOrScrap, value);
            }
        }

        private Warehouse _Warehouse;
        [Association("Warehouse-Locations", typeof(Warehouse))]
        [RuleRequiredField("RRF for WarehouseLocation.Warehouse", DefaultContexts.Save)]
        [DataSourceCriteria("IsActive=True")]
        public Warehouse Warehouse
        {
            get
            {
                return _Warehouse;
            }
            set
            {
                SetPropertyValue("Warehouse", ref _Warehouse, value);
            }
        }


        public bool HasItems
        {
            get
            {
                if (!IsLoading && !IsSaving)
                {
                    XPCollection<Inventory> xcol = new XPCollection<Inventory>(Session);
                    xcol.Filter = new BinaryOperator("Location", this, BinaryOperatorType.Equal);
                    return xcol.Count > 0;
                }
                return false;
            }
           
        }
    }

}
