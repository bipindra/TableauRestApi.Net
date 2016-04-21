using System;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
  
    [XmlRoot( IsNullable=false)]
    public enum SiteRoleType {
        
        /// <remarks/>
        Guest,
        
        /// <remarks/>
        Interactor,
        
        /// <remarks/>
        Publisher,
        
        /// <remarks/>
        ServerAdministrator,
        
        /// <remarks/>
        SiteAdministrator,
        
        /// <remarks/>
        Unlicensed,
        
        /// <remarks/>
        UnlicensedWithPublish,
        
        /// <remarks/>
        Viewer,
        
        /// <remarks/>
        ViewerWithPublish,
    }
}