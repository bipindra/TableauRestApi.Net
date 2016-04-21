using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    
    [XmlType(AnonymousType=true)]
    [XmlRoot(Namespace="http://tableau.com/api",ElementName = "tsResponse")]
    public class TsResponse {
        
        private List<object> _itemsField;
        
        public TsResponse() {
            _itemsField = new List<object>();
        }
        
        [XmlElement("connection", typeof(ConnectionType))]
        [XmlElement("connections", typeof(ConnectionListType))]
        [XmlElement("credentials", typeof(TableauCredentialsType))]
        [XmlElement("datasource", typeof(DataSourceType))]
        [XmlElement("datasources", typeof(DataSourceListType))]
        [XmlElement("error", typeof(ErrorType))]
        [XmlElement("favorites", typeof(FavoriteListType))]
        [XmlElement("fileUpload", typeof(FileUploadType))]
        [XmlElement("group", typeof(GroupType))]
        [XmlElement("groups", typeof(GroupListType))]
        [XmlElement("job", typeof(JobType))]
        [XmlElement("pagination", typeof(PaginationType))]
        [XmlElement("permissions", typeof(PermissionsType))]
        [XmlElement("project", typeof(ProjectType))]
        [XmlElement("projects", typeof(ProjectListType))]
        [XmlElement("site", typeof(SiteType))]
        [XmlElement("sites", typeof(SiteListType))]
        [XmlElement("tags", typeof(TagListType))]
        [XmlElement("user", typeof(UserType))]
        [XmlElement("users", typeof(UserListType))]
        [XmlElement("views", typeof(ViewListType))]
        [XmlElement("workbook", typeof(WorkbookType))]
        [XmlElement("workbooks", typeof(WorkbookListType))]
        public List<object> Items {
            get {
                return _itemsField;
            }
            set {
                _itemsField = value;
            }
        }
    }
}