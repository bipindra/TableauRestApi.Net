using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ConnectionType {
        
        private string _idField;
        
        private string _typeField;
        
        private string _serverAddressField;
        
        private string _serverPortField;
        
        private string _userNameField;
        
        private string _passwordField;
        
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
        public string Type {
            get {
                return _typeField;
            }
            set {
                _typeField = value;
            }
        }
        
        [XmlAttribute()]
        public string ServerAddress {
            get {
                return _serverAddressField;
            }
            set {
                _serverAddressField = value;
            }
        }
        
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string ServerPort {
            get {
                return _serverPortField;
            }
            set {
                _serverPortField = value;
            }
        }
        
        [XmlAttribute()]
        public string UserName {
            get {
                return _userNameField;
            }
            set {
                _userNameField = value;
            }
        }
        
        [XmlAttribute()]
        public string Password {
            get {
                return _passwordField;
            }
            set {
                _passwordField = value;
            }
        }
    }
}