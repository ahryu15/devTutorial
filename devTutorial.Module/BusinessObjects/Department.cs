using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace devTutorial.Module.BusinessObjects
{
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty(nameof(Title))]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Department : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Department(Session session)
            : base(session)
        {
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { SetPropertyValue(nameof(Title), ref title, value); }
        }

        private string office;
        public string Office
        {
            get { return office; }
            set { SetPropertyValue(nameof(Office), ref office, value); }
        }

        [Association("Department-Contacts")]
        public XPCollection<Contact> Contacts
        {
            get { return GetCollection<Contact>(nameof(Contacts)); }
        }
    }
}