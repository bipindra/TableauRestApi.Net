# TableauRestApi.Net

C# wrapper classes to access tableau rest api.

Currently Supported Server Version : 9.2
Currently Supported Api Version : 2.1 

####Usages:

var api = new TableauApi(new ConnectionType()
            {
                ServerAddress = "http://server/",
                UserName = "username",
                Password = "password"
            }, "");

api.SignIn();

api.GetUsers();

api.Query_Sites();

***All calls are async***