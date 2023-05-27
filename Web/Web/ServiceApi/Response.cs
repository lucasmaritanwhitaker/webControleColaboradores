namespace Web.ServiceApi
{
    public static class Response
    {
        //public static T GetModel<T>(this HttpResponseMessage request) => JsonContent.DeserializeObject<T>(request.Content.ReadAsStringAsync().Result);
        public static string GetMessage(this HttpResponseMessage request) => request.Content.ReadAsStringAsync().Result;
    }
}
