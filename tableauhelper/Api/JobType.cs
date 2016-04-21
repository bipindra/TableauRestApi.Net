using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class JobType {
        
        private List<StatusNoteType> _statusNotesField;
        
        private string _idField;
        
        private JobTypeMode _modeField;
        
        private bool _modeFieldSpecified;
        
        private JobTypeType _typeField;
        
        private bool _typeFieldSpecified;
        
        private string _progressField;
        
        private DateTime _createdAtField;
        
        private bool _createdAtFieldSpecified;
        
        private DateTime _updatedAtField;
        
        private bool _updatedAtFieldSpecified;
        
        private DateTime _completedAtField;
        
        private bool _completedAtFieldSpecified;
        
        public JobType() {
            _statusNotesField = new List<StatusNoteType>();
        }
        
        [XmlArrayItem("statusNote", IsNullable=false)]
        public List<StatusNoteType> StatusNotes {
            get {
                return _statusNotesField;
            }
            set {
                _statusNotesField = value;
            }
        }
        
        [XmlAttribute()]
        public string Id {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
        
        [XmlAttribute()]
        public JobTypeMode Mode {
            get {
                return _modeField;
            }
            set {
                _modeField = value;
            }
        }
        
        [XmlIgnore()]
        public bool ModeSpecified {
            get {
                return _modeFieldSpecified;
            }
            set {
                _modeFieldSpecified = value;
            }
        }
        
        [XmlAttribute()]
        public JobTypeType Type {
            get {
                return _typeField;
            }
            set {
                _typeField = value;
            }
        }
        
        [XmlIgnore()]
        public bool TypeSpecified {
            get {
                return _typeFieldSpecified;
            }
            set {
                _typeFieldSpecified = value;
            }
        }
        
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string Progress {
            get {
                return _progressField;
            }
            set {
                _progressField = value;
            }
        }
        
        [XmlAttribute()]
        public DateTime CreatedAt {
            get {
                return _createdAtField;
            }
            set {
                _createdAtField = value;
            }
        }
        
        [XmlIgnore()]
        public bool CreatedAtSpecified {
            get {
                return _createdAtFieldSpecified;
            }
            set {
                _createdAtFieldSpecified = value;
            }
        }
        
        [XmlAttribute()]
        public DateTime UpdatedAt {
            get {
                return _updatedAtField;
            }
            set {
                _updatedAtField = value;
            }
        }
        
        [XmlIgnore()]
        public bool UpdatedAtSpecified {
            get {
                return _updatedAtFieldSpecified;
            }
            set {
                _updatedAtFieldSpecified = value;
            }
        }
        
        [XmlAttribute()]
        public DateTime CompletedAt {
            get {
                return _completedAtField;
            }
            set {
                _completedAtField = value;
            }
        }
        
        [XmlIgnore()]
        public bool CompletedAtSpecified {
            get {
                return _completedAtFieldSpecified;
            }
            set {
                _completedAtFieldSpecified = value;
            }
        }
    }
}