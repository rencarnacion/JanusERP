using System;
using DevExpress.Xpo;
using System.Security;
using System.Diagnostics;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.Security;
using JanusERP.Module.SystemManager;

namespace JanusERP.Module.Base
{
    [ImageName("BO_Security")]
    public class PersistentPermissionObject : BasePersistentObject, IPersistentPermission, IXpoCloneable {
       
        private Role _Role;
        private IPermission _Permission;
      
        public PersistentPermissionObject(Session session)
            : this(session, null) {
        }
        public PersistentPermissionObject(Session session, IPermission permission)
            : base(session) {
            _Permission = permission;
        }
        public override string ToString() {
            return _Permission != null ? _Permission.ToString() : "Permission is null";
        }
        public static IPermission GetPermissionFromXml(string permissionXml) {
            try {
                if (!String.IsNullOrEmpty(permissionXml)) {
                    SecurityElement securityElement = SecurityElement.FromString(permissionXml);
                    string typeName = securityElement.Attribute("class");
                    //string assemblyName = securityElement.Attribute("assembly");
                    IPermission result = (IPermission)ReflectionHelper.CreateObject(typeName);
                    result.FromXml(securityElement);
                    return result;
                }
            } catch (Exception e) {
                Tracing.Tracer.LogError(e);
            }
            return null;
        }
        [Size(4000), Browsable(false)]
        public string SerializedPermission {
            get { return _Permission != null ? _Permission.ToXml().ToString() : string.Empty; }
            set {
                try {
                    SetPropertyValue("Permission", ref _Permission, GetPermissionFromXml(value));
                } catch (Exception e) {
                    Trace.WriteLine(e.ToString());
                }
            }
        }
        [Association("Role-PersistentPermissionObjects")]
        public Role Role {
            get { return _Role; }
            set { SetPropertyValue("Role", ref _Role, value); }
        }
        [Custom("PropertyEditorType", "DevExpress.ExpressApp.Editors.DetailPropertyEditor")]
        public IPermission Permission {
            get { return _Permission; }
        }
        #region IPersistentPermission Members
        IPermission IPersistentPermission.Permission {
            get { return _Permission; }
            set { _Permission = value; }
        }
        IXPSimpleObject IXpoCloneable.CloneTo(Type targetType) {
            if (!typeof(PersistentPermissionObject).IsAssignableFrom(targetType))
                return null;
            PersistentPermissionObject result = (PersistentPermissionObject)ReflectionHelper.CreateObject(GetType(), Session);
            result.Role = Role;
            result.SerializedPermission = SerializedPermission;
            return result;
        }
        #endregion
    }
}