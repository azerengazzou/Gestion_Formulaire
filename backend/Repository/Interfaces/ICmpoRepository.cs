﻿using backend.Models;

namespace backend.Repository.Interfaces
{
    public interface ICmpoRepository : IGenericRepository<Cmp>
    {
        Task<ICollection<Cmp>> GetAllwithDetails();
    }
}
