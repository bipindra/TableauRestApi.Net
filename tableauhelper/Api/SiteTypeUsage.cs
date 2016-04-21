using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
    [XmlType(AnonymousType=true)]
    public class SiteTypeUsage {
        
        private string _numUsersField;
        
        private string _storageField;
        
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string NumUsers {
            get {
                return _numUsersField;
            }
            set {
                _numUsersField = value;
            }
        }
        
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string Storage {
            get {
                return _storageField;
            }
            set {
                _storageField = value;
            }
        }
    }
}