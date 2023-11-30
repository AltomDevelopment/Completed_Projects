using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteHealthApp
{
    internal class APIhandling
    {
        //What spotify returns when the request is submitted 
        /*{
            "access_token": "BQDBKJ5eo5jxbtpWjVOj7ryS84khybFpP_lTqzV7uV-T_m0cTfwvdn5BnBSKPxKgEb11",
            "token_type": "Bearer",
            "expires_in": 3600
        }*/

        //private async Task<string> GetAccessToken()
        //{
        //SpotifyToken token = new SpotifyToken();
        //Will have to create a new class to create the spotify token
        /*
         * public class SpotifyToken 
        { 
        public string access_token { get; set; } 
        public string token_type { get; set; }
        public int expires_in { get; set; } 
        }
        */
        /*
    string postString = string.Format("grant_type=client_credentials");

    byte[] byteArray = Encoding.UTF8.GetBytes(postString);
    string url = "https://accounts.spotify.com/api/token";

    WebRequest request = WebRequest.Create(url);
    request.Method = "POST";
    request.Headers.Add("Authorization", "Basic {Encoded ClientId:ClientSecret}"); request.ContentType = "application/x-www-form-urlencoded";
    request.ContentLength = byteArray.Length;

    using (Stream dataStream = request.GetRequestStream())
    {
        dataStream.Write(byteArray, 0, byteArray.Length);
        using (WebResponse response = await request.GetResponseAsync())
        {
            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string responseFromServer = reader.ReadToEnd();
                    token = JsonConvert.DeserializeObject << strong > SpotifyToken </ strong >> (responseFromServer);
                }
            }
        }
    }

    return token.access_token;*/
    }
}
