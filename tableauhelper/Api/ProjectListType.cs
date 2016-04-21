using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ProjectListType {
        
        private List<ProjectType> _projectField;
        
        public ProjectListType() {
            _projectField = new List<ProjectType>();
        }
        
        [XmlElement("project")]
        public List<ProjectType> Project {
            get {
                return _projectField;
            }
            set {
                _projectField = value;
            }
        }
    }
}