using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableauHelper.Api;

namespace TableauHelper.RestClient
{
    public class TableauApi : ITableauApi
    {
        private readonly RestApiClient _client;
        private readonly ConnectionType connType;

        public TableauApi(ConnectionType options, string site):this(options,site, "9.2")
        {

        }
        public TableauApi(ConnectionType options,string site,string serverVersion)
        {
            _client = new RestApiClient(options.ServerAddress,options.UserName,options.Password,site,serverVersion);
            OnError = DefaultOnError;
        }

        private void DefaultOnError(ErrorType e)
        {

            throw new Exception(e.Summary)
            {
                Data =
                    {
                        {"Code", e.Code},
                        {"Summary", e.Summary},
                        {"Detail", e.Detail}
                    }
            };
        }
        private async Task<T> GetApi<T>(string api) where T : class
        {
            return await GetApi<T>(api, false);
        }
        private async Task<T> GetApi<T>(string api,bool? login) where T:class 
        {
            var response = await _client.GetApi(api,login);
            foreach (object item in response.Items)
            {

                T unknown = item as T;
                if (unknown != null) return unknown;
                var error = item as ErrorType;
                if (error != null)
                {
                    OnError.Invoke(error);
                }
            }
            return null;
        }

        public Action<ErrorType> OnError { get; set; }

        public async Task<bool> SignIn()
        {
            return await _client.SignIn(null);
        }

        public async Task<bool> SignIn(string userId)
        {
            return await _client.SignIn(userId);
        }

        

        public async Task<bool> SignOut()
        {
            await _client.PostApi("auth/signout", "", true);
            return true;
        }

        
        public async Task<IEnumerable<UserType>> GetUsers()
        {
            var response = await GetApi<UserListType>("users");
            return response != null ? response.User : null;
        }

        #region Query_Site
        public async Task<SiteType> Query_Site()
        {
            return await Query_Site(null, null);
        }

        public async Task<SiteType> Query_Site(string siteId)
        {
            return await Query_Site(siteId, null);
        }
        public async Task<SiteType> Query_Site(string siteId, string key)
        {
            
            if (string.IsNullOrEmpty(siteId))
            {
                siteId = _client.SiteId;
                key = string.Empty;
            }
            string url = siteId;
            key = key ?? "";
            switch (key.ToLower())
            {
                case "name":
                    url += "?key=name";
                    break;
                case "contenturl":
                    url += "?key=contentUrl";
                    break;
            }
            return await GetApi<SiteType>(url);
        }
        #endregion

        #region Query_Sites
        public async Task<SiteListType> Query_Sites()
        {
            return await Query_Sites(null, null);
        }
        public async Task<SiteListType> Query_Sites(int? pageSize, int? pageNumber)
        {
            var url = "sites/?";
            url += pageSize.HasValue ? "pageSize=" + pageSize.Value.ToString() : string.Empty;
            url += pageNumber.HasValue ? "pageNumber=" + pageNumber.Value.ToString() : string.Empty;
            return await GetApi<SiteListType>(url, true);
        }

        #endregion

        #region Query_Projects
        public async Task<ProjectListType> Query_Projects()
        {
            return await Query_Projects(null, null);
        }

        public async Task<ProjectListType> Query_Projects(int? pageSize, int? pageNumber)
        {
            var url = "projects/?";
            url += pageSize.HasValue ? "pageSize=" + pageSize.Value.ToString() : string.Empty;
            url += pageNumber.HasValue ? "pageNumber=" + pageNumber.Value.ToString() : string.Empty;
            return await GetApi<ProjectListType>(url);
        }
        #endregion
    }
}