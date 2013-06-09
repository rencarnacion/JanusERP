using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using JanusERP.Module.Entities.Customers;

namespace JanusERP.Module.Controllers.Customers
{
    public partial class SalesQuoteController : ViewController
    {
        public SalesQuoteController()
        {
            InitializeComponent();
            RegisterActions(components);
            TargetObjectType = typeof (SalesQuote);
        }

        private void saConvertSO_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

        }

        private void saCloseLost_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

        }
    }
}
