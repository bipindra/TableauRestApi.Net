using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class FavoriteType {
        
        private object _itemField;
        
        private string _labelField;
        
        [XmlElement("view", typeof(ViewType))]
        [XmlElement("workbook", typeof(WorkbookType))]
        public object Item {
            get {
                return _itemField;
            }
            set {
                _itemField = value;
            }
        }
        
        [XmlAttribute()]
        public string Label {
            get {
                return _labelField;
            }
            set {
                _labelField = value;
            }
        }
    }
}