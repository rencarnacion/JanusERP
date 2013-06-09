using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using JanusERP.Module.Entities.SystemManager;

namespace JanusERP.Module.Base
{
   public class Address :  BasePersistentObject
    {
       public Address(Session session) : base(session) { }

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


    





    }
}
