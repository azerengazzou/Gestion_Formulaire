using backend.Services.Interfaces;

namespace backend.Services.Classes
{
    public class CmpServices : ICmpServices
    {

        public readonly ICmpServices _servicesCMP;
        public CmpServices(ICmpServices cmpservices)
        {
            _servicesCMP = cmpservices;
        }
    }
}
