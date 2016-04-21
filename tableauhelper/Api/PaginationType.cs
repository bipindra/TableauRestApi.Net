using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(IsNullable=true)]
    public class PaginationType {
        
        private string _pageNumberField;
        
        private string _pageSizeField;
        
        private string _totalAvailableField;
        
        [XmlAttribute(DataType="positiveInteger")]
        public string PageNumber {
            get {
                return _pageNumberField;
            }
            set {
                _pageNumberField = value;
            }
        }
        
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string PageSize {
            get {
                return _pageSizeField;
            }
            set {
                _pageSizeField = value;
            }
        }
        
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string TotalAvailable {
            get {
                return _totalAvailableField;
            }
            set {
                _totalAvailableField = value;
            }
        }
    }
}