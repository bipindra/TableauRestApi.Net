using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class SiteListType {
        
        private List<SiteType> _siteField;
        
        public SiteListType() {
            _siteField = new List<SiteType>();
        }
        
        [XmlElement("site")]
        public List<SiteType> Site {
            get {
                return _siteField;
            }
            set {
                _siteField = value;
            }
        }
    }
}