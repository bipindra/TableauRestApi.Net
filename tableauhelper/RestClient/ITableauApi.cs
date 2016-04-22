using System.Collections.Generic;
using System.Threading.Tasks;
using TableauHelper.Api;

namespace TableauHelper.RestClient
{
    public interface ITableauApi
    {
        Task<bool> SignIn();
        Task<bool> SignOut();


        Task<SiteType> Query_Site(string siteId, string key);
        Task<SiteListType> Query_Sites();
        Task<SiteListType> Query_Sites(int? pageSize, int? pageNumber);


        Task<ProjectListType> Query_Projects();
        Task<ProjectListType> Query_Projects(int? pageSize, int? pageNumber);

        Task<IEnumerable<UserType>> GetUsers();


    }
}