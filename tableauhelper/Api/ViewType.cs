using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ViewType {
        
        private ViewTypeUsage _usageField;
        
        private string _idField;
        
        private string _nameField;
        
        private string _contentUrlField;
        
        public ViewType() {
            _usageField = new ViewTypeUsage();
        }
        
        public ViewTypeUsage Usage {
            get {
                return _usageField;
            }
            set {
                _usageField = value;
            }
        }
        
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
        public string Name {
            get {
                return _nameField;
            }
            set {
                _nameField = value;
            }
        }
        
        [XmlAttribute()]
        public string ContentUrl {
            get {
                return _contentUrlField;
            }
            set {
                _contentUrlField = value;
            }
        }
    }
}