using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class StatusNoteListType {
        
        private List<StatusNoteType> _statusNoteField;
        
        public StatusNoteListType() {
            _statusNoteField = new List<StatusNoteType>();
        }
        
        [XmlElement("statusNote")]
        public List<StatusNoteType> StatusNote {
            get {
                return _statusNoteField;
            }
            set {
                _statusNoteField = value;
            }
        }
    }
}