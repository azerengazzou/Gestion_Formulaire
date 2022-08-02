using backend.Models;

namespace backend.Services.Interfaces
{
    public interface IFormServices
    {
        Task<IEnumerable<Form>> GetListForms();
        Task<Form> GetbyId(int Formid);
        Task UpdateForm(Form Form);
        Task CreateForm(Form Form);
        Task DeleteFormAsync(int id);


    }
}
