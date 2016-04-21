using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ProjectType {
        
        private UserType _ownerField;
        
        private string _idField;
        
        private string _nameField;
        
        private string _descriptionField;
        
        private ProjectTypeContentPermissions _contentPermissionsField;
        
        private bool _contentPermissionsFieldSpecified;
        
        public ProjectType() {
            _ownerField = new UserType();
        }
        
        public UserType Owner {
            get {
                return _ownerField;
            }
            set {
                _ownerField = value;
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
        
        [XmlAttribute()]
        public string Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
        
        [XmlAttribute()]
        public ProjectTypeContentPermissions ContentPermissions {
            get {
                return _contentPermissionsField;
            }
            set {
                _contentPermissionsField = value;
            }
        }
        
        [XmlIgnore()]
        public bool ContentPermissionsSpecified {
            get {
                return _contentPermissionsFieldSpecified;
            }
            set {
                _contentPermissionsFieldSpecified = value;
            }
        }
    }
}