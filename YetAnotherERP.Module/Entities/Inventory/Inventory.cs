using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.ConditionalEditorState;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

using YetAnotherERP.Module.Base;

namespace YetAnotherERP.Module.Entities.Inventory
{
    [DefaultClassOptions, CreatableItem(false), NavigationItem("Inventory")]
    [EditorStateRule("ESR for Inventory.Lot", "Lot", EditorState.Hidden, "InventoriedItem.TrackByLot=False", ViewType.Any)]
    [EditorStateRule("ESR for Inventory.DateCode", "DateCode", EditorState.Hidden, "InventoriedItem.TrackByDateCode=False", ViewType.Any)]
    public class Inventory : BasePersistentObject
    {
        public Inventory(Session session): base(session){}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }


        private ProductInventory _InventoriedItem;
        [Association("Product-Stock", typeof(ProductInventory) ), RuleRequiredField("RRF for Inventory.InventoriedItem", DefaultContexts.Save), ImmediatePostData]
        public ProductInventory InventoriedItem
        {
            get
            {
                return _InventoriedItem;
            }
            set
            {
                SetPropertyValue("InventoriedItem", ref _InventoriedItem, value);
            }
        }

        private string _lot;
        [Size(12)]
        [RuleRequiredField("RRF for Inventory.Lot", DefaultContexts.Save, TargetCriteria = "InventoriedItem.TrackByLot=True")]
        public string Lot
        {
            get { return _lot; }
            set { SetPropertyValue("Lot", ref _lot, value); }
        }

        private DateTime _DateCode;
        [RuleRequiredField("RRF for Inventory.DateCode", DefaultContexts.Save, TargetCriteria = "InventoriedItem.TrackByDateCode=True")]
        public DateTime DateCode
        {
            get { return _DateCode; }
            set { SetPropertyValue("DateCode", ref _DateCode, value); }
        }

        private decimal _Quantity;
        [DbType("decimal(28,12)")]
        [Custom("DisplayFormat", "{0:N}")]
        [Custom("EditMask", "N")]
        public decimal Quantity
        {
            get { return _Quantity; }
            set { SetPropertyValue("Quantity", ref _Quantity, value); }
        }

    }

}
