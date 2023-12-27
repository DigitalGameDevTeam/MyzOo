using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class Firebase
    {
        public IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "4aMoTZ643V42sf4UZCPitkoc1qZrUhfmzB8aKJar",
            BasePath = "https://myzooipca-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        public IFirebaseClient client;

        public Firebase()
        {
            try
            {
                client = new FireSharp.FirebaseClient(fc);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot connect to the server");
            }
        }
        // Inside the Firebase class
        public async Task<bool> Login(string email, string password)
        {
            try
            {
                FirebaseAuthResponse response = await FirebaseAuthenticationSignInAsync(email, password);

                // Assuming there's a property in FirebaseAuthResponse indicating success or failure
                if (response != null && !string.IsNullOrEmpty(response.IdToken))
                {
                    Console.WriteLine("Login successful!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid email or password");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }



        // Firebase Authentication via REST API
        public async Task<FirebaseAuthResponse> FirebaseAuthenticationSignInAsync(string email, string password)
        {
            using (var httpClient = new HttpClient())
            {
                var request = new Dictionary<string, string>
                {
                    { "email", email },
                    { "password", password },
                    { "returnSecureToken", "false" }
                };

                FormUrlEncodedContent content = new FormUrlEncodedContent(request);

                HttpResponseMessage message = await httpClient.PostAsync($"https://identitytoolkit.googleapis.com/v1/accounts:signUp?key={fc.AuthSecret}", content);
                string response = await message.Content.ReadAsStringAsync();

                if (false /*response.IsSuccessStatusCode*/)
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<FirebaseAuthResponse>(response);
                }
                else
                {
                    throw new Exception($"Authentication failed. Status Code: {message.StatusCode}");
                }
            }
        }


    }

    // Example response model for Firebase Authentication
    public class FirebaseAuthResponse
    {
        public string IdToken { get; set; }
        public string RefreshToken { get; set; }
        // Add other properties as needed
    }
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        // Add other user properties as needed
    }



}
