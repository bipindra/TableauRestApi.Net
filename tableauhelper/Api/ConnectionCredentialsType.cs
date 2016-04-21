using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class ConnectionCredentialsType {
        
        private string _nameField;
        
        private string _passwordField;
        
        private bool _embedField;
        
        private bool _embedFieldSpecified;
        
        private bool _oAuthField;
        
        private bool _oAuthFieldSpecified;
        
        [XmlAttribute()]
        public string Name {
            get {
                return _nameField;
            }
            set {
                _nameField = value;
            }
        }
        
        [XmlAttribute()]
        public string Password {
            get {
                return _passwordField;
            }
            set {
                _passwordField = value;
            }
        }
        
        [XmlAttribute()]
        public bool Embed {
            get {
                return _embedField;
            }
            set {
                _embedField = value;
            }
        }
        
        [XmlIgnore()]
        public bool EmbedSpecified {
            get {
                return _embedFieldSpecified;
            }
            set {
                _embedFieldSpecified = value;
            }
        }
        
        [XmlAttribute()]
        public bool OAuth {
            get {
                return _oAuthField;
            }
            set {
                _oAuthField = value;
            }
        }
        
        [XmlIgnore()]
        public bool OAuthSpecified {
            get {
                return _oAuthFieldSpecified;
            }
            set {
                _oAuthFieldSpecified = value;
            }
        }
    }
}