using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class UserListType {
        
        private List<UserType> _userField;
        
        public UserListType() {
            _userField = new List<UserType>();
        }
        
        [XmlElement("user")]
        public List<UserType> User {
            get {
                return _userField;
            }
            set {
                _userField = value;
            }
        }
    }
}