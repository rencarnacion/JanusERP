namespace YetAnotherERP.Module.Controllers.Customers
{
    partial class SalesQuoteController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saCloseLost = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saConvertSO = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saCloseLost
            // 
            this.saCloseLost.Caption = "Close - Lost";
            this.saCloseLost.Category = "RecordEdit";
            this.saCloseLost.ConfirmationMessage = null;
            this.saCloseLost.Id = "saCloseLost";
            this.saCloseLost.ImageName = null;
            this.saCloseLost.Shortcut = null;
            this.saCloseLost.Tag = null;
            this.saCloseLost.TargetObjectsCriteria = null;
            this.saCloseLost.TargetViewId = "SalesQuote_DetailView";
            this.saCloseLost.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.saCloseLost.ToolTip = null;
            this.saCloseLost.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.saCloseLost.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saCloseLost_Execute);
            // 
            // saConvertSO
            // 
            this.saConvertSO.Caption = "Convert To Sales Order";
            this.saConvertSO.Category = "RecordEdit";
            this.saConvertSO.ConfirmationMessage = "Do you want to convert this quote to sales order?";
            this.saConvertSO.Id = "saConvertSO";
            this.saConvertSO.ImageName = null;
            this.saConvertSO.Shortcut = null;
            this.saConvertSO.Tag = null;
            this.saConvertSO.TargetObjectsCriteria = null;
            this.saConvertSO.TargetViewId = "SalesQuote_DetailView";
            this.saConvertSO.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.saConvertSO.ToolTip = null;
            this.saConvertSO.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.saConvertSO.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saConvertSO_Execute);
            // 
            // SalesQuoteController
            // 
            this.TargetObjectType = typeof(YetAnotherERP.Module.Entities.Customers.SalesQuote);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saCloseLost;
        private DevExpress.ExpressApp.Actions.SimpleAction saConvertSO;
    }
}
