using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace JanusERP.Module.Base
{
   [NonPersistent]
    public abstract class BaseDocument : BasePersistentObject
    {
        public BaseDocument(Session session)
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

        private string _DocumentID;
       /// <summary>
       /// Get or sets the Document ID
       /// </summary>
        [Size(30)]
        public string DocumentID
        {
            get
            {
                return _DocumentID;
            }
            set
            {
                SetPropertyValue("DocumentID", ref _DocumentID, value);
            }
        }

        [Persistent("Total")]
        protected decimal? _TotalAmount;
       /// <summary>
       /// Gets the Document Total Amount
       /// </summary>
        [PersistentAlias("_Total"), ImmediatePostData]
        public decimal? TotalAmount
        {
            get
            {
                if (!IsLoading && !IsSaving && !_TotalAmount.HasValue)
                {
                    UpdateTotal(false);
                }
                return _TotalAmount;
            }
           
        }

        private void Reset()
        {
            _TotalAmount = null;
        }


        public abstract void UpdateTotal(bool forceChangeEvents);

    }

}
