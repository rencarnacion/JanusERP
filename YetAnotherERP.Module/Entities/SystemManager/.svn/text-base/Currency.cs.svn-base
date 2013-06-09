using System;

using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using YetAnotherERP.Module.Base;

namespace YetAnotherERP.Module.Entities.SystemManager
{
    [VisibleInReports(true)]
    [CreatableItem(false), NavigationItem("System Manager")]
    [DefaultProperty("Currency")]
   public class Currency : BasePersistentObject
    {
       public Currency(Session session) : base(session) { }

       private string _CurrencyName;
       public string CurrencyName
       {
           get
           {
               return _CurrencyName;
           }
           set
           {
               SetPropertyValue("CurrencyName", ref _CurrencyName, value);
           }
       }

       private string _Symbol;
        [Size(30)]
       public string Symbol
       {
           get
           {
               return _Symbol;
           }
           set
           {
               SetPropertyValue("Symbol", ref _Symbol, value);
           }
       }

       private decimal _ExchangeRate;
        [DbType("numeric(18,6)")]
       public decimal ExchangeRate
       {
           get
           {
               return _ExchangeRate;
           }
           set
           {
               SetPropertyValue("ExchangeRate", ref _ExchangeRate, value);
           }
       }

        private string _CurrencyDescription;
        public string CurrencyDescription
        {
            get
            {
                return _CurrencyDescription;
            }
            set
            {
                SetPropertyValue("CurrencyDescription", ref _CurrencyDescription, value);
            }
        }

        private int _CurrencyPositivePattern;
        public int CurrencyPositivePattern
        {
            get
            {
                return _CurrencyPositivePattern;
            }
            set
            {
                SetPropertyValue("CurrencyPositivePattern", ref _CurrencyPositivePattern, value);
            }
        }

        private int _CurrencyNegativePattern;
        public int CurrencyNegativePattern
        {
            get
            {
                return _CurrencyNegativePattern;
            }
            set
            {
                SetPropertyValue("CurrencyNegativePattern", ref _CurrencyNegativePattern, value);
            }
        }

        private string _CurrencyDecimalSeparator;
        [Size(1)]
        public string CurrencyDecimalSeparator
        {
            get
            {
                return _CurrencyDecimalSeparator;
            }
            set
            {
                SetPropertyValue("CurrencyDecimalSeparator", ref _CurrencyDecimalSeparator, value);
            }
        }

        private int _CurrencyDecimalDigits;
        public int CurrencyDecimalDigits
        {
            get
            {
                return _CurrencyDecimalDigits;
            }
            set
            {
                SetPropertyValue("CurrencyDecimalDigits", ref _CurrencyDecimalDigits, value);
            }
        }

        private string _CurrencyGroupSeparator;
        public string CurrencyGroupSeparator
        {
            get
            {
                return _CurrencyGroupSeparator;
            }
            set
            {
                SetPropertyValue("CurrencyGroupSeparator", ref _CurrencyGroupSeparator, value);
            }
        }

        private int _CurrencyGroupSizes;
        public int CurrencyGroupSizes
        {
            get
            {
                return _CurrencyGroupSizes;
            }
            set
            {
                SetPropertyValue("CurrencyGroupSizes", ref _CurrencyGroupSizes, value);
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

        private bool _IsHomeCurrency;
        public bool IsHomeCurrency
        {
            get
            {
                return _IsHomeCurrency;
            }
            set
            {
                SetPropertyValue("IsHomeCurrency", ref _IsHomeCurrency, value);
            }
        }
    }
}
