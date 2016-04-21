using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class WorkbookListType {
        
        private List<WorkbookType> _workbookField;
        
        public WorkbookListType() {
            _workbookField = new List<WorkbookType>();
        }
        
        [XmlElement("workbook")]
        public List<WorkbookType> Workbook {
            get {
                return _workbookField;
            }
            set {
                _workbookField = value;
            }
        }
    }
}