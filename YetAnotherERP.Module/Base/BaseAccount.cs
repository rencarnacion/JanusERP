using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace JanusERP.Module.Base
{
    
    [DefaultProperty("AccountName")]
    public class BaseAccount : BasePersistentObject
    {
        public BaseAccount(Session session)
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
            IsActive = true;
            AccountOpenSince = new DateTime();
        } 


        private string _AccountName;
        /// <summary>
        /// Account Name
        /// </summary>
        [Size(100)]
        [RuleRequiredField("RRF for BaseAccount.AccountName", DefaultContexts.Save)]
        public string AccountName
        {
            get
            {
                return _AccountName;
            }
            set
            {
                SetPropertyValue("AccountName", ref _AccountName, value);
            }
        }


        private string _CompanyName;
        /// <summary>
        /// The Account Company Name
        /// </summary>
        [Size(100)]
        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                SetPropertyValue("CompanyName", ref _CompanyName, value);
            }
        }


        private string _TaxNumberID;
        /// <summary>
        /// The Tax Provider Number ID
        /// This is used for Tax declarations
        /// </summary>
        [Size(60)]
        [RuleRequiredField("RRF for BaseAccount.TaxNumberID", DefaultContexts.Save)]
        public string TaxNumberID
        {
            get
            {

                return _TaxNumberID;
            }
            set
            {
                SetPropertyValue("TaxNumberID", ref _TaxNumberID, value);
            }
        }


        private bool _IsActive;
        /// <summary>
        /// Gets or sets whether the Account is Active
        /// </summary>
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


        private DateTime? _AccountOpenSince;
        /// <summary>
        /// Get or sets the date since the account was opened.
        /// </summary>
        public DateTime? AccountOpenSince
        {
            get
            {
                return _AccountOpenSince;
            }
            set
            {
                SetPropertyValue("AccountOpenSince", ref _AccountOpenSince, value);
            }
        }

        private decimal _CreditLimit;
        /// <summary>
        /// Gets or sets the Credit limit for this account.
        /// </summary>
        [Custom("EditMask", "C2")]
        public decimal CreditLimit
        {
            get
            {
                return _CreditLimit;
            }
            set
            {
                SetPropertyValue("CreditLimit", ref _CreditLimit, value);
            }
        }

        private bool _EnableEDI;
        /// <summary>
        /// Gets or sets whether this account has EDI enabled.
        /// </summary>
        public bool EnableEDI
        {
            get
            {
                return _EnableEDI;
            }
            set
            {
                SetPropertyValue("EnableEDI", ref _EnableEDI, value);
            }
        }


    }

}
