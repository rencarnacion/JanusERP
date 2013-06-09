using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors.DXErrorProvider;
using YetAnotherERP.Module.Entities.SystemManager;
using YetAnotherERP.Module.Base;

namespace YetAnotherERP.Module.Entities.Inventory
{
    [CreatableItem(false), NavigationItem("Inventory"), VisibleInReports(true)]
    [DefaultProperty("ItemName")]
    public class Item : BasePersistentObject, IDXDataErrorInfo
    {
        public Item(Session session): base(session){}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            ISell = false;
            IBuy = false;
        }

        private string _ItemName;
        [Size(50)]
        [Indexed]
        [RuleRequiredField("Item-ItemName", DefaultContexts.Save)]
        public string ItemName
        {
            get
            {
                return _ItemName;
            }
            set
            {
                SetPropertyValue("ItemName", ref _ItemName, value);
            }
        }

        private string _itemDescription;
        [Size(100)]
        public  string  ItemDescription
        {
            get { return _itemDescription; }
            set { SetPropertyValue("ItemDescription", ref _itemDescription, value); }
        }

        private string _ItemDescription;
        public string ItemDescription
        {
            get { return _ItemDescription; }
            set { SetPropertyValue("ItemDescription", ref _ItemName, value); }
        }



        private TaxCode _TaxID;
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

        private decimal _Price;
        [DbType("decimal(18,5)")]
        public decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                SetPropertyValue("Price", ref _Price, value);
            }
        }

        private bool _ISell;
        public  bool  ISell
        {
            get { return _ISell; }
            set { SetPropertyValue("ISell", ref _ISell, value); }
        }

        private bool _IBuy;
        public bool IBuy
        {
            get { return _IBuy; }
            set { SetPropertyValue("IBuy", ref _IBuy, value); }
        }

        private string _BarCode;
        [RuleUniqueValue("RUV Item.BarCode", DefaultContexts.Save)]
        public string BarCode
        {
            get { return _BarCode; }
            set { SetPropertyValue("BarCode", ref _BarCode, value); }
        }

        private bool _IsActive;
        public  bool  IsActive
        {
            get { return _IsActive; }
            set { SetPropertyValue("IsActive", ref _IsActive, value); }
        }

        [Size(SizeAttribute.Unlimited), Delayed(true), ValueConverter(typeof(ImageValueConverter))]
        public Image Photo
        {
            get { return GetDelayedPropertyValue<Image>("Photo"); }
            set { SetDelayedPropertyValue<Image>("Photo", value); }
        }

        #region IDXDataErrorInfo Implementation

        public  void GetError(ErrorInfo info)
        {
            
        }

        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            var loClassInfo = Session.GetClassInfo(this);
            if (propertyName.EndsWith("!"))
                propertyName = propertyName.TrimEnd(Convert.ToChar("!"));
            
            var loMemberInfo = loClassInfo.GetPersistentMember(propertyName);
            if (loMemberInfo == null) return;

            bool loRuleRequired = loMemberInfo.HasAttribute("RuleRequiredFieldAttribute");
            if (loRuleRequired)
            {
                if (IsLoading) return;

                if (string.Compare(loMemberInfo.StorageType.Name, "String", false)==0)
                {
                    if ((loMemberInfo.GetValue(this) == null) && string.IsNullOrEmpty(loMemberInfo.GetValue(this).ToString()))
                    {
                        info.ErrorText =
                            ((RuleRequiredFieldAttribute)
                             loMemberInfo.GetAttributeInfo("RuleRequiredFieldAttribute")).CustomMessageTemplate;
                        info.ErrorType = ErrorType.Information;
                    }
                    else
                    {
                        info.ErrorText =
                           ((RuleRequiredFieldAttribute)
                            loMemberInfo.GetAttributeInfo("RuleRequiredFieldAttribute")).CustomMessageTemplate;
                        info.ErrorType = ErrorType.Critical;
                    }
                }


            }


        }

        #endregion


    }

}
