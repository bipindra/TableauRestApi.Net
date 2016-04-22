using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TableauHelper.Api;

namespace TableauHelper.RestClient
{
    /// <summary>
    ///     Tableau Rest API Client
    /// </summary>
    public class RestApiClient
    {
        private readonly Dictionary<string, IEnumerable<string>> _apiCapabilities = new Dictionary
            <string, IEnumerable<string>>
        {
            {
                "2.1", new List<string>
                {
                    "QuerySites",
                    "Query_Views"
                }
            }
        };

        /// <summary>
        ///     currently supporting version - needed coz each version has different xml namespace
        /// </summary>
        private readonly Dictionary<string, string> _namespaceMap = new Dictionary<string, string>
        {
            {"2.1", "http://tableau.com/api"},
            {"2.2", "http://tableau.com/api"}
        };

        private readonly Dictionary<string, string> _versionMap = new Dictionary<string, string>
        {
            {"9.2", "2.1"},
            {"9.3", "2.2"}
        };

        private string Server { get; set; }
        private string DefaultSite { get; set; }

        private string DefaultUserName { get; set; }

        private string DefaultPassword { get; set; }

        public string ApiVersion { get; private set; }

        public string SiteId { get; private set; }

        public string UserId { get; private set; }
        public string Token { get; private set; }

        #region Logging

        /// <summary>
        ///     A way to create custom log
        /// </summary>
        public Action<string> Log { get; set; }

        #endregion


        #region Constructor

        /// <summary>
        ///     Constructor with blank site
        /// </summary>
        /// <param name="server"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public RestApiClient(string server, string user, string password)
            : this(server, user, password, "")
        {
        }

        /// <summary>
        ///     Constructor with default version to 2.2
        /// </summary>
        /// <param name="server"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <param name="site"></param>
        public RestApiClient(string server, string user, string password, string site)
            : this(server, user, password, site, "9.3")
        {
        }

        /// <summary>
        ///     Main Constructor with all params
        /// </summary>
        /// <param name="server"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <param name="site"></param>
        /// <param name="apiVersion"></param>
        public RestApiClient(string server, string user, string password, string site, string apiVersion)
        {
            Server = server;
            DefaultSite = site ?? "";
            DefaultUserName = user;
            DefaultPassword = password;
            ApiVersion = _versionMap[apiVersion];
            Log = x => { };
        }

        #endregion

        #region Rest API Implementations


        #region Generic Api

        public async Task<TsResponse> GetApi(string url,bool? login)
        {
            var apiUrl = BuildApiUrl(url, login);
            var resultContent = await GetApiAsync(apiUrl);
            return resultContent.XmlDeserializeFromString<TsResponse>();
        }

        public async Task<TsResponse> PostApi(string url,string content, bool login=false)
        {
            var apiUrl = BuildApiUrl(url,login);
            var resultContent = await PostAsync(apiUrl,content);
            if (string.IsNullOrEmpty(resultContent)) return null;
            return resultContent.XmlDeserializeFromString<TsResponse>();
        }

        #endregion

        #region Helper methods

        private string BuildApiUrl(string callingUrl)
        {
            return BuildApiUrl(callingUrl, false);
        }
        private string BuildApiUrl(string callingUrl, bool? login)
        {
            if (login??false)
            {
                return Server + "/api/" + ApiVersion + "/" + callingUrl;
            }
            return Server + "/api/" + ApiVersion + "/sites/" + SiteId + "/" + callingUrl;
        }

        private async Task<string> GetApiAsync(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Server);
                client.DefaultRequestHeaders.Add("X-Tableau-Auth", Token);
                var result = await client.GetAsync(apiUrl);
                var data = await result.Content.ReadAsStringAsync();
                Log(data);
                return data;
            }
        }


        private async Task<string> PostAsync(string url, string input)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Server);
                var content = new StringContent(input, Encoding.UTF8, "application/xml");
                client.DefaultRequestHeaders.Add("X-Tableau-Auth", Token);
                var result = await client.PostAsync(url, content).ConfigureAwait(true);
                var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(true);
                Log(resultContent);
                return resultContent;

            }
        }

        #endregion

        #region Authentication

        /// <summary>
        ///     Sign In
        /// </summary>
        public async Task<bool> SignIn()
        {
            return await SignIn(null);
        }

        /// <summary>
        ///     Sign in with impersonate user id
        /// </summary>
        /// <param name="impersonateUserId"></param>
        public async Task<bool> SignIn(string impersonateUserId)
        {
            var apiUrl = "auth/signin";
            var user = string.IsNullOrEmpty(impersonateUserId)
                ? "": string.Format("<user id=\"{0}\" />", impersonateUserId);

            var input = string.Format("<tsRequest><credentials name=\"{0}\" password=\"{1}\" ><site contentUrl=\"{2}\" /> {3}</credentials></tsRequest>",
                 DefaultUserName, DefaultPassword, DefaultSite, user);

            var tsSignInResponse = await PostApi(apiUrl, input,true);
            var cred = tsSignInResponse.Items.First() as TableauCredentialsType;
            if (cred != null)
            {
                Token = cred.Token;
                SiteId = cred.Site.Id;
                UserId = cred.User.Id;
                return false;
            }
            return true;
        }

       

        #endregion

     
        #endregion
    }
}