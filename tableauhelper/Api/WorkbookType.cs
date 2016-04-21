using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class WorkbookType {
        
        private ConnectionCredentialsType _connectionCredentialsField;
        
        private SiteType _siteField;
        
        private ProjectType _projectField;
        
        private UserType _ownerField;
        
        private List<TagType> _tagsField;
        
        private List<ViewType> _viewsField;
        
        private string _idField;
        
        private string _nameField;
        
        private string _descriptionField;
        
        private string _contentUrlField;
        
        private bool _showTabsField;
        
        private bool _showTabsFieldSpecified;
        
        public WorkbookType() {
            _viewsField = new List<ViewType>();
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
        
        [XmlArrayItem("view", IsNullable=false)]
        public List<ViewType> Views {
            get {
                return _viewsField;
            }
            set {
                _viewsField = value;
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
        public string ContentUrl {
            get {
                return _contentUrlField;
            }
            set {
                _contentUrlField = value;
            }
        }
        
        [XmlAttribute()]
        public bool ShowTabs {
            get {
                return _showTabsField;
            }
            set {
                _showTabsField = value;
            }
        }
        
        [XmlIgnore()]
        public bool ShowTabsSpecified {
            get {
                return _showTabsFieldSpecified;
            }
            set {
                _showTabsFieldSpecified = value;
            }
        }
    }
}