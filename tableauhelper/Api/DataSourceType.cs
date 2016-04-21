using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class DataSourceType {
        
        private ConnectionCredentialsType _connectionCredentialsField;
        
        private SiteType _siteField;
        
        private ProjectType _projectField;
        
        private UserType _ownerField;
        
        private List<TagType> _tagsField;
        
        private string _idField;
        
        private string _nameField;
        
        private string _descriptionField;
        
        private string _typeField;
        
        public DataSourceType() {
            _tagsField = new List<TagType>();
            _ownerField = new UserType();
            _projectField = new ProjectType();
            _siteField = new SiteType();
            _connectionCredentialsField = new ConnectionCredentialsType();
        }
        
        public ConnectionCredentialsType ConnectionCredentials {
            get {
                return _connectionCredentialsField;
            }
            set {
                _connectionCredentialsField = value;
            }
        }
        
        public SiteType Site {
            get {
                return _siteField;
            }
            set {
                _siteField = value;
            }
        }
        
        public ProjectType Project {
            get {
                return _projectField;
            }
            set {
                _projectField = value;
            }
        }
        
        public UserType Owner {
            get {
                return _ownerField;
            }
            set {
                _ownerField = value;
            }
        }
        
        [XmlArrayItem("tag", IsNullable=false)]
        public List<TagType> Tags {
            get {
                return _tagsField;
            }
            set {
                _tagsField = value;
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
        public string Type {
            get {
                return _typeField;
            }
            set {
                _typeField = value;
            }
        }
    }
}