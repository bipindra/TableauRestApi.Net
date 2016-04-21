using System.Collections.Generic;
using System.Threading.Tasks;
using TableauHelper.Api;

namespace TableauHelper.RestClient
{
    public interface ITableauApi
    {
        Task<bool> SignIn();
        Task<bool> SignOut();


        Task<SiteType> GetSite(string siteId, string key);


        Task<IEnumerable<UserType>> GetUsers();


    }
}