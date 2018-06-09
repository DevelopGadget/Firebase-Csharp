
using Firbase_Example.Model;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;

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
                AuthSecret = "AIzaSyAPS6szX5-SYS0hmtdcTJb0MQeaMlmC9p4",
                BasePath = "https://csharp-example.firebaseio.com/",
            };
            _Client = new FirebaseClient(Config);
        }

        public bool Client()
        {
            return _Client != null ? true : false;
        }

        public void CreateUser(User Cuenta)
        {
            _Client.CreateUser(Cuenta.Email, Cuenta.Password);
        }
    }
}
