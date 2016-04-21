using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class UserType {
        
        private DomainDirectiveType _domainField;
        
        private string _idField;
        
        private string _nameField;
        
        private string _fullNameField;
        
        private string _emailField;
        
        private string _passwordField;
        
        private SiteRoleType _siteRoleField;
        
        private bool _siteRoleFieldSpecified;
        
        private DateTime _lastLoginField;
        
        private bool _lastLoginFieldSpecified;
        
        private string _externalAuthUserIdField;
        
        public UserType() {
            _domainField = new DomainDirectiveType();
        }
        
        public DomainDirectiveType Domain {
            get {
                return _domainField;
            }
            set {
                _domainField = value;
            }
        }
        
        [XmlAttribute("id")]
        public string Id {
            get {
                return _idField;
            }
            set {
                _idField = value;
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
        
        [XmlAttribute("fullname")]
        public string FullName {
            get {
                return _fullNameField;
            }
            set {
                _fullNameField = value;
            }
        }
        
        [XmlAttribute("email")]
        public string Email {
            get {
                return _emailField;
            }
            set {
                _emailField = value;
            }
        }
        
        [XmlAttribute("password")]
        public string Password {
            get {
                return _passwordField;
            }
            set {
                _passwordField = value;
            }
        }
        
        [XmlAttribute("siteRole")]
        public SiteRoleType SiteRole {
            get {
                return _siteRoleField;
            }
            set {
                _siteRoleField = value;
            }
        }
        
        [XmlIgnore()]
        public bool SiteRoleSpecified {
            get {
                return _siteRoleFieldSpecified;
            }
            set {
                _siteRoleFieldSpecified = value;
            }
        }
        
        [XmlAttribute()]
        public DateTime LastLogin {
            get {
                return _lastLoginField;
            }
            set {
                _lastLoginField = value;
            }
        }
        
        [XmlIgnore()]
        public bool LastLoginSpecified {
            get {
                return _lastLoginFieldSpecified;
            }
            set {
                _lastLoginFieldSpecified = value;
            }
        }
        
        [XmlAttribute()]
        public string ExternalAuthUserId {
            get {
                return _externalAuthUserIdField;
            }
            set {
                _externalAuthUserIdField = value;
            }
        }
    }
}