using Sitecore.Forms.Mvc.ViewModels.Fields;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Sitecore.Support.Forms.Mvc.ViewModels.Fields
{
    public class DropListField : RadioListField
    {
        public bool EmptyChoise { get; set; }

        public DropListField()
        {
            this.EmptyChoise = true;
        }

        public override void Initialize()
        {
            if (this.Parameters.ContainsKey("emptychoice"))
                this.EmptyChoise = this.Parameters["emptychoice"].Equals("yes", StringComparison.InvariantCultureIgnoreCase);
            if (this.Items == null)
                this.Items = new List<SelectListItem>();
            if (this.EmptyChoise)
                this.Items.Insert(0, new SelectListItem()
                {
                    Text = string.Empty,
                    Value = string.Empty
                });
            base.Initialize();
        }
    }
}