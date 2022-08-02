using backend.Models;
using backend.Repository.Interfaces;

namespace backend.Repository.Classes
{
    public class FormRepository : GenericRepository<Form>, IFormRepository
    {
            public FormRepository(DBFormContext context) : base(context)
            {

            }
    }
}