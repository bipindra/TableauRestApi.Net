using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class StatusNoteType {
        
        private StatusNoteTypeType _typeField;
        
        private string _valueField;
        
        private string _textField;
        
        [XmlAttribute()]
        public StatusNoteTypeType Type {
            get {
                return _typeField;
            }
            set {
                _typeField = value;
            }
        }
        
        [XmlAttribute()]
        public string Value {
            get {
                return _valueField;
            }
            set {
                _valueField = value;
            }
        }
        
        [XmlAttribute()]
        public string Text {
            get {
                return _textField;
            }
            set {
                _textField = value;
            }
        }
    }
}