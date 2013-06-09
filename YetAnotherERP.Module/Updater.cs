using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using JanusERP.Module.SystemManager;
using JanusERP.Module.Entities.SystemManager;


namespace JanusERP.Module
{
    public class Updater : ModuleUpdater
    {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();

            CompanyInformation.GetInstance(ObjectSpace);
            LoadDefaultUsersAndRolesData();
        }

        void LoadDefaultUsersAndRolesData()
        {
            Employee adminUser = ObjectSpace.FindObject<Employee>(new BinaryOperator("UserName", "Admin"));
            if (adminUser==null)
            {
                adminUser = ObjectSpace.CreateObject<Employee>();
                adminUser.UserName = "Admin";
                adminUser.SetPassword("");
            }

            Role adminRole = ObjectSpace.FindObject<Role>(new BinaryOperator("Name", "Administrator"));
            if (adminRole==null)
            {
                adminRole = ObjectSpace.CreateObject<Role>();
                adminRole.Name = "Administrator";
            }

            while (adminRole.PersistentPermissions.Count>0)
            {
                ObjectSpace.Delete(adminRole.PersistentPermissions[0]);
            }

            adminRole.AddPermission(new ObjectAccessPermission(typeof (object), ObjectAccess.AllAccess));

            adminRole.Save();
            adminUser.Roles.Add(adminRole);
            adminUser.Save();

        }

    }
}
