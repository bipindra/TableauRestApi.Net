using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class SiteType {
        
        private SiteTypeUsage _usageField;
        
        private string _idField;
        
        private string _nameField;
        
        private string _contentUrlField;
        
        private SiteTypeAdminMode _adminModeField;
        
        private bool _adminModeFieldSpecified;
        
        private string _userQuotaField;
        
        private string _storageQuotaField;
        
        private bool _disableSubscriptionsField;
        
        private bool _disableSubscriptionsFieldSpecified;
        
        private SiteTypeState _stateField;
        
        private bool _stateFieldSpecified;
        
        public SiteType() {
            _usageField = new SiteTypeUsage();
        }
        
        public SiteTypeUsage Usage {
            get {
                return _usageField;
            }
            set {
                _usageField = value;
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
        
        [XmlAttribute("contentUrl")]
        public string ContentUrl {
            get {
                return _contentUrlField;
            }
            set {
                _contentUrlField = value;
            }
        }
        
        [XmlAttribute()]
        public SiteTypeAdminMode AdminMode {
            get {
                return _adminModeField;
            }
            set {
                _adminModeField = value;
            }
        }
        
        [XmlIgnore()]
        public bool AdminModeSpecified {
            get {
                return _adminModeFieldSpecified;
            }
            set {
                _adminModeFieldSpecified = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string UserQuota {
            get {
                return _userQuotaField;
            }
            set {
                _userQuotaField = value;
            }
        }
        
        [XmlAttribute(DataType="integer")]
        public string StorageQuota {
            get {
                return _storageQuotaField;
            }
            set {
                _storageQuotaField = value;
            }
        }
        
        [XmlAttribute()]
        public bool DisableSubscriptions {
            get {
                return _disableSubscriptionsField;
            }
            set {
                _disableSubscriptionsField = value;
            }
        }
        
        [XmlIgnore()]
        public bool DisableSubscriptionsSpecified {
            get {
                return _disableSubscriptionsFieldSpecified;
            }
            set {
                _disableSubscriptionsFieldSpecified = value;
            }
        }
        
        [XmlAttribute()]
        public SiteTypeState State {
            get {
                return _stateField;
            }
            set {
                _stateField = value;
            }
        }
        
        [XmlIgnore()]
        public bool StateSpecified {
            get {
                return _stateFieldSpecified;
            }
            set {
                _stateFieldSpecified = value;
            }
        }
    }
}