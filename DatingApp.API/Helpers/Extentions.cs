using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extentions
    {
        public static void AddApplicationError(this HttpResponse resoponse, string message) {
            resoponse.Headers.Add("Application-Error", message);
            resoponse.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            resoponse.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}