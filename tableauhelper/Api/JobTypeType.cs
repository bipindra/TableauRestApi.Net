using System;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    [XmlType(AnonymousType=true)]
    public enum JobTypeType {
        
        /// <remarks/>
        GroupSync,
    }
}