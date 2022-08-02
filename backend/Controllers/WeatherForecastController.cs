using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    //public class WeatherForecastController : ControllerBase
    //{
    //    private static readonly string[] Summaries = new[]
    //    {
    //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    //};

    //    private readonly ILogger<WeatherForecastController> _logger;

    //    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    //    {
    //        _logger = logger;
    //    }

    //    [HttpGet(Name = "GetWeatherForecast")]
    //    public IEnumerable<WeatherForecast> Get()
    //    {
    //        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //        {
    //            Date = DateTime.Now.AddDays(index),
    //            TemperatureC = Random.Shared.Next(-20, 55),
    //            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //        })
    //        .ToArray();
    //    }
    //}



    // CONTENT EXP TO FOLLOW 

    // *********************** CONTROLLER EXP : **********************************

    //[RoutePrefix("CentreGestion")]
    //public class CentreGestionController : ApiController
    //{
    //    CentreGestionBL serviceCentreGestion;
    //    public CentreGestionController()
    //    {
    //        serviceCentreGestion = new CentreGestionBL();
    //    }
    //    [HttpGet]
    //    [Route("RecupererLesCentreGestionParNom")]
    //    [ActionName("RecupererLesCentreGestionParNom")]
    //    public GenericListResponse<CentreGestion> RecupererLesCentreGestionParNom(string nom)
    //    {
    //        if (string.IsNullOrEmpty(nom))
    //        {
    //            new GenericListResponse<CentreGestion>()
    //            {
    //                BTEntityList = null,
    //                ErrorMessage = string.Empty,
    //                ResultMessage = "Nom Invalide",
    //                HttpStatusCode = HttpStatusCode.BadRequest
    //            };
    //        }
    //        try
    //        {
    //            List<CentreGestion> centregestion = serviceCentreGestion.GetCentresGestionParNom(nom);
    //            if (centregestion.Count() == 0)
    //            {
    //                return new GenericListResponse<CentreGestion>()
    //                {
    //                    BTEntityList = null,
    //                    ErrorMessage = string.Empty,
    //                    ResultMessage = "Centre de Gestion introuvable",
    //                    HttpStatusCode = HttpStatusCode.BadRequest
    //                };
    //            }
    //            else
    //            {
    //                return new GenericListResponse<CentreGestion>()
    //                {
    //                    BTEntityList = centregestion,
    //                    ErrorMessage = string.Empty,
    //                    ResultMessage = "L'opération s'est déroulée avec succés.",
    //                    HttpStatusCode = HttpStatusCode.BadRequest
    //                };
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            return new GenericListResponse<CentreGestion>()
    //            {
    //                BTEntityList = null,
    //                ErrorMessage = ex.Message,
    //                ResultMessage = "Une erreur est survenue.",
    //                HttpStatusCode = HttpStatusCode.BadRequest
    //            };
    //        }
    //    }

    //    [HttpGet]
    //    [Route("RecupererCentreGestionParCode")]
    //    [ActionName("RecupererCentreGestionParCode")]
    //    public GenericResponse<CentreGestion> RecupererCentreGestionParCode(int code)
    //    {
    //        try
    //        {
    //            CentreGestion Centregestion = serviceCentreGestion.GetCentresGestionParCode(code);
    //            if (Centregestion == null)
    //            {
    //                return new GenericResponse<CentreGestion>()
    //                {
    //                    BTEntity = null,
    //                    ErrorMessage = string.Empty,
    //                    ResultMessage = "Centre de Gestion Introuvable",
    //                    HttpStatusCode = HttpStatusCode.BadRequest
    //                };
    //            }
    //            else
    //            {
    //                return new GenericResponse<CentreGestion>()
    //                {
    //                    BTEntity = Centregestion,
    //                    ErrorMessage = string.Empty,
    //                    ResultMessage = "L'opération s'est déroulée avec succés.",
    //                    HttpStatusCode = HttpStatusCode.BadRequest
    //                };
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            return new GenericResponse<CentreGestion>()
    //            {
    //                BTEntity = null,
    //                ErrorMessage = ex.Message,
    //                ResultMessage = "Une erreur est survenue.",
    //                HttpStatusCode = HttpStatusCode.BadRequest
    //            };
    //        }
    //    }

    //    [HttpGet]
    //    [Route("RecupererLesCentresGestion")]
    //    [ActionName("RecupererLesCentresGestion")]
    //    public GenericListResponse<CentreGestion> RecupererLesCentresGestion()
    //    {
    //        try
    //        {
    //            List<CentreGestion> Centregestion = serviceCentreGestion.GetCentresGestion();
    //            if (Centregestion.Count() == 0)
    //            {
    //                return new GenericListResponse<CentreGestion>()
    //                {
    //                    BTEntityList = null,
    //                    ErrorMessage = string.Empty,
    //                    ResultMessage = "Centres de Gestion Introuvables",
    //                    HttpStatusCode = HttpStatusCode.BadRequest
    //                };
    //            }
    //            else
    //            {
    //                return new GenericListResponse<CentreGestion>()
    //                {
    //                    BTEntityList = Centregestion,
    //                    ErrorMessage = string.Empty,
    //                    ResultMessage = "L'opération s'est déroulée avec succés.",
    //                    HttpStatusCode = HttpStatusCode.BadRequest
    //                };
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            return new GenericListResponse<CentreGestion>()
    //            {
    //                BTEntityList = null,
    //                ErrorMessage = ex.Message,
    //                ResultMessage = "Une erreur est survenue.",
    //                HttpStatusCode = HttpStatusCode.BadRequest
    //            };
    //        }
    //    }
    //}

    // *********************** SERVICES EXP : **********************************


    //public class CentreGestionBL : ICentreGestionBL
    //{
    //    CentreGestionDAL serviceCentreGestion;
    //    public CentreGestionBL()
    //    {
    //        serviceCentreGestion = new CentreGestionDAL();
    //    }

    //    public List<CentreGestion> GetCentresGestionParNom(string nom)
    //    {
    //        try
    //        {
    //            return serviceCentreGestion.GetLesCentresGestionByNom(nom);
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //    }
    //    public CentreGestion GetCentresGestionParCode(int code)
    //    {
    //        try
    //        {
    //            return serviceCentreGestion.GetLesCentresGestionByCode(code);
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //    }
    //    public List<CentreGestion> GetCentresGestion()
    //    {
    //        try
    //        {
    //            return serviceCentreGestion.GetLesCentresGestion();
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //    }



    //}

    // *********************** Repository EXP : **********************************


//    public DbSet<T> DbSet;

//    public readonly AdministrationDBContext _dbContext;

//    public GenericDAL()
//    {
//        _dbContext = new AdministrationDBContext();
//        DbSet = _dbContext.Set<T>();
//    }


//    public IQueryable<T> GetAll()
//    {
//        return DbSet;
//    }

//    public async Task<T> FindByIdAsync(int id)
//    {
//        return await DbSet.FindAsync(id);
//    }

//    public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
//    {
//        return DbSet.Where(predicate);
//    }

//    public async Task EditAsync(T entity)
//    {
//        _dbContext.Entry(entity).State = EntityState.Modified;
//        await _dbContext.SaveChangesAsync();
//    }

//    public async Task InsertAsync(T entity)
//    {

//        DbSet.Add(entity);
//        await _dbContext.SaveChangesAsync();
//    }

//    public async Task DeleteAsync(T entity)
//    {
//        DbSet.Remove(entity);
//        await _dbContext.SaveChangesAsync();
//    }

//    public T FindById(int id)
//    {
//        return DbSet.Find(id);
//    }

//    public void Edit(T entity)
//    {
//        _dbContext.Entry(entity).State = EntityState.Modified;
//        _dbContext.SaveChanges();
//    }

//    public void Insert(T entity)
//    {
//        DbSet.Add(entity);
//        _dbContext.SaveChanges();
//    }

//    public void Delete(T entity)
//    {
//        DbSet.Remove(entity);
//        _dbContext.SaveChanges();
//    }

//    public IEnumerable<T> GetAll(string propertyName, int? nombrElement, int? numeroPage, bool? isOrderDescending, Expression<Func<T, bool>> predicate)
//    {
//        try
//        {
//            int nbrRows = nombrElement ?? 10;
//            int numPage = numeroPage ?? 0;
//            bool isDec = isOrderDescending ?? false;

//            if (nbrRows <= 0)
//                nbrRows = 10;
//            if (numPage <= 0)
//                numPage = 0;

//            if (!string.IsNullOrEmpty(propertyName) && ExtensionMethods.PropertyExists<T>(propertyName))
//            {
//                if (!isDec)
//                    return DbSet.OrderByPropertyName(propertyName).Where(predicate).Skip(numPage).Take(nbrRows).AsEnumerable();
//                else
//                    return DbSet.OrderByPropertyNameDescending(propertyName).Where(predicate).Skip(numPage).Take(nbrRows).AsEnumerable();
//            }
//            else
//            {
//                return DbSet/*.Skip(numPage)*/.Take(nbrRows).AsEnumerable();
//            }
//        }
//        catch (Exception ex)
//        {

//            throw;
//        }
//    }

//    public int GetRowCount(Expression<Func<T, bool>> predicate = null)
//    {
//        try
//        {
//            if (predicate == null)
//                return DbSet.Count();
//            else
//                return DbSet.Where(predicate).Count();
//        }
//        catch (Exception ex)
//        {

//            throw;
//        }
//    }

//}

}