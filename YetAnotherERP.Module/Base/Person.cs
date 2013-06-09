using System;
using System.Drawing;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo.Metadata;


namespace YetAnotherERP.Module.Base
{
    [NonPersistent]
   public class Person : BasePersistentObject, IPerson
    {
       public  Person(Session session):base(session){}


        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { SetPropertyValue("FirstName", ref _FirstName, value); }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { SetPropertyValue("LastName", ref _LastName, value); }
        }

        private string _MiddleName;
        public string MiddleName
        {
            get { return _MiddleName; }
            set { SetPropertyValue("MiddleName", ref _MiddleName, value); }
        }

        private string _Email;
        public  string Email
        {
            get { return _Email; }
            set { SetPropertyValue("Email", ref _Email, value); }
        }

        private DateTime _Birthday;
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { SetPropertyValue("Birthday", ref _Birthday, value); }
        }

        [Persistent]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Size(SizeAttribute.Unlimited), Delayed(true), ValueConverter(typeof(ImageValueConverter))]
        public Image Foto
        {
            get { return GetDelayedPropertyValue<Image>("Foto"); }
            set { SetDelayedPropertyValue<Image>("Foto", value); }
        }



    }
}
