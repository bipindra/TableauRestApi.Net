using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class TagListType {
        
        private List<TagType> _tagField;
        
        public TagListType() {
            _tagField = new List<TagType>();
        }
        
        [XmlElement("tag")]
        public List<TagType> Tag {
            get {
                return _tagField;
            }
            set {
                _tagField = value;
            }
        }
    }
}