using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class GroupType {
        
        private DomainDirectiveType _domainField;
        
        private ImportDirectiveType _importField;
        
        private string _idField;
        
        private string _nameField;
        
        public GroupType() {
            _importField = new ImportDirectiveType();
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
        
        public ImportDirectiveType Import {
            get {
                return _importField;
            }
            set {
                _importField = value;
            }
        }
        
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
        public string Name {
            get {
                return _nameField;
            }
            set {
                _nameField = value;
            }
        }
    }
}