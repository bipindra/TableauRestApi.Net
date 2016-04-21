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
        private string site;
        public TableauApi(ConnectionType options,string site,string serverVersion="9.2")
        {
            site = site;
            _client = new RestApiClient(options.ServerAddress,options.UserName,options.Password,site,"9.2");
            OnError = (e) =>
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
            };
        }


        private async Task<T> GetApi<T>(string api) where T:class 
        {
            var response = await _client.GetApi(api);
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

        public async Task<SiteType> GetSite()
        {
            return await GetSite(null, null);
        }

        public async Task<SiteType> GetSite(string siteId)
        {
            return await GetSite(siteId, null);
        }
        public async Task<SiteType> GetSite(string siteId, string key)
        {
            string url = siteId;
            if (string.IsNullOrEmpty(siteId))
            {
                siteId = _client.SiteId;
            }
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
    }
}