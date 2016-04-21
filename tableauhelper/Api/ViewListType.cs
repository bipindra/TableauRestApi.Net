using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ViewListType {
        
        private List<ViewType> _viewField;
        
        public ViewListType() {
            _viewField = new List<ViewType>();
        }
        
        [XmlElement("view")]
        public List<ViewType> View {
            get {
                return _viewField;
            }
            set {
                _viewField = value;
            }
        }
    }
}