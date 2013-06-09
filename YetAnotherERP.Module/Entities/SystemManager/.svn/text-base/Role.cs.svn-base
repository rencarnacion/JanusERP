// Developer Express Code Central Example:
// How to create fully custom Role, User, Event, Resource classes for use with the Security and Scheduler modules
// 
// This example demonstrates how to create fully custom classes for use in our
// Security Module (Complex Security Strategy) and Schedule Module.
using DevExpress.Xpo;
using System.Security;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Persistent.Validation;
using DevExpress.Persistent.Base.Security;
using YetAnotherERP.Module.Base;

namespace YetAnotherERP.Module.SystemManager
{
    [ImageName("BO_Role")]
    [DefaultProperty("Name")]
    [NavigationItem("System Manager"), CreatableItem(false), VisibleInReports(true)]
    [RuleCriteria(null, "Delete", "Employees.Count == 0", "Cannot delete the role because there are users that reference it", SkipNullOrEmptyValues = true)]
    public class Role : BasePersistentObject, IRole, ICustomizableRole {
      
        public const string DefaultAdministratorsGroupName = "Administrators";
        public const string DefaultUsersGroupName = "Users";
        private string _Name;
        private List<IPermission> _Permissions = new List<IPermission>();

       
        public Role(Session session) : base(session) { }
       
        public ReadOnlyCollection<IPermission> GetPermissions(IList<IPersistentPermission> persistentPermissions) {
            _Permissions.Clear();
            foreach (IPersistentPermission persistentPermission in persistentPermissions)
                if (persistentPermission.Permission != null)
                    _Permissions.Add(persistentPermission.Permission);
            return _Permissions.AsReadOnly();
        }
        [Association("Employee-Role", UseAssociationNameAsIntermediateTableName = true)]
        public XPCollection<Employee> Employees {
            get { return GetCollection<Employee>("Employees"); }
        }
        [Aggregated, Association("Role-PersistentPermissionObjects")]
        [DevExpress.Xpo.DisplayName("Permissions")]
        public XPCollection<PersistentPermissionObject> PersistentPermissions {
            get { return GetCollection<PersistentPermissionObject>("PersistentPermissions"); }
        }
       
        public PersistentPermissionObject AddPermission(IPermission permission) {
            PersistentPermissionObject result = new PersistentPermissionObject(Session, permission);
            PersistentPermissions.Add(result);
            return result;
        }

        IList<IUser> IRole.Users {
            get { return new ListConverter<IUser, Employee>(Employees); }
        }

        #region IRole Members
        [RuleRequiredField(null, "Save", "The group name must not be empty")]
        [RuleUniqueValue(null, "Save", "The group with the entered Name was already registered within the system")]
        public string Name {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
        ReadOnlyCollection<IPermission> IRole.Permissions {
            get { return GetPermissions(new ListConverter<IPersistentPermission, PersistentPermissionObject>(PersistentPermissions)); }
        }
        #endregion
        #region ICustomizableRole Members
        void ICustomizableRole.AddPermission(IPermission permission) {
            AddPermission(permission);
        }
        #endregion
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
        //Created/Updated: WIN-NSG2NRJ75MG\Guillermo at 9/6/2011 11:11 AM
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