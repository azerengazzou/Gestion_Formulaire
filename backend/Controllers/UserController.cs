using backend.Models;
using backend.Models.Response;
using backend.Repository.Interfaces;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserServices _userservices;

        public UserController(IUserServices userservices)
        {
            this._userservices = userservices;
            
        }

        [HttpGet]
        [Route("RecupererListeUtilisateurs")]
        [ActionName("RecupererListeUtilisateurs")]
        public GenericResponse<User> RecupererListeUtilisateurs()
        {
            try
            {
                List<User> ListUsers = _userservices.GetListUsers();

                if (ListUsers.Count() != 0)
                {
                    return new GenericResponse<User>()
                    {
                        FbuilderList = ListUsers,
                        ErrorMessage = string.Empty,
                        HttpStatusCode = HttpStatusCode.OK,
                        ResultMessage = "L'opération s'est déroulée avec succés."
                    };
                }
                else
                {
                    return new GenericResponse<User>()
                    {
                        FbuilderList = null,
                        ErrorMessage = string.Empty,
                        HttpStatusCode = HttpStatusCode.OK,
                        ResultMessage = "Aucun Utilisateur trouvé"
                    };
                }
            }
            catch (Exception ex)
            {
                return new GenericResponse<User>()
                {
                    FbuilderList = null,
                    ResultMessage = ex.Message,
                    ErrorMessage = "Une erreur est survenue.",
                    HttpStatusCode = HttpStatusCode.InternalServerError,
                };
            }
        }

    }
}
