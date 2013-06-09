using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

using YetAnotherERP.Module.Entities.Inventory;
using YetAnotherERP.Module.Entities.Suppliers;
using YetAnotherERP.Module.Entities.SystemManager;
using YetAnotherERP.Module.Entities.Customers;

namespace YetAnotherERP.Module.Base
{
    [CreatableItem(false)]
    [NavigationItem(false)]
    [VisibleInReports(true)]
    public class BaseDocumentLine : BasePersistentObject
    {
        public BaseDocumentLine(Session session)
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

        private Item _ItemID;
        /// <summary>
        /// Get or Sets the Item Product
        /// </summary>
        public Item ItemID
        {
            get
            {
                return _ItemID;
            }
            set
            {
                Item oldItem = _ItemID;
                SetPropertyValue("ItemID", ref _ItemID, value);
                
                if (!IsLoading && oldItem != null)
                {
                    TaxID = value.TaxID;
                    UnitPrice = value.Price;
                }
                OnChanged("UnitPrice");
                OnChanged("TaxID");
                OnChanged("TaxAmount");
            }
        }


        private decimal _UnitPrice;
        /// <summary>
        /// Gets or sets the Item´s Unit Price
        /// </summary>
        [ImmediatePostData]
        public decimal UnitPrice
        {
            get
            {
                return _UnitPrice;
            }
            set
            {
                SetPropertyValue("UnitPrice", ref _UnitPrice, value);
                UpdateTotal();
            }
        }

        private decimal _Quantity;
        /// <summary>
        /// Gets or sets the Item´s Quantity
        /// </summary>
        [ImmediatePostData]
        [Custom("DisplayFormat", "{0:N2}"), Custom("EditMask", "N2")]
        public decimal Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                SetPropertyValue("Quantity", ref _Quantity, value);
                UpdateTotal();
            }
        }

        private TaxCode _TaxID;
        /// <summary>
        /// Gets or sets the Tax type to apply to Item
        /// </summary>
        public TaxCode TaxID
        {
            get
            {
                return _TaxID;
            }
            set
            {
                SetPropertyValue("TaxID", ref _TaxID, value);
            }
        }

        [Persistent("TaxAmount")]
        private decimal _TaxAmount;
        /// <summary>
        /// Gets the Calculated Tax Amount to apply
        /// </summary>
        [PersistentAlias("_TaxAmount")]
        [ImmediatePostData]
        public decimal TaxAmount
        {
            get
            {
                if (!IsLoading && !IsSaving)
                {
                    if (TaxID != null)
                    {
                        decimal rate = TaxID.Rate;
                        decimal result = decimal.Multiply(decimal.Multiply(UnitPrice, Quantity), rate);
                        _TaxAmount = result;
                    }
                }
                return _TaxAmount;
            }                   
        }

        [Persistent("TotalAmount")]
        private decimal _TotalAmount;
        /// <summary>
        /// Gets the calculated Total Amount of the Line
        /// </summary>
        [PersistentAlias("_TotalAmount")]
        public decimal TotalAmount
        {
            get
            {
                return _TotalAmount;
            }
            
        }

        /// <summary>
        /// Updates Total Amount of the Main Document
        /// </summary>
        private void UpdateTotal()
        {
            var oldTotal = _TotalAmount;
            _TotalAmount = decimal.Add(decimal.Multiply(UnitPrice, Quantity), TaxAmount);
            OnChanged("TotalAmount", oldTotal, _TotalAmount);
            if (!IsLoading && !IsSaving)
            {
                if (SalesOrderID != null)
                {
                    SalesOrderID.UpdateTotal(true);
                }
                else if(SalesQuoteID != null)
                {
                    SalesQuoteID.UpdateTotal(true);
                }
                else if (SalesInvoiceID !=null)
                {
                    SalesInvoiceID.UpdateTotal(true);
                }
                else if (SalesDeliveryNoteID != null)
                {
                    SalesDeliveryNoteID.UpdateTotal(true);
                }
                else if (RMAID != null)
                {
                    RMAID.UpdateTotal(true);
                }
                else if (SalesCreditMemoID != null)
                {
                    SalesCreditMemoID.UpdateTotal(true);
                }
                else if(PurchaseOrderID != null)
                {
                    PurchaseOrderID.UpdateTotal(true);
                }
                else if (PurchaseQuoteID != null)
                {
                    PurchaseQuoteID.UpdateTotal(true);
                }
                else if (PurchaseInvoiceID != null)
                {
                    PurchaseInvoiceID.UpdateTotal(true);
                }
            }
        }

        #region  Sales Documents 

        private SalesCreditMemo _SalesCreditMemoID;

        [Association("SalesCreditMemoDetails", typeof(SalesCreditMemo))]
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public SalesCreditMemo SalesCreditMemoID
        {
            get { return _SalesCreditMemoID; }
            set { SetPropertyValue("SalesCreditMemoID", ref _SalesCreditMemoID, value); }
        }



        private RMA _RMAID;
    [Association("RMADetails", typeof(RMA))]
        [VisibleInDetailView(false), VisibleInLookupListView(false), VisibleInListView(false)]
        public RMA RMAID
        {
            get
            {
                return _RMAID;
            }
            set
            {
                SetPropertyValue("RMAID", ref _RMAID, value);
            }
        }



        private SalesOrder _SalesOrderID;
        [Association("SalesOrderDetails", typeof(SalesOrder))]
        [VisibleInDetailView(false), VisibleInLookupListView(false), VisibleInListView(false)]
        public SalesOrder SalesOrderID
        {
            get
            {
                return _SalesOrderID;
            }
            set
            {
                SetPropertyValue("SalesOrderID", ref _SalesOrderID, value);
            }
        }

        private SalesInvoice _SalesInvoiceID;
        [Association("SalesInvoiceDetails", typeof(SalesInvoice))]
        [VisibleInDetailView(false), VisibleInLookupListView(false), VisibleInListView(false)]
        public SalesInvoice SalesInvoiceID
        {
            get
            {
                return _SalesInvoiceID;
            }
            set
            {
                SetPropertyValue("SalesInvoiceID", ref _SalesInvoiceID, value);
            }
        }

        private SalesDeliveryNote _SalesDeliveryNoteID;
        [Association("SalesDeliveryNoteDetails", typeof(SalesDeliveryNote))]
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public SalesDeliveryNote SalesDeliveryNoteID
        {
            get
            {
                return _SalesDeliveryNoteID;
            }
            set
            {
                SetPropertyValue("SalesDeliveryNoteID", ref _SalesDeliveryNoteID, value);
            }
        }

        private SalesQuote _SalesQuoteID;
        [Association("SalesQuoteDetails" , typeof(SalesQuote))]
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public SalesQuote SalesQuoteID
        {
            get
            {
                return _SalesQuoteID;
            }
            set
            {
                SetPropertyValue("SalesQuoteID", ref _SalesQuoteID, value);
            }
        }

        #endregion

        #region Purchase Documents 

        private PurchaseOrder _PurchaseOrderID;
        [Association("PurchaseOrderDetails", typeof(PurchaseOrder))]
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public PurchaseOrder PurchaseOrderID
        {
            get
            {
                return _PurchaseOrderID;
            }
            set
            {
                SetPropertyValue("PurchaseOrderID", ref _PurchaseOrderID, value);
            }
        }

        private PurchaseQuote _PurchaseQuoteID;
        [Association("PurchaseQuoteDetails", typeof(PurchaseQuote))]
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public PurchaseQuote PurchaseQuoteID
        {
            get
            {
                return _PurchaseQuoteID;
            }
            set
            {
                SetPropertyValue("PurchaseQuoteID", ref _PurchaseQuoteID, value);
            }
        }

        private PurchaseInvoice _PurchaseInvoiceID;
        [Association("PurchaseInvoiceDetails", typeof(PurchaseInvoice))]
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
        public PurchaseInvoice PurchaseInvoiceID
        {
            get
            {
                return _PurchaseInvoiceID;
            }
            set
            {
                SetPropertyValue("PurchaseInvoiceID", ref _PurchaseInvoiceID, value);
            }
        }





        #endregion









    }

}
