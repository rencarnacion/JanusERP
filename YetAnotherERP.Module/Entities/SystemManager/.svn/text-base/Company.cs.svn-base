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
    [NavigationItem("System Manager"), DefaultProperty("CompanyName"), VisibleInReports(true)]
    public class Company   : BasePersistentObject
    {

        protected internal Company(Session session) : base(session) { }

        public static Company GetInstance(Session session)
        {
            Company result = session.FindObject<Company>(null);
            if (result == null)
            {
                result = new Company(session) { CompanyName = "My Company" };
                result.Save();
            }

            return result;
        }


        // Fields...
        private string mCompanyName;

        [Size(100)]
        public string CompanyName
        {
            get
            {
                return mCompanyName;
            }
            set
            {
                SetPropertyValue("CompanyName", ref mCompanyName, value);
            }
        }

        private static FieldsClass mFields;
        public new static FieldsClass Fields
        {
            get
            {
                if (ReferenceEquals(mFields, null))
                    mFields = new FieldsClass();
                return mFields;
            }
        }

        //Created/Updated: WIN-NSG2NRJ75MG\Guillermo on WIN-NSG2NRJ75MG at 9/6/2011 11:09 AM
        public new class FieldsClass : YetAnotherERP.Module.Base.BasePersistentObject.FieldsClass
        {
            public FieldsClass()
                : base()
            {
            }
            public FieldsClass(string propertyName)
                : base(propertyName)
            {
            }
        }
    }
}
