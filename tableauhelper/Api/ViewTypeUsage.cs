using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
    [XmlType(AnonymousType=true)]
    public class ViewTypeUsage {
        
        private string _totalViewCountField;
        
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string TotalViewCount {
            get {
                return _totalViewCountField;
            }
            set {
                _totalViewCountField = value;
            }
        }
    }
}