using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class TableauCredentialsType {
        
        private SiteType _siteField;
        
        private UserType _userField;
        
        private string _nameField;
        
        private string _passwordField;
        
        private string _tokenField;
        
        public TableauCredentialsType() {
            _userField = new UserType();
            _siteField = new SiteType();
        }
        
        [XmlElement("site",typeof(SiteType))]
        public SiteType Site {
            get {
                return _siteField;
            }
            set {
                _siteField = value;
            }
        }
        
        [XmlElement("user",typeof(UserType))]
        public UserType User {
            get {
                return _userField;
            }
            set {
                _userField = value;
            }
        }
        
        [XmlAttribute("name")]
        public string Name {
            get {
                return _nameField;
            }
            set {
                _nameField = value;
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
        
        [XmlAttribute("token")]
        public string Token {
            get {
                return _tokenField;
            }
            set {
                _tokenField = value;
            }
        }
    }
}