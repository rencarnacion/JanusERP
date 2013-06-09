using System;

using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using JanusERP.Module.Base;
using System.Drawing;
using DevExpress.Xpo.Metadata;

namespace JanusERP.Module.Entities.SystemManager
{
    [VisibleInReports(true)]
    [CreatableItem(false), NavigationItem("System Manager")]
    [DefaultProperty("Code")]
    public class PostalCode :  BasePersistentObject
    {
        public PostalCode(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            IsActive = true;
        }


        private string _Code;
        [Size(50)]
        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                SetPropertyValue("Code", ref _Code, value);
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

        private string _City;
        [Size(100)]
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                SetPropertyValue("City", ref _City, value);
            }
        }

        private string _State;
        [Size(30)]
        public string State
        {
            get
            {
                return _State;
            }
            set
            {
                SetPropertyValue("State", ref _State, value);
            }
        }

        private string _StateCode;
        [Size(5)]
        public string StateCode
        {
            get
            {
                return _StateCode;
            }
            set
            {
                SetPropertyValue("StateCode", ref _StateCode, value);
            }
        }

        private string _AreaCode;
        [Size(3)]
        public string AreaCode
        {
            get
            {
                return _AreaCode;
            }
            set
            {
                SetPropertyValue("AreaCode", ref _AreaCode, value);
            }
        }

        private string _County;
        [Size(25)]
        public string County
        {
            get
            {
                return _County;
            }
            set
            {
                SetPropertyValue("County", ref _County, value);
            }
        }

        private Country _CountryID;
        public Country CountryID
        {
            get
            {
                return _CountryID;
            }
            set
            {
                SetPropertyValue("CountryID", ref _CountryID, value);
            }
        }


        private string _TimeZone;
        [Size(70)]
        public string TimeZone
        {
            get
            {
                return _TimeZone;
            }
            set
            {
                SetPropertyValue("TimeZone", ref _TimeZone, value);
            }
        }

        private float _Longitude;
        public float Longitude
        {
            get
            {
                return _Longitude;
            }
            set
            {
                SetPropertyValue("Longitude", ref _Longitude, value);
            }
        }

        private float _Latitude;
        public float Latitude
        {
            get
            {
                return _Latitude;
            }
            set
            {
                SetPropertyValue("Latitude", ref _Latitude, value);
            }
        }

        private string _Address;
        [Size(200)]
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                SetPropertyValue("Address", ref _Address, value);
            }
        }


    }
}
