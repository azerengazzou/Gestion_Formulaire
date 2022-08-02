using backend.Models;
using backend.Repository.Interfaces;
using backend.Services.Interfaces;

namespace backend.Services.Classes
{
    public class FormServices : IFormServices
    {
        public readonly IFormRepository _serviceForms;
        public FormServices(IFormRepository formservices)
        {
            _serviceForms = formservices;
        }
        public async Task<IEnumerable<Form>> GetListForms()
        {
            try
            {
                return await _serviceForms.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Form> GetbyId(int Formid)
        {
            return await _serviceForms.GetByid(Formid);
        }


        public async Task UpdateForm(Form Form)
        {
            await _serviceForms.Update(Form);
        }

        public async Task CreateForm(Form Form)
        {
            await _serviceForms.Create(Form);
        }

        public async Task DeleteFormAsync(int id)
        {
            await _serviceForms.Delete(await _serviceForms.GetByid(id));
        }
    }
}
