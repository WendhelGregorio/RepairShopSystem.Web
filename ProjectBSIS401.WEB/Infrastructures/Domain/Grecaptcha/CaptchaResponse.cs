using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Grecaptcha
{
    public class CaptchaResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
       

        [JsonProperty("error-codes")]
        public List<string> ErrorMessage { get; set; }

        public static bool Validate(string encodedResponse)
        {
            if (string.IsNullOrEmpty(encodedResponse)) return false;

            var client = new System.Net.WebClient();
            var secretPrivateKey = "6LeOOOEZAAAAAF2ZsonaerieReKW62bYdjNnqmzr";

            if (string.IsNullOrEmpty(secretPrivateKey)) return false;

            var googleReply = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretPrivateKey, encodedResponse));

            var captchaResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<CaptchaResponse>(googleReply);

            return captchaResponse.Success;

           
        }

    }
}
