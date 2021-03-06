﻿using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
//using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace devTutorial.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Resume")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Resume : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Resume(Session session)
            : base(session)
        {
        }

        private Contact contact;
        public Contact Contact
        {
            get
            {
                return contact;
            }
            set
            {
                SetPropertyValue(nameof(Contact), ref contact, value);
            }
        }
        [Aggregated, Association("Resume-PortfolioFileData")]
        public XPCollection<PortfolioFileData> Portfolio
        {
            get
            {
                return GetCollection<PortfolioFileData>(nameof(Portfolio));
            }
        }
    }
}