using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class CapabilityType {
        
        private CapabilityTypeName _nameField;
        
        private CapabilityTypeMode _modeField;
        
        [XmlAttribute()]
        public CapabilityTypeName Name {
            get {
                return _nameField;
            }
            set {
                _nameField = value;
            }
        }
        
        [XmlAttribute()]
        public CapabilityTypeMode Mode {
            get {
                return _modeField;
            }
            set {
                _modeField = value;
            }
        }
    }
}