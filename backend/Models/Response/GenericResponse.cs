using System.Net;

namespace backend.Models.Response
{
    public class GenericResponse<T>
    {
        public List<T> FbuilderList { get; set; }
        public string ErrorMessage { get; set; }
        public string ResultMessage { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
