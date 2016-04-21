using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ParentType {
        
        private string _idField;
        
        private ParentTypeType _typeField;
        
        [XmlAttribute()]
        public string Id {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
        
        [XmlAttribute()]
        public ParentTypeType Type {
            get {
                return _typeField;
            }
            set {
                _typeField = value;
            }
        }
    }
}