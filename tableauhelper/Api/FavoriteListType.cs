using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
  
    [XmlRoot(Namespace="http://tableau.com/api")]
    public class FavoriteListType {
        
        private List<FavoriteType> _favoriteField;
        
        public FavoriteListType() {
            _favoriteField = new List<FavoriteType>();
        }
        
        [XmlElement("favorite")]
        public List<FavoriteType> Favorite {
            get {
                return _favoriteField;
            }
            set {
                _favoriteField = value;
            }
        }
    }
}