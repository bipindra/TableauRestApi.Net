using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class TagType {
        
        private string _labelField;
        
        [XmlAttribute()]
        public string Label {
            get {
                return _labelField;
            }
            set {
                _labelField = value;
            }
        }
    }
}