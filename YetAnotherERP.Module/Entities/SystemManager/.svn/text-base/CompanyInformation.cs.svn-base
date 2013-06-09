using System;
using DevExpress.Xpo;
using YetAnotherERP.Module.Base;
using System.Drawing;
using DevExpress.Xpo.Metadata;
using DevExpress.Persistent.Base;
using System.ComponentModel;

namespace YetAnotherERP.Module.Entities.SystemManager
{
    [VisibleInReports(true)]
    [CreatableItem(false), NavigationItem("System Manager")]
    [DefaultProperty("CompanyName")]
    public class CompanyInformation : BasePersistentObject
    {

        protected internal CompanyInformation(Session session) : base(session) { }

        public static CompanyInformation GetInstance(Session session)
        {
            CompanyInformation result = session.FindObject<CompanyInformation>(null);
            if (result == null)
            {
                result = new CompanyInformation(session);
                result.CompanyName = "My Company";
                result.CompanySlogan = "My Company Slogan";
                result.Save();
            }
            return result;
        }

        private string _CompanyName;
        /// <summary>
        /// Gets or sets the Company Name.
        /// </summary>
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

        private string _CompanySlogan;
        /// <summary>
        /// Gets or set the Company´s Slogan.
        /// </summary>
        public string CompanySlogan
        {
            get
            {
                return _CompanySlogan;
            }
            set
            {
                SetPropertyValue("CompanySlogan", ref _CompanySlogan, value);
            }
        }


        private string _CompanyEmail;
        /// <summary>
        /// Get or set the Company Email Address.
        /// </summary>
        public string CompanyEmail
        {
            get
            {
                return _CompanyEmail;
            }
            set
            {
                SetPropertyValue("CompanyEmail", ref _CompanyEmail, value);
            }
        }


        private string _CompanyUrl;
        /// <summary>
        /// Get or set the Company URL.
        /// </summary>
        public string CompanyUrl
        {
            get
            {
                return _CompanyUrl;
            }
            set
            {
                SetPropertyValue("CompanyUrl", ref _CompanyUrl, value);
            }
        }

        private string _CompanyTaxID;
        /// <summary>
        /// Get or set the Company Tax Id.
        /// </summary>
        public string CompanyTaxID
        {
            get
            {
                return _CompanyTaxID;
            }
            set
            {
                SetPropertyValue("CompanyTaxID", ref _CompanyTaxID, value);
            }
        }

        /// <summary>
        /// Gets or set the Company Logo.
        /// </summary>
        [Size(SizeAttribute.Unlimited), Delayed(true), ValueConverter(typeof(ImageValueConverter))]
        public Image CompanyLogo
        {
            get { return GetDelayedPropertyValue<Image>("CompanyLogo"); }
            set { SetDelayedPropertyValue<Image>("CompanyLogo", value); }
        }

        /// <summary>
        /// Lame solution to avoid Singleton deletion by accident (or not).
        /// </summary>
        protected override void OnDeleting()
        {
            throw new Exception("Cannot be deleted!");
        }


    }

}