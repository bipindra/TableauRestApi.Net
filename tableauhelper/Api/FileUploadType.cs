using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class FileUploadType {
        
        private string _uploadSessionIdField;
        
        private string _fileSizeField;
        
        [XmlAttribute()]
        public string UploadSessionId {
            get {
                return _uploadSessionIdField;
            }
            set {
                _uploadSessionIdField = value;
            }
        }
        
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string FileSize {
            get {
                return _fileSizeField;
            }
            set {
                _fileSizeField = value;
            }
        }
    }
}