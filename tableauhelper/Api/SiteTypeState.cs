using System;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    [XmlType(AnonymousType=true)]
    public enum SiteTypeState {
        
        /// <remarks/>
        Active,
        
        /// <remarks/>
        Suspended,
    }
}