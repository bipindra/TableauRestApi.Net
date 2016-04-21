using System;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    [XmlType(AnonymousType=true)]
    public enum CapabilityTypeName {
        
        /// <remarks/>
        AddComment,
        
        /// <remarks/>
        ChangeHierarchy,
        
        /// <remarks/>
        ChangePermissions,
        
        /// <remarks/>
        Connect,
        
        /// <remarks/>
        Delete,
        
        /// <remarks/>
        ExportData,
        
        /// <remarks/>
        ExportImage,
        
        /// <remarks/>
        ExportXml,
        
        /// <remarks/>
        Filter,
        
        /// <remarks/>
        ProjectLeader,
        
        /// <remarks/>
        Read,
        
        /// <remarks/>
        ShareView,
        
        /// <remarks/>
        ViewComments,
        
        /// <remarks/>
        ViewUnderlyingData,
        
        /// <remarks/>
        WebAuthoring,
        
        /// <remarks/>
        Write,
    }
}