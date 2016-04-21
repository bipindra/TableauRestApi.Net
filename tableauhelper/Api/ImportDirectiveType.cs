using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ImportDirectiveType {
        
        private ImportSourceType _sourceField;
        
        private string _domainNameField;
        
        private SiteRoleType _siteRoleField;
        
        [XmlAttribute()]
        public ImportSourceType Source {
            get {
                return _sourceField;
            }
            set {
                _sourceField = value;
            }
        }
        
        [XmlAttribute()]
        public string DomainName {
            get {
                return _domainNameField;
            }
            set {
                _domainNameField = value;
            }
        }
        
        [XmlAttribute()]
        public SiteRoleType SiteRole {
            get {
                return _siteRoleField;
            }
            set {
                _siteRoleField = value;
            }
        }
    }
}