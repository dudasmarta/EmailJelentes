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

namespace Jelentés.Module.BusinessObjects
{
    [DefaultClassOptions]
   
    public class Jelentes : XPObject
    { 
        public Jelentes(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        private string _name;

        public string Name
        {
            get
            { 
                return _name; 
            }
            set
            {
                SetPropertyValue("Name", ref _name, value);
            }
        }

        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                SetPropertyValue("Email", ref _email, value);
            }
        }

        private DateTime _kuldes;

        public DateTime Kuldes
        {
            get
            {
                return _kuldes;
            }
            set
            {
                SetPropertyValue("Kuldes", ref _kuldes, value);
            }
        }

        private string _description;
        [Size (2048)]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                SetPropertyValue("Description", ref _description, value);
            }
        }
    }
}