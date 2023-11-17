using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class Firebase
    {
        //firebase connection Settings
        public IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "4aMoTZ643V42sf4UZCPitkoc1qZrUhfmzB8aKJar",
            BasePath = "https://myzooipca-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        public IFirebaseClient client;
        //Code to warn console if class cannot connect when called.
        public Firebase()
        {
            try
            {
                client = new FireSharp.FirebaseClient(fc);
            }
            catch (Exception)
            {
                Console.WriteLine("sunucuya bağlanılamadı");
            }
        }
    }
}
