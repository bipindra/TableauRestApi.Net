using System;
using System.Xml.Serialization;

namespace TableauHelper.Api
{
    [Serializable()]
    [XmlType(AnonymousType=true)]
    public enum StatusNoteTypeType {
        
        /// <remarks/>
        CountOfUsersAddedToGroup,
        
        /// <remarks/>
        CountOfUsersAddedToSite,
        
        /// <remarks/>
        CountOfUsersWithInsufficientLicenses,
        
        /// <remarks/>
        CountOfUsersInActiveDirectoryGroup,
        
        /// <remarks/>
        CountOfUsersProcessed,
        
        /// <remarks/>
        CountOfUsersSkipped,
        
        /// <remarks/>
        CountOfUsersInformationUpdated,
        
        /// <remarks/>
        CountOfUsersSiteRoleUpdated,
        
        /// <remarks/>
        CountOfUsersRemovedFromGroup,
        
        /// <remarks/>
        CountOfUsersUnlicensed,
    }
}