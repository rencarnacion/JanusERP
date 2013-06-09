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
    [DefaultProperty("CountryName")]
   public class Country  : BasePersistentObject
    {
       public Country(Session session) : base(session) { }

       public override void AfterConstruction()
       {
           base.AfterConstruction();
           IsActive = true;
           ShowOnWeb = false;
           EuropeanUnion = false;
           SearchablePostalCode = false;
           AutoAddPostalCode = false;
       }

       private string _CountryName;
       [Size(50)]
       public string CountryName
       {
           get
           {
               return _CountryName;
           }
           set
           {
               SetPropertyValue("CountryName", ref _CountryName, value);
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

       private string _TwoLetterISOCode;
        [Size(2)]
       public string TwoLetterISOCode
       {
           get
           {
               return _TwoLetterISOCode;
           }
           set
           {
               SetPropertyValue("TwoLetterISOCode", ref _TwoLetterISOCode, value);
           }
       }

        private string _ThreeLetterISOCode;
        [Size(3)]
        public string ThreeLetterISOCode
        {
            get
            {
                return _ThreeLetterISOCode;
            }
            set
            {
                SetPropertyValue("ThreeLetterISOCode", ref _ThreeLetterISOCode, value);
            }
        }

        private string _NumericISOCode;
        [Size(10)]
        public string NumericISOCode
        {
            get
            {
                return _NumericISOCode;
            }
            set
            {
                SetPropertyValue("NumericISOCode", ref _NumericISOCode, value);
            }
        }

        private string _CountryCode;
        [Size(50)]
        public string CountryCode
        {
            get
            {
                return _CountryCode;
            }
            set
            {
                SetPropertyValue("CountryCode", ref _CountryCode, value);
            }
        }

        private string _MobilePhoneFormat;
        [Size(20)]
        public string MobilePhoneFormat
        {
            get
            {
                return _MobilePhoneFormat;
            }
            set
            {
                SetPropertyValue("MobilePhoneFormat", ref _MobilePhoneFormat, value);
            }
        }

        private string _LandlineFormat;
        [Size(20)]
        public string LandlineFormat
        {
            get
            {
                return _LandlineFormat;
            }
            set
            {
                SetPropertyValue("LandlineFormat", ref _LandlineFormat, value);
            }
        }

        private bool _SearchablePostalCode;
        public bool SearchablePostalCode
        {
            get
            {
                return _SearchablePostalCode;
            }
            set
            {
                SetPropertyValue("SearchablePostalCode", ref _SearchablePostalCode, value);
            }
        }

        private bool _AutoAddPostalCode;
        public bool AutoAddPostalCode
        {
            get
            {
                return _AutoAddPostalCode;
            }
            set
            {
                SetPropertyValue("AutoAddPostalCode", ref _AutoAddPostalCode, value);
            }
        }

        private bool _EuropeanUnion;
        public bool EuropeanUnion
        {
            get
            {
                return _EuropeanUnion;
            }
            set
            {
                SetPropertyValue("EuropeanUnion", ref _EuropeanUnion, value);
            }
        }

        private bool _ShowOnWeb;
        public bool ShowOnWeb
        {
            get
            {
                return _ShowOnWeb;
            }
            set
            {
                SetPropertyValue("ShowOnWeb", ref _ShowOnWeb, value);
            }
        }

      
        [Size(SizeAttribute.Unlimited), Delayed(true), ValueConverter(typeof(ImageValueConverter))]
        public Image Flag
        {
            get { return GetDelayedPropertyValue<Image>("Flag"); }
            set { SetDelayedPropertyValue<Image>("Flag", value); }
        }

        private Currency _CurrencyID;
        public Currency CurrencyID
        {
            get
            {
                return _CurrencyID;
            }
            set
            {
                SetPropertyValue("CurrencyID", ref _CurrencyID, value);
            }
        }



    }
}
