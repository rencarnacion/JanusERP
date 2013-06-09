using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace JanusERP.Module.Win
{
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class JanusERPWindowsFormsModule : ModuleBase
    {
        public JanusERPWindowsFormsModule()
        {
            InitializeComponent();
        }
    }
}
