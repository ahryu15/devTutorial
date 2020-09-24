using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.XtraEditors;

namespace devTutorial.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class WinNullTextEditorController : ViewController
    {
        public WinNullTextEditorController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            RegisterActions(components);
        }
        void TryInitializeAnniversaryItem()
        {
            PropertyEditor propertyEditor = ((DetailView)View).FindItem("Anniversary") as PropertyEditor;

            if (propertyEditor != null)
            {
                if (propertyEditor.Control != null)
                {
                    InitNullText(propertyEditor);
                }
                else
                {
                    propertyEditor.ControlCreated += PropertyEditor_ControlCreated;
                }
            }
        }

        void InitNullText(PropertyEditor propertyEditor)
        {
            ((BaseEdit)propertyEditor.Control).Properties.NullText = CaptionHelper.NullValueText;
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
            ((CompositeView)View).ItemsChanged += WinNullTextEditorController_ItemsChanged;
            TryInitializeAnniversaryItem();
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
            ((CompositeView)View).ItemsChanged -= WinNullTextEditorController_ItemsChanged;
        }

        private void PropertyEditor_ControlCreated(object sender, EventArgs e)
        {
            InitNullText((PropertyEditor)sender);
        }

        private void WinNullTextEditorController_ItemsChanged(object sender, ViewItemsChangedEventArgs e)
        {
            if (e.ChangedType == ViewItemsChangedType.Added && e.Item.Id == "Anniversary")
            {
                TryInitializeAnniversaryItem();
            }
        }
    }
}
