using FireSharp.Response;
using MyzOo.Models;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Methods
{
    internal class ClientCrud
    {
        private readonly Firebase conn = new Firebase();
        private int lastKnownID = -1;

        // Returns client ID if found, else null
        public string Login(string username, string password)
        {
            List<Client> clients = this.LoadData();
            foreach (Client c in clients)
            {
                if (c.Username == username && c.Password == Client.encryptSHA512(password))
                    return c.Id.ToString();
            }

            return null;
        }

        // Register new client
        public void SetData(string username, string password)
        {
            // Refresh memory so we know what the last registered ID was
            this.LoadData();
            try
            {
                Client set = new Client(username, Client.encryptSHA512(password))
                {
                    Id = ++lastKnownID
                };
                var SetData = conn.client.Set("clients/" + lastKnownID, set);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        public List<Client> LoadData()
        {
            try
            {
                FirebaseResponse al = conn.client.Get("clients/");
                List<Client> listData = JsonConvert.DeserializeObject<List<Client>>(al.Body.ToString());
                if (listData == null || listData.Count == 0)
                    return null;

                List<Client> allData = new List<Client>();
                foreach (var kvp in listData)
                {
                    allData.Add(kvp);
                    this.lastKnownID = kvp.Id;
                }

                return allData;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                return null;
            }
        }
        public void UpdateData(int id, string username, string password)
        {
            return;
        }

        public void DeleteData(int id)
        {
            return;
        }
    }
}
