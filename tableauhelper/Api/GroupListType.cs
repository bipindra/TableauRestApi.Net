using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class GroupListType {
        
        private List<GroupType> _groupField;
        
        public GroupListType() {
            _groupField = new List<GroupType>();
        }
        
        [XmlElement("group")]
        public List<GroupType> Group {
            get {
                return _groupField;
            }
            set {
                _groupField = value;
            }
        }
    }
}