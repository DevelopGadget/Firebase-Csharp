
using Firbase_Example.Model;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Firbase_Example.Controller
{
    class FirebaseController
    {
        private static FirebaseClient _Client;
        private IFirebaseConfig Config;

        public FirebaseController()
        {
            Config = new FirebaseConfig
            {
                AuthSecret = "lwZV4HydSMJh1t080Ztuim5u4vcwIsfAcCT8fqbD",
                BasePath = "https://csharp-example.firebaseio.com/",
            };
            _Client = new FirebaseClient(Config);
        }

        public bool Client()
        {
            return _Client != null ? true : false;
        }

        public async Task<bool> CreateUser(User Cuenta)
        {
            PushResponse response = await _Client.PushAsync("Users", Cuenta);
            return response.StatusCode == HttpStatusCode.OK ? true : false;
        }
    }
}
