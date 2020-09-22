﻿using System;
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
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using devTutorial.Module.BusinessObjects;

namespace devTutorial.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PopupNotesController : ViewController
    {
        public PopupNotesController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
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
        }

        private void ShowNotesAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Note));
            string noteListviewId = Application.FindLookupListViewId(typeof(Note));
            CollectionSourceBase collectionSource = Application.CreateCollectionSource(objectSpace, typeof(Note), noteListviewId);
            e.View = Application.CreateListView(noteListviewId, collectionSource, true);
            //option
            e.Size = new System.Drawing.Size(600, 400);
            //e.Maximized = true;
            e.IsSizeable = false;
        }

        private void ShowNotesAction_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            DemoTask task = (DemoTask)View.CurrentObject;
            foreach(Note note in e.PopupWindowViewSelectedObjects)
            {
                if(!string.IsNullOrEmpty(task.Description))
                {
                    task.Description += Environment.NewLine;
                }
                task.Description += note.Text;
            }
            if(((DetailView)View).ViewEditMode == ViewEditMode.View)
            {
                View.ObjectSpace.CommitChanges();
            }
        }
    }
}
