using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class GranteeCapabilitiesType {
        
        private object _itemField;
        
        private List<CapabilityType> _capabilitiesField;
        
        public GranteeCapabilitiesType() {
            _capabilitiesField = new List<CapabilityType>();
        }
        
        [XmlElement("group", typeof(GroupType))]
        [XmlElement("user", typeof(UserType))]
        public object Item {
            get {
                return _itemField;
            }
            set {
                _itemField = value;
            }
        }
        
        [XmlArrayItem("capability", IsNullable=false)]
        public List<CapabilityType> Capabilities {
            get {
                return _capabilitiesField;
            }
            set {
                _capabilitiesField = value;
            }
        }
    }
}