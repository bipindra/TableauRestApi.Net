using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class PermissionsType {
        
        private ParentType _parentField;
        
        private object _itemField;
        
        private List<GranteeCapabilitiesType> _granteeCapabilitiesField;
        
        public PermissionsType() {
            _granteeCapabilitiesField = new List<GranteeCapabilitiesType>();
            _parentField = new ParentType();
        }
        
        public ParentType Parent {
            get {
                return _parentField;
            }
            set {
                _parentField = value;
            }
        }
        
        [XmlElement("datasource", typeof(DataSourceType))]
        [XmlElement("project", typeof(ProjectType))]
        [XmlElement("workbook", typeof(WorkbookType))]
        public object Item {
            get {
                return _itemField;
            }
            set {
                _itemField = value;
            }
        }
        
        [XmlElement("granteeCapabilities")]
        public List<GranteeCapabilitiesType> GranteeCapabilities {
            get {
                return _granteeCapabilitiesField;
            }
            set {
                _granteeCapabilitiesField = value;
            }
        }
    }
}