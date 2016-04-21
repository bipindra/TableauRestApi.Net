using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ErrorType {
        
        private string _summaryField;
        
        private string _detailField;
        
        private string _codeField;
        
        [XmlElement("summary")]
        public string Summary {
            get {
                return _summaryField;
            }
            set {
                _summaryField = value;
            }
        }
        
        [XmlElement("detail")]
        public string Detail {
            get {
                return _detailField;
            }
            set {
                _detailField = value;
            }
        }
        
        [XmlAttribute(AttributeName = "code",DataType="positiveInteger")]
        public string Code {
            get {
                return _codeField;
            }
            set {
                _codeField = value;
            }
        }
    }
}