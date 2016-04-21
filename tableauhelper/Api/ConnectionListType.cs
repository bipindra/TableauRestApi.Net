using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ConnectionListType {
        
        private List<ConnectionType> _connectionField;
        
        public ConnectionListType() {
            _connectionField = new List<ConnectionType>();
        }
        
        [XmlElement("connection")]
        public List<ConnectionType> Connection {
            get {
                return _connectionField;
            }
            set {
                _connectionField = value;
            }
        }
    }
}