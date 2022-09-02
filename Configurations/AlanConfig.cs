using Microsoft.Office.SharePoint.Tools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization;

namespace SFDevSept2022.Configurations
{
    public class AlanConfig: ConfigSection
    {
        [ObjectInfo(Title = "FaceBookUsername", Description = "This is a FaceBookUsername field.")]
        [ConfigurationProperty("FaceBookUsername", DefaultValue = "")]
        public string FaceBookUsernameProperty
        {
            get
            {
                return (string)this["FaceBookUsername"];
            }
            set
            {
                this["FaceBookUsername"] = value;
            }
        }

        [ObjectInfo(Title = "FaceBookPassword", Description = "This is a FaceBookPassword field.")]
        [ConfigurationProperty("FaceBookPassword", DefaultValue = "")]
        public string FaceBookPasswordProperty
        {
            get
            {
                return (string)this["FaceBookPassword"];
            }
            set
            {
                this["FaceBookPassword"] = value;
            }
        }
    }
}