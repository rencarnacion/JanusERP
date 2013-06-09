using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Data.Filtering;

using JanusERP.Module.Base;

namespace JanusERP.Module.Entities.Inventory
{
    [CreatableItem(false), NavigationItem("Inventory"), VisibleInReports(true)]
    public class ProductInventory : BasePersistentObject
    {
       public ProductInventory(Session session)
            : base(session)
        {
            TrackByLot = false;
            TrackByDateCode = false;
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        private Item _MasterItem;
        [RuleRequiredField("RRF for ProductInventory.MasterItem", DefaultContexts.Save)]
        [RuleUniqueValue("RUV for ProductInventory.MasterItem", DefaultContexts.Save)]
        public Item MasterItem
        {
            get
            {
                return _MasterItem;
            }
            set
            {
                SetPropertyValue("MasterItem", ref _MasterItem, value);
            }
        }


        private bool _TrackByLot;
        public bool TrackByLot
        {
            get
            {
                return _TrackByLot;
            }
            set
            {
                SetPropertyValue("TrackByLot", ref _TrackByLot, value);
            }
        }

        private bool _TrackByDateCode;
        public bool TrackByDateCode
        {
            get
            {
                return _TrackByDateCode;
            }
            set
            {
                SetPropertyValue("TrackByDateCode", ref _TrackByDateCode, value);
            }
        }

        [Association("Product-Stock", typeof(Inventory)), Aggregated]
        public XPCollection<Inventory> Stock
        {
            get { return GetCollection<Inventory>("Stock"); }
        }


        protected override void OnDeleting()
        {
           if (Session.CollectReferencingObjects(this).Count > 0)
            {
                throw new Exception("");               
            }
           base.OnDeleting();
        }
    }

}