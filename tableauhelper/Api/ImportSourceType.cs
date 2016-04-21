using System;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
  
    [XmlRoot( IsNullable=false)]
    public enum ImportSourceType {
        
        /// <remarks/>
        ActiveDirectory,
    }
}