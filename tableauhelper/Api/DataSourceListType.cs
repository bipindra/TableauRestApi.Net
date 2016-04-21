using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class DataSourceListType {
        
        private List<DataSourceType> _datasourceField;
        
        public DataSourceListType() {
            _datasourceField = new List<DataSourceType>();
        }
        
        [XmlElement("datasource")]
        public List<DataSourceType> Datasource {
            get {
                return _datasourceField;
            }
            set {
                _datasourceField = value;
            }
        }
    }
}